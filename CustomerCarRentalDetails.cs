using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmCustomerCarRentalDetails : Form
    {
        public frmCustomerCarRentalDetails(string username, string custId)
        {
            InitializeComponent();
            txtRentalId.Text = GenerateCarRentalId();
            LoadCarIds();
            lblCarAvailable.Visible = false;
            DesableFields();
            txtCustId.Text = custId;

            cmbCarId.SelectedIndexChanged += CmbCarId_SelectedIndexChanged;

            dtpRentalStartDate.Value = DateTime.Now;
            dtpRentalEndDate.Value = DateTime.Now;

            dtpRentalStartDate.ValueChanged += DtpRentalDate_ValueChanged;
            dtpRentalEndDate.ValueChanged += DtpRentalDate_ValueChanged;

            //txtDailyRate.TextChanged += TxtDailyRate_TextChanged;

            tblCarRentalDetails.CellClick += tblCarRentalDetails_CellClick;
        }

        private string GenerateId(string prefix)
        {
            Random random = new Random();
            string part1 = random.Next(0, 1000).ToString("D3");
            string part2 = random.Next(1, 1000).ToString("D3");
            return $"{prefix}{part1}-{part2}";
        }

        public string GenerateOrderId() => GenerateId("RE");
        public string GenerateCarRentalId() => GenerateId("RE");

        public void DesableFields()
        {
            dtpRentalStartDate.Enabled = false;
            dtpRentalEndDate.Enabled = false;
            btnRentNow.Enabled = false;
        }

        public void EnableFields()
        {
            dtpRentalStartDate.Enabled = true;
            dtpRentalEndDate.Enabled = true;
            txtTotalRentDays.Enabled = true;
            btnRentNow.Enabled = true;
        }

        private void LoadCarIds()
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT carId FROM car";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbCarId.Items.Add(reader["carId"].ToString());
                            }
                        }
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbCarId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCarId.SelectedItem != null)
            {
                string selectedCarId = cmbCarId.SelectedItem.ToString();
                EnableFields();

                try
                {
                    using (var db = new CarManagementSystem.DBConnection.DBConnection())
                    {
                        db.OpenConnection();

                        string query = "SELECT * FROM car WHERE carId = @carId";
                        using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                        {
                            command.Parameters.AddWithValue("@carId", selectedCarId);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtDailyRate.Text = reader["dailyRate"].ToString();
                                    txtYear.Text = reader["year"].ToString();
                                    txtMake.Text = reader["make"].ToString();
                                    txtModel.Text = reader["model"].ToString();

                                    string imgPath = reader["imagePath"].ToString();
                                    if (!string.IsNullOrEmpty(imgPath) && System.IO.File.Exists(imgPath))
                                    {
                                        carImgBox.Image = new Bitmap(imgPath);
                                    }
                                    else
                                    {
                                        carImgBox.Image = null;
                                    }
                                    lblCarAvailable.Visible = true;
                                    string carAvailability = reader["availability"].ToString();

                                    if (carAvailability == "Available")
                                    {
                                        lblCarAvailable.Text = "Available";
                                        lblCarAvailable.BackColor = Color.FromArgb(59, 216, 94);
                                    }
                                    else
                                    {
                                        DesableFields();
                                        lblCarAvailable.Text = "Unavailable";
                                        lblCarAvailable.BackColor = Color.FromArgb(255, 0, 0);
                                    }
                                }
                            }
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


        private void DtpRentalDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalRentDays();
            UpdateTotalCost();
        }

        private void CalculateTotalRentDays()
        {
            DateTime startDate = dtpRentalStartDate.Value;
            DateTime endDate = dtpRentalEndDate.Value;

            if (endDate >= startDate)
            {
                TimeSpan rentalDuration = endDate - startDate;
                txtTotalRentDays.Text = rentalDuration.Days.ToString();
            }
            else
            {
                txtTotalRentDays.Text = "00";
            }
        }

        private void UpdateTotalCost()
        {
            if (decimal.TryParse(txtDailyRate.Text, out decimal dailyRate) && int.TryParse(txtTotalRentDays.Text, out int totalRentDays))
            {
                decimal totalCost = dailyRate * totalRentDays;
                txtTotalCost.Text = totalCost.ToString("#.##");
            }
            else
            {
                txtTotalCost.Text = "00";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (searchText == "")
            {
                MessageBox.Show("Please enter a search text.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (searchText[0] == 'C')
            {
                SearchCustomer(searchText);
            }
            else
            {
                SearchCar(searchText);
            }
        }

        private void SearchCar(string searchText)
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string carQuery = "SELECT * FROM car WHERE carId = @carId OR model LIKE @model";
                    using (MySqlCommand carCommand = new MySqlCommand(carQuery, db.GetConnection()))
                    {
                        carCommand.Parameters.AddWithValue("@carId", searchText);
                        carCommand.Parameters.AddWithValue("@model", $"%{searchText}%");

                        using (MySqlDataReader carReader = carCommand.ExecuteReader())
                        {
                            if (carReader.Read())
                            {
                                // Populate car details
                                cmbCarId.Text = carReader["carId"].ToString();
                                txtDailyRate.Text = carReader["dailyRate"].ToString();
                                txtYear.Text = carReader["year"].ToString();
                                txtMake.Text = carReader["make"].ToString();
                                txtModel.Text = carReader["model"].ToString();

                                string imgPath = carReader["imagePath"].ToString();
                                if (!string.IsNullOrEmpty(imgPath) && System.IO.File.Exists(imgPath))
                                {
                                    carImgBox.Image = new Bitmap(imgPath);
                                }
                                else
                                {
                                    carImgBox.Image = null;
                                }

                                lblCarAvailable.Visible = true;
                                string carAvailability = carReader["availability"].ToString();

                                if (carAvailability == "Available")
                                {
                                    lblCarAvailable.Text = "Available";
                                    lblCarAvailable.BackColor = Color.FromArgb(59, 216, 94);
                                }
                                else
                                {
                                    DesableFields();
                                    lblCarAvailable.Text = "Unavailable";
                                    lblCarAvailable.BackColor = Color.FromArgb(255, 0, 0);
                                }

                                /*if (cmbCustId.SelectedIndex == -1)
                                {
                                    dtpRentalStartDate.Enabled = false;
                                    dtpRentalEndDate.Enabled = false;
                                    txtDailyRate.Enabled = false;
                                    btnRentNow.Enabled = false;
                                }
                                else
                                {
                                    EnableFields();
                                }*/
                            }
                            else
                            {
                                txtYear.Text = "";
                                txtMake.Text = "";
                                txtModel.Text = "";
                                carImgBox.Image = null;
                                lblCarAvailable.Visible = false;

                                // Enable all fields for new entry
                                EnableFields();
                            }
                        }
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching car details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCustomer(string searchText)
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    // Query to fetch data from customer table based on customerId or customerName
                    string customerQuery = "SELECT * FROM customer WHERE customerId = @customerId OR firstName LIKE @customerName";
                    using (MySqlCommand customerCommand = new MySqlCommand(customerQuery, db.GetConnection()))
                    {
                        customerCommand.Parameters.AddWithValue("@customerId", searchText);
                        customerCommand.Parameters.AddWithValue("@customerName", $"%{searchText}%");

                        using (MySqlDataReader customerReader = customerCommand.ExecuteReader())
                        {
                            if (customerReader.Read())
                            {
                                // Populate customer details
                                string customerId = customerReader["customerId"].ToString();
                                txtCustId.Text = customerId;

                                // Disable car fields except for car details
                                DesableFields();
                            }
                            else
                            {
                                // Reset customer details fields
                                txtCustId.Text = "";

                                // Enable all fields for new entry
                                DesableFields();
                            }
                        }
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRentNow_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    // Insert into "order" table
                    string orderId = GenerateOrderId();
                    string insertOrderQuery = "INSERT INTO `order` (orderId, customerId, orderDate, total) VALUES (@orderId, @customerId, @orderDate, @total)";
                    using (MySqlCommand insertOrderCmd = new MySqlCommand(insertOrderQuery, db.GetConnection()))
                    {
                        insertOrderCmd.Parameters.AddWithValue("@orderId", orderId);
                        insertOrderCmd.Parameters.AddWithValue("@customerId", txtCustId.Text);
                        insertOrderCmd.Parameters.AddWithValue("@orderDate", DateTime.Now);
                        insertOrderCmd.Parameters.AddWithValue("@total", decimal.Parse(txtTotalCost.Text));

                        insertOrderCmd.ExecuteNonQuery();
                    }

                    // Insert into "rentaldetail" table
                    string rentalId = GenerateCarRentalId(); // Assuming you have a method to generate rental ID
                    string insertRentalQuery = "INSERT INTO rentaldetail (rentalDetailId, orderId, carId, customerId, rentalStartDate, rentalEndDate, dailyRate, totalCost, totalDays) VALUES (@rentalDetailId, @orderId, @carId, @customerId, @startDate, @endDate, @dailyRate, @totalCost, @totalDays)";
                    using (MySqlCommand insertRentalCmd = new MySqlCommand(insertRentalQuery, db.GetConnection()))
                    {
                        insertRentalCmd.Parameters.AddWithValue("@rentalDetailId", rentalId);
                        insertRentalCmd.Parameters.AddWithValue("@orderId", orderId); // Add OrderID here
                        insertRentalCmd.Parameters.AddWithValue("@carId", cmbCarId.SelectedItem.ToString());
                        insertRentalCmd.Parameters.AddWithValue("@customerId", txtCustId.Text);
                        insertRentalCmd.Parameters.AddWithValue("@startDate", dtpRentalStartDate.Value);
                        insertRentalCmd.Parameters.AddWithValue("@endDate", dtpRentalEndDate.Value);
                        insertRentalCmd.Parameters.AddWithValue("@dailyRate", decimal.Parse(txtDailyRate.Text)); // Assuming txtDailyRate contains the daily rate
                        insertRentalCmd.Parameters.AddWithValue("@totalCost", decimal.Parse(txtTotalCost.Text)); // Assuming txtTotalCost contains the total cost
                        insertRentalCmd.Parameters.AddWithValue("@totalDays", txtTotalRentDays.Text); // Assuming txtTotalCost contains the total cost

                        insertRentalCmd.ExecuteNonQuery();
                    }

                    // Update car availability to "Unavailable"
                    string updateCarQuery = "UPDATE car SET availability = 'Unavailable' WHERE carId = @carId";
                    using (MySqlCommand updateCarCmd = new MySqlCommand(updateCarQuery, db.GetConnection()))
                    {
                        updateCarCmd.Parameters.AddWithValue("@carId", cmbCarId.SelectedItem.ToString());
                        updateCarCmd.ExecuteNonQuery();
                    }

                    db.CloseConnection();
                    LoadCarRentalDetails(rentalId);
                    MessageBox.Show("Rental details saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DesableFields();
                    txtCustId.Text = "";
                    cmbCarId.SelectedIndex = -1;
                    txtYear.Text = "";
                    txtMake.Text = "";
                    txtModel.Text = "";
                    txtDailyRate.Text = "";
                    txtTotalCost.Text = "";
                    txtTotalRentDays.Text = "";
                    dtpRentalStartDate.Value = DateTime.Now;
                    dtpRentalEndDate.Value = DateTime.Now;
                    carImgBox.Image = null;
                    lblCarAvailable.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving rental details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCarRentalDetails(string rentalId)
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT rentalDetailId, orderId, carId, rentalStartDate, rentalEndDate, dailyRate, totalCost FROM rentaldetail WHERE rentalDetailId = @rentalId";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@rentalId", rentalId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable rentalDetailsTable = new DataTable();
                            adapter.Fill(rentalDetailsTable);
                            tblCarRentalDetails.DataSource = rentalDetailsTable;
                        }
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading rental details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tblCarRentalDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row or an out-of-bounds row
            if (e.RowIndex >= 0 && e.RowIndex < tblCarRentalDetails.Rows.Count)
            {
                DataGridViewRow row = tblCarRentalDetails.Rows[e.RowIndex];

                // Populate the fields with the selected row's data
                txtRentalId.Text = row.Cells["rentalDetailId"].Value.ToString();
                // You might want to set the cmbCustId based on the orderId, fetching the customer ID if needed
                // cmbCustId.SelectedItem = GetCustomerIdByOrderId(row.Cells["orderId"].Value.ToString());
                cmbCarId.SelectedItem = row.Cells["carId"].Value.ToString();
                dtpRentalStartDate.Value = DateTime.Parse(row.Cells["rentalStartDate"].Value.ToString());
                dtpRentalEndDate.Value = DateTime.Parse(row.Cells["rentalEndDate"].Value.ToString());
                txtDailyRate.Text = row.Cells["dailyRate"].Value.ToString();
                txtTotalCost.Text = row.Cells["totalCost"].Value.ToString();

                // Optionally, load the customer ID and details based on the order ID
                // You might need to implement a method to fetch and set these details
                btnRentNow.Text = "UPDATE RENT";
            }
        }
    }
}
