using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmSearchCarParts : Form
    {
        // Add TextBox controls for search criteria
        private TextBox txtSearchPartId;
        private TextBox txtSearchPartName;
        private TextBox txtSearchModel;
        private Button btnSearchCarParts;

        public frmSearchCarParts()
        {
            InitializeComponent();
            InitializeSearchControls(); 
            SearchCarPartDetails();
        }

        private void InitializeSearchControls()
        {
            // Initialize and add search TextBox controls
            txtSearchPartId = new TextBox { Location = new Point(10, 10), Width = 100, PlaceholderText = "Part ID" };
            txtSearchPartName = new TextBox { Location = new Point(120, 10), Width = 100, PlaceholderText = "Part Name" };
            txtSearchModel = new TextBox { Location = new Point(230, 10), Width = 100, PlaceholderText = "Model" };
            btnSearchCarParts = new Button { Location = new Point(340, 10), Width = 75, Text = "Search" };

            btnSearchCarParts.Click += new EventHandler(searchCarParts_Click);

            this.Controls.Add(txtSearchPartId);
            this.Controls.Add(txtSearchPartName);
            this.Controls.Add(txtSearchModel);
            this.Controls.Add(btnSearchCarParts);
        }

        private void SearchCarPartDetails(string partId = null, string partName = null, string model = null)
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT * FROM carpart WHERE 1=1";
                    if (!string.IsNullOrEmpty(partId))
                    {
                        query += " AND PartId = @PartId";
                    }
                    if (!string.IsNullOrEmpty(partName))
                    {
                        query += " AND PartName LIKE @PartName";
                    }
                    if (!string.IsNullOrEmpty(model))
                    {
                        query += " AND Model LIKE @Model";
                    }

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        if (!string.IsNullOrEmpty(partId))
                        {
                            command.Parameters.AddWithValue("@PartId", partId);
                        }
                        if (!string.IsNullOrEmpty(partName))
                        {
                            command.Parameters.AddWithValue("@PartName", "%" + partName + "%");
                        }
                        if (!string.IsNullOrEmpty(model))
                        {
                            command.Parameters.AddWithValue("@Model", "%" + model + "%");
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

                                Label lblPartDetails = new Label
                                {
                                    Text = $"Part ID: {reader["PartId"]}\n" +
                                           $"Part Name: {reader["PartName"]}\n" +
                                           $"Model: {reader["Model"]}\n" +
                                           $"Price: {reader["Price"]}\n" +
                                           $"Available Qty: {reader["QtyOnHand"]}\n",
                                    Location = new Point(10, 10),
                                    AutoSize = true
                                };
                                pnlOrder.Controls.Add(lblPartDetails);

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

        private void searchCarParts_Click(object sender, EventArgs e)
        {
            string partId = txtSearchPartId.Text.Trim();
            string partName = txtSearchPartName.Text.Trim();
            string model = txtSearchModel.Text.Trim();

            SearchCarPartDetails(partId, partName, model);

            txtSearchPartId.Clear();
            txtSearchPartName.Clear();
            txtSearchModel.Clear();
        }
    }
}
