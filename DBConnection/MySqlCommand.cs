
using System.Data;

namespace CarManagementSystem.DBConnection
{
    internal class MySqlCommand
    {
        private string query;
        private MySqlConnection con;

        public MySqlCommand(string query, MySqlConnection con)
        {
            this.query = query;
            this.con = con;
        }

        internal int ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        internal MySqlDataReader ExecuteReader(CommandBehavior closeConnection)
        {
            throw new NotImplementedException();
        }
    }
}