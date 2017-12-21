using BookSalesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesApp.DataHolder
{
    public static class DataHolder
    {
        public static List<Category> Categories;
        public static List<Publisher> Publishers;
        public static List<Book> Books;
        public static List<User> Users;
        public static List<Order> Orders;
        public static List<Order_Details> Orders_Details;
        public static User CurrentUser;
    }
}
