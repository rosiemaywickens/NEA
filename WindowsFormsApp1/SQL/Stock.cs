using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.SQL
{
    public class Stock
    {
        public int amount { get; set; }    
        public int locationID { get; set; } 
        public int medicineID { get; set; } 


        public static void addstock(int medicineID, int LocationID , int amount)
        {
            MySqlConnection connection = Database.Connection();
            using (connection) 
            {
                connection.Open();
                string query = "INSERT INTO `neaschema`.`stock` ( `MedicineId`, `locationId`, `amount` ) VALUES (@medicine, @location, @amount);\r\n";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@medicine", medicineID);
                command.Parameters.AddWithValue("@location", LocationID);
                command.Parameters.AddWithValue("@amount", amount);
                 
                command.ExecuteNonQuery();
              
            }
           


        }
 
        
        






    }
    public class medication
    {
        public int medid { get; set; }
        public int dose { get; set; }
        public string medname { get; set; }
        public string brand { get; set; }
        public int controlled { get; set; }

        public static ReadOnlyCollection<medication> Listbymed(string med)
        {
            List<medication> result = new List<medication>();


            MySqlConnection connection4 = Database.Connection();
            using (connection4)
            {
                connection4.Open();
                string query = "SELECT * FROM `neaschema`.`medicines` WHERE medname LIKE @medname";
                MySqlCommand command = new MySqlCommand(query, connection4);
                command.Parameters.AddWithValue("@medname", " % " + med + " % ");

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        medication medicine = medy(reader);
                        result.Add(medicine);
                    }
                }
            }

            return new ReadOnlyCollection<medication>(result);


        }

        


        private static medication medy(MySqlDataReader reader)
        {
            medication medicine = new medication
            {
                medid = reader.GetInt32("medicineID"),
                dose = reader.GetInt32("dose"),
                medname = reader.GetString("medname"),
                brand = reader.GetString("brand"),
                controlled = reader.GetInt32("controlled")
            };
            return medicine;
        }
    }




}
