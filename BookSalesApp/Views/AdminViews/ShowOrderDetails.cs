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
    public partial class ShowOrderDetails : Form
    {
        LookAllOrders lao;
        Order order;

        public ShowOrderDetails(LookAllOrders LAO,Order _order)
        {
            lao = LAO;
            order = _order;
            InitializeComponent();
        }

        private void ShowOrderDetails_Load(object sender, EventArgs e)
        {
            Order_Details od = DataHolder.DataHolder.Orders_Details.FirstOrDefault(x => x.OrderId == order.Id);
            Book book = DataHolder.DataHolder.Books.FirstOrDefault(x => x.Id == od.BookId);

            lblDetailsDate.Text = od.AddedDate.ToShortDateString();
            lblDetailsPrice.Text = od.Price.ToString();
            lblDetailsQuantity.Text = od.Quantity.ToString();
            lblBookname.Text = book.Name;
            lblBookprice.Text = book.Price.ToString();
            lblBookCategory.Text = DataHolder.DataHolder.Categories.FirstOrDefault(x => x.Id == book.CategoryId).Name;
            lblBookPublisher.Text = DataHolder.DataHolder.Publishers.FirstOrDefault(x => x.Id == book.PublisherId).Name;

        }

        private void ShowOrderDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            lao.Show();
            Dispose();
        }
    }
}
