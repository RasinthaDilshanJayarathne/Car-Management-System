using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using CarManagementSystem.DBConnection;

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

            string adminQuery = "SELECT * FROM admin WHERE email = @Email AND password = @Password";
            string customerQuery = "SELECT * FROM customer WHERE email = @Email AND password = @Password";

            try
            {
                using (var db = new CarManagementSystem.DBConnection.DBConnection())
                {
                    db.OpenConnection();

                    if (CheckUserCredentials(adminQuery, db, email, password))
                    {
                        // Admin found, navigate to admin dashboard
                        frmAdminDashboard adminDashboard = new frmAdminDashboard();
                        this.Hide();
                        adminDashboard.Show();
                        return; // Exit method after successful login
                    }

                    if (CheckUserCredentials(customerQuery, db, email, password))
                    {
                        // Customer found, navigate to customer dashboard
                        frmCustomerDashboard customerDashboard = new frmCustomerDashboard();
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
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckUserCredentials(string query, CarManagementSystem.DBConnection.DBConnection db, string email, string password)
        {
            using (MySqlCommand command = new MySqlCommand(query, db.GetConnection()))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password); // Consider hashing the password for better security

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    return reader.Read();
                }
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
