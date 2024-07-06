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
    public partial class frmCustomerCarRentalHistory : Form
    {
        public frmCustomerCarRentalHistory(string username, string custId)
        {
            InitializeComponent();
            LoadRentalDetails(custId); 
        }

        private void LoadRentalDetails(string custId)
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT od.OrderID, od.RentalDetailID, od.CarID, od.RentalStartDate, od.RentalEndDate, od.TotalCost, od.TotalDays , c.ImagePath, od.status FROM rentaldetail od INNER JOIN `order` o ON o.OrderID=od.OrderID INNER JOIN car c ON c.CarID=od.CarID WHERE od.CustomerID = @customerId";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@customerId", custId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int xPos = 10;
                            int yPos = 10;
                            int columnCount = 0;

                            while (reader.Read())
                            {
                                string rentalDetailId = reader["RentalDetailID"].ToString();
                                string carId = reader["CarID"].ToString();
                                string availability = reader["status"].ToString();

                                Panel pnlOrder = new Panel
                                {
                                    Size = new Size(200, 280),
                                    Location = new Point(xPos, yPos),
                                    BorderStyle = BorderStyle.FixedSingle
                                };

                                Label lblRentalDetails = new Label
                                {
                                    Text = $"Rental ID: {rentalDetailId}\n" +
                                           $"Car ID: {carId}\n" +
                                           $"Rental Start Date: {reader["RentalStartDate"]}\n" +
                                           $"Rental End Date: {reader["RentalEndDate"]}\n" +
                                           $"Total Days: {reader["TotalDays"]}\n" +
                                           $"Total Cost: {reader["TotalCost"]}",
                                    Location = new Point(10, 10),
                                    AutoSize = true
                                };
                                pnlOrder.Controls.Add(lblRentalDetails);

                                PictureBox imgOrderBox = new PictureBox
                                {
                                    Size = new Size(180, 140),
                                    Location = new Point(10, 100),
                                    BorderStyle = BorderStyle.FixedSingle,
                                    SizeMode = PictureBoxSizeMode.StretchImage
                                };
                                pnlOrder.Controls.Add(imgOrderBox);

                                string imgPath = reader["ImagePath"].ToString();
                                if (!string.IsNullOrEmpty(imgPath) && System.IO.File.Exists(imgPath))
                                {
                                    imgOrderBox.Image = new Bitmap(imgPath);
                                }
                                else
                                {
                                    imgOrderBox.Image = null;
                                }

                                Button btnReturnCar = new Button
                                {
                                    Size = new Size(180, 30),
                                    Location = new Point(10, 250),
                                    Text = "RETURN CAR",
                                    BackColor = Color.Orange,
                                };

                                if (availability == "Completed")
                                {
                                    btnReturnCar.Enabled = false;
                                    btnReturnCar.Text = "RETURN OK";
                                    btnReturnCar.BackColor = Color.Gray;
                                }
                                else
                                {
                                    btnReturnCar.Enabled = true;
                                }

                                btnReturnCar.Click += (sender, e) => ReturnCar_Click(sender, e, rentalDetailId, carId);
                                pnlOrder.Controls.Add(btnReturnCar);
                                pnlOrderContainer.Controls.Add(pnlOrder);

                                xPos += 214;
                                columnCount++;

                                if (columnCount == 3)
                                {
                                    columnCount = 0;
                                    xPos = 10;
                                    yPos += 290;
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

        private void ReturnCar_Click(object sender, EventArgs e, string rentalDetailId, string carId)
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string updateCarQuery = "UPDATE car SET availability = 'Available' WHERE carId = @carId";
                    using (MySqlCommand updateCarCmd = new MySqlCommand(updateCarQuery, db.GetConnection()))
                    {
                        updateCarCmd.Parameters.AddWithValue("@carId", carId);
                        updateCarCmd.ExecuteNonQuery();
                    }

                    string updateRentalQuery = "UPDATE rentaldetail SET status = 'Completed' WHERE rentalDetailId = @rentalDetailId";
                    using (MySqlCommand updateCarCmd = new MySqlCommand(updateRentalQuery, db.GetConnection()))
                    {
                        updateCarCmd.Parameters.AddWithValue("@rentalDetailId", rentalDetailId);
                        updateCarCmd.ExecuteNonQuery();
                    }

                    db.CloseConnection();
                    MessageBox.Show($"Returning car for Rental ID: {rentalDetailId}", "Return Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving rental details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
