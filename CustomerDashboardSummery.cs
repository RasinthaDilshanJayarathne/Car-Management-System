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
            SearchCarDetails();
            SearchCarPartDetails();
            //currentId = custId;
        }

        private void SearchCarDetails()
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT * from car";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
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
                                    Text = $"Car ID: {reader["CarId"]}\n" +
                                           $"Make: {reader["Make"]}\n" +
                                           $"Model: {reader["Model"]}\n" +
                                           $"Year: {reader["Year"]}\n" +
                                           $"Daily Rate: {reader["DailyRate"]}\n" +
                                           $"Availability: {reader["Availability"]}",
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
                                pnlContainer.Controls.Add(pnlOrder);

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

        private void SearchCarPartDetails()
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT * from carpart";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
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
                                    Text = $"Part ID: {reader["PartId"]}\n" +
                                           $"Part Name: {reader["PartName"]}\n" +
                                           $"Model: {reader["Model"]}\n" +
                                           $"Price: {reader["Price"]}\n" +
                                           $"Available Qty: {reader["QtyOnHand"]}\n",
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
                                pnlContainer.Controls.Add(pnlOrder);

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