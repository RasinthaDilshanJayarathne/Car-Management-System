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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login(object sender, EventArgs e)
        {
            string email = "admin@gmail.com";
            string password = "Password";

            if (txtEmail.Text == email && txtPassword.Text == password)
            {
                frmAdminDashboard adminDashboard = new frmAdminDashboard();
                this.Hide();
                adminDashboard.Show();
            }
            else
            {
                frmCustomerDashboard customerDashboard = new frmCustomerDashboard();
                this.Hide();
                customerDashboard.Show();
            }


        }

        private void signUp(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
