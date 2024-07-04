using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            lblUserName.Text = $"{currentUsername}";
            lblDateTime.Text = DateTime.Now.ToString();

            //ShowDashboardSummary();

            // Initialize and start the timer to update the date and time
            /*Timer timer = new Timer();
            timer.Interval = 1000; // 1 second intervals
            timer.Tick += new EventHandler(UpdateDateTime);
            timer.Start();*/
        }

        private void clickLogout(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void getDashboardSummery(object sender, EventArgs e)
        {
            lblTitle.Text = "CUSTOMER-DASHBOARD";
            //ShowDashboardSummary();
        }

        private void ShowDashboardSummary()
        {
            CustomerDashboardSummery dashboardSummery = new CustomerDashboardSummery(currentUsername, currentCustomerId);
            dashboardSummery.TopLevel = false;
            dashboardSummery.FormBorderStyle = FormBorderStyle.None;
            dashboardSummery.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(dashboardSummery);
            dashboardSummery.Show();
        }

        private void UpdateDateTime(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void getOrderCarPart(object sender, EventArgs e)
        {
            lblTitle.Text = "ORDER CAR PARTS";
            frmCustomerOrderDetails customerOrderDetails = new frmCustomerOrderDetails(currentUsername, currentCustomerId);
            customerOrderDetails.TopLevel = false;
            customerOrderDetails.FormBorderStyle = FormBorderStyle.None;
            customerOrderDetails.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(customerOrderDetails);
            customerOrderDetails.Show();
        }

        private void getCarRental(object sender, EventArgs e)
        {
            lblTitle.Text = "CAR RENTAL";
            frmCustomerCarRentalDetails customerCarRentalDetails = new frmCustomerCarRentalDetails(currentUsername, currentCustomerId);
            customerCarRentalDetails.TopLevel = false;
            customerCarRentalDetails.FormBorderStyle = FormBorderStyle.None;
            customerCarRentalDetails.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(customerCarRentalDetails);
            customerCarRentalDetails.Show();
        }

        private void getOrderHistory(object sender, EventArgs e)
        {
            lblTitle.Text = $"{currentUsername.ToUpper()}" + " YOUR ORDER HISTORY";
            frmCustomerOrderHistory customerOrderHistory = new frmCustomerOrderHistory(currentUsername, currentCustomerId);
            customerOrderHistory.TopLevel = false;
            customerOrderHistory.FormBorderStyle = FormBorderStyle.None;
            customerOrderHistory.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(customerOrderHistory);
            customerOrderHistory.Show();
        }

        private void getCarRentalHistory(object sender, EventArgs e)
        {
            lblTitle.Text = $"{currentUsername.ToUpper()}" + " YOUR CAR RENTAL HISTORY";
            frmCustomerCarRentalHistory customerCarRentalHistory = new frmCustomerCarRentalHistory(currentUsername, currentCustomerId);
            customerCarRentalHistory.TopLevel = false;
            customerCarRentalHistory.FormBorderStyle = FormBorderStyle.None;
            customerCarRentalHistory.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(customerCarRentalHistory);
            customerCarRentalHistory.Show();
        }
    }
}
