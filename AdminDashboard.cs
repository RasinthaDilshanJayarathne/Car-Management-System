using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CarManagementSystem
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();

            lblTitle.Text = "ADMIN-DASHBOARD";
            lblUserName.Text = "Admin.";
            lblDateTime.Text = DateTime.Now.ToString();

            AdminDashboardSummery dashboardSummery = new AdminDashboardSummery();
            dashboardSummery.TopLevel = false;
            dashboardSummery.FormBorderStyle = FormBorderStyle.None;
            dashboardSummery.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(dashboardSummery);
            dashboardSummery.Show();
        }

        private void getManageCarDetails(object sender, EventArgs e)
        {
            lblTitle.Text = "MANAGE CAR DETAILS";
            frmManageCarDetails manageCarDetails = new frmManageCarDetails();
            manageCarDetails.TopLevel = false;
            manageCarDetails.FormBorderStyle = FormBorderStyle.None;
            manageCarDetails.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(manageCarDetails);
            manageCarDetails.Show();
        }

        private void getDashboardSummery(object sender, EventArgs e)
        {

            lblTitle.Text = "ADMIN-DASHBOARD";
            AdminDashboardSummery adminDashboardSummery = new AdminDashboardSummery();
            adminDashboardSummery.TopLevel = false;
            adminDashboardSummery.FormBorderStyle = FormBorderStyle.None;
            adminDashboardSummery.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(adminDashboardSummery);
            adminDashboardSummery.Show();
        }

        private void getManageCarParts(object sender, EventArgs e)
        {
            lblTitle.Text = "MANAGE CAR PART DETAILS";
            frmManageCarPartsDetails carPartsDetails = new frmManageCarPartsDetails();
            carPartsDetails.TopLevel = false;
            carPartsDetails.FormBorderStyle = FormBorderStyle.None;
            carPartsDetails.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(carPartsDetails);
            carPartsDetails.Show();
        }

        private void getCustomerDetails(object sender, EventArgs e)
        {
            lblTitle.Text = "MANAGE CUSTOMER DETAILS";
            frmManageCustomerDetails manageCustomerDetails = new frmManageCustomerDetails();
            manageCustomerDetails.TopLevel = false;
            manageCustomerDetails.FormBorderStyle = FormBorderStyle.None;
            manageCustomerDetails.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(manageCustomerDetails);
            manageCustomerDetails.Show();
        }

        private void getOrderDetails(object sender, EventArgs e)
        {
            lblTitle.Text = "MANAGE ORDER DETAILS";
            frmManageOrderDetails manageOrderDetails = new frmManageOrderDetails();
            manageOrderDetails.TopLevel = false;
            manageOrderDetails.FormBorderStyle = FormBorderStyle.None;
            manageOrderDetails.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(manageOrderDetails);
            manageOrderDetails.Show();
        }

        private void getAllReports(object sender, EventArgs e)
        {
            lblTitle.Text = "REPORT GENERATION";
            frmManageCustomerDetails manageCustomerDetails = new frmManageCustomerDetails();
            manageCustomerDetails.TopLevel = false;
            manageCustomerDetails.FormBorderStyle = FormBorderStyle.None;
            manageCustomerDetails.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(manageCustomerDetails);
            manageCustomerDetails.Show();
        }

        private void getManageCarRentalDetails(object sender, EventArgs e)
        {
            lblTitle.Text = "MANAGE CAR RENTAL DETAILS";
            frmManageCarRental manageCarRental = new frmManageCarRental();
            manageCarRental.TopLevel = false;
            manageCarRental.FormBorderStyle = FormBorderStyle.None;
            manageCarRental.Dock = DockStyle.Fill;

            this.pnlDashboard.Controls.Clear();
            this.pnlDashboard.Controls.Add(manageCarRental);
            manageCarRental.Show();
        }

        private void clickLogout(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }
        
    }
}
