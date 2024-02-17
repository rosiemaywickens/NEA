using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
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
}
