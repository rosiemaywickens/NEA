using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Logic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.SQL
{
    public class Account
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public int AccessLevel { get; set; }
        public string Salt { get; set; }


        /// <summary>
        /// Creates new account & returns object
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="accessLevel"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static void CreateAccount(string username, string password, int accessLevel)
        {
            // INSERT INTO `neaschema`.`account` (, `UserName`, `password`, `accessLevel`, `salt`) VALUES ('test', '1111', '1', '2222');

            MySqlConnection connection = Database.Connection();
            string salt = Hashing.Createsalt();
            string passwordHashed = Hashing.GenerateHash(password, salt);

            using (connection)
            {
                connection.Open();
                string query = "INSERT INTO `neaschema`.`account` ( `UserName`, `password`, `accessLevel`, `salt`) VALUES (@username, @password, @accessLevel, @salt);\r\n";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", passwordHashed);
                command.Parameters.AddWithValue("@accessLevel", accessLevel);
                command.Parameters.AddWithValue("@salt", salt);
                // sends to my sql
                command.ExecuteNonQuery();
            }

            // create new salt, store new salt , create passwordhash, store hash Not passord




        }
        //
        /// <summary>
        /// List all accounts in DB
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<Account> List()
        {
            List<Account> result = new List<Account>();

            MySqlConnection connection = Database.Connection();
            using (connection)
            {
                connection.Open();
                string query = "SELECT * FROM `neaschema`.`account`";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CreateAccountFromDbRow(reader);
                    }
                }
            }

            return new ReadOnlyCollection<Account>(result);

        }



        public static ReadOnlyCollection<Account> ListByUserName(string userName)
        {
            List<Account> result = new List<Account>();

            MySqlConnection connection = Database.Connection();
            using (connection)
            {
                connection.Open();
                string query = "SELECT * FROM `neaschema`.`account` WHERE username = @username";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", userName);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        CreateAccountFromDbRow(reader);
                    }
                }
            }

            return new ReadOnlyCollection<Account>(result);

        }


        /// <summary>
        /// turn row into object
        /// </summary>
        /// <param name="reader"></param>
        private static void CreateAccountFromDbRow(MySqlDataReader reader)
        {
            Account account = new Account();
            account.UserName = reader.GetString("UserName");
            account.Password = reader.GetString("Password");
            account.AccessLevel = reader.GetInt32("accessLevel");
            account.Salt = reader.GetString("salt");
        }

    }
}
