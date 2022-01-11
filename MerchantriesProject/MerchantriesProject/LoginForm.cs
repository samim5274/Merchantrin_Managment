using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerchantriesProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter the username and passeord.");
            }
            else
            {
                if (cbxRole.SelectedIndex > -1)
                {
                    if (cbxRole.SelectedItem.ToString() == "ADMIN")
                    {
                        using (var context = new MerchantriesEntities())
                        {

                            var q = from log in context.UserDetails
                                    where log.S_Username == txtUsername.Text && log.S_Password == txtPassword.Text
                                    select log;
                            if (q.SingleOrDefault() != null)
                            {
                                MotherForm selle = new MotherForm();
                                selle.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(@"If you are the admin,please fill the correct Role and Invalid user Name and Password pls try again", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else
                    {
                        using (var context = new MerchantriesEntities())
                        {
                           
                            var q = from log in context.UserDetails
                                    where log.S_Username == txtUsername.Text && log.S_Password == txtPassword.Text
                                    select log;
                            if (q.SingleOrDefault() != null)
                            {
                                SalesForm selle = new SalesForm();
                                selle.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(@"If you are the seller,please fill the correct Role and Invalid user Name and Password pls try again", @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select a Role.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
