using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmManageCarRental : Form
    {
        private BindingList<Customer> customers = new BindingList<Customer>();
        private BindingList<Car> cars = new BindingList<Car>();
        private string imagePath;

        public frmManageCarRental()
        {
            InitializeComponent();
            LoadComboBoxData();
            DisableFields();
            cmbCarId.Enabled = false;

            txtRentalId.Text = GenerateRentalId();

            txtDailyRate.TextChanged += TxtDailyRate_TextChanged;

            cmbCustId.SelectedIndexChanged += cmbCustId_SelectedIndexChanged;
            cmbCarId.SelectedIndexChanged += cmbCarId_SelectedIndexChanged;
            searchIcon.Click += btnSearching_Click;
        }

        private void DisableFields()
        {
            //cmbCarId.Enabled = false;
            dtpRentalEndDate.Enabled = false;
            dtpRentalStartDate.Enabled = false;
            //txtDailyRate.Enabled = false;
            txtTotalDays.Enabled = false;
            txtTotalCost.Enabled = false;
            btnRentNow.Enabled = false;
            lblCarAvailable.Visible = false;

        }

        private void EnabledFields()
        {
            dtpRentalEndDate.Enabled = true;
            dtpRentalStartDate.Enabled = true;
            //txtDailyRate.Enabled = true;
            txtTotalDays.Enabled = true;
            txtTotalCost.Enabled = true;
            btnRentNow.Enabled = true;
            lblCarAvailable.Visible =true;

        }

        private MySqlConnection OpenDatabaseConnection()
        {
            var db = new CarManagementSystem.DBConnection.DBConnection();
            db.OpenConnection();
            return db.GetConnection();
        }

        private void LoadComboBoxData()
        {
            using (var connection = OpenDatabaseConnection())
            {
                if (connection != null)
                {
                    LoadCustomers(connection);
                    LoadCars(connection);
                }
                else
                {
                    ShowErrorMessage("Failed to connect to the database.");
                }
            }
        }

        private string GenerateId(string prefix)
        {
            Random random = new Random();
            string part1 = random.Next(0, 1000).ToString("D3");
            string part2 = random.Next(1, 1000).ToString("D3");
            return $"{prefix}{part1}-{part2}";
        }

        public string GenerateRentalId() => GenerateId("RE");

        private void LoadCustomers(MySqlConnection connection)
        {
            string queryCustomer = "SELECT customerId, firstName, lastName, phone, email FROM customer";
            LoadDataToComboBox<Customer>(queryCustomer, connection, cmbCustId, customers);
        }

        private void LoadCars(MySqlConnection connection)
        {
            string queryCars = "SELECT carId, make, model, price, year, imagePath, availability FROM car";
            LoadDataToComboBox<Car>(queryCars, connection, cmbCarId, cars);
        }

        private void LoadDataToComboBox<T>(string query, MySqlConnection connection, ComboBox comboBox, BindingList<T> bindingList)
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    comboBox.Items.Clear();
                    bindingList.Clear();

                    while (reader.Read())
                    {
                        string id = reader[0].ToString();
                        comboBox.Items.Add(id);
                        bindingList.Add(CreateObject<T>(reader));
                    }
                }
            }
        }

        private T CreateObject<T>(IDataRecord reader)
        {
            if (typeof(T) == typeof(Customer))
            {
                return (T)(object)new Customer
                {
                    CustomerId = reader[0].ToString(),
                };
            }
            else if (typeof(T) == typeof(Car))
            {
                return (T)(object)new Car
                {
                    CarId = reader["carId"].ToString(),
                    Make = reader["make"].ToString(),
                    Model = reader["model"].ToString(),
                    Price = Convert.ToDecimal(reader["price"]),
                    Year = Convert.ToInt32(reader["year"]),
                    ImagePath = reader["imagePath"].ToString(),
                    Availability = reader["availability"].ToString()
                };
            }
            throw new InvalidCastException($"Type {typeof(T)} is not supported.");
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbCustId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustId.SelectedIndex >= 0)
            {
                Customer selectedCustomer = customers[cmbCustId.SelectedIndex];
                cmbCarId.Enabled = true;
            }
        }

        private void cmbCarId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCarId.SelectedIndex >= 0)
            {
                Car selectedCar = cars[cmbCarId.SelectedIndex];

                txtMake.Text = selectedCar.Make;
                txtModel.Text = selectedCar.Model;
                txtPrice.Text = selectedCar.Price.ToString();
                txtYear.Text = selectedCar.Year.ToString();

                SetCarImage(selectedCar.ImagePath);

                // Check the availability of the selected car
                if (selectedCar.Availability.Equals("available", StringComparison.OrdinalIgnoreCase))
                {
                    lblCarAvailable.Text = "Available";
                    lblCarAvailable.BackColor = Color.FromArgb(59, 216, 94);
                    EnabledFields();
                }
                else
                {
                    lblCarAvailable.Text = "Unavailable";
                    lblCarAvailable.BackColor = Color.Red;
                    cmbCarId.Enabled = true;
                    DisableFields();
                }

                lblCarAvailable.Visible = true; // Make sure the label is visible
            }
        }


        private void btnSearching_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT CarID, Make, Model, Year, Price, Description, ImagePath FROM car WHERE CarID = @term";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@term", searchTerm);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cmbCarId.Text = reader["CarID"].ToString();
                                txtMake.Text = reader["Make"].ToString();
                                txtModel.Text = reader["Model"].ToString();
                                txtYear.Text = reader["Year"].ToString();
                                txtPrice.Text = reader["Price"].ToString();

                                string imgPath = reader["ImagePath"].ToString();
                                if (!string.IsNullOrEmpty(imgPath) && System.IO.File.Exists(imgPath))
                                {
                                    carImgBox.Image = new Bitmap(imgPath);
                                    imagePath = imgPath;
                                }
                                else
                                {
                                    carImgBox.Image = null;
                                    imagePath = string.Empty;
                                }
                                lblCarAvailable.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Car not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void SetCarImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    carImgBox.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"Failed to load image: {ex.Message}");
                }
            }
            else
            {
                carImgBox.Image = null;
            }
        }

        private void btnRentNow_Click(object sender, EventArgs e)
        {

        }

        private void dtpRentalStartDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotalDays();
        }

        private void dtpRentalEndDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotalDays();
        }

        private void CalculateAndDisplayTotalDays()
        {
            // Get the selected start and end dates
            DateTime startDate = dtpRentalStartDate.Value;
            DateTime endDate = dtpRentalEndDate.Value;

            // Calculate the difference in days
            TimeSpan difference = endDate - startDate;
            int totalDays = (int)difference.TotalDays;

            // Display the total days in txtTotalDays TextBox
            txtTotalDays.Text = totalDays.ToString();
        }

        private void TxtDailyRate_TextChanged(object sender, EventArgs e)
        {
            // Call method to calculate and display total cost
            txtTotalCost.Text = CalculateTotalCost().ToString("0.00");
        }

        private decimal CalculateTotalCost()
        {
            decimal dailyRate;
            int totalDays;

            if (!decimal.TryParse(txtDailyRate.Text, out dailyRate))
            {
                ShowErrorMessage("Invalid daily rate entered.");
                return 0; 
            }

            if (!int.TryParse(txtTotalDays.Text, out totalDays))
            {
                ShowErrorMessage("Invalid total days entered.");
                return 0; 
            }

            decimal totalCost = dailyRate * totalDays;
            return totalCost;
        }
    }

    public class Customer
    {
        public string CustomerId { get; set; }
    }

    public class Car
    {
        public string CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string ImagePath { get; set; }
        public string Availability { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
    }
}
