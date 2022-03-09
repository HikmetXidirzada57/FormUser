using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ad = txtLogin.Text;
            string pas = txtPasLogin.Text;

            bool isCorrect = false;

            foreach (var user in AllMyList.UserList) 
            {
                if (user.Email == ad && user.Password == pas)
                {
                    isCorrect = true;
                    break;
                }
            }
            if (isCorrect)
            {
                WelcomeForm us = new WelcomeForm();
                us.ShowDialog();  
            }
            else
            {
                LblError.Visible = true;
                LblError.Text = "Email or Password isnt true";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
