using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CarManagementSystem.DBConnection
{
    public class DBConnection : IDisposable
    {
        public MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; username=root; password=; database=abcCarService");


        public void OpenConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
