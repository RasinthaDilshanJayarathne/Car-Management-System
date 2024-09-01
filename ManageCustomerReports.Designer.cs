namespace CarManagementSystem
{
    partial class frmManageCustomerReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cmbReports = new ComboBox();
            lblReports = new Label();
            tblReports = new Guna.UI2.WinForms.Guna2DataGridView();
            lblReportFilterDate = new Label();
            dtpReportFilterDate = new DateTimePicker();
            btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)tblReports).BeginInit();
            SuspendLayout();
            // 
            // cmbReports
            // 
            cmbReports.FormattingEnabled = true;
            cmbReports.Location = new Point(23, 43);
            cmbReports.Name = "cmbReports";
            cmbReports.Size = new Size(198, 23);
            cmbReports.TabIndex = 79;
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.BackColor = Color.White;
            lblReports.Font = new Font("Segoe UI", 9F);
            lblReports.ForeColor = Color.Black;
            lblReports.Location = new Point(23, 22);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(124, 15);
            lblReports.TabIndex = 78;
            lblReports.Text = "Genarate Report Types";
            // 
            // tblReports
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            tblReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tblReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tblReports.ColumnHeadersHeight = 17;
            tblReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tblReports.DefaultCellStyle = dataGridViewCellStyle3;
            tblReports.GridColor = Color.FromArgb(231, 229, 255);
            tblReports.Location = new Point(6, 149);
            tblReports.Name = "tblReports";
            tblReports.RowHeadersVisible = false;
            tblReports.Size = new Size(691, 234);
            tblReports.TabIndex = 99;
            tblReports.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            tblReports.ThemeStyle.AlternatingRowsStyle.Font = null;
            tblReports.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tblReports.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tblReports.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tblReports.ThemeStyle.BackColor = Color.White;
            tblReports.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            tblReports.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            tblReports.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tblReports.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            tblReports.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tblReports.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tblReports.ThemeStyle.HeaderStyle.Height = 17;
            tblReports.ThemeStyle.ReadOnly = false;
            tblReports.ThemeStyle.RowsStyle.BackColor = Color.White;
            tblReports.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tblReports.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            tblReports.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            tblReports.ThemeStyle.RowsStyle.Height = 25;
            tblReports.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            tblReports.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // lblReportFilterDate
            // 
            lblReportFilterDate.AutoSize = true;
            lblReportFilterDate.BackColor = Color.White;
            lblReportFilterDate.Font = new Font("Segoe UI", 9F);
            lblReportFilterDate.ForeColor = Color.Black;
            lblReportFilterDate.Location = new Point(23, 82);
            lblReportFilterDate.Name = "lblReportFilterDate";
            lblReportFilterDate.Size = new Size(98, 15);
            lblReportFilterDate.TabIndex = 101;
            lblReportFilterDate.Text = "Report Filter Date";
            // 
            // dtpReportFilterDate
            // 
            dtpReportFilterDate.CalendarForeColor = Color.White;
            dtpReportFilterDate.CalendarMonthBackground = Color.White;
            dtpReportFilterDate.CalendarTitleBackColor = SystemColors.ControlText;
            dtpReportFilterDate.CalendarTitleForeColor = Color.White;
            dtpReportFilterDate.CalendarTrailingForeColor = Color.White;
            dtpReportFilterDate.Location = new Point(23, 100);
            dtpReportFilterDate.Name = "dtpReportFilterDate";
            dtpReportFilterDate.Size = new Size(206, 23);
            dtpReportFilterDate.TabIndex = 100;
            dtpReportFilterDate.Value = new DateTime(2024, 6, 30, 0, 0, 0, 0);
            dtpReportFilterDate.ValueChanged += dtpReportFilterDate_ValueChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.BorderRadius = 5;
            btnGenerate.CustomizableEdges = customizableEdges1;
            btnGenerate.DisabledState.BorderColor = Color.DarkGray;
            btnGenerate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGenerate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGenerate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGenerate.FillColor = Color.FromArgb(59, 216, 94);
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(600, 390);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGenerate.Size = new Size(97, 29);
            btnGenerate.TabIndex = 102;
            btnGenerate.Text = "GENERATE";
            // 
            // frmManageCustomerReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(703, 430);
            Controls.Add(btnGenerate);
            Controls.Add(lblReportFilterDate);
            Controls.Add(dtpReportFilterDate);
            Controls.Add(tblReports);
            Controls.Add(cmbReports);
            Controls.Add(lblReports);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManageCustomerReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomerReports";
            ((System.ComponentModel.ISupportInitialize)tblReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbReports;
        private Label lblReports;
        private Guna.UI2.WinForms.Guna2DataGridView tblReports;
        private Label lblReportFilterDate;
        private DateTimePicker dtpReportFilterDate;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
    }
}