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
    public partial class frmCustomerOrderHistory : Form
    {
        public frmCustomerOrderHistory(string username, string custId)
        {
            InitializeComponent();
            LoadOrderDetails(custId);
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
