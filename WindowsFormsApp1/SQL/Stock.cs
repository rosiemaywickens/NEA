using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.SQL
{
    public class Stock
    {
        public int amount { get; set; }    
        public int locationID { get; set; } 
        public int medicineID { get; set; } 


        public static void addstock(string medicineName, int LocationID , int amount, string brand)
        {
            MySqlConnection connection = Database.Connection();
            using (connection) 
            {
                connection.Open();
                string query = "INSERT INTO stock (MedicineName, locationID, amount, Brand) VALUES (@medicine, @location, @amount, @brand)";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@medicine", medicineName);
                command.Parameters.AddWithValue("@location", LocationID);
                command.Parameters.AddWithValue("@amount", amount);
                command.Parameters.AddWithValue("@brand", brand);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Stock added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No stock was added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
           


        }
        public static ReadOnlyCollection<Stock> ListStock(int searchTerm)
        {
            List<Stock> stockList = new List<Stock>();

            MySqlConnection connection = Database.Connection();

            try
            {
                connection.Open();

                string query = "SELECT * FROM stock WHERE MedicineID LIKE @searchTerm";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Stock stockItem = CreateStockFromDbRow(reader);
                        stockList.Add(stockItem);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                Console.WriteLine($"Error listing stock: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return new ReadOnlyCollection<Stock>(stockList);
        }

        private static Stock CreateStockFromDbRow(MySqlDataReader reader)
        {
            Stock stockItem = new Stock
            {
                medicineID = reader.GetInt32("MedicineId"),
                locationID = reader.GetInt32("LocationId"),
                amount = reader.GetInt32("Amount")
            };
            return stockItem;
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
                string query = "SELECT * FROM medicine WHERE medname LIKE @medname";
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
