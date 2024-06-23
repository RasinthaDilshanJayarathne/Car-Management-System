using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarManagementSystem
{
    public partial class frmManageCarPartsDetails : Form
    {
        private string imagePath;

        public frmManageCarPartsDetails()
        {
            InitializeComponent();
            LoadTableData();
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.ico)|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.ico";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    carPartImgBox.Image = new Bitmap(ofd.FileName);
                    imagePath = ofd.FileName;
                }
            }
        }

        private void btnSaveCarPart_Click(object sender, EventArgs e)
        {
            string partId = txtPartId.Text;
            string name = txtPartName.Text;
            string model = txtModel.Text;
            string price = txtPrice.Text;
            string qtyOnHand = txtQtyOnHand.Text;
            string description = txtDescription.Text;

            if (!IsValidInput(partId, name, model, price, qtyOnHand, description))
                return;


            int count = btnCarPartSave.Text == "SAVE" ?
                        InsertOrUpdateCarPart(partId, name, model, price, qtyOnHand, description, imagePath, isUpdate: false) :
                        InsertOrUpdateCarPart(partId, name, model, price, qtyOnHand, description, imagePath, isUpdate: true);

            string message = btnCarPartSave.Text == "SAVE" ? "registered" : "updated";

            if (count > 0)
            {
                MessageBox.Show($"Car successfully {message}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadTableData();
                if (btnCarPartSave.Text == "UPDATE")
                {
                    txtPartId.Enabled = true;
                    btnCarPartSave.Text = "SAVE";
                }
            }
            else
            {
                MessageBox.Show($"Failed to {message} car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int InsertOrUpdateCarPart(string partId, string name, string model, string price, string qtyOnHand, string description, string imagePath, bool isUpdate)
        {
            int count = 0;
            string query = isUpdate ?
                           "UPDATE carpart SET PartName = @name, Model = @model, Price = @price, QtyOnHand = @qtyOnHand, Description = @description, ImagePath = @imagePath WHERE PartID = @partId" :
                           "INSERT INTO carpart (PartID, PartName, Model, Price, QtyOnHand, Description, ImagePath) VALUES (@partId, @name, @model, @price, @qtyOnHand, @description, @imagePath)";

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@partId", partId);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@model", model);
                        command.Parameters.AddWithValue("@price", decimal.Parse(price));
                        command.Parameters.AddWithValue("@qtyOnHand", int.Parse(qtyOnHand));
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

        private void LoadTableData()
        {
            try
            {
                using (var db = new DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT PartID, PartName, Model, Price, QtyOnHand, Description, ImagePath FROM carpart";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            tblCarPartDetails.DataSource = dataTable;
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
            txtPartId.Clear();
            txtPartName.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            txtQtyOnHand.Clear();
            txtDescription.Clear();
            txtSearch.Clear();
            carPartImgBox.Image = null;
            imagePath = string.Empty;
        }

        private bool IsValidInput(string partId, string name, string model, string price, string qtyOnHand, string description)
        {
            if (string.IsNullOrEmpty(partId))
            {
                MessageBox.Show("Part ID cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Model cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!decimal.TryParse(price, out _))
            {
                MessageBox.Show("Price must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(qtyOnHand, out _))
            {
                MessageBox.Show("Quantity on Hand must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnDeleteCarPart_Click(object sender, EventArgs e)
        {
            string partId = txtPartId.Text.Trim();

            if (string.IsNullOrWhiteSpace(partId))
            {
                MessageBox.Show("Please enter the Car Part ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int count = DeleteCarPart(partId);

            if (count > 0)
            {
                MessageBox.Show("Car Part successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadTableData();
            }
            else
            {
                MessageBox.Show("Failed to delete car part.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int DeleteCarPart(string partId)
        {
            int count = 0;
            try
            {
                using (var db = new DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "DELETE FROM carpart WHERE PartID = @partId";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@partId", partId);
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

        private void btnSearching_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            try
            {
                using (var db = new DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT PartId, PartName, Model, Price, QtyOnHand, Description, ImagePath FROM carpart WHERE PartId = @term OR Model = @term OR PartName = @term";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@term", searchTerm);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtPartId.Text = reader["PartId"].ToString();
                                txtPartName.Text = reader["PartName"].ToString();
                                txtModel.Text = reader["Model"].ToString();
                                txtPrice.Text = reader["Price"].ToString();
                                txtQtyOnHand.Text = reader["QtyOnHand"].ToString();
                                txtDescription.Text = reader["Description"].ToString();

                                txtPartId.Enabled = false;
                                btnCarPartSave.Text = "UPDATE";

                                string imgPath = reader["ImagePath"].ToString();
                                if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
                                {
                                    carPartImgBox.Image = new Bitmap(imgPath);
                                    imagePath = imgPath;
                                }
                                else
                                {
                                    carPartImgBox.Image = null;
                                    imagePath = string.Empty;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Car Part not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
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

        private void carPartDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblCarPartDetails.Rows[e.RowIndex];

                txtPartId.Text = row.Cells["colId"].Value.ToString();
                txtPartName.Text = row.Cells["colPartName"].Value.ToString();
                txtModel.Text = row.Cells["colModel"].Value.ToString();
                txtPrice.Text = row.Cells["colYear"].Value.ToString();
                txtQtyOnHand.Text = row.Cells["colQtyOnHand"].Value.ToString();
                txtDescription.Text = row.Cells["colDescription"].Value.ToString();

                txtPartId.Enabled = false;
                btnCarPartSave.Text = "UPDATE";

                string imgPath = row.Cells["ImagePath"].Value.ToString();
                if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
                {
                    carPartImgBox.Image = new Bitmap(imgPath);
                    imagePath = imgPath;
                }
                else
                {
                    carPartImgBox.Image = null;
                    imagePath = string.Empty;
                }
            }
        }

    }
}
