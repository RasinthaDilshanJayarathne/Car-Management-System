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
            string price = txtPrice.Text;
            string description = txtDescription.Text;

            if (!IsValidInput(carId, make, model, year, price, description))
                return;

            int count = btnCarSave.Text == "SAVE" ?
                        InsertOrUpdateCar(carId, make, model, year, price, description, imagePath, isUpdate: false) :
                        InsertOrUpdateCar(carId, make, model, year, price, description, imagePath, isUpdate: true);

            string message = btnCarSave.Text == "SAVE" ? "registered" : "updated";

            if (count > 0)
            {
                MessageBox.Show($"Car successfully {message}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadTableData();
                if (btnCarSave.Text == "UPDATE")
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

        private int InsertOrUpdateCar(string carId, string make, string model, string year, string price, string description, string imagePath, bool isUpdate)
        {
            int count = 0;
            string query = isUpdate ?
                           "UPDATE car SET Make = @make, Model = @model, Year = @year, Price = @price, Description = @description, ImagePath = @imagePath WHERE CarID = @cId" :
                           "INSERT INTO car (CarID, Make, Model, Year, Price, Description, ImagePath) VALUES (@cId, @make, @model, @year, @price, @description, @imagePath)";

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@cId", carId);
                        command.Parameters.AddWithValue("@make", make);
                        command.Parameters.AddWithValue("@model", model);
                        command.Parameters.AddWithValue("@year", int.Parse(year));
                        command.Parameters.AddWithValue("@price", decimal.Parse(price));
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@imagePath", imagePath);

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

        private bool IsValidInput(string carId, string make, string model, string year, string price, string description)
        {
            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(year) ||
                string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(year, out _) || !decimal.TryParse(price, out _))
            {
                MessageBox.Show("Please enter valid Year and Price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            int count = DeleteCar(carId);

            if (count > 0)
            {
                MessageBox.Show("Car successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadTableData();
            }
            else
            {
                MessageBox.Show("Failed to delete car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int DeleteCar(string carId)
        {
            int count = 0;

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "DELETE FROM car WHERE CarID = @cId";

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@cId", carId);
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

        private void LoadTableData()
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT CarID, Make, Model, Year, Price, Description, ImagePath FROM car";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            tblCarDetails.DataSource = dataTable;
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
            txtPrice.Clear();
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

                txtCarId.Text = row.Cells["colId"].Value.ToString();
                txtMake.Text = row.Cells["colMake"].Value.ToString();
                txtModel.Text = row.Cells["colModel"].Value.ToString();
                txtYear.Text = row.Cells["colYear"].Value.ToString();
                txtPrice.Text = row.Cells["colPrice"].Value.ToString();
                txtDescription.Text = row.Cells["colDescription"].Value.ToString();

                txtCarId.Enabled = false;
                btnCarSave.Text = "UPDATE";

                string imgPath = row.Cells["ImagePath"].Value.ToString();
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

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT CarID, Make, Model, Year, Price, Description, ImagePath FROM car WHERE CarID = @term OR Model = @term OR Year = @term";
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
                                txtPrice.Text = reader["Price"].ToString();
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

    }
}
