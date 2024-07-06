using System;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmCustomerDashboard : Form
    {
        private string currentUsername;
        private string currentCustomerId;

        public frmCustomerDashboard(string username, string customerId)
        {
            InitializeComponent();
            currentUsername = username;
            currentCustomerId = customerId;
            lblTitle.Text = "CUSTOMER-DASHBOARD";
            lblUserName.Text = currentUsername;
            lblDateTime.Text = DateTime.Now.ToString();

        }

        private void SwitchToForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlDashboard.Controls.Clear();
            pnlDashboard.Controls.Add(form);
            form.Show();
        }

        private void clickLogout(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void getDashboardSummary(object sender, EventArgs e)
        {
            lblTitle.Text = "CUSTOMER-DASHBOARD";
            SwitchToForm(new frmCustomerDashboardSummery(currentUsername, currentCustomerId));
        }

        private void getOrderCarPart(object sender, EventArgs e)
        {
            lblTitle.Text = "ORDER CAR PARTS";
            SwitchToForm(new frmCustomerOrderDetails(currentUsername, currentCustomerId));
        }

        private void getCarRental(object sender, EventArgs e)
        {
            lblTitle.Text = "CAR RENTAL";
            SwitchToForm(new frmCustomerCarRentalDetails(currentUsername, currentCustomerId));
        }

        private void getOrderHistory(object sender, EventArgs e)
        {
            lblTitle.Text = $"{currentUsername.ToUpper()}" + " YOUR ORDER HISTORY";
            SwitchToForm(new frmCustomerOrderHistory(currentUsername, currentCustomerId));
        }

        private void getCarRentalHistory(object sender, EventArgs e)
        {
            lblTitle.Text = $"{currentUsername.ToUpper()}" + " YOUR CAR RENTAL HISTORY";
            SwitchToForm(new frmCustomerCarRentalHistory(currentUsername, currentCustomerId));
        }

        private void searchCars(object sender, EventArgs e)
        {
            lblTitle.Text = "ALL CARS";
            SwitchToForm(new frmSearchCars());
        }

        private void searchCarParts(object sender, EventArgs e)
        {
            lblTitle.Text = "ALL CAR PARTS";
            SwitchToForm(new frmSearchCarParts());
        }
    }
}
