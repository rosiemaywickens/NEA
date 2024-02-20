using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Logic;
using WindowsFormsApp1.SQL;
using WindowsFormsApp1.UI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1012, 594);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // username box
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // password box
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Account.CreateAccount("rosie", "123", 1, 3);

            string username = this.LogText1.Text.Trim();
            string pass = this.PassText.Text.Trim();

            // get account 
            ReadOnlyCollection<Account> accountsMatchingUserName = Account.ListByUserName(username);

            if (accountsMatchingUserName.Count > 0)
            {
                Account account = accountsMatchingUserName[0];

                // Hash the entered password with the retrieved salt
                IHashing hasher = new Hashing();
                string hashedPassword = hasher.GenerateHash(pass, account.Salt);
                

                // Check if the hashed password matches the one stored in the database
                if (hashedPassword.Equals(account.Password))
                {
                    
                    MainScreen mainScreen = new MainScreen(account.AccessLevel);
                    mainScreen.Size = new Size(1012, 594);
                    mainScreen.StartPosition = FormStartPosition.CenterScreen;
                    mainScreen.Show();
                    
 
                }
                else
                {
                    MessageBox.Show("Password did not match.");
                }
            }
            else
            {
                MessageBox.Show("Username does not exist.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
    
}
