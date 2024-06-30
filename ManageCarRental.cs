using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmManageCarRental : Form
    {
        private BindingList<Customer> customers = new BindingList<Customer>();
        private BindingList<Car> cars = new BindingList<Car>();

        public frmManageCarRental()
        {
            InitializeComponent();
            LoadComboBoxData();
            cmbCarId.Enabled = false;

            cmbCustId.SelectedIndexChanged += cmbCustId_SelectedIndexChanged;
            cmbCarId.SelectedIndexChanged += cmbCarId_SelectedIndexChanged;
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

        private void LoadCustomers(MySqlConnection connection)
        {
            string queryCustomer = "SELECT customerId, firstName, lastName, phone, email FROM customer";
            LoadDataToComboBox<Customer>(queryCustomer, connection, cmbCustId, customers);
        }

        private void LoadCars(MySqlConnection connection)
        {
            string queryCars = "SELECT carId, make, model, price, year, imagePath FROM car";
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
                    ImagePath = reader["imagePath"].ToString()
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
        public decimal Price { get; set; }
        public int Year { get; set; }
    }
}
