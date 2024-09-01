namespace CarManagementSystem
{
    partial class frmReportViewer
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
            tblReportData = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox1 = new PictureBox();
            lblReportName = new Label();
            label1 = new Label();
            lblDate = new Label();
            btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)tblReportData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tblReportData
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            tblReportData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tblReportData.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tblReportData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tblReportData.ColumnHeadersHeight = 17;
            tblReportData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tblReportData.DefaultCellStyle = dataGridViewCellStyle3;
            tblReportData.GridColor = Color.FromArgb(231, 229, 255);
            tblReportData.Location = new Point(12, 133);
            tblReportData.Name = "tblReportData";
            tblReportData.RowHeadersVisible = false;
            tblReportData.Size = new Size(621, 337);
            tblReportData.TabIndex = 59;
            tblReportData.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            tblReportData.ThemeStyle.AlternatingRowsStyle.Font = null;
            tblReportData.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tblReportData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tblReportData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tblReportData.ThemeStyle.BackColor = Color.Gainsboro;
            tblReportData.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            tblReportData.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            tblReportData.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tblReportData.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            tblReportData.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tblReportData.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tblReportData.ThemeStyle.HeaderStyle.Height = 17;
            tblReportData.ThemeStyle.ReadOnly = false;
            tblReportData.ThemeStyle.RowsStyle.BackColor = Color.White;
            tblReportData.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tblReportData.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            tblReportData.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            tblReportData.ThemeStyle.RowsStyle.Height = 25;
            tblReportData.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            tblReportData.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Gainsboro;
            pictureBox1.Image = Properties.Resources._3751179131;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // lblReportName
            // 
            lblReportName.AutoSize = true;
            lblReportName.BackColor = Color.Gainsboro;
            lblReportName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportName.ForeColor = Color.Black;
            lblReportName.Location = new Point(136, 52);
            lblReportName.Name = "lblReportName";
            lblReportName.Size = new Size(235, 30);
            lblReportName.TabIndex = 79;
            lblReportName.Text = "Genarate Report Types";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(136, 12);
            label1.Name = "label1";
            label1.Size = new Size(212, 30);
            label1.TabIndex = 80;
            label1.Text = "ABC CAR TREADERS";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Gainsboro;
            lblDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(136, 86);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 25);
            lblDate.TabIndex = 81;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.Gainsboro;
            btnGenerate.BorderRadius = 5;
            btnGenerate.CustomizableEdges = customizableEdges1;
            btnGenerate.DisabledState.BorderColor = Color.DarkGray;
            btnGenerate.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGenerate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGenerate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGenerate.FillColor = Color.Gainsboro;
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.Red;
            btnGenerate.Location = new Point(601, 12);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnGenerate.Size = new Size(32, 29);
            btnGenerate.TabIndex = 103;
            btnGenerate.Text = "X";
            btnGenerate.Click += btnClose_Click;
            // 
            // frmReportViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(645, 482);
            Controls.Add(btnGenerate);
            Controls.Add(lblDate);
            Controls.Add(label1);
            Controls.Add(lblReportName);
            Controls.Add(pictureBox1);
            Controls.Add(tblReportData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmReportViewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReportView";
            ((System.ComponentModel.ISupportInitialize)tblReportData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView tblReportData;
        private PictureBox pictureBox1;
        private Label lblReportName;
        private Label label1;
        private Label lblDate;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
    }
}