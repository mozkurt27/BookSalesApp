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
    public partial class LookAllOrders : Form
    {
        AdminPanel ap;
        public LookAllOrders(AdminPanel AP)
        {
            ap = AP;
            InitializeComponent();
        }

        private void LookAllOrders_Load(object sender, EventArgs e)
        {
            foreach (var item in DataHolder.DataHolder.Orders)
            {
                lbShowOrders.Items.Add(item);
            }
        }

        private void LookAllOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            ap.Show();
            Dispose();
        }

        private void lbShowOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = (Order)lbShowOrders.SelectedItem;

            ShowOrderDetails sod = new ShowOrderDetails(this,order);
            sod.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ap.Show();
            Dispose();
        }
    }
}
