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
            string searchValue = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Please enter a value to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                using (var command = new MySqlCommand("SELECT * FROM customer WHERE firstName LIKE @searchValue OR lastName LIKE @searchValue", db.GetConnection()))
                {
                    db.OpenConnection();
                    command.Parameters.AddWithValue("@searchValue", $"%{searchValue}%");

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtCustomerId.Text = reader["customerId"].ToString();
                            txtFirstName.Text = reader["firstName"].ToString();
                            txtLastName.Text = reader["lastName"].ToString();
                            txtPhoneNo.Text = reader["phone"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtPassword.Text = reader["password"].ToString();
                            txtConfPassword.Text = reader["password"].ToString();
                            txtSearch.Text = "";
                        }
                        else
                        {
                            ClearFields(); 
                            MessageBox.Show("No matching customer found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDeleteCust_Click(object sender, EventArgs e)
        {
            string custId = txtCustomerId.Text.Trim();
            if (string.IsNullOrWhiteSpace(custId))
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int count = DeleteCustomer(custId);
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
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Customer deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int DeleteCustomer(string custId)
        {
            using (var db = new CarManagementSystem.DBConnection.DBConnection())
            using (var command = new MySqlCommand("DELETE FROM customer WHERE customerId = @custId", db.GetConnection()))
            {
                db.OpenConnection();
                command.Parameters.AddWithValue("@custId", custId);
                return command.ExecuteNonQuery();
            }
        }

        private void btnSaveCust_Click(object sender, EventArgs e)
        {
            string custId = txtCustomerId.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phoneNo = txtPhoneNo.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confPassword = txtConfPassword.Text;

            if (!IsValidInput(custId, firstName, lastName, phoneNo, email, password, confPassword))
                return;

            DialogResult result = MessageBox.Show("Are you sure you want to update this customer?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int count = UpdateCustomer(custId, firstName, lastName, phoneNo, email, password);
                    if (count > 0)
                    {
                        MessageBox.Show("Customer successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadTableData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Customer update canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int UpdateCustomer(string custId, string firstName, string lastName, string phoneNo, string email, string password)
        {
            using (var db = new CarManagementSystem.DBConnection.DBConnection())
            using (var command = new MySqlCommand("UPDATE customer SET firstName = @firstName, lastName = @lastName, phone = @phoneNo, email = @Email, password = @password WHERE customerId = @custId", db.GetConnection()))
            {
                db.OpenConnection();
                command.Parameters.AddWithValue("@custId", custId);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@phoneNo", phoneNo);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@password", password);
                return command.ExecuteNonQuery();
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

        private void tblCustomerDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tblCustomerDetails.Rows[e.RowIndex];
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
                using (var command = new MySqlCommand("SELECT * FROM customer", db.GetConnection()))
                {
                    db.OpenConnection();
                    using (var dataAdapter = new MySqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        tblCustomerDetails.DataSource = dataTable;
                        SetColumnOrder();
                    }
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

        private void SetColumnOrder()
        {
            tblCustomerDetails.Columns["customerId"].DisplayIndex = 0;
            tblCustomerDetails.Columns["colFirstName"].DisplayIndex = 1;
            tblCustomerDetails.Columns["colLastName"].DisplayIndex = 2;
            tblCustomerDetails.Columns["colPhone"].DisplayIndex = 3;
            tblCustomerDetails.Columns["colEmail"].DisplayIndex = 4;
            tblCustomerDetails.Columns["colPassword"].DisplayIndex = 5;
        }
    }
}
