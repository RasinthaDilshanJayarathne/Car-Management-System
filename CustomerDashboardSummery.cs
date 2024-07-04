using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class CustomerDashboardSummery : Form
    {
        private string currentUsername;
        private string currentId;
        public CustomerDashboardSummery(string username,string custId)
        {
            InitializeComponent();
            LoadRentalDetails(custId);
            LoadOrderDetails(custId);
            //currentId = custId;
        }

        private void LoadRentalDetails(string custId)
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT od.OrderID, od.RentalDetailID, od.CarID, od.RentalStartDate, od.RentalEndDate, od.TotalCost, od.TotalDays , c.ImagePath FROM rentaldetail od INNER JOIN `order` o ON o.OrderID=od.OrderID INNER JOIN car c ON c.CarID=od.CarID WHERE od.CustomerID = @customerId";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@customerId", custId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                                int xPos = 10; // Initial X position for the panels
                                int yPos = 10; // Initial Y position for the panels
                                int columnCount = 0; // Track the current column

                                while (reader.Read())
                                {
                                    // Create a new panel for each rental detail
                                    Panel pnlOrder = new Panel
                                    {
                                        Size = new Size(200, 250),
                                        Location = new Point(xPos, yPos),
                                        BorderStyle = BorderStyle.FixedSingle
                                    };

                                    // Create a label to display rental details
                                    Label lblRentalDetails = new Label
                                    {
                                        Text = $"Rental ID: {reader["RentalDetailID"]}\n" +
                                               $"Car ID: {reader["CarID"]}\n" +
                                               $"Start Date: {reader["RentalStartDate"]}\n" +
                                               $"End Date: {reader["RentalEndDate"]}\n" +
                                               $"Total Days: {reader["TotalDays"]}\n" +
                                               $"Total Cost: {reader["TotalCost"]}",
                                        Location = new Point(10, 10),
                                        AutoSize = true
                                    };
                                    pnlOrder.Controls.Add(lblRentalDetails);

                                    // Create a picture box for the car image
                                    PictureBox imgOrderBox = new PictureBox
                                    {
                                        Size = new Size(180, 140),
                                        Location = new Point(10, 100),
                                        BorderStyle = BorderStyle.FixedSingle,
                                        SizeMode = PictureBoxSizeMode.StretchImage
                                    };
                                    pnlOrder.Controls.Add(imgOrderBox);

                                    // Load the car image
                                    string imgPath = reader["ImagePath"].ToString();
                                    if (!string.IsNullOrEmpty(imgPath) && System.IO.File.Exists(imgPath))
                                    {
                                        imgOrderBox.Image = new Bitmap(imgPath);
                                    }
                                    else
                                    {
                                        imgOrderBox.Image = null;
                                    }

                                    // Add the panel to the pnlOrderContainer
                                    pnlOrderContainer.Controls.Add(pnlOrder);

                                    // Update the X position for the next panel
                                    xPos += 214; // Adjust the value based on your panel width and desired spacing
                                    columnCount++;

                                    // Move to the next row after every third panel
                                    if (columnCount == 3)
                                    {
                                        columnCount = 0;
                                        xPos = 10; // Reset X position for the next row
                                        yPos += 260; // Adjust the value based on your panel height and desired spacing
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

        private void LoadOrderDetails(string custId)
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT rd.OrderID, o.OrderDate, rd.ProductID, rd.UnitPrice, o.Total, rd.Quantity, c.ImagePath FROM orderdetail rd INNER JOIN `order` o ON o.OrderID = rd.OrderID INNER JOIN carpart c ON c.PartID = rd.ProductID WHERE o.CustomerID = @customerId";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@customerId", custId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int xPos = 10; // Initial X position for the panels
                            int yPos = 10; // Initial Y position for the panels
                            int columnCount = 0; // Track the current column

                            while (reader.Read())
                            {
                                // Create a new panel for each rental detail
                                Panel pnlOrder = new Panel
                                {
                                    Size = new Size(200, 250),
                                    Location = new Point(xPos, yPos),
                                    BorderStyle = BorderStyle.FixedSingle
                                };

                                // Create a label to display rental details
                                Label lblRentalDetails = new Label
                                {
                                    Text = $"Order ID: {reader["OrderID"]}\n" +
                                           $"Order Date: {reader["OrderDate"]}\n" +
                                           $"Product ID: {reader["ProductID"]}\n" +
                                           $"Unit Price: {reader["UnitPrice"]}\n" +
                                           $"Total: {reader["Total"]}\n" +
                                           $"Order Quantity: {reader["Quantity"]}",
                                    Location = new Point(10, 10),
                                    AutoSize = true
                                };
                                pnlOrder.Controls.Add(lblRentalDetails);

                                // Create a picture box for the car image
                                PictureBox imgOrderBox = new PictureBox
                                {
                                    Size = new Size(180, 140),
                                    Location = new Point(10, 100),
                                    BorderStyle = BorderStyle.FixedSingle,
                                    SizeMode = PictureBoxSizeMode.StretchImage
                                };
                                pnlOrder.Controls.Add(imgOrderBox);

                                // Load the car image
                                string imgPath = reader["ImagePath"].ToString();
                                if (!string.IsNullOrEmpty(imgPath) && System.IO.File.Exists(imgPath))
                                {
                                    imgOrderBox.Image = new Bitmap(imgPath);
                                }
                                else
                                {
                                    imgOrderBox.Image = null;
                                }

                                // Add the panel to the pnlOrderContainer
                                pnlOrderContainer.Controls.Add(pnlOrder);

                                // Update the X position for the next panel
                                xPos += 214; // Adjust the value based on your panel width and desired spacing
                                columnCount++;

                                // Move to the next row after every third panel
                                if (columnCount == 3)
                                {
                                    columnCount = 0;
                                    xPos = 10; // Reset X position for the next row
                                    yPos += 260; // Adjust the value based on your panel height and desired spacing
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
}