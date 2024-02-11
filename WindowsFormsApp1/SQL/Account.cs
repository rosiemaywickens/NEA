using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.SQL
{
    public class Account
    {
        /// <summary>
        /// Creates new account & returns object
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="accessLevel"></param>
        /// <param name="salt"></param>
        /// <returns></returns>
        public static void CreateAccount(string username, string password, int accessLevel, int salt)
        {
            // INSERT INTO `neaschema`.`account` (, `UserName`, `password`, `accessLevel`, `salt`) VALUES ('test', '1111', '1', '2222');

            MySqlConnection connection = Database.Connection();

            using (connection)
            {
                connection.Open();
                string query = "INSERT INTO `neaschema`.`account` ( `UserName`, `password`, `accessLevel`, `salt`) VALUES (@username, @password, @accessLevel, @salt);\r\n";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@accessLevel", accessLevel);
                command.Parameters.AddWithValue("@salt", salt);
                // sends to my sql
                command.ExecuteNonQuery();
            }

            // create new salt, store new salt , create passwordhash, store hash Not passord


            

        }

        /// <summary>
        /// List all accounts in DB
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<Account> List()
        {
            throw new NotImplementedException();
        }


        public static ReadOnlyCollection<Account> ListByUserName(string userName)
        {
            throw new NotImplementedException();
        }

    }
}
