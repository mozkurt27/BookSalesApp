using BookSalesApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace BookSalesApp.AppManagers
{
    public class ConnectionManager : IDisposable
    {
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        
        

        public ConnectionManager()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["BECDB"].ConnectionString;

            _sqlConnection = new SqlConnection(connectionString);
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
        }

        public void DataLoad()
        {
            DataHolder.DataHolder.Categories = GetQueryResult<Category>("Select * from Categories");
            DataHolder.DataHolder.Publishers = GetQueryResult<Publisher>("Select * from Publishers");
            DataHolder.DataHolder.Books = GetQueryResult<Book>("Select * from Books");
            DataHolder.DataHolder.Users = GetQueryResult<User>("Select * from Users");
            DataHolder.DataHolder.Orders = GetQueryResult<Order>("Select * from Orders");
            DataHolder.DataHolder.Orders_Details = GetQueryResult<Order_Details>("Select * from Orders_Details");
        }
        public void SetData(string query, out int effectedRows)
        {
            effectedRows = SetQueryResult(query);
        }
        public void SetData(string query)
        {
            int effectedRows;
            effectedRows = SetQueryResult(query);
        }
        private SqlDataReader ExecuteReader(string query)
        {
            _sqlCommand.CommandText = query;

            _sqlConnection.Open();

            return _sqlCommand.ExecuteReader();
        }

        private List<T> GetQueryResult<T>(string query)

        {
            SqlDataReader reader = ExecuteReader(query);

            List<string> columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();

            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            List<T> result = new List<T>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object row = Activator.CreateInstance(type);

                    object[] cells = new object[reader.FieldCount];
                    reader.GetValues(cells);

                    foreach (var property in properties)
                    {
                        if (columns.Contains(property.Name))
                        {
                            int index = columns.FindIndex(x => x == property.Name);

                            property.SetValue(row, cells[index]);
                        }
                    }

                    result.Add((T)row);
                }
            }

            _sqlConnection.Close();

            return result;
        }
        private int SetQueryResult(string query)
        {
            int effectedRows;
            _sqlCommand.CommandText = query;
            _sqlConnection.Open();
            effectedRows = _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
            return effectedRows;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
