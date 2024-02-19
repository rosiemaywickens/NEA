using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Logic;

namespace WindowsFormsApp1.SQL
{
    internal class Database
    {
        public Database() { }

        public static MySqlConnection Connection()
        {
            MySqlConnection connection = new MySqlConnection(@"Server=localhost; Database = nea; UID= root; Password= root");
            return connection;

        }


    }
}
