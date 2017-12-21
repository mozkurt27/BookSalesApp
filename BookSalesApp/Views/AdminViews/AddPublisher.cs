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
    public partial class AddPublisher : Form
    {
        AdminPanel ap;

        public AddPublisher(AdminPanel AP)
        {
            ap = AP;
            InitializeComponent();
        }

        private void AddPublisher_Load(object sender, EventArgs e)
        {

        }

        private void AddPublisher_FormClosing(object sender, FormClosingEventArgs e)
        {
            ap.Show();
            Dispose();
            
        }

        private void btnPublisherAdd_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text.Length > 0 && txtPhone.Text.Length > 0 && txtAdress.Text.Length > 0)
            {
                bool check = DataHolder.DataHolder.Publishers.Any(x => x.Name == txtName.Text);
                if (!check)
                {
                    Publisher newpublisher = new Publisher()
                    {
                        AddedDate = DateTime.Now,
                        Address = txtAdress.Text,
                        Name = txtName.Text,
                        Phone = txtPhone.Text,
                        Id = DataHolder.DataHolder.Publishers.LastOrDefault().Id + 1
                    };
                    string datetime = "2017-09-19";
                    DataHolder.DataHolder.Publishers.Add(newpublisher);
                    string query = "insert into Publishers(AddedDate, Name, Address, Phone) values('" + datetime + "', '" + newpublisher.Name + "', '" + newpublisher.Address + "','" + newpublisher.Phone + "')";

                    ConnectionManager cm = new ConnectionManager();
                    cm.SetData(query);
                    MessageBox.Show("Yayıncı Eklendi...");
                }
                else MessageBox.Show("Bu isimde yayıncı bulunmaktadır...");


            }
            else MessageBox.Show("Bilgileri tam Giriniz!!!");



        }
    }
}
