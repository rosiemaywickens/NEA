using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
