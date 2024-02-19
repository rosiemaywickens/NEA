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

namespace WindowsFormsApp1.UI
{
    public partial class CheckStock : UserControl
    {
        public CheckStock()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            {

                string searchTerm = searchbox2.Text.Trim();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    // Search for medicines based on the input text
                    ReadOnlyCollection<medication> medicines = medication.Listbymed(searchTerm);
                    
                    if (medicines.Count > 0)
                    {
                        // Display the first medicine found (you may want to handle multiple matches differently)
                        medication firstMedicine = medicines[0];
                        int y = firstMedicine.medid;
                        string x = firstMedicine.brand;
                        string z = firstMedicine.medname;
                        int q = firstMedicine.dose;

                        
                        
                        ReadOnlyCollection<Stock> stockItems = Stock.ListStock( y);

                        
                        dataGridView1.Rows.Clear();
                        foreach (Stock stockItem in stockItems)
                        {
                            
                            dataGridView1.Rows.Add(
                                stockItem.locationID,
                                z,
                                q,
                                x,
                                stockItem.amount
                            );
                        }
                    }
                    else
                    {
                        // No matching medicines found
                        enter.ForeColor = Color.Red;
                        // Clear DataGridView
                        dataGridView1.Rows.Clear();
                    }
                }

            }
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CheckStock_Load(object sender, EventArgs e)
        {

        }

        private void searchbox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
