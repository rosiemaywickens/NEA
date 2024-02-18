using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.SQL;

namespace WindowsFormsApp1.UI
{
    public partial class InputPrescription : UserControl
    {
        public InputPrescription()
        {
            InitializeComponent();
            xprin.Mask = "00000000";
            xmein.Mask = "0000";
            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputbutton_Click(object sender, EventArgs e)
        {
            string prescriptionNumber = xprin.Text;
            string medicineID = xmein.Text;
            string dayInput = day.Text;
            string monthInput = month.Text;
            string yearInput = year.Text;
            string customersurname = xsuin.Text;

            // Validate prescription number
            if (!validateprin(prescriptionNumber))
            {
                errorbox2.Text = ("Invalid PrescriptionID.please Enter an 8 digit number");
                return;
            }

            // Validate medicine ID
            if (!Validatexmin(medicineID))
            {
                errorbox2.AppendText("Invalid MedicineID. please enter a 4-digit number."+ Environment.NewLine);
                return;
            }

            // Validate day, month, and year
            if (!Validatedates(dayInput, 1, 31) || !Validatedates(monthInput, 1, 12) || !Validatedates(yearInput, 1900, 2100))
            {
                errorbox2.AppendText("Invalid date. Please enter valid day (1-31), month (1-12), and year (1900-2100)." + Environment.NewLine);
                return;
            }
            else
            {
                
                    
            }

            if ((validateprin(prescriptionNumber))&& (Validatexmin(medicineID)) && Validatedates(dayInput, 1, 31)&&( Validatedates(monthInput,1,12))&& Validatedates(yearInput, 1900, 2100))
            {

                string date = dayInput + "/" + monthInput + "/" + yearInput;
                prescriptions.Addprescriptions(Convert.ToInt32(prescriptionNumber), Convert.ToInt32(medicineID), date, customersurname); 

            }

            








        }

        private void xprin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public bool validateprin(string y)
        {
            try
            {
                int c = Convert.ToInt32(y);
                if (y.Length == 8)
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }


            }
            catch 
            { 
            return false;
            }
        }

        public bool Validatexmin(string z)
        {
            try
            {
                int x = Convert.ToInt32(z);
                if (z.Length == 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch
            {
                return false;
            }
        
        }
        public bool Validatedates(string b, int min, int max)
        {
            try
            {
                int c = Convert.ToInt32(b);
                if (c >= min && c <= max)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        
        }

        private void day_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void day_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void day_Click(object sender, EventArgs e)
        {
            day.Mask = "00";
        }
        private void month_Click(object sender, EventArgs e)
        {
            month.Mask = "00";
        }
        private void year_Click(object sender, EventArgs e)
        {
            year.Mask = "00";
        }


        private void xsuin_TextChanged(object sender, EventArgs e)
        {

        }
    
    
    
    
    }
}
