using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmManageOrderDetails : Form
    {
        private BindingList<Customer> customers = new BindingList<Customer>();
        private BindingList<Carpart> carParts = new BindingList<Carpart>();
        //private BindingList<Car> cars = new BindingList<Car>();
        private BindingList<OrderDetail> orderDetails = new BindingList<OrderDetail>();
        private decimal totalOrderPrice = 0.00m;

        public frmManageOrderDetails()
        {
            InitializeComponent();
            LoadComboBoxData();
            DisableFields();
            txtOrderId.Text = GenerateOrderId();

            // Attach event handlers
            cmbCustId.SelectedIndexChanged += CmbCustId_SelectedIndexChanged;
            cmbProductId.SelectedIndexChanged += CmbProductId_SelectedIndexChanged;
            txtOederQty.TextChanged += TxtOrderQty_TextChanged; // Event handler for orderQty validation
            searchIcon.Click += btnSearch_Click;
        }

        private MySqlConnection OpenDatabaseConnection()
        {
            var db = new CarManagementSystem.DBConnection.DBConnection();
            db.OpenConnection();
            return db.GetConnection();
        }

        public void LoadComboBoxData()
        {
            try
            {
                using (var connection = OpenDatabaseConnection())
                {
                    LoadCustomers(connection);
                    LoadCarParts(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCustomers(MySqlConnection connection)
        {
            string queryCustomer = "SELECT customerId, firstName, lastName, phone, email FROM customer";
            using (MySqlCommand command = new MySqlCommand(queryCustomer, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    cmbCustId.Items.Clear();
                    customers.Clear();

                    while (reader.Read())
                    {
                        string customerId = reader["customerId"].ToString();
                        cmbCustId.Items.Add(customerId);
                        customers.Add(new Customer
                        {
                            CustomerId = customerId,
                            FirstName = reader["firstName"].ToString(),
                            LastName = reader["lastName"].ToString(),
                            Phone = reader["phone"].ToString(),
                            Email = reader["email"].ToString()
                        });
                    }
                }
            }
        }

        private void LoadCarParts(MySqlConnection connection)
        {
            string queryCarPart = "SELECT partId, partname, model, price, description, qtyonhand FROM carpart";
            using (MySqlCommand command = new MySqlCommand(queryCarPart, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    cmbProductId.Items.Clear();
                    carParts.Clear();

                    while (reader.Read())
                    {
                        string partId = reader["partId"].ToString();
                        cmbProductId.Items.Add(partId);
                        carParts.Add(new Carpart
                        {
                            PartId = partId,
                            PartName = reader["partname"].ToString(),
                            Model = reader["model"].ToString(),
                            UnitPrice = reader["price"].ToString(),
                            Description = reader["description"].ToString(),
                            QtyOnHand = reader["qtyonhand"].ToString()
                        });
                    }
                }
            }
        }

        public string GenerateOrderId()
        {
            Random random = new Random();
            string part1 = random.Next(0, 1000).ToString("D3");
            string part2 = random.Next(1, 1000).ToString("D3");
            return $"O{part1}-{part2}";
        }

        public string GenerateOrderDetailId()
        {
            Random random = new Random();
            string part1 = random.Next(0, 1000).ToString("D3");
            string part2 = random.Next(1, 1000).ToString("D3");
            return $"OD{part1}-{part2}";
        }

        public void DisableFields()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhoneNo.Enabled = false;
            txtEmail.Enabled = false;
            txtOrderId.Enabled = false;
            cmbProductId.Enabled = false; // Initially disable product selection
            txtOederQty.Enabled = false; // Initially disable order quantity
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

                    // Enable product section
                    EnableProductSection();
                }
            }
        }

        private void EnableProductSection()
        {
            cmbProductId.Enabled = true;
            txtOederQty.Enabled = true;
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
                    txtModel.Text = selectedPart.Model;
                    txtPrice.Text = selectedPart.UnitPrice;
                    txtQty.Text = selectedPart.QtyOnHand;
                }
            }
        }

        private void TxtOrderQty_TextChanged(object sender, EventArgs e)
        {
            ValidateOrderQuantity();
        }

        private void ValidateOrderQuantity()
        {
            if (int.TryParse(txtOederQty.Text, out int orderQty))
            {
                if (int.TryParse(txtQty.Text, out int qtyOnHand))
                {
                    if (orderQty > qtyOnHand)
                    {
                        MessageBox.Show("Out of quantity", "Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtOederQty.Text = qtyOnHand.ToString(); // Reset orderQty to max available quantity
                    }
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string partId = cmbProductId.SelectedItem?.ToString();
            string orderQtyText = txtOederQty.Text;

            if (string.IsNullOrEmpty(partId) || string.IsNullOrEmpty(orderQtyText) || !int.TryParse(orderQtyText, out int orderQty))
            {
                MessageBox.Show("Please ensure all product details are selected and filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Carpart selectedPart = carParts.FirstOrDefault(p => p.PartId == partId);
            if (selectedPart == null || orderQty > int.Parse(selectedPart.QtyOnHand))
            {
                MessageBox.Show("Invalid product selection or quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal unitPrice = decimal.Parse(selectedPart.UnitPrice);
            decimal totalPrice = unitPrice * orderQty;
            totalOrderPrice += totalPrice;

            orderDetails.Add(new OrderDetail
            {
                PartId = partId,
                PartName = selectedPart.PartName,
                Model = selectedPart.Model,
                UnitPrice = unitPrice,
                OrderQty = orderQty,
                TotalPrice = totalPrice
            });

            tblCarPartDetails.DataSource = orderDetails.ToList(); // Assuming tblCarPartDetails is a DataGridView
            txtTotal.Text = totalOrderPrice.ToString("F2");

            // Clear product selection
            cmbProductId.SelectedIndex = -1;
            txtPartName.Text = "";
            txtModel.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtOederQty.Text = "";
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            string customerId = cmbCustId.SelectedItem?.ToString();
            DateTime orderDate = DateTime.Today;
            decimal totalPrice = CalculateTotalPriceForAllDetails();
            decimal cash = 0.0m;
            decimal balance = 0.0m;

            // Parse cash and balance as decimals
            decimal.TryParse(txtCash.Text, out cash);
            decimal.TryParse(txtBalance.Text, out balance);

            if (string.IsNullOrEmpty(customerId) || orderDetails.Count == 0)
            {
                MessageBox.Show("Please ensure all order details are selected and filled.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = OpenDatabaseConnection())
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string orderQuery = "INSERT INTO `order` (orderId, customerId, orderdate, total, cash, balance) VALUES (@orderId, @customerId, @orderDate, @total, @cash, @balance)";
                            using (MySqlCommand command = new MySqlCommand(orderQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@orderId", orderId);
                                command.Parameters.AddWithValue("@customerId", customerId);
                                command.Parameters.AddWithValue("@orderdate", orderDate);
                                command.Parameters.AddWithValue("@total", totalPrice);
                                command.Parameters.AddWithValue("@cash", cash);
                                command.Parameters.AddWithValue("@balance", balance);

                                command.ExecuteNonQuery();
                            }

                            foreach (var orderDetail in orderDetails)
                            {
                                string orderDetailId = GenerateOrderDetailId();
                                string orderDetailQuery = "INSERT INTO orderdetail (orderdetailId, orderId, productId, quantity, unitPrice) VALUES (@orderdetailId, @orderId, @productId, @quantity, @unitPrice)";
                                using (MySqlCommand command = new MySqlCommand(orderDetailQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@orderdetailId", orderDetailId);
                                    command.Parameters.AddWithValue("@orderId", orderId);
                                    command.Parameters.AddWithValue("@productId", orderDetail.PartId);
                                    command.Parameters.AddWithValue("@quantity", orderDetail.OrderQty);
                                    command.Parameters.AddWithValue("@unitPrice", orderDetail.UnitPrice);

                                    command.ExecuteNonQuery();
                                }

                                // Update the quantity in the carpart table
                                string updateQuantityQuery = "UPDATE carpart SET qtyonhand = qtyonhand - @quantity WHERE partId = @partId";
                                using (MySqlCommand command = new MySqlCommand(updateQuantityQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@quantity", orderDetail.OrderQty);
                                    command.Parameters.AddWithValue("@partId", orderDetail.PartId);

                                    command.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Order purchased successfully.", "Order Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the form for a new order
                            ClearForm();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"An error occurred while processing the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private decimal CalculateTotalPriceForAllDetails()
        {
            decimal total = 0.0m;

            foreach (var orderDetail in orderDetails)
            {
                total += orderDetail.UnitPrice * orderDetail.OrderQty;
            }

            txtTotal.Text = total.ToString("F2"); // Format as currency
            return total;
        }


        private void ClearForm()
        {
            txtOrderId.Text = GenerateOrderId();
            cmbCustId.SelectedIndex = -1;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";
            cmbProductId.SelectedIndex = -1;
            txtPartName.Text = "";
            txtModel.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtOederQty.Text = "";
            txtTotal.Text = "";
            totalOrderPrice = 0.00m;
            orderDetails.Clear();
            tblCarPartDetails.DataSource = null;
            DisableFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCustomer();
        }

        private void SearchCustomer()
        {
            string searchCriteria = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchCriteria))
            {
                MessageBox.Show("Please enter a customer ID or name to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = OpenDatabaseConnection())
                {
                    string query = "SELECT customerId, firstName, lastName, phone, email FROM customer WHERE customerId = @search OR firstName LIKE @search OR lastName LIKE @search";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@search", searchCriteria);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cmbCustId.Text = reader["customerId"].ToString();
                                txtFirstName.Text = reader["firstName"].ToString();
                                txtLastName.Text = reader["lastName"].ToString();
                                txtPhoneNo.Text = reader["phone"].ToString();
                                txtEmail.Text = reader["email"].ToString();

                                // Enable product section
                                EnableProductSection();
                            }
                            else
                            {
                                MessageBox.Show("No customer found with the given ID or name.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        public string PartName { get; set; }
        public string Model { get; set; }
        public string UnitPrice { get; set; }
        public string Description { get; set; }
        public string QtyOnHand { get; set; }
    }

    public class OrderDetail
    {
        public string PartId { get; set; }
        public string PartName { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public int OrderQty { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
