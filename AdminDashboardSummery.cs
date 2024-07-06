using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class AdminDashboardSummery : Form
    {
        public AdminDashboardSummery()
        {
            InitializeComponent();
            NoOfCounts();
        }

        public void NoOfCounts()
        {
            try
            {
                using (var db = new DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    // Queries for counting cars, car parts, customers, and orders
                    string queryCar = "SELECT IFNULL(COUNT(*), 0) FROM car";
                    string queryCarParts = "SELECT IFNULL(COUNT(*), 0) FROM carpart";
                    string queryCustomer = "SELECT IFNULL(COUNT(*), 0) FROM customer";
                    string queryOrder = "SELECT IFNULL(COUNT(*), 0) FROM `order`";

                    // Update labels with counts
                    lblNoOfCars.Text = ExecuteCountQuery(db, queryCar);
                    lblNoOfCarParts.Text = ExecuteCountQuery(db, queryCarParts);
                    lblNoOfCustomers.Text = ExecuteCountQuery(db, queryCustomer);
                    lblNoOfOrders.Text = ExecuteCountQuery(db, queryOrder);

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ExecuteCountQuery(DBConnection.DBConnection db, string query)
        {
            using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
            {
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count.ToString("D2");
            }
        }
    }
}
