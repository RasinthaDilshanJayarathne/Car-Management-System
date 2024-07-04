using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using CarManagementSystem.DBConnection;
using System.Security.Cryptography;
using System.Text;

namespace CarManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void login(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //string hashedPassword = HashPassword(password);

            string adminQuery = "SELECT * FROM admin WHERE email = @Email AND password = @Password";
            string customerQuery = "SELECT * FROM customer WHERE email = @Email AND password = @Password";

            try
            {
                using (var db = new DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    if (CheckUserCredentials(adminQuery, db, email, password, out string adminUsername, out string adminId))
                    {
                        // Admin found, navigate to admin dashboard
                        frmAdminDashboard adminDashboard = new frmAdminDashboard();
                        this.Hide();
                        adminDashboard.Show();
                        return; // Exit method after successful login
                    }

                    if (CheckUserCredentials(customerQuery, db, email, password, out string customerUsername, out string customerId))
                    {
                        // Customer found, navigate to customer dashboard
                        frmCustomerDashboard customerDashboard = new frmCustomerDashboard(customerUsername, customerId);
                        this.Hide();
                        customerDashboard.Show();
                        return; // Exit method after successful login
                    }

                    // If neither admin nor customer found, show error
                    MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckUserCredentials(string query, DBConnection.DBConnection db, string email, string password, out string username, out string custId)
        {
            using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        username = reader["firstName"].ToString(); // Assumes 'firstName' column exists in both admin and customer tables
                        custId = reader["customerId"].ToString(); // Assumes 'customerId' column exists
                        return true;
                    }
                    else
                    {
                        username = null;
                        custId = null;
                        return false;
                    }
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void signUp(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }
    }
}
