using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            // at least 1 returned?
            if(accountsMatchingUserName.Count > 0 )
            {
                // use the first one, there should not be more than one unless we are in testing mode
                Account account = accountsMatchingUserName[0];

                // check the password

                // hash user input
                string passwordHashed = Hashing.GenerateHash(pass, account.Salt);

                // does it match the one in the db?
                bool match = passwordHashed.Equals(account.Password);

                if(match)
                {
                    MainScreen mainScreen = new MainScreen();
                    mainScreen.Show();
                }
                else
                {
                    MessageBox.Show("password did not match");
                }


            }
            else
            {
                MessageBox.Show("username does not exist");
            }

            
        }
    }
}
