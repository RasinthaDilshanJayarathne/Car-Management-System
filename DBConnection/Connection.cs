using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementSystem.DBConnection
{
    internal class Connection
    {
        //1.Address of SQL server and database(Connection String)
        string ConnectionString = "server=localhost;uid=root;pwd=12345;database=car_management_system";
        //2.Establish connection(c# sqlconnection class)
        static MySqlConnection con = null;

        public Connection()
        {
            con = new MySqlConnection(ConnectionString);
        }

        public int Execute(string Query)
        {
            try
            {
                //3.Open connection(c# sqlconnection open)
                con.Open();

                //4.Prepare SQL query
                MySqlCommand cmd = new MySqlCommand(Query, con);

                //5.Execute query(c# sqlcommand class)
                int effectedrow = cmd.ExecuteNonQuery();

                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //6.Close connection(c# sqlconnection close)
                con.Close();
            }
            return 0;

        }
        public MySqlCommand getCommandAndPassQuery(string Query)
        {
            try
            {
                con.Close();
                //3.Open connection(c# sqlconnection open)
                con.Open();

                //4.Prepare SQL query
                MySqlCommand cmd = new MySqlCommand(Query, con);

                return cmd;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public MySqlDataReader Select(string Query)
        {

            try
            {
                //3.Open connection(c# sqlconnection open)
                con.Open();

                //4.Prepare SQL query
                MySqlCommand cmd = new MySqlCommand(Query, con);

                //5.Execute query(c# sqlcommand class)
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
