using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

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
            if (!IsValidInput(out var carPart)) return;

            var message = btnCarPartSave.Text == "SAVE" ? "registered" : "updated";
            var isUpdate = btnCarPartSave.Text != "SAVE";
            var count = InsertOrUpdateCarPart(carPart, isUpdate);

            if (count > 0)
            {
                MessageBox.Show($"Car part successfully {message}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadTableData();
                if (isUpdate)
                {
                    txtPartId.Enabled = true;
                    btnCarPartSave.Text = "SAVE";
                }
            }
            else
            {
                MessageBox.Show($"Failed to {message} car part.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private (string PartId, string Name, string Model, decimal Price, int QtyOnHand, string Description, string ImagePath) GetCarPartInput()
        {
            return (
                txtPartId.Text,
                txtPartName.Text,
                txtModel.Text,
                decimal.Parse(txtPrice.Text),
                int.Parse(txtQtyOnHand.Text),
                txtDescription.Text,
                imagePath
            );
        }

        private bool IsValidInput(out (string PartId, string Name, string Model, decimal Price, int QtyOnHand, string Description, string ImagePath) carPart)
        {
            carPart = GetCarPartInput();
            if (string.IsNullOrWhiteSpace(carPart.PartId) ||
                string.IsNullOrWhiteSpace(carPart.Name) ||
                string.IsNullOrWhiteSpace(carPart.Model) ||
                string.IsNullOrWhiteSpace(carPart.Description))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out carPart.Price) ||
                !int.TryParse(txtQtyOnHand.Text, out carPart.QtyOnHand))
            {
                MessageBox.Show("Please enter valid numbers for price and quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private int InsertOrUpdateCarPart((string PartId, string Name, string Model, decimal Price, int QtyOnHand, string Description, string ImagePath) carPart, bool isUpdate)
        {
            var query = isUpdate ?
                "UPDATE carpart SET PartName = @name, Model = @model, Price = @price, QtyOnHand = @qtyOnHand, Description = @description, ImagePath = @imagePath WHERE PartID = @partId" :
                "INSERT INTO carpart (PartID, PartName, Model, Price, QtyOnHand, Description, ImagePath) VALUES (@partId, @name, @model, @price, @qtyOnHand, @description, @imagePath)";

            return ExecuteNonQuery(query, new MySqlParameter[]
            {
                new MySqlParameter("@partId", carPart.PartId),
                new MySqlParameter("@name", carPart.Name),
                new MySqlParameter("@model", carPart.Model),
                new MySqlParameter("@price", carPart.Price),
                new MySqlParameter("@qtyOnHand", carPart.QtyOnHand),
                new MySqlParameter("@description", carPart.Description),
                new MySqlParameter("@imagePath", carPart.ImagePath)
            });
        }

        private void LoadTableData()
        {
            var query = "SELECT PartID, PartName, Model, Price, QtyOnHand, Description, ImagePath FROM carpart";
            var dataTable = ExecuteQuery(query);
            if (dataTable != null)
            {
                tblCarPartDetails.DataSource = dataTable;
                tblCarPartDetails.Columns["ImagePath"].Visible = false;
            }
        }

        private void ClearFields()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }

            carPartImgBox.Image = null;
            imagePath = string.Empty;
            txtPartId.Text = "";
            txtPartName.Text = "";
            txtModel.Text = "";
            txtPrice.Text = "";
            txtQtyOnHand.Text = "";
            txtDescription.Text= "";
        }

        private void btnDeleteCarPart_Click(object sender, EventArgs e)
        {
            var partId = txtPartId.Text.Trim();

            if (string.IsNullOrWhiteSpace(partId))
            {
                MessageBox.Show("Please enter the Car Part ID to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this car part?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            var count = DeleteCarPart(partId);
            if (count > 0)
            {
                MessageBox.Show("Car Part successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                btnCarPartSave.Text = "SAVE";
                LoadTableData();
            }
            else
            {
                MessageBox.Show("Failed to delete car part.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int DeleteCarPart(string partId)
        {
            var query = "DELETE FROM carpart WHERE PartID = @partId";
            return ExecuteNonQuery(query, new MySqlParameter[]
            {
                new MySqlParameter("@partId", partId)
            });
        }

        private void btnSearching_Click(object sender, EventArgs e)
        {
            var searchTerm = txtSearch.Text.Trim();
            var query = "SELECT PartId, PartName, Model, Price, QtyOnHand, Description, ImagePath FROM carpart WHERE PartId = @term OR Model = @term OR PartName = @term";
            var parameters = new MySqlParameter[] { new MySqlParameter("@term", searchTerm) };
            var dataTable = ExecuteQuery(query, parameters);
            if (dataTable?.Rows.Count > 0)
            {
                var row = dataTable.Rows[0];
                txtPartId.Text = row["PartId"].ToString();
                txtPartName.Text = row["PartName"].ToString();
                txtModel.Text = row["Model"].ToString();
                txtPrice.Text = row["Price"].ToString();
                txtQtyOnHand.Text = row["QtyOnHand"].ToString();
                txtDescription.Text = row["Description"].ToString();
                txtPartId.Enabled = false;
                btnCarPartSave.Text = "UPDATE";
                LoadImage(row["ImagePath"].ToString());
            }
            else
            {
                MessageBox.Show("Car Part not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void LoadImage(string imgPath)
        {
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

        private void tblCarPartDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = tblCarPartDetails.Rows[e.RowIndex];
            txtPartId.Text = row.Cells["PartID"].Value.ToString();
            txtPartName.Text = row.Cells["PartName"].Value.ToString();
            txtModel.Text = row.Cells["Model"].Value.ToString();
            txtPrice.Text = row.Cells["Price"].Value.ToString();
            txtQtyOnHand.Text = row.Cells["QtyOnHand"].Value.ToString();
            txtDescription.Text = row.Cells["Description"].Value.ToString();
            txtPartId.Enabled = false;
            btnCarPartSave.Text = "UPDATE";
            LoadImage(row.Cells["ImagePath"].Value.ToString());
        }

        private DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            try
            {
                using (var db = new DBConnection.DBConnection())
                using (var command = new MySqlCommand(query, db.GetConnection()))
                {
                    db.OpenConnection();
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private int ExecuteNonQuery(string query, MySqlParameter[] parameters)
        {
            try
            {
                using (var db = new DBConnection.DBConnection())
                using (var command = new MySqlCommand(query, db.GetConnection()))
                {
                    db.OpenConnection();
                    command.Parameters.AddRange(parameters);
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
