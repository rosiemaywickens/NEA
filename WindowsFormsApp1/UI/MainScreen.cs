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

namespace WindowsFormsApp1.UI
{
    public partial class MainScreen : Form
    {

        public enum Screen
        {
            InputPrescription, SearchPrescription
        }

        public MainScreen()
        {
            InitializeComponent();
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
            string x = Hashing.GenerateHash("rosie2", "rose");
        }

    }
}
