using System;
using System.Collections.Generic;
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
    public partial class MainScreen : Form
    {

        public enum Screen
        {
            InputPrescription, SearchPrescription, CheckStock, ManageStock, settings
        }

        public MainScreen(int access)
        {
            InitializeComponent();
            if (access == 1)
            {
                button1.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
            }
        }
         

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        public void SwitchScreeen(Screen screen)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            UserControl userControl = new UserControl();
            switch(screen)
            {
                case Screen.InputPrescription:
                    // 
                    userControl = new InputPrescription();
                    break;
                case Screen.SearchPrescription:
                    //
                    userControl = new SearchPrescriptions();
                    break;
                case Screen.CheckStock:
                    //
                    userControl = new CheckStock();
                    break;
                case Screen.ManageStock:
                    //
                    userControl = new ManageStock();
                    break;
                case Screen.settings:
                    userControl = new settings();
                    break;

            }

            this.splitContainer1.Panel2.Controls.Add(userControl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwitchScreeen(Screen.InputPrescription);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwitchScreeen(Screen.SearchPrescription);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SwitchScreeen(Screen.CheckStock);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SwitchScreeen(Screen.ManageStock);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SwitchScreeen(Screen.settings);
        }
    }
}
