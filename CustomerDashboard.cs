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
    public partial class frmCustomerDashboard : Form
    {
        public frmCustomerDashboard()
        {
            InitializeComponent();

            lblTitle.Text = "CUSTOMER-DASHBOARD";
            lblUserName.Text = "User.";
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void clickLogout(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }
    }
}
