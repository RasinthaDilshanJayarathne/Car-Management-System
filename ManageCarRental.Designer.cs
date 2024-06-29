namespace CarManagementSystem
{
    partial class frmManageCarRental
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
            txtCarName = new Label();
            cmbCarId = new ComboBox();
            lblCarName = new Label();
            txtRetunDate = new DateTimePicker();
            lblReturnDate = new Label();
            lblCarId = new Label();
            SuspendLayout();
            // 
            // txtCarName
            // 
            txtCarName.AutoSize = true;
            txtCarName.BackColor = Color.White;
            txtCarName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCarName.ForeColor = Color.Gray;
            txtCarName.Location = new Point(183, 73);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(0, 20);
            txtCarName.TabIndex = 71;
            // 
            // cmbCarId
            // 
            cmbCarId.FormattingEnabled = true;
            cmbCarId.Location = new Point(88, 71);
            cmbCarId.Name = "cmbCarId";
            cmbCarId.Size = new Size(78, 23);
            cmbCarId.TabIndex = 66;
            // 
            // lblCarName
            // 
            lblCarName.AutoSize = true;
            lblCarName.BackColor = Color.White;
            lblCarName.Font = new Font("Segoe UI", 9F);
            lblCarName.ForeColor = Color.Gray;
            lblCarName.Location = new Point(184, 53);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(60, 15);
            lblCarName.TabIndex = 70;
            lblCarName.Text = "Car Name";
            // 
            // txtRetunDate
            // 
            txtRetunDate.CalendarForeColor = Color.White;
            txtRetunDate.CalendarMonthBackground = Color.White;
            txtRetunDate.CalendarTitleBackColor = SystemColors.ControlText;
            txtRetunDate.CalendarTitleForeColor = Color.White;
            txtRetunDate.CalendarTrailingForeColor = Color.White;
            txtRetunDate.Location = new Point(86, 123);
            txtRetunDate.Name = "txtRetunDate";
            txtRetunDate.Size = new Size(206, 23);
            txtRetunDate.TabIndex = 69;
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.BackColor = Color.White;
            lblReturnDate.Font = new Font("Segoe UI", 9F);
            lblReturnDate.ForeColor = Color.Gray;
            lblReturnDate.Location = new Point(97, 106);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(69, 15);
            lblReturnDate.TabIndex = 68;
            lblReturnDate.Text = "Return Date";
            // 
            // lblCarId
            // 
            lblCarId.AutoSize = true;
            lblCarId.BackColor = Color.White;
            lblCarId.Font = new Font("Segoe UI", 9F);
            lblCarId.ForeColor = Color.Gray;
            lblCarId.Location = new Point(88, 51);
            lblCarId.Name = "lblCarId";
            lblCarId.Size = new Size(38, 15);
            lblCarId.TabIndex = 67;
            lblCarId.Text = "Car Id";
            // 
            // frmManageCarRental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(687, 391);
            Controls.Add(txtCarName);
            Controls.Add(cmbCarId);
            Controls.Add(lblCarName);
            Controls.Add(txtRetunDate);
            Controls.Add(lblReturnDate);
            Controls.Add(lblCarId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManageCarRental";
            Text = "ManageCarRental";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCarName;
        private ComboBox cmbCarId;
        private Label lblCarName;
        private DateTimePicker txtRetunDate;
        private Label lblReturnDate;
        private Label lblCarId;
    }
}