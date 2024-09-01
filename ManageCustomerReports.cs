using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarManagementSystem
{
    public partial class frmManageCustomerReports : Form
    {
        public frmManageCustomerReports()
        {
            InitializeComponent();

            // Add items to the ComboBox
            cmbReports.Items.Add("Car Details Report");
            cmbReports.Items.Add("Car Parts Details Report");
            cmbReports.Items.Add("Customer Details Report");
            cmbReports.Items.Add("Customer Order Details Report");

            lblReportFilterDate.Hide();
            dtpReportFilterDate.Hide();

            // Handle the SelectedIndexChanged event
            cmbReports.SelectedIndexChanged += cmbReports_SelectedIndexChanged;

            // Handle the ValueChanged event for the DateTimePicker
            dtpReportFilterDate.ValueChanged += dtpReportFilterDate_ValueChanged;

            // Handle the Click event for the Generate button
            btnGenerate.Click += btnGenerate_Click;
        }

        private void cmbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedReport = cmbReports.SelectedItem.ToString();
            DataTable dataTable = new DataTable();

            switch (selectedReport)
            {
                case "Car Details Report":
                    lblReportFilterDate.Hide();
                    dtpReportFilterDate.Hide();
                    dataTable = GetCarDetailsReport();
                    break;
                case "Car Parts Details Report":
                    lblReportFilterDate.Hide();
                    dtpReportFilterDate.Hide();
                    dataTable = GetCarPartsDetailsReport();
                    break;
                case "Customer Details Report":
                    lblReportFilterDate.Hide();
                    dtpReportFilterDate.Hide();
                    dataTable = GetCustomerDetailsReport();
                    break;
                case "Customer Order Details Report":
                    lblReportFilterDate.Show();
                    dtpReportFilterDate.Show();
                    dataTable = GetCustomerOrderDetailsReport();
                    break;
                default:
                    break;
            }

            // Load the data into the DataGridView
            tblReports.DataSource = dataTable;
        }

        private DataTable GetCarDetailsReport()
        {
            DataTable table = new DataTable();

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();
                    string query = "SELECT CarID, Make, Model, Year, Availability, Price FROM car";

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Load the DataTable schema based on the query results
                            table.Load(reader);
                        }
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving car details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

        private DataTable GetCarPartsDetailsReport()
        {
            DataTable table = new DataTable();

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();
                    string query = "SELECT PartID, PartName, Model, Price, QtyOnHand FROM carpart";

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Load the DataTable schema based on the query results
                            table.Load(reader);
                        }
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving car parts details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

        private DataTable GetCustomerDetailsReport()
        {
            DataTable table = new DataTable();

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();
                    string query = "SELECT CustomerId, FirstName, Email FROM admin";

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Load the DataTable schema based on the query results
                            table.Load(reader);
                        }
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

        private DataTable GetCustomerOrderDetailsReport()
        {
            DataTable table = new DataTable();

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();
                    string query = @"
                        SELECT 
                            od.OrderDetailID, 
                            o.OrderID, 
                            o.CustomerID, 
                            o.OrderDate, 
                            od.ProductID, 
                            od.Quantity, 
                            od.UnitPrice, 
                            o.Total, 
                            o.Cash, 
                            o.Balance
                        FROM 
                            OrderDetail od
                        JOIN 
                            `Order` o 
                        ON 
                            od.OrderID = o.OrderID
                        ORDER BY 
                            o.OrderDate DESC, od.OrderDetailID";

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Load the data into the DataTable
                            table.Load(reader);
                        }
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving customer order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

        private DataTable GetCustomerOrderDetailsReport(DateTime selectedDate)
        {
            DataTable table = new DataTable();

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();
                    string query = @"
                        SELECT 
                            od.OrderDetailID, 
                            o.OrderID, 
                            o.CustomerID, 
                            o.OrderDate, 
                            od.ProductID, 
                            od.Quantity, 
                            od.UnitPrice, 
                            o.Total, 
                            o.Cash, 
                            o.Balance
                        FROM 
                            OrderDetail od
                        JOIN 
                            `Order` o 
                        ON 
                            od.OrderID = o.OrderID
                        WHERE 
                            o.OrderDate = @SelectedDate
                        ORDER BY 
                            o.OrderDate DESC, od.OrderDetailID";

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@SelectedDate", selectedDate.ToString("yyyy-MM-dd"));
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Load the data into the DataTable
                            table.Load(reader);
                        }
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving customer order details for the selected date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

        private void dtpReportFilterDate_ValueChanged(object sender, EventArgs e)
        {
            if (cmbReports.SelectedItem != null && cmbReports.SelectedItem.ToString() == "Customer Order Details Report")
            {
                DataTable dataTable = GetCustomerOrderDetailsReport(dtpReportFilterDate.Value);
                tblReports.DataSource = dataTable;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)tblReports.DataSource;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                string selectedReport = cmbReports.SelectedItem.ToString();
                frmReportViewer reportViewer = new frmReportViewer(dataTable, selectedReport);
                reportViewer.Show();
            }
            else
            {
                MessageBox.Show("No data available to generate the report.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
