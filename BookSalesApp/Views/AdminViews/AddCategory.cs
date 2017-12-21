using BookSalesApp.AppManagers;
using BookSalesApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSalesApp.Views.AdminViews
{
    public partial class AddCategory : Form
    {
        AdminPanel ap;
        public AddCategory(AdminPanel AP)
        {
            ap = AP;
            InitializeComponent();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            bool check = DataHolder.DataHolder.Categories.Any(x => x.Name == txtCategoryname.Text);


            if (!check)
            {
                
                Category newCategory = new Category()
                {
                    AddedDate = DateTime.Now,
                    Name =txtCategoryname.Text,
                    Description = txtCategorydesc.Text,Id = DataHolder.DataHolder.Categories.LastOrDefault().Id + 1
                };
                string datetime = "2017-09-19";

                DataHolder.DataHolder.Categories.Add(newCategory);
                string query = "insert into Categories(AddedDate, Name, Description) values('"+datetime+"', '"+newCategory.Name+"', '"+newCategory.Description+"')";
                
                ConnectionManager cm = new ConnectionManager();
                cm.SetData(query);
                MessageBox.Show("Kategori Eklendi...");
            }
            else
            {
                MessageBox.Show("Bu ada ait kategory var. Lütfen kategory adını tekrar giriniz.");
            }

                
        }

        private void AddCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            ap.Show();
            Dispose();
        }
    }
}
