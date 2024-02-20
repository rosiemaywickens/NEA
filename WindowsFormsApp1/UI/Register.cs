using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.SQL;

namespace WindowsFormsApp1.UI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void password1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password2_TextChanged(object sender, EventArgs e)
        {

        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass1 = password1.Text;
            string pass2 = password2.Text;
            string pass3 = userbox.Text;
            if (pass1 != pass2)
            {
                MessageBox.Show("Passwords do not match. Re-enter");
            }
            else if (pass1.Length <8 && pass2.Length <8)
            {
                MessageBox.Show("Password is less than 7 characters");
            }
            else
            {
                Account.CreateAccount(pass3, pass1, 1);
                MessageBox.Show("Account Successfully Created");
            }
        }
    }
}
