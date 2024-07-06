using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmSearchCars : Form
    {
        private TextBox txtSearchCarId;
        private TextBox txtSearchModel;
        private TextBox txtSearchYear;
        private Button btnSearchCars;

        public frmSearchCars()
        {
            InitializeComponent();
            InitializeSearchControls();
            SearchCarDetails();
        }

        private void InitializeSearchControls()
        {
            txtSearchCarId = new TextBox { Location = new Point(10, 10), Width = 100, PlaceholderText = "Car ID" };
            txtSearchModel = new TextBox { Location = new Point(120, 10), Width = 100, PlaceholderText = "Model" };
            txtSearchYear = new TextBox { Location = new Point(230, 10), Width = 100, PlaceholderText = "Year" };
            btnSearchCars = new Button { Location = new Point(340, 10), Width = 75, Text = "Search" };

            btnSearchCars.Click += new EventHandler(searchCars_Click);

            this.Controls.Add(txtSearchCarId);
            this.Controls.Add(txtSearchModel);
            this.Controls.Add(txtSearchYear);
            this.Controls.Add(btnSearchCars);
        }

        private void SearchCarDetails(string carId = null, string model = null, string year = null)
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT * FROM car WHERE 1=1";
                    if (!string.IsNullOrEmpty(carId))
                    {
                        query += " AND CarId = @CarId";
                    }
                    if (!string.IsNullOrEmpty(model))
                    {
                        query += " AND Model LIKE @Model";
                    }
                    if (!string.IsNullOrEmpty(year))
                    {
                        query += " AND Year = @Year";
                    }

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        if (!string.IsNullOrEmpty(carId))
                        {
                            command.Parameters.AddWithValue("@CarId", carId);
                        }
                        if (!string.IsNullOrEmpty(model))
                        {
                            command.Parameters.AddWithValue("@Model", "%" + model + "%");
                        }
                        if (!string.IsNullOrEmpty(year))
                        {
                            command.Parameters.AddWithValue("@Year", year);
                        }

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            pnlContainer.Controls.Clear();
                            int xPos = 10;
                            int yPos = 40;
                            int columnCount = 0;

                            while (reader.Read())
                            {
                                Panel pnlOrder = new Panel
                                {
                                    Size = new Size(200, 250),
                                    Location = new Point(xPos, yPos),
                                    BorderStyle = BorderStyle.FixedSingle
                                };

                                Label lblCarDetails = new Label
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
                                pnlOrder.Controls.Add(lblCarDetails);

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

                                pnlContainer.Controls.Add(pnlOrder);

                                xPos += 214;
                                columnCount++;

                                if (columnCount == 3)
                                {
                                    columnCount = 0;
                                    xPos = 10;
                                    yPos += 260;
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

        private void searchCars_Click(object sender, EventArgs e)
        {
            string carId = txtSearchCarId.Text.Trim();
            string model = txtSearchModel.Text.Trim();
            string year = txtSearchYear.Text.Trim();

            SearchCarDetails(carId, model, year);

            txtSearchCarId.Clear();
            txtSearchModel.Clear();
            txtSearchYear.Clear();
        }
    }
}
