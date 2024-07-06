using System;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
            UpdateDashboard("ADMIN-DASHBOARD", new AdminDashboardSummery());
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void UpdateDashboard(string title, Form form)
        {
            lblTitle.Text = title;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlDashboard.Controls.Clear();
            pnlDashboard.Controls.Add(form);
            form.Show();
        }

        private void getManageCarDetails(object sender, EventArgs e) =>
            UpdateDashboard("MANAGE CAR DETAILS", new frmManageCarDetails());

        private void getDashboardSummery(object sender, EventArgs e) =>
            UpdateDashboard("ADMIN-DASHBOARD", new AdminDashboardSummery());

        private void getManageCarParts(object sender, EventArgs e) =>
            UpdateDashboard("MANAGE CAR PART DETAILS", new frmManageCarPartsDetails());

        private void getCustomerDetails(object sender, EventArgs e) =>
            UpdateDashboard("MANAGE CUSTOMER DETAILS", new frmManageCustomerDetails());

        private void getOrderDetails(object sender, EventArgs e) =>
            UpdateDashboard("MANAGE ORDER DETAILS", new frmManageOrderDetails());

        private void getAllReports(object sender, EventArgs e) =>
            UpdateDashboard("REPORT GENERATION", new frmManageCustomerDetails());

        private void getManageCarRentalDetails(object sender, EventArgs e) =>
            UpdateDashboard("MANAGE CAR RENTAL DETAILS", new frmManageCarRentalDetails());

        private void clickLogout(object sender, EventArgs e)
        {
            Hide();
            new frmLogin().Show();
        }
    }
}
