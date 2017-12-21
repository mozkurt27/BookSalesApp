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
    public partial class AdminPanel : Form
    {
        LoginForm lf;
        public AdminPanel(LoginForm LF)
        {
            lf = LF;
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            foreach (var item in DataHolder.DataHolder.Books)
            {
                lbBooks.Items.Add(item);
            }
            foreach (var item in DataHolder.DataHolder.Categories)
            {
                lbCategories.Items.Add(item);
            }
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {

            lf.Show();
            Dispose();
        }

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category selected = lbCategories.SelectedItem as Category;
            lbBooks.Items.Clear();
            List<Book> Temp_List = DataHolder.DataHolder.Books.FindAll(x => x.CategoryId == selected.Id);
            foreach (var item in Temp_List)
            {
                lbBooks.Items.Add(item);
            }


        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory(this);
            ac.Show();
            Hide();
        }

        private void btnPublisherAdd_Click(object sender, EventArgs e)
        {
            AddPublisher ap = new AddPublisher(this);
            ap.Show();
            Hide();
        }

        private void AdminPanel_VisibleChanged(object sender, EventArgs e)
        {

            lbCategories.Items.Clear();
            foreach (var item in DataHolder.DataHolder.Categories)
            {
                lbCategories.Items.Add(item);
            }
            lbBooks.Items.Clear();
            foreach (var item in DataHolder.DataHolder.Books)
            {
                lbBooks.Items.Add(item);
            }

        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook(this);
            ab.Show();
            Hide();
        }

        private void btnAllOrders_Click(object sender, EventArgs e)
        {
            LookAllOrders lao = new LookAllOrders(this);
            lao.Show();
            Hide();
        }
    }
}
