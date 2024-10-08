﻿using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmManageOrderDetails : Form
    {
        private BindingList<Customer> customers = new BindingList<Customer>();
        private BindingList<Carpart> carParts = new BindingList<Carpart>();
        private BindingList<Car> cars = new BindingList<Car>();
        private BindingList<OrderDetail> orderDetails = new BindingList<OrderDetail>();
        private decimal totalOrderPrice = 0.00m;

        public frmManageOrderDetails()
        {
            InitializeComponent();
            InitializeForm();

        }

        private void InitializeForm()
        {
            LoadComboBoxData();
            DisableFields();
            txtOrderId.Text = GenerateOrderId();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            cmbCustId.SelectedIndexChanged += CmbCustId_SelectedIndexChanged;
            cmbProductId.SelectedIndexChanged += CmbProductId_SelectedIndexChanged;
            cmbVehicleId.SelectedIndexChanged += CmbVehicleId_SelectedIndexChanged;
            txtOederQty.TextChanged += TxtOrderQty_TextChanged; // Event handler for orderQty validation
            searchIcon.Click += btnSearch_Click;
            btnPurchase.Click += btnPurchaseOrder_Click;
            txtCash.TextChanged += TxtCash_TextChanged;
        }

        private MySqlConnection OpenDatabaseConnection()
        {
            var db = new CarManagementSystem.DBConnection.DBConnection();
            db.OpenConnection();
            return db.GetConnection();
        }

        private void LoadComboBoxData()
        {
            try
            {
                using (var connection = OpenDatabaseConnection())
                {
                    LoadCustomers(connection);
                    LoadCarParts(connection);
                    LoadCars(connection);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"An error occurred: {ex.Message}");
            }
        }

        private void LoadCars(MySqlConnection connection)
        {
            string queryCar = "SELECT carId, make, model, year, price, qtyOnHand FROM car WHERE sellOrRent = 0";
            LoadDataToComboBox(queryCar, connection, cmbVehicleId, cars);
        }

        private void LoadCustomers(MySqlConnection connection)
        {
            string queryCustomer = "SELECT customerId, firstName, lastName, phone, email FROM customer";
            LoadDataToComboBox(queryCustomer, connection, cmbCustId, customers);
        }

        private void LoadCarParts(MySqlConnection connection)
        {
            string queryCarPart = "SELECT partId, partname, model, price, description, qtyonhand FROM carpart";
            LoadDataToComboBox(queryCarPart, connection, cmbProductId, carParts);
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

        private T CreateObject<T>(MySqlDataReader reader)
        {
            if (typeof(T) == typeof(Customer))
            {
                return (T)(object)new Customer
                {
                    CustomerId = reader["customerId"].ToString(),
                    FirstName = reader["firstName"].ToString(),
                    LastName = reader["lastName"].ToString(),
                    Phone = reader["phone"].ToString(),
                    Email = reader["email"].ToString()
                };
            }
            else if (typeof(T) == typeof(Carpart))
            {
                return (T)(object)new Carpart
                {
                    PartId = reader["partId"].ToString(),
                    PartName = reader["partname"].ToString(),
                    Model = reader["model"].ToString(),
                    UnitPrice = reader["price"].ToString(),
                    Description = reader["description"].ToString(),
                    QtyOnHand = reader["qtyonhand"].ToString()
                };
            }
            else if (typeof(T) == typeof(Car))
            {
                return (T)(object)new Car
                {
                    CarId = reader["carId"].ToString(),
                    Make = reader["make"].ToString(),
                    Model = reader["model"].ToString(),
                    Year = reader["year"].ToString(),
                    Price = reader["price"].ToString(),
                    QtyOnHand = reader["qtyOnHand"].ToString()
                };
            }

            return default(T);
        }

        private string GenerateId(string prefix)
        {
            Random random = new Random();
            string part1 = random.Next(0, 1000).ToString("D3");
            string part2 = random.Next(1, 1000).ToString("D3");
            return $"{prefix}{part1}-{part2}";
        }

        public string GenerateOrderId() => GenerateId("OD");
        public string GenerateOrderDetailId() => GenerateId("OD");

        private void DisableFields()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtPhoneNo.Enabled = false;
            txtEmail.Enabled = false;
            txtOrderId.Enabled = false;
            cmbProductId.Enabled = false;
            cmbVehicleId.Enabled = false;
            txtOederQty.Enabled = false;
            btnAdd.Enabled = false;
            txtTotal.Enabled = false;
            txtCash.Enabled = false;
            txtBalance.Enabled = false;
            btnPurchase.Enabled = false;
            btnClear.Enabled = false;
        }

        private void EnableProductSection()
        {
            cmbProductId.Enabled = true;
            cmbVehicleId.Enabled = true;
            txtOederQty.Enabled = true;
        }

        private void CmbCustId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustId.SelectedItem != null)
            {
                string selectedCustomerId = cmbCustId.SelectedItem.ToString();
                var selectedCustomer = customers.FirstOrDefault(c => c.CustomerId == selectedCustomerId);

                if (selectedCustomer != null)
                {
                    PopulateCustomerFields(selectedCustomer);
                    EnableProductSection();
                }
            }
        }

        private void PopulateCustomerFields(Customer customer)
        {
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtPhoneNo.Text = customer.Phone;
            txtEmail.Text = customer.Email;
        }

        private void CmbProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductId.SelectedItem != null)
            {
                cmbVehicleId.Enabled = false;
                string selectedPartId = cmbProductId.SelectedItem.ToString();
                var selectedPart = carParts.FirstOrDefault(p => p.PartId == selectedPartId);

                if (selectedPart != null)
                {
                    PopulateProductFields(selectedPart);
                    btnAdd.Enabled = true;
                    txtTotal.Enabled = true;
                    txtCash.Enabled = true;
                    txtBalance.Enabled = true;
                    btnClear.Enabled = true;
                }
            }
        }

        private void PopulateProductFields(Carpart part)
        {
            txtPartName.Text = part.Description;
            txtModel.Text = part.Model;
            txtPrice.Text = part.UnitPrice;
            txtQty.Text = part.QtyOnHand;
        }

        private void CmbVehicleId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehicleId.SelectedItem != null)
            {
                cmbProductId.Enabled = false;
                string selectedCarId = cmbVehicleId.SelectedItem.ToString();
                var selectedCar = cars.FirstOrDefault(p => p.CarId == selectedCarId);

                if (selectedCar != null)
                {
                    PopulateCarFields(selectedCar);
                    btnAdd.Enabled = true;
                    txtTotal.Enabled = true;
                    txtCash.Enabled = true;
                    txtBalance.Enabled = true;
                    btnClear.Enabled = true;
                }
            }
        }

        private void PopulateCarFields(Car car)
        {
            txtPartName.Text = car.Make;
            txtModel.Text = car.Model;
            txtPrice.Text = car.Price;
            txtQty.Text = car.QtyOnHand;
        }

        private void TxtOrderQty_TextChanged(object sender, EventArgs e)
        {
            ValidateOrderQuantity();
        }

        private void ValidateOrderQuantity()
        {
            if (int.TryParse(txtOederQty.Text, out int orderQty) &&
                int.TryParse(txtQty.Text, out int qtyOnHand) &&
                orderQty > qtyOnHand)
            {
                ShowWarningMessage("Out of quantity");
                txtOederQty.Text = qtyOnHand.ToString();
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtOederQty.Text, out int orderQty) && orderQty > 0)
            {
                string partId = cmbProductId.SelectedItem?.ToString();
                string carId = cmbVehicleId.SelectedItem?.ToString();

                if (IsValidOrderInput(partId, carId, txtOederQty.Text, out orderQty))
                {
                    if (!string.IsNullOrEmpty(partId))
                    {
                        AddOrderDetail(partId, orderQty, true); // Add order detail for a part
                    }
                    else if (!string.IsNullOrEmpty(carId))
                    {
                        AddOrderDetail(carId, orderQty, false); // Add order detail for a car
                    }
                    else
                    {
                        ShowErrorMessage("Please select a product or vehicle.");
                        return;
                    }

                    UpdateOrderDetailsTable();
                    ClearProductSelection();
                }
                else
                {
                    ShowErrorMessage("Invalid order input.");
                }
            }
            else
            {
                ShowErrorMessage("Invalid order quantity.");
            }
        }


        private bool IsValidOrderInput(string partId, string carId, string orderQtyText, out int orderQty)
        {
            orderQty = 0;

            if (string.IsNullOrEmpty(orderQtyText) || !int.TryParse(orderQtyText, out orderQty))
            {
                ShowWarningMessage("Please ensure all product details are selected and filled.");
                return false;
            }

            /*var selectedPart = carParts.FirstOrDefault(p => p.PartId == partId);
            var selectedCar = carParts.FirstOrDefault(p => p.PartId == carId);
            if (selectedPart == null || orderQty > int.Parse(selectedPart.QtyOnHand) || selectedCar == null || orderQty > int.Parse(selectedCar.QtyOnHand))
            {
                ShowWarningMessage("Invalid product selection or quantity.");
                return false;
            }*/

            return true;
        }

        private void AddOrderDetail(string productIdOrVehicleId, int orderQty, bool isProductId)
        {
            var existingOrderDetail = orderDetails.FirstOrDefault(od => isProductId ? od.PartId == productIdOrVehicleId : od.PartId == productIdOrVehicleId);

            if (existingOrderDetail != null)
            {
                // Update the existing order detail
                existingOrderDetail.OrderQty += orderQty;
                existingOrderDetail.TotalPrice = existingOrderDetail.OrderQty * existingOrderDetail.UnitPrice;
            }
            else
            {
                if (isProductId)
                {
                    // Add a new order detail for a part
                    var selectedPart = carParts.First(p => p.PartId == productIdOrVehicleId);
                    decimal unitPrice = decimal.Parse(selectedPart.UnitPrice);
                    decimal totalPrice = unitPrice * orderQty;

                    totalOrderPrice += totalPrice;

                    orderDetails.Add(new OrderDetail
                    {
                        PartId = productIdOrVehicleId,
                        PartName = selectedPart.PartName,
                        Model = selectedPart.Model,
                        UnitPrice = unitPrice,
                        OrderQty = orderQty,
                        TotalPrice = totalPrice
                    });
                }
                else
                {
                    // Add a new order detail for a car
                    var selectedCar = cars.First(c => c.CarId == productIdOrVehicleId);
                    decimal unitPrice = decimal.Parse(selectedCar.Price);
                    decimal totalPrice = unitPrice * orderQty;

                    totalOrderPrice += totalPrice;

                    orderDetails.Add(new OrderDetail
                    {
                        PartId = productIdOrVehicleId,
                        PartName = selectedCar.Make,
                        Model = selectedCar.Model,
                        UnitPrice = unitPrice,
                        OrderQty = orderQty,
                        TotalPrice = totalPrice
                    });
                }
            }

            // Update the total order price
            totalOrderPrice = orderDetails.Sum(od => od.TotalPrice);
        }


        private void UpdateOrderDetailsTable()
        {
            var filteredOrderDetails = orderDetails.Select(od => new
            {
                od.PartId,
                od.PartName,
                od.OrderQty,
                od.UnitPrice,
                od.TotalPrice
            }).ToList();
            tblOrderDetails.DataSource = filteredOrderDetails;
            txtTotal.Text = totalOrderPrice.ToString("F2");
        }

        private void ClearProductSelection()
        {
            cmbProductId.SelectedIndex = -1;
            cmbVehicleId.SelectedIndex = -1;
            txtPartName.Text = "";
            txtModel.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtOederQty.Text = "";
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {

            if (IsValidPurchaseInput(out string orderId, out string customerId, out decimal cash, out decimal balance))
            {
                ProcessPurchase(orderId, customerId, cash, balance);
            }
        }

        private bool IsValidPurchaseInput(out string orderId, out string customerId, out decimal cash, out decimal balance)
        {
            orderId = txtOrderId.Text;
            customerId = cmbCustId.SelectedItem?.ToString();
            cash = 0;
            balance = 0;

            if (string.IsNullOrEmpty(customerId) || !decimal.TryParse(txtCash.Text, out cash))
            {
                ShowWarningMessage("Please ensure a valid customer is selected and cash amount is entered.");
                return false;
            }

            balance = cash - totalOrderPrice;
            if (balance < 0)
            {
                ShowWarningMessage("Insufficient cash provided.");
                return false;
            }

            return true;
        }

        private void ProcessPurchase(string orderId, string customerId, decimal cash, decimal balance)
        {
            try
            {
                InsertOrder(orderId, customerId, totalOrderPrice, cash, balance);

                foreach (var detail in orderDetails)
                {
                    InsertOrderDetail(orderId, detail);
                    UpdateCarPartQuantity(detail.PartId, detail.OrderQty);
                    UpdateCarQuantity(detail.PartId, detail.OrderQty);
                }

                ShowInfoMessage($"Order successfully purchased! Balance: {balance:F2}");
                ResetForm();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"An error occurred while processing the purchase: {ex.Message}");
            }
        }


        private void InsertOrder(string orderId, string customerId, decimal totalPrice, decimal cash, decimal balance)
        {
            string queryOrder = "INSERT INTO `order` (orderId, customerId, orderDate, total, cash, balance) VALUES (@orderId, @customerId, @orderDate, @total, @cash, @balance)";
            ExecuteNonQuery(queryOrder, ("@orderId", orderId), ("@customerId", customerId), ("@orderDate", DateTime.Now), ("@total", totalPrice), ("@cash", cash), ("@balance", balance));
        }


        private void InsertOrderDetail(string orderId, OrderDetail detail)
        {
            string queryOrderDetail = "INSERT INTO orderdetail (orderDetailId, orderId, productId, quantity, unitPrice) VALUES (@orderDetailId, @orderId, @productId, @quantity, @unitPrice)";
            string orderDetailId = GenerateOrderDetailId();
            ExecuteNonQuery(queryOrderDetail, ("@orderDetailId", orderDetailId), ("@orderId", orderId), ("@productId", detail.PartId), ("@quantity", detail.OrderQty), ("@unitPrice", detail.UnitPrice));
        }

        private void UpdateCarPartQuantity(string partId, int orderQty)
        {
            string queryUpdateCarPart = "UPDATE carpart SET qtyonhand = qtyonhand - @orderQty WHERE partId = @partId";
            ExecuteNonQuery(queryUpdateCarPart, ("@orderQty", orderQty), ("@partId", partId));
        }

        private void UpdateCarQuantity(string carId, int orderQty)
        {
            string queryUpdateCar = "UPDATE car SET qtyonhand = 0, availability = 'Unavailable' WHERE carId = @carId";
            ExecuteNonQuery(queryUpdateCar, ("@carId", carId));
        }

        private void ExecuteNonQuery(string query, params (string, object)[] parameters)
        {
            using (var connection = OpenDatabaseConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    foreach (var (parameterName, value) in parameters)
                    {
                        command.Parameters.AddWithValue(parameterName, value);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            if (!string.IsNullOrEmpty(orderId))
            {
                try
                {
                    using (var connection = OpenDatabaseConnection())
                    {
                        string query = "SELECT o.orderId, o.customerId, o.total, od.partId, od.orderQty, p.partname " +
                                       "FROM `order` o " +
                                       "JOIN orderdetail od ON o.orderId = od.orderId " +
                                       "JOIN carpart p ON od.partId = p.partId " +
                                       "WHERE o.orderId = @orderId";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@orderId", orderId);
                            using (var reader = command.ExecuteReader())
                            {
                                orderDetails.Clear();
                                while (reader.Read())
                                {
                                    orderDetails.Add(new OrderDetail
                                    {
                                        PartId = reader["partId"].ToString(),
                                        PartName = reader["partname"].ToString(),
                                        OrderQty = Convert.ToInt32(reader["orderQty"]),
                                        TotalPrice = Convert.ToDecimal(reader["orderQty"]) * Convert.ToDecimal(reader["price"])
                                    });
                                }
                                tblOrderDetails.DataSource = orderDetails.ToList();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorMessage($"An error occurred while searching for the order: {ex.Message}");
                }
            }
            else
            {
                ShowWarningMessage("Please enter a valid order ID.");
            }
        }

        private void TxtCash_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCash.Text, out decimal cash))
            {
                decimal balance = cash - totalOrderPrice;
                txtBalance.Text = balance.ToString("F2");

                if (balance >= 0)
                {
                    btnPurchase.Enabled = true;
                }
                else
                {
                    btnPurchase.Enabled = false;
                }
            }
            else
            {
                txtBalance.Text = "0.00";
                btnPurchase.Enabled = false;
            }
        }


        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowInfoMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetForm()
        {
            txtOrderId.Text = GenerateOrderId();
            cmbCustId.SelectedIndex = -1;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";
            cmbProductId.SelectedIndex = -1;
            cmbVehicleId.SelectedIndex = -1;
            txtPartName.Text = "";
            txtModel.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtOederQty.Text = "";
            txtCash.Text = "";
            txtTotal.Text = "";
            orderDetails.Clear();
            tblOrderDetails.DataSource = null;
            totalOrderPrice = 0.00m;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            cmbCustId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";

            cmbCustId.SelectedIndex = -1;
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";
            cmbProductId.SelectedIndex = -1;
            cmbVehicleId.SelectedIndex = -1;
            txtPartName.Text = "";
            txtModel.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            txtOederQty.Text = "";
            txtBalance.Text = "";
            txtCash.Text = "";
            txtTotal.Text = "";
            orderDetails.Clear();
            tblOrderDetails.DataSource = null;
            totalOrderPrice = 0.00m;
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
            public string ImagePath { get; set; }
        }

        public class OrderDetail
        {
            public string PartId { get; set; }
            public string OrderDetailId { get; set; }
            public string OrderId { get; set; }
            public string PartName { get; set; }
            public string Model { get; set; }
            public decimal UnitPrice { get; set; }
            public int OrderQty { get; set; }
            public decimal TotalPrice { get; set; }
        }

        public class Car
        {
            public string CarId { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }
            public string Price { get; set; }
            public string QtyOnHand { get; set; }
            public string ImagePath { get; set; }
        }
    }
}