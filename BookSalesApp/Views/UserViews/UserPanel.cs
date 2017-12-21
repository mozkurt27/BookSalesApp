using BookSalesApp.AppManagers;
using BookSalesApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSalesApp.Views.UserViews
{
    public partial class UserPanel : Form
    {
        LoginForm lf;
        List<Book> Sepet;
        List<int> bookQuantity;
        Book tempBook;
        public UserPanel(LoginForm LF)
        {

            lf = LF;
            InitializeComponent();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            Sepet = new List<Book>();
            bookQuantity = new List<int>();
            Book tempBook = new Book();
            lblWelcome.Text = DataHolder.DataHolder.CurrentUser.Name + " " + DataHolder.DataHolder.CurrentUser.Lastname + " Hoşgeldiniz :)";
            foreach (var item in DataHolder.DataHolder.Categories)
            {
                cbCategories.Items.Add(item);
            }
            cbCategories.SelectedIndex = 0;

        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbBooks.Items.Clear();
            foreach (var item in DataHolder.DataHolder.Books)
            {
                if (item.CategoryId == ((Category)cbCategories.SelectedItem).Id)
                {
                    lbBooks.Items.Add(item);
                }
            }
            lbBooks.SelectedIndex = 0;
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            lf.Show();
            Dispose();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tempBook = (Book)lbBooks.SelectedItem;

            if (Sepet.Count == 0)
            {
                Sepet.Add(tempBook);
                bookQuantity.Add(1);
                SumPrice();

            }
            else
            {
                bool check = false;
                foreach (var item in Sepet)
                {
                    if (item.Id == tempBook.Id)
                    {
                        check = true;
                        bookQuantity[Sepet.IndexOf(item)] += 1;
                        SumPrice();
                    }
                }
                if (!check)
                {
                    Sepet.Add(tempBook);
                    bookQuantity.Add(1);
                    SumPrice();
                }

            }

            lbBookBox.Items.Clear();
            foreach (var item in Sepet)
            {
                lbBookBox.Items.Add(item + " ==>> " + bookQuantity[Sepet.IndexOf(item)] + " Adet");
            }
            lbBookBox.SelectedIndex = 0;

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (lbBookBox.SelectedIndex >= 0)
            {
                
                if (bookQuantity[lbBookBox.SelectedIndex] == 1)
                {
                    Sepet.RemoveAt(lbBookBox.SelectedIndex);
                    bookQuantity.RemoveAt(lbBookBox.SelectedIndex);
                    SumPrice();
                }
                else
                {
                    bookQuantity[lbBookBox.SelectedIndex] -= 1;
                    SumPrice();
                }

                lbBookBox.Items.Clear();
                foreach (var item in Sepet)
                {
                    lbBookBox.Items.Add(item + " ==>> " + bookQuantity[Sepet.IndexOf(item)] + " Adet");
                }

            }
        }

        void SumPrice()
        {
            decimal sum = 0;
            foreach (var item in Sepet)
            {
                sum += (item.Price * bookQuantity[Sepet.IndexOf(item)]);
            }
            lblSumPrice.Text = $"Toplam Fiyat : {sum} TL";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            //////Hata Var Kontrol ET///////

            DialogResult dr = MessageBox.Show("İşlemi tamamlamak istiyor musunuz??", "Sipariş Tamamlama ", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Order order = new Order() { AddedDate = DateTime.Now, Id = DataHolder.DataHolder.Orders.LastOrDefault().Id + 1, UserId = DataHolder.DataHolder.CurrentUser.Id };
                DataHolder.DataHolder.Orders.Add(order);
                string query = "insert into Orders(AddedDate, UserId) values('2017-09-20'," + order.UserId + ")";
                ConnectionManager cm1 = new ConnectionManager();
                
                cm1.SetData(query);

                foreach (var item in Sepet)
                {
                    ConnectionManager cm2 = new ConnectionManager();
                    query = "";
                    query = "insert into Orders_Details(AddedDate, Quantity, Price, BookId, OrderId) values('2047-09-20'," + bookQuantity[Sepet.IndexOf(item)] + "," + ((int)item.Price * bookQuantity[Sepet.IndexOf(item)]) + "," + item.Id + "," + DataHolder.DataHolder.Orders.LastOrDefault().Id + ")";
                    int effectedRows = 0;
                    cm2.SetData(query,out effectedRows);
                    Start:
                    if (effectedRows != 1) { goto Start; }      
                }

                lbBookBox.Items.Clear();
                Sepet.Clear();
                bookQuantity.Clear();
                MessageBox.Show("Sipariş Verildi...");
            }

        }
    }
}
