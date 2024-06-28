using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmManageOrderDetails : Form
    {
        private BindingList<Customer> customers = new BindingList<Customer>();
        private BindingList<Carpart> carParts = new BindingList<Carpart>();
        private BindingList<Car> cars = new BindingList<Car>();

        public frmManageOrderDetails()
        {
            InitializeComponent();
            LoadComboBoxData();
            DisableFields();
            txtOrderId.Text = GenerateUniqueNumber();

            // Attach event handlers
            cmbCustId.SelectedIndexChanged += CmbCustId_SelectedIndexChanged;
            cmbProductId.SelectedIndexChanged += CmbProductId_SelectedIndexChanged;
            cmbCarId.SelectedIndexChanged += CmbCarId_SelectedIndexChanged;
        }

        public void LoadComboBoxData()
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    // Load customers
                    string queryCustomer = "SELECT customerId, firstName, lastName, phone, email FROM customer";
                    using (MySqlCommand command = new MySqlCommand(queryCustomer, db.GetConnection()))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            cmbCustId.Items.Clear();
                            customers.Clear();

                            while (reader.Read())
                            {
                                string customerId = reader["customerId"].ToString();
                                string firstName = reader["firstName"].ToString();
                                string lastName = reader["lastName"].ToString();
                                string phone = reader["phone"].ToString();
                                string email = reader["email"].ToString();

                                cmbCustId.Items.Add(customerId);
                                customers.Add(new Customer
                                {
                                    CustomerId = customerId,
                                    FirstName = firstName,
                                    LastName = lastName,
                                    Phone = phone,
                                    Email = email
                                });
                            }
                        }
                    }

                    // Load car parts
                    string queryCarPart = "SELECT partId, description, qtyonhand FROM carpart";
                    using (MySqlCommand command = new MySqlCommand(queryCarPart, db.GetConnection()))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            cmbProductId.Items.Clear();
                            carParts.Clear();

                            while (reader.Read())
                            {
                                string partId = reader["partId"].ToString();
                                string description = reader["description"].ToString();
                                string qtyOnHand = reader["qtyonhand"].ToString();

                                cmbProductId.Items.Add(partId);
                                carParts.Add(new Carpart
                                {
                                    PartId = partId,
                                    Description = description,
                                    QtyOnHand = qtyOnHand
                                });
                            }
                        }
                    }

                    // Load cars
                    string queryCars = "SELECT carId, model FROM car";
                    using (MySqlCommand command = new MySqlCommand(queryCars, db.GetConnection()))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            cmbCarId.Items.Clear();
                            cars.Clear();

                            while (reader.Read())
                            {
                                string carId = reader["carId"].ToString();
                                string model = reader["model"].ToString();

                                cmbCarId.Items.Add(carId);
                                cars.Add(new Car
                                {
                                    CarId = carId,
                                    Model = model
                                });
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

        public string GenerateUniqueNumber()
        {
            Random random = new Random();
            string part1 = random.Next(0, 1000).ToString("D3");
            string part2 = random.Next(1, 1000).ToString("D3");
            string uniqueNumber = $"0{part1}-{part2}";
            return uniqueNumber;
        }

        public void DisableFields()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhoneNo.Enabled = false;
            txtEmail.Enabled = false;
            txtOrderId.Enabled = false;
        }

        private void CmbCustId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustId.SelectedItem != null)
            {
                string selectedCustomerId = cmbCustId.SelectedItem.ToString();
                Customer selectedCustomer = customers.FirstOrDefault(c => c.CustomerId == selectedCustomerId);

                if (selectedCustomer != null)
                {
                    txtFirstName.Text = selectedCustomer.FirstName;
                    txtLastName.Text = selectedCustomer.LastName;
                    txtPhoneNo.Text = selectedCustomer.Phone;
                    txtEmail.Text = selectedCustomer.Email;
                }
            }
        }

        private void CmbProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductId.SelectedItem != null)
            {
                string selectedPartId = cmbProductId.SelectedItem.ToString();
                Carpart selectedPart = carParts.FirstOrDefault(p => p.PartId == selectedPartId);

                if (selectedPart != null)
                {
                    txtPartName.Text = selectedPart.Description;
                    txtQtyOnHand.Text = selectedPart.QtyOnHand;
                }
            }
        }

        private void CmbCarId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCarId.SelectedItem != null)
            {
                string selectedCarId = cmbCarId.SelectedItem.ToString();

                Car selectedCar = cars.FirstOrDefault(c => c.CarId == selectedCarId);

                if (selectedCar != null)
                {
                    txtCarName.Text = selectedCar.Model;
                }
            }
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // Implement functionality for adding an order
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            // Implement functionality for purchasing an order
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Implement functionality for clearing form fields
        }
    }

    public class Customer
    {
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class Carpart
    {
        public string PartId { get; set; }
        public string Description { get; set; }
        public string QtyOnHand { get; set; }
    }

    public class Car
    {
        public string CarId { get; set; }
        public string Model { get; set; }
    }
}
