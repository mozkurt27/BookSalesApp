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
    public partial class AddBook : Form
    {
        AdminPanel ap;
        public AddBook(AdminPanel AP)
        {
            ap = AP;
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

            foreach (var item in DataHolder.DataHolder.Categories)
            {
                cbCategories.Items.Add(item);
            }
            foreach (var item in DataHolder.DataHolder.Publishers)
            {
                cbPublishers.Items.Add(item);
            }
            cbCategories.SelectedIndex = 0;
            cbPublishers.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //veritabanında kitap varmı kontrol et publisherada ekle bunu
            if (txtBookname.Text.Length > 0 && txtBookprice.Text.Length > 0 && txtBookstock.Text.Length > 0 && txtBookdiscount.Text.Length > 0)
            {
                bool check = DataHolder.DataHolder.Books.Any(x => x.Name == txtBookname.Text);
                if (!check)
                {
                    

                            Book newBook = new Book()
                            {
                                Id = DataHolder.DataHolder.Books.LastOrDefault().Id + 1,
                                AddedDate = DateTime.Now,
                                Name = txtBookname.Text,
                                Price = decimal.Parse(txtBookprice.Text),
                                UnitsInStock = int.Parse(txtBookstock.Text),
                                DiscountRate = int.Parse(txtBookdiscount.Text),
                                CategoryId = ((Category)cbCategories.SelectedItem).Id,
                                PublisherId = ((Publisher)cbPublishers.SelectedItem).Id
                            };

                            DataHolder.DataHolder.Books.Add(newBook);

                            string datetime = "2017-09-19";
                            string query = "insert into Books(AddedDate, Name, Price, UnitsInStock, DiscountRate,CategoryId,PublisherId) values('" + datetime + "', '" + newBook.Name + "', " + newBook.Price + "," + newBook.UnitsInStock + "," + newBook.DiscountRate + "," + newBook.CategoryId + "," + newBook.PublisherId + ")";

                            ConnectionManager cm = new ConnectionManager();
                            cm.SetData(query);
                            MessageBox.Show("Kitap eklendi!!!");

                }
                else MessageBox.Show("Bu isimde kitap zaten bulunmaktadır");


            }
            else MessageBox.Show("Eksik bilgi girmeyiniz!!!");
        }

        private void AddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            ap.Show();
            Dispose();
        }
    }
}
