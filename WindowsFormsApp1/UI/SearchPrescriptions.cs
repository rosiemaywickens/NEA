using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using WindowsFormsApp1.SQL;

namespace WindowsFormsApp1.UI
{
    public partial class SearchPrescriptions : UserControl
    {
        public SearchPrescriptions()
        {
            InitializeComponent();
            surnamecheck.Checked = true;

        }

        private void surnamecheck_CheckedChanged(object sender, EventArgs e)
        {
            prenum.Checked = false;
            

        }

        private void prenum_CheckedChanged(object sender, EventArgs e)
        {
            surnamecheck.Checked = false;
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        public bool validateprescriptionnumber(string ep)
        {
            try
            {
                int x = Convert.ToInt32(ep);
                if (ep.Length == 8) 
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

        private void enbut_Click(object sender, EventArgs e)
        {
            string searched = searchbox.Text.Trim();
            //checks input
            if (string.IsNullOrEmpty(searched))
            {
                searcherrors.Visible = true;
                searcherrors.Text = ("you must enter either a surname or an 8 digit prescription number");

            }

            if (surnamecheck.Checked)
            {
                prescriptions.Listbycustomersurname(searched);
                searcherrors.Visible = false;


                resultsgrid.Rows.Clear();


                ReadOnlyCollection<prescriptions> prescriptionsList = prescriptions.Listbycustomersurname("YourCustomerSurname");

                foreach (prescriptions prescription in prescriptionsList)
                {

                    resultsgrid.Rows.Add(
                        prescription.PrescriptionId,
                        prescription.MedicineID,
                        prescription.ExpiryDate,
                        prescription.CustomerSurname);


                }
            }
            else if (prenum.Checked)
            {
                if (!validateprescriptionnumber(searched))
                {
                    searcherrors.Text = ("to searchby presription number you must enter an 8 digit number");
                }
                else
                {
                    searcherrors.Visible = false;


                    resultsgrid.Rows.Clear();


                    ReadOnlyCollection<prescriptions> prescriptionsList = prescriptions.Listbyprescriptionnumber(Convert.ToInt32(searched));

                    foreach (prescriptions prescription in prescriptionsList)
                    {

                        resultsgrid.Rows.Add(
                            prescription.PrescriptionId,
                            prescription.MedicineID,
                            prescription.ExpiryDate,
                            prescription.CustomerSurname);


                    }
                }
            }
            else
            {
                searcherrors.Text = ("you must check atleast one box");
            }       
        }

        private void SearchPrescriptions_Load(object sender, EventArgs e)
        {
            searcherrors.Visible = false;
        }

        private void resultsgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
