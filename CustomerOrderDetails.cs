using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmCustomerOrderDetails : Form
    {
        private BindingList<Carpart> carParts = new BindingList<Carpart>();
        private BindingList<OrderDetail> orderDetails = new BindingList<OrderDetail>();
        private BindingList<Car> cars = new BindingList<Car>();
        private decimal totalOrderPrice = 0.00m;
        private string customerId;

        public frmCustomerOrderDetails(string username, string custId)
        {
            InitializeComponent();
            customerId = custId;
            ConfigureOrderDetailsTable();
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
            txtOederQty.TextChanged += TxtOrderQty_TextChanged;
            btnAdd.Click += btnAddOrder_Click;
            btnPurchase.Click += btnPurchaseOrder_Click;
            cmbProductId.SelectedIndexChanged += CmbProductId_SelectedIndexChanged;
            cmbVehicleId.SelectedIndexChanged += CmbVehicleId_SelectedIndexChanged;
            txtCash.TextChanged += TxtCash_TextChanged;
        }

        private MySqlConnection OpenDatabaseConnection()
        {
            var db = new CarManagementSystem.DBConnection.DBConnection();
            var connection = db.GetConnection();
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }

        private void LoadComboBoxData()
        {
            try
            {
                using (var connection = OpenDatabaseConnection())
                {
                    LoadCarParts(connection);
                    LoadCars(connection);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"An error occurred: {ex.Message}");
            }
        }

        private void LoadCarParts(MySqlConnection connection)
        {
            string queryCarPart = "SELECT partId, partname, model, price, description, qtyonhand, imagePath FROM carpart";
            LoadDataToComboBox(queryCarPart, connection, cmbProductId, carParts);
        }

        private void LoadCars(MySqlConnection connection)
        {
            string queryCar = "SELECT carId, make, model, year, price, qtyOnHand, imagePath FROM car WHERE sellOrRent = 0";
            LoadDataToComboBox(queryCar, connection, cmbVehicleId, cars);
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
            if (typeof(T) == typeof(Carpart))
            {
                return (T)(object)new Carpart
                {
                    PartId = reader["partId"].ToString(),
                    PartName = reader["partname"].ToString(),
                    Model = reader["model"].ToString(),
                    UnitPrice = Convert.ToDecimal(reader["price"]),
                    Description = reader["description"].ToString(),
                    QtyOnHand = reader["qtyonhand"].ToString(),
                    ImagePath = reader["imagePath"].ToString()
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
                    Price = Convert.ToDecimal(reader["price"]),
                    QtyOnHand = reader["qtyOnHand"].ToString(),
                    ImagePath = reader["imagePath"].ToString()
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

        public string GenerateOrderId() => GenerateId("O");
        public string GenerateOrderDetailId() => GenerateId("OD");

        private void DisableFields()
        {
            txtOrderId.Enabled = false;
            btnAdd.Enabled = false;
            txtTotal.Enabled = false;
            txtCash.Enabled = false;
            txtBalance.Enabled = false;
            btnPurchase.Enabled = false;
        }

        private void EnableFields()
        {
            btnAdd.Enabled = true;
            txtTotal.Enabled = true;
            txtCash.Enabled = true;
            txtBalance.Enabled = true;
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
                    LoadProductImage(selectedPart.ImagePath);
                    EnableFields();
                }
            }
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
                    LoadCarImage(selectedCar.ImagePath);
                    EnableFields();
                }
            }
        }

        private void PopulateCarFields(Car car)
        {
            txtPartName.Text = car.Make;
            txtModel.Text = car.Model;
            txtPrice.Text = car.Price.ToString();
            txtQty.Text = car.QtyOnHand;
        }

        private void LoadProductImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                imgProductBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                imgProductBox.Image = null;
            }
        }

        private void LoadCarImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                imgProductBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                imgProductBox.Image = null;
            }
        }

        private void PopulateProductFields(Carpart part)
        {
            txtPartName.Text = part.PartName;
            txtModel.Text = part.Model;
            txtPrice.Text = part.UnitPrice.ToString();
            txtQty.Text = part.QtyOnHand;
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
                ShowWarningMessage("Order quantity exceeds available stock.");
                txtOederQty.Text = qtyOnHand.ToString();
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (IsValidOrderInput(out string partId, out int orderQty))
            {
                AddOrderDetail(partId, orderQty, cmbProductId.SelectedItem != null);
                UpdateOrderDetailsTable();
            }
        }

        private bool IsValidOrderInput(out string partId, out int orderQty)
        {
            partId = cmbProductId.SelectedItem?.ToString() ?? cmbVehicleId.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(partId))
            {
                ShowWarningMessage("Please select a product or vehicle.");
                orderQty = 0;
                return false;
            }

            if (!int.TryParse(txtOederQty.Text, out orderQty) || orderQty <= 0)
            {
                ShowWarningMessage("Please enter a valid order quantity.");
                return false;
            }

            return true;
        }

        private void AddOrderDetail(string productIdOrVehicleId, int orderQty, bool isProductId)
        {
            var existingOrderDetail = orderDetails.FirstOrDefault(od => od.PartId == productIdOrVehicleId);

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
                    AddNewOrderDetail(selectedPart.PartId, selectedPart.PartName, selectedPart.Model, selectedPart.UnitPrice, orderQty);
                }
                else
                {
                    // Add a new order detail for a car
                    var selectedCar = cars.First(c => c.CarId == productIdOrVehicleId);
                    AddNewOrderDetail(selectedCar.CarId, selectedCar.Make, selectedCar.Model, selectedCar.Price, orderQty);
                }
            }
        }

        private void AddNewOrderDetail(string partId, string partName, string model, decimal unitPrice, int orderQty)
        {
            orderDetails.Add(new OrderDetail
            {
                OrderDetailId = GenerateOrderDetailId(),
                PartId = partId,
                PartName = partName,
                Model = model,
                UnitPrice = unitPrice,
                OrderQty = orderQty,
                TotalPrice = unitPrice * orderQty
            });
            totalOrderPrice += unitPrice * orderQty;
            txtTotal.Text = totalOrderPrice.ToString("C2");
        }

        private void UpdateOrderDetailsTable()
        {
            tblOrderDetails.DataSource = null;
            tblOrderDetails.DataSource = orderDetails;
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            if (orderDetails.Count > 0)
            {
                bool success = ProcessOrder();
                if (success)
                {
                    ShowInformationMessage("Order placed successfully!");
                    ResetOrderForm();
                }
            }
            else
            {
                ShowWarningMessage("No items in the order to process.");
            }
        }

        private bool ProcessOrder()
        {
            try
            {
                using (var connection = OpenDatabaseConnection())
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            InsertOrder(connection, transaction);
                            InsertOrderDetails(connection, transaction);
                            transaction.Commit();
                            return true;
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"An error occurred: {ex.Message}");
                return false;
            }
        }

        private void InsertOrder(MySqlConnection connection, MySqlTransaction transaction)
        {
            string queryOrder = "INSERT INTO `order` (orderId, customerId, orderDate, total, cash, balance) VALUES (@orderId, @customerId, @orderDate, @total, @cash, @balance)";

            using (MySqlCommand command = new MySqlCommand(queryOrder, connection, transaction))
            {
                command.Parameters.AddWithValue("@orderId", txtOrderId.Text);
                command.Parameters.AddWithValue("@customerId", customerId);
                command.Parameters.AddWithValue("@orderDate", DateTime.Now);
                command.Parameters.AddWithValue("@total", totalOrderPrice);
                command.Parameters.AddWithValue("@cash", txtCash.Text);
                command.Parameters.AddWithValue("@balance", txtBalance.Text);

                command.ExecuteNonQuery();
            }
        }

        private void InsertOrderDetails(MySqlConnection connection, MySqlTransaction transaction)
        {
            foreach (var orderDetail in orderDetails)
            {
                string queryOrderDetail = "INSERT INTO orderdetail (orderDetailId, orderId, productId, quantity, unitPrice) VALUES (@orderDetailId, @orderId, @productId, @quantity, @unitPrice)";

                using (MySqlCommand command = new MySqlCommand(queryOrderDetail, connection, transaction))
                {
                    command.Parameters.AddWithValue("@orderDetailId", orderDetail.OrderDetailId);
                    command.Parameters.AddWithValue("@orderId", txtOrderId.Text);
                    command.Parameters.AddWithValue("@productId", orderDetail.PartId);
                    command.Parameters.AddWithValue("@quantity", orderDetail.OrderQty);
                    command.Parameters.AddWithValue("@unitPrice", orderDetail.UnitPrice);

                    command.ExecuteNonQuery();
                }

                UpdateCarPartQuantity(orderDetail.PartId, orderDetail.OrderQty);
                UpdateCarQuantity(orderDetail.PartId, orderDetail.OrderQty);
            }
        }

        private void UpdateCarPartQuantity(string partId, int qtyOrdered)
        {
            string query = "UPDATE carpart SET qtyonhand = qtyonhand - @qtyOrdered WHERE partId = @partId";

            using (var connection = OpenDatabaseConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@qtyOrdered", qtyOrdered);
                command.Parameters.AddWithValue("@partId", partId);
                command.ExecuteNonQuery();
            }
        }

        private void UpdateCarQuantity(string carId, int qtyOrdered)
        {
            string query = "UPDATE car SET qtyOnHand = qtyOnHand - @qtyOrdered WHERE carId = @carId";

            using (var connection = OpenDatabaseConnection())
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@qtyOrdered", qtyOrdered);
                command.Parameters.AddWithValue("@carId", carId);
                command.ExecuteNonQuery();
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowInformationMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetOrderForm()
        {
            txtOrderId.Text = GenerateOrderId();
            txtOederQty.Clear();
            txtTotal.Text = "";
            txtPartName.Text = "";
            txtModel.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
            txtOederQty.Text = "";
            txtCash.Clear();
            txtBalance.Text = "";
            cmbProductId.SelectedIndex = -1;
            cmbVehicleId.SelectedIndex = -1;
            tblOrderDetails.DataSource = null;
            orderDetails.Clear();
            totalOrderPrice = 0.00m;
            DisableFields();
        }

        private void ConfigureOrderDetailsTable()
        {
            tblOrderDetails.AutoGenerateColumns = false;
            tblOrderDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OrderDetailId", HeaderText = "Order Detail ID" });
            tblOrderDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "PartName", HeaderText = "Part Name" });
            tblOrderDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Model", HeaderText = "Model" });
            tblOrderDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Unit Price" });
            tblOrderDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OrderQty", HeaderText = "Quantity" });
            tblOrderDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalPrice", HeaderText = "Total Price" });
        }
    }

    public class Carpart
    {
        public string PartId { get; set; }
        public string PartName { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public string QtyOnHand { get; set; }
        public string ImagePath { get; set; }
    }

    public class Car
    {
        public string CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }
        public string QtyOnHand { get; set; }
        public string ImagePath { get; set; }
    }

    public class OrderDetail
    {
        public string OrderDetailId { get; set; }
        public string PartId { get; set; }
        public string PartName { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public int OrderQty { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
