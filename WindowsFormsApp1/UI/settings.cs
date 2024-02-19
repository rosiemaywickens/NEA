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
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }
        //check passwords match
        //user name hasnt been used before
        //passord is over 8 digits
        public bool validatepasswords(string x, string y)
        {
            if (x == y)
            {
                if(x.Length <= 8)
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }  
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass1 = password1.Text;
            string pass2 = password2.Text;
            string pass3 = userbox.Text;
            if (validatepasswords(pass1, pass2))
            {
                Account.CreateAccount(pass3, pass1, 1);
            }
            else
            {
          
            }
            
        
        
        }

        private void password2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
