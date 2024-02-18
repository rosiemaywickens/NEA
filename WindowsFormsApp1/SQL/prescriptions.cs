using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.SQL
{
    internal class prescriptions
    {
        public int PrescriptionId { get; set; }
        public int MedicineID { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string CustomerSurname { get; set; }



        public static void Addprescriptions(int PrescriptionId, int MedicineID, DateTime ExpiryDate, string CustomerSurname)
        {
            string x = ExpiryDate.ToString("yyyy-MM-dd ");
            MySqlConnection connection = Database.Connection();
            using (connection)
            {
                connection.Open();
                string query = "INSERT INTO `neaschema`.`prescriptions` ( `PrescriptionID`,`MedicineID`, `ExpiryDate`, `CustomerSurname` ) VALUES (@medicine, @location, @amount);\r\n";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@PrescriptionID", PrescriptionId);
                command.Parameters.AddWithValue("@MedicineID", MedicineID);
                command.Parameters.AddWithValue("@ExpiryDate", x);
                command.Parameters.AddWithValue("@CustomerSurname", CustomerSurname);

                command.ExecuteNonQuery();

            }
        }
        public static ReadOnlyCollection<prescriptions> Listbyprescriptionnumber(int prescriptionid)
        {
            List<prescriptions> result = new List<prescriptions>();


            MySqlConnection connection2 = Database.Connection();
            using (connection2)
            {
                connection2.Open();
                string query = "SELECT * FROM `neaschema`.`prescriptions` WHERE PresciptionID = @prescriptionid";
                MySqlCommand command = new MySqlCommand(query, connection2);
                command.Parameters.AddWithValue("@PrescriptionID", prescriptionid);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        prescriptions prescription = CreatePrescriptionFromDbRow(reader);
                        result.Add(prescription);
                    }
                }
            }

            return new ReadOnlyCollection<prescriptions>(result);
        }
    

        private static prescriptions CreatePrescriptionFromDbRow(MySqlDataReader reader)
        {
            prescriptions prescription = new prescriptions();
            prescription.PrescriptionId = reader.GetInt32("PresciptionID");
            prescription.MedicineID = reader.GetInt32("MedicineID");
            prescription.ExpiryDate = reader.GetDateTime("ExpiryDate");
            prescription.CustomerSurname = reader.GetString("customerSurname");
            return prescription;
        }
        public static ReadOnlyCollection<prescriptions> Listbycustomersurname(string customersurname)
        {
            List<prescriptions> result = new List<prescriptions>();


            MySqlConnection connection3 = Database.Connection();
            using (connection3)
            {
                connection3.Open();
                string query2 = "SELECT * FROM `neaschema`.`prescriptions` WHERE customersurname = @customersurname";
                MySqlCommand command = new MySqlCommand(query2, connection3);
                command.Parameters.AddWithValue("@customersurname", customersurname);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        prescriptions prescription = CreatePrescriptionFromDbRow(reader);
                        result.Add(prescription);
                    }
                }
            }

            return new ReadOnlyCollection<prescriptions>(result);
        }




    }
}

