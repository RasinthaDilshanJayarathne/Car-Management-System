using System;
using System.Data;
using System.Windows.Forms;

namespace CarManagementSystem
{
    public partial class frmReportViewer : Form
    {
        private DataTable reportData;

        public frmReportViewer(DataTable dataTable, string reportName)
        {
            InitializeComponent();
            this.reportData = dataTable;
            lblReportName.Text = reportName;
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");


            // Set the report name as the form's title
            this.Text = reportName;

            // Load the DataTable into a DataGridView (assuming you have a DataGridView on the form)
            if (reportData != null)
            {
                tblReportData.DataSource = reportData;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmReportViewer frm = new frmReportViewer(this.reportData, lblReportName.Text);
            frm.Close();
        }
    }
}
