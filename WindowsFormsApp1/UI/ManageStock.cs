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

        public int ValidatedMedicineId { get; private set; }
        public int ValidatedLocationId { get; private set; }
        public int ValidatedAmount { get; private set; }

        private bool allInputsValid = false;


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
            allInputsValid = false;

            if (ValidateMedicineId(medidbox.Text.Trim()) &&
                ValidateLocationId(lidbox.Text.Trim()) &&
                ValidateAmount(AmountBox.Text.Trim()))
            {
                allInputsValid = true;

                // Set public properties with the validated values
                ValidatedMedicineId = Convert.ToInt32(medidbox.Text);
                ValidatedLocationId = Convert.ToInt32(lidbox.Text);
                ValidatedAmount = Convert.ToInt32(AmountBox.Text);

                // If all validations pass, add stock
                Stock.addstock(ValidatedMedicineId, ValidatedLocationId, ValidatedAmount);
            }
        }

        private bool ValidateMedicineId(string medicineId)
        {
            try
            {
                int fmed = Convert.ToInt32(medicineId);
                if (medicineId.Length != 4)
                {
                    ShowError("ERROR MedicineID. (4 digit integer must be entered)");
                    return false;
                }
            }
            catch (Exception)
            {
                ShowError("ERROR medicineID. (4 digit integer must be entered)");
                return false;
            }

            return true;
        }

        private bool ValidateLocationId(string locationId)
        {
            try
            {
                int lid = Convert.ToInt32(locationId);
            }
            catch
            {
                ShowError("LocationID error (integer must be entered).");
                return false;
            }

            return true;
        }

        private bool ValidateAmount(string amount)
        {
            try
            {
                int Amount = Convert.ToInt32(amount);
            }
            catch
            {
                ShowError("Amount error (must enter integer)");
                return false;
            }

            return true;
        }

        private void ShowError(string errorMessage)
        {
            errorbox.Visible = true;
            errorbox.AppendText(errorMessage + Environment.NewLine);
        }

        private void errorbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

