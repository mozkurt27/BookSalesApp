using BookSalesApp.AppManagers;
using BookSalesApp.Models;
using BookSalesApp.Views.AdminViews;
using BookSalesApp.Views.UserViews;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookSalesApp
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            ConnectionManager cm = new ConnectionManager();
            cm.DataLoad();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserManager um = new UserManager();
            bool check = um.checkUser(txtUsername.Text, txtPassword.Text);

            if (check)
             {

                if (DataHolder.DataHolder.CurrentUser.Role.Equals("user"))
                {
                    UserPanel up = new UserPanel(this);
                    up.Show();
                    Hide();

                }else
                {
                    AdminPanel ap = new AdminPanel(this);
                    ap.Show();
                    Hide(); 
                }
                 
             }
             else MessageBox.Show("Yanlış Giriş!!!");
            

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
