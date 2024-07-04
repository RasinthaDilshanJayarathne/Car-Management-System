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
    public partial class frmCustomerOrderDetails : Form
    {
        private BindingList<Carpart> carParts = new BindingList<Carpart>();
        private BindingList<OrderDetail> orderDetails = new BindingList<OrderDetail>();
        private decimal totalOrderPrice = 0.00m;
        private string customerId;

        public frmCustomerOrderDetails(string username, string custId)
        {
            InitializeComponent();
            customerId = custId;
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
            btnPurchase.Click += btnPurchaseOrder_Click;
            cmbProductId.SelectedIndexChanged += CmbProductId_SelectedIndexChanged;
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
                    LoadCarParts(connection);
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
                        string id = reader["partId"].ToString();
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
                    UnitPrice = reader["price"].ToString(),
                    Description = reader["description"].ToString(),
                    QtyOnHand = reader["qtyonhand"].ToString(),
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
            //btnPurchase.Enabled = true;
        }

        private void CmbProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductId.SelectedItem != null)
            {
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

        private void PopulateProductFields(Carpart part)
        {
            txtPartName.Text = part.Description;
            txtModel.Text = part.Model;
            txtPrice.Text = part.UnitPrice;
            txtQty.Text = part.QtyOnHand;
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
                AddOrderDetail(partId, orderQty);
                UpdateOrderDetailsTable();
            }
        }

        private bool IsValidOrderInput(out string partId, out int orderQty)
        {
            partId = cmbProductId.SelectedItem?.ToString();
            orderQty = 0;

            // Check if partId is null or empty
            if (string.IsNullOrEmpty(partId))
            {
                ShowWarningMessage("Please select a product.");
                return false;
            }

            // Check if order quantity is a valid integer
            if (!int.TryParse(txtOederQty.Text, out orderQty) || orderQty <= 0)
            {
                ShowWarningMessage("Please enter a valid order quantity.");
                return false;
            }

            // Find the selected part in the carParts list
            /*var selectedPart = carParts.FirstOrDefault(p => p.PartId == partId);

            // Check if the selected part exists
            if (selectedPart == null)
            {
                ShowWarningMessage("Selected product not found.");
                return false;
            }

            // Check if order quantity exceeds available stock
            if (orderQty > int.Parse(selectedPart.QtyOnHand))
            {
                ShowWarningMessage("Order quantity exceeds available stock.");
                return false;
            }*/

            return true;
        }



        private void AddOrderDetail(string partId, int orderQty)
        {
            var existingOrderDetail = orderDetails.FirstOrDefault(od => od.PartId == partId);

            if (existingOrderDetail != null)
            {
                // Update the existing order detail
                existingOrderDetail.OrderQty += orderQty;
                existingOrderDetail.TotalPrice = existingOrderDetail.OrderQty * existingOrderDetail.UnitPrice;
            }
            else
            {
                // Add a new order detail
                var selectedPart = carParts.First(p => p.PartId == partId);
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

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            if (IsValidPurchaseInput(out string orderId, out decimal cash, out decimal balance))
            {
                ProcessPurchase(orderId, cash, balance);
            }
        }

        private bool IsValidPurchaseInput(out string orderId, out decimal cash, out decimal balance)
        {
            orderId = txtOrderId.Text;
            cash = 0;
            balance = 0;

            if (orderDetails.Count == 0 || !decimal.TryParse(txtCash.Text, out cash))
            {
                ShowWarningMessage("Invalid input. Please add products to the order and enter a valid cash amount.");
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

        private void ProcessPurchase(string orderId, decimal cash, decimal balance)
        {
            try
            {
                using (var connection = OpenDatabaseConnection())
                {
                    InsertOrder(connection, orderId, customerId, totalOrderPrice, cash, balance);

                    foreach (var detail in orderDetails)
                    {
                        InsertOrderDetail(connection, orderId, detail);
                        UpdateCarPartQuantity(connection, detail.PartId, detail.OrderQty);
                    }

                    ShowInformationMessage($"Purchase successful! Balance: {balance:C}");
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"An error occurred while processing the purchase: {ex.Message}");
            }
        }

        private void InsertOrder(MySqlConnection connection, string orderId, string customerId, decimal totalPrice, decimal cash, decimal balance)
        {
            string queryOrder = "INSERT INTO `order` (orderId, customerId, orderDate, total, cash, balance) VALUES (@orderId, @customerId, @orderDate, @total, @cash, @balance)";
            ExecuteNonQuery(connection, queryOrder, ("@orderId", orderId), ("@customerId", customerId), ("@orderDate", DateTime.Now), ("@total", totalPrice), ("@cash", cash), ("@balance", balance));
        }

        private void InsertOrderDetail(MySqlConnection connection, string orderId, OrderDetail detail)
        {
            string queryOrderDetail = "INSERT INTO orderdetail (orderDetailId, orderId, productId, quantity, unitPrice) VALUES (@orderDetailId, @orderId, @productId, @quantity, @unitPrice)";
            string orderDetailId = GenerateOrderDetailId();
            ExecuteNonQuery(connection, queryOrderDetail, ("@orderDetailId", orderDetailId), ("@orderId", orderId), ("@productId", detail.PartId), ("@quantity", detail.OrderQty), ("@unitPrice", detail.UnitPrice));
        }

        private void UpdateCarPartQuantity(MySqlConnection connection, string partId, int orderQty)
        {
            string queryUpdateCarPart = "UPDATE carpart SET qtyonhand = qtyonhand - @orderQty WHERE partId = @partId";
            ExecuteNonQuery(connection, queryUpdateCarPart, ("@orderQty", orderQty), ("@partId", partId));
        }

        private void ExecuteNonQuery(MySqlConnection connection, string query, params (string, object)[] parameters)
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

        private void ResetForm()
        {
            txtOrderId.Text = GenerateOrderId();
            cmbProductId.SelectedIndex = -1;
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
            DisableFields();
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

        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowInformationMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
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
        public string OrderDetailId { get; set; }
        public string PartId { get; set; }
        public string PartName { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public int OrderQty { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
