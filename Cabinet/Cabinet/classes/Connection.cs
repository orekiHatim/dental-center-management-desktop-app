using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cabinet.classes
{
    class Connection
    {
        private string server;
        private string database;
        private string userId;
        private string password;
        private string connString;
        private MySqlConnection conn;



        public Connection()
        {

        }

        public void Initialize()
        {
            server = "localhost";
            database = "cabinet";
            userId = "root";
            password = "1234";

            connString = "Data source=" + server + ";User ID=" + userId + ";Password=" + password + ";Database=" + database;
            conn = new MySqlConnection(connString);

        }

        public bool openConnection()
        {
            try
            {
                conn.Open();
                return true;
            } catch(MySqlException)
            {
                return false;
            }
        }

        public void closeConnection()
        {
            this.conn.Close();
        }

        public MySqlConnection getConnection()
        {
            return this.conn;
        }
    }
}
