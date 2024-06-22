using CarManagementSystem.DBConnection;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void signUp(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string contactNumber = txtPhoneNo.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confPassword = txtConPassword.Text;

            int count = InsertCustomer(firstName, lastName, contactNumber, email, password, confPassword);

            if (count > 0)
            {
                MessageBox.Show("Customer successfully registered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Example of navigating to another form (assuming 'Login' is another form)
                Login login = new Login();
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show("Failed to register customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int InsertCustomer(string firstName, string lastName, string contactNumber, string email, string password, string confPassword)
        {
            int count = 0;

            // Validate input
            if (!IsValidInput(firstName, lastName, contactNumber, email, password, confPassword))
            {
                return count; // Validation failed, return 0
            }

            try
            {
                using (CarManagementSystem.DBConnection.DBConnection db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    string query = "INSERT INTO customer (FirstName, LastName, Phone, Email, Password, ConfPassword) VALUES (@fName, @lName, @contact, @Email, @pswrd, @confPswrd)";

                    using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
                    {
                        command.Parameters.Add("@fName", MySqlDbType.VarChar).Value = firstName;
                        command.Parameters.Add("@lName", MySqlDbType.VarChar).Value = lastName;
                        command.Parameters.Add("@contact", MySqlDbType.VarChar).Value = contactNumber;
                        command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = email;
                        command.Parameters.Add("@pswrd", MySqlDbType.VarChar).Value = password;
                        command.Parameters.Add("@confPswrd", MySqlDbType.VarChar).Value = confPassword;

                        count = command.ExecuteNonQuery();
                    }
                }

                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return count; // Return 0 or handle the error as appropriate for your application
            }
        }

        private bool IsValidInput(string firstName, string lastName, string contactNumber, string email, string password, string confPassword)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter a valid first name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter a valid last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(contactNumber))
            {
                MessageBox.Show("Please enter a valid contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a valid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (password != confPassword)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void goBackLogin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide();
        }
    }
}
