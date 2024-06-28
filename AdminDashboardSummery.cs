using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
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
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    // Queries for counting cars, car parts, and customers
                    string queryCar = "SELECT IFNULL(COUNT(*), 0) FROM car";
                    string queryCarParts = "SELECT IFNULL(COUNT(*), 0) FROM carpart";
                    string queryCustomer = "SELECT IFNULL(COUNT(*), 0) FROM customer";

                    // Count the number of cars
                    using (MySqlCommand command = new MySqlCommand(queryCar, db.GetConnection()))
                    {
                        int carCount = Convert.ToInt32(command.ExecuteScalar());
                        lblNoOfCars.Text = carCount.ToString("D2"); 
                    }

                    // Count the number of car parts
                    using (MySqlCommand command = new MySqlCommand(queryCarParts, db.GetConnection()))
                    {
                        int carPartsCount = Convert.ToInt32(command.ExecuteScalar());
                        lblNoOfCarParts.Text = carPartsCount.ToString("D2");
                    }

                    // Count the number of customers
                    using (MySqlCommand command = new MySqlCommand(queryCustomer, db.GetConnection()))
                    {
                        int customerCount = Convert.ToInt32(command.ExecuteScalar());
                        lblNoOfCustomers.Text = customerCount.ToString("D2");
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
