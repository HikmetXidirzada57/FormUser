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
    public partial class registeer : Form
    {

        public registeer()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string passwrod = txtPass.Text;
            string confirmPas = txtConfirm.Text;
            if (!string.IsNullOrWhiteSpace(email) &&
                !string.IsNullOrWhiteSpace(passwrod)
                && !string.IsNullOrWhiteSpace(confirmPas))
            {

                if (passwrod == confirmPas)
                {
                    LblError.Visible = false;
                    if (AllMyList.UserList.Count == 0)
                    {
                        User us = new User();
                        us.Email = email;
                        us.Password = passwrod;
                        AllMyList.UserList.Add(us);
                        MessageBox.Show("user registered succesfully!");
                    }
                    else
                    {
                        bool correct = true;
                        foreach (var user in AllMyList.UserList)
                        {
                            if (user.Email == email)
                            {
                                correct = false;
                                break;
                            }
                        }

                        if (correct)
                        {
                            User us = new User();
                            us.Email = email;
                            us.Password = passwrod;
                            AllMyList.UserList.Add(us);

                            MessageBox.Show("User registered succesfully!");

                            txtEmail.Text = "";
                            txtPass.Text = "";
                            txtConfirm.Text = "";
                            this.Close();
                            LoginForm lg = new LoginForm();

                        }

                        else
                        {
                            LblError.Visible = true;
                            LblError.Text = "email is already exist";
                        }
                    }
                }
                else
                {
                    LblError.Visible = true;
                    LblError.Text = "email ve password uygun deyil";
                }
            }
            else
            {
                LblError.Visible = true;
                LblError.Text = "email ve parol uygun deyil";
            }
        }

        private void registeer_Load(object sender, EventArgs e)
        {

        }
    }
}