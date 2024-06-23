using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmManageCustomerDetails : Form
    {
        public frmManageCustomerDetails()
        {
            InitializeComponent();
            LoadTableData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Please enter a value to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT * FROM customer WHERE firstName LIKE @searchValue OR lastName LIKE @searchValue";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            tblCustomerDetails.DataSource = dataTable;
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

        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            string custId = txtCustomerId.Text;
            if (string.IsNullOrWhiteSpace(custId))
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "DELETE FROM customer WHERE customerId = @custId";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@custId", custId);
                        int count = command.ExecuteNonQuery();

                        if (count > 0)
                        {
                            MessageBox.Show("Customer successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadTableData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            string custId = txtCustomerId.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNo = txtPhoneNo.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confPassword = txtConPassword.Text;

            if (!IsValidInput(custId, firstName, lastName, phoneNo, email, password, confPassword))
                return;

            int count = UpdateCustomer(custId, firstName, lastName, phoneNo, email, password);

            if (count > 0)
            {
                MessageBox.Show($"Customer successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadTableData();
            }
            else
            {
                MessageBox.Show($"Failed to update customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int UpdateCustomer(string custId, string firstName, string lastName, string phoneNo, string email, string password)
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "UPDATE customer SET firstName = @firstName, lastName = @lastName, phone = @phoneNo, email = @Email, password = @password, confPassword = @password  WHERE customerId = @custId";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.AddWithValue("@custId", custId);
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@phoneNo", phoneNo);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@password", password);

                        return command.ExecuteNonQuery();
                    }
                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private bool IsValidInput(string custId, string firstName, string lastName, string phoneNo, string email, string password, string confPassword)
        {
            if (string.IsNullOrWhiteSpace(custId) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(phoneNo) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confPassword))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (password != confPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblCustomerDetails.Rows[e.RowIndex];

                //txtCustomerId.Text = row.Cells["cusId"].Value.ToString();
                txtCustomerId.Text = row.Cells["customerId"].Value.ToString();
                txtFirstName.Text = row.Cells["colFirstName"].Value.ToString();
                txtLastName.Text = row.Cells["colLastName"].Value.ToString();
                txtPhoneNo.Text = row.Cells["colPhone"].Value.ToString();
                txtEmail.Text = row.Cells["colEmail"].Value.ToString();
                txtPassword.Text = row.Cells["colPassword"].Value.ToString();
                txtConfPassword.Text = row.Cells["colPassword"].Value.ToString();

                txtCustomerId.Enabled = false;
            }
        }

        private void LoadTableData()
        {
            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "SELECT * FROM customer";
                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            tblCustomerDetails.DataSource = dataTable;
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
            txtCustomerId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNo.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfPassword.Clear();
        }
    }
}
