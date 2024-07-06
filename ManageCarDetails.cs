using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmManageCarDetails : Form
    {
        private string imagePath;

        public frmManageCarDetails()
        {
            InitializeComponent();
            LoadTableData();
        }

        private void uploadImage(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.ico)|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.ico";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    carImgBox.Image = new Bitmap(ofd.FileName);
                    imagePath = ofd.FileName;
                }
            }
        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            string carId = txtCarId.Text;
            string make = txtMake.Text;
            string model = txtModel.Text;
            string year = txtYear.Text;
            string dailyRate = txtDailyRate.Text;
            string description = txtDescription.Text;

            if (!IsValidInput(carId, make, model, year, dailyRate, description))
                return;

            bool isUpdate = btnCarSave.Text == "UPDATE";
            int count = SaveCarDetails(carId, make, model, year, dailyRate, description, imagePath, isUpdate);

            string message = isUpdate ? "updated" : "registered";

            if (count > 0)
            {
                MessageBox.Show($"Car successfully {message}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadTableData();
                if (isUpdate)
                {
                    txtCarId.Enabled = true;
                    btnCarSave.Text = "SAVE";
                }
            }
            else
            {
                MessageBox.Show($"Failed to {message} car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int SaveCarDetails(string carId, string make, string model, string year, string dailyRate, string description, string imagePath, bool isUpdate)
        {
            string query = isUpdate ?
                           "UPDATE car SET Make = @make, Model = @model, Year = @year, DailyRate = @dailyRate, Description = @description, ImagePath = @imagePath WHERE CarID = @cId" :
                           "INSERT INTO car (CarID, Make, Model, Year, DailyRate, Description, ImagePath) VALUES (@cId, @make, @model, @year, @dailyRate, @description, @imagePath)";
            return ExecuteNonQuery(query, new MySqlParameter[]
            {
                new MySqlParameter("@cId", carId),
                new MySqlParameter("@make", make),
                new MySqlParameter("@model", model),
                new MySqlParameter("@year", int.Parse(year)),
                new MySqlParameter("@dailyRate", decimal.Parse(dailyRate)),
                new MySqlParameter("@description", description),
                new MySqlParameter("@imagePath", imagePath)
            });
        }

        private bool IsValidInput(string carId, string make, string model, string year, string dailyRate, string description)
        {
            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(year) ||
                string.IsNullOrWhiteSpace(dailyRate) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(year, out _) || !decimal.TryParse(dailyRate, out _))
            {
                MessageBox.Show("Please enter valid Year and Daily Rate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            string carId = txtCarId.Text;

            if (string.IsNullOrWhiteSpace(carId))
            {
                MessageBox.Show("Please enter the Car ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this car?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int count = DeleteCar(carId);

                if (count > 0)
                {
                    MessageBox.Show("Car successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    txtCarId.Text = "";
                    LoadTableData();
                    btnCarSave.Text = "SAVE";
                }
                else
                {
                    MessageBox.Show("Failed to delete car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Car deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int DeleteCar(string carId)
        {
            string query = "DELETE FROM car WHERE CarID = @cId";
            return ExecuteNonQuery(query, new MySqlParameter[]
            {
                new MySqlParameter("@cId", carId)
            });
            
        }

        private void LoadTableData()
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT CarID, Make, Model, Year, DailyRate, Description, ImagePath FROM car";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            tblCarDetails.DataSource = dataTable;
                            tblCarDetails.Columns["ImagePath"].Visible = false;
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

        private void ClearFields()
        {
            txtCarId.Clear();
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtDailyRate.Clear();
            txtDescription.Clear();
            txtSearch.Clear();
            carImgBox.Image = null;
            imagePath = string.Empty;
        }

        private void carDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblCarDetails.Rows[e.RowIndex];

                txtCarId.Text = row.Cells["CarID"].Value?.ToString();
                txtMake.Text = row.Cells["Make"].Value?.ToString();
                txtModel.Text = row.Cells["Model"].Value?.ToString();
                txtYear.Text = row.Cells["Year"].Value?.ToString();
                txtDailyRate.Text = row.Cells["DailyRate"].Value?.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();

                txtCarId.Enabled = false;
                btnCarSave.Text = "UPDATE";

                string imgPath = row.Cells["ImagePath"].Value?.ToString();
                if (!string.IsNullOrEmpty(imgPath) && System.IO.File.Exists(imgPath))
                {
                    carImgBox.Image = new Bitmap(imgPath);
                    imagePath = imgPath;
                }
                else
                {
                    carImgBox.Image = null;
                    imagePath = string.Empty;
                }
            }
        }

        private void btnSearching_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            string query = "SELECT CarID, Make, Model, Year, DailyRate, Description, ImagePath FROM car WHERE CarID = @term OR Model = @term OR Year = @term";

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@term", searchTerm);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCarId.Text = reader["CarID"].ToString();
                                txtMake.Text = reader["Make"].ToString();
                                txtModel.Text = reader["Model"].ToString();
                                txtYear.Text = reader["Year"].ToString();
                                txtDailyRate.Text = reader["DailyRate"].ToString();
                                txtDescription.Text = reader["Description"].ToString();

                                txtCarId.Enabled = false;

                                string imgPath = reader["ImagePath"].ToString();
                                if (!string.IsNullOrEmpty(imgPath) && System.IO.File.Exists(imgPath))
                                {
                                    carImgBox.Image = new Bitmap(imgPath);
                                    imagePath = imgPath;
                                }
                                else
                                {
                                    carImgBox.Image = null;
                                    imagePath = string.Empty;
                                }

                                btnCarSave.Text = "UPDATE";
                            }
                            else
                            {
                                MessageBox.Show("Car not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private int ExecuteNonQuery(string query, MySqlParameter[] parameters)
        {
            int count = 0;

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddRange(parameters);
                        count = command.ExecuteNonQuery();
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return count;
        }
    }
}
