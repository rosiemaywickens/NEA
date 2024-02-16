using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.SQL;

namespace WindowsFormsApp1.UI
{
    public partial class ManageStock : UserControl
    {

        public ManageStock()
        {
            InitializeComponent();
        
        
            errorbox.Visible = false;
        
        
        
        
        
        
        
        }


       
        





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

 

        private void medidbox_TextChanged(object sender, EventArgs e)
        {

        }



        private void ManageStock_Load(object sender, EventArgs e)
        {

        }

        private void lidbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void eneterbut_Click(object sender, EventArgs e)
        {
            errorbox.Visible = false;
            string medicineid = this.medidbox.Text.Trim();
            try
            {
                int fmed =  Convert.ToInt32(medicineid);
                if  (medicineid.Length != 4)
                {
                errorbox.Text = ("ERROR MedicineID.(4 digit integer must be entered)");

                }
            }
            catch (Exception)
            {
                errorbox.Visible = true;
                errorbox.Text = ("ERROR medicineID. (4 digit integer must be entered)");
               
            }

            string locationid =  this.lidbox.Text.Trim();
            try
            {
                int lid = Convert.ToInt32(locationid);
            }
            catch
            {
                errorbox.Visible= true;
                errorbox.AppendText("     LocationID error(integer must be entered). ");
            }
            string am = AmountBox.Text.Trim();
            try
            {
                int Amount = Convert.ToInt32(am);
            }
            catch
            {
                errorbox.Visible= true;
                errorbox.AppendText("you must enter an integer into thge amount box");
            } 
            if (errorbox.Visible == false)
            {
                Stock.addstock(fmed, lid,  Amount);
            }

            
                
        
        }

        private void errorbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
