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
        public int PrescriptionID { get; set; }
        public int MedicineID { get; set; }
        public string ExpiryDate { get; set; }
        public string CustomerSurname { get; set; }



        public static void Addprescriptions(int PrescriptionID, int MedicineID, string ExpiryDate, string CustomerSurname)
        {
            
            MySqlConnection connection = Database.Connection();
            using (connection)
            {
                connection.Open();
                string query = "INSERT INTO `neaschema`.`prescriptions` ( `PrescriptionID`,`MedicineID`, `ExpiryDate`, `CustomerSurname` ) VALUES (@PrescriptionID,@MedicineID,@ExpiryDate,@Customersurname);\r\n";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@PrescriptionID", PrescriptionID);
                command.Parameters.AddWithValue("@MedicineID", MedicineID);
                command.Parameters.AddWithValue("@ExpiryDate", ExpiryDate);
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
                string query = "SELECT * FROM `neaschema`.`prescriptions` WHERE PrescriptionID = @PrescriptionID";
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
            prescriptions prescription = new prescriptions
            {
                PrescriptionID = reader.GetInt32("PrescriptionID"),
                MedicineID = reader.GetInt32("MedicineID"),
                ExpiryDate = reader.GetString("ExpiryDate"),
                CustomerSurname = reader.GetString("Customersurname")
            };
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

