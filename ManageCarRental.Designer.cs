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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txtRentalStartDate = new DateTimePicker();
            searchIcon = new PictureBox();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            cmbCustId = new ComboBox();
            txtMake = new Label();
            lblCusId = new Label();
            txtYear = new Label();
            txtModel = new Label();
            txtPrice = new Label();
            txtRentalId = new Label();
            cmbCarId = new ComboBox();
            lblMake = new Label();
            lblYear = new Label();
            lblModel = new Label();
            lblPrice = new Label();
            lblCarId = new Label();
            lblRentalId = new Label();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnRentNow = new Guna.UI2.WinForms.Guna2Button();
            txtTotalCost = new Label();
            lblRentalEndDate = new Label();
            txtTotalDays = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblRentalStartDate = new Label();
            txtDailyRate = new Label();
            lblTotalCost = new Label();
            lblTotalDays = new Label();
            lblDailyRate = new Label();
            tblRentalDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            carImgBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            guna2GradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblRentalDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carImgBox).BeginInit();
            SuspendLayout();
            // 
            // txtRentalStartDate
            // 
            txtRentalStartDate.CalendarForeColor = Color.White;
            txtRentalStartDate.CalendarMonthBackground = Color.White;
            txtRentalStartDate.CalendarTitleBackColor = SystemColors.ControlText;
            txtRentalStartDate.CalendarTitleForeColor = Color.White;
            txtRentalStartDate.CalendarTrailingForeColor = Color.White;
            txtRentalStartDate.Location = new Point(13, 26);
            txtRentalStartDate.Name = "txtRentalStartDate";
            txtRentalStartDate.Size = new Size(206, 23);
            txtRentalStartDate.TabIndex = 69;
            // 
            // searchIcon
            // 
            searchIcon.Image = Properties.Resources.download__1_;
            searchIcon.Location = new Point(223, 16);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(24, 23);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 73;
            searchIcon.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderColor = Color.White;
            txtSearch.CustomizableEdges = customizableEdges9;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(24, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search by Car Id / Cust Id / Mode ";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearch.Size = new Size(196, 29);
            txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtSearch.TabIndex = 72;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            guna2HtmlLabel1.Location = new Point(220, 54);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(94, 19);
            guna2HtmlLabel1.TabIndex = 75;
            guna2HtmlLabel1.Text = "Invoice Details";
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.White;
            guna2GradientPanel1.BorderColor = Color.Black;
            guna2GradientPanel1.BorderRadius = 5;
            guna2GradientPanel1.BorderThickness = 1;
            guna2GradientPanel1.Controls.Add(cmbCustId);
            guna2GradientPanel1.Controls.Add(txtMake);
            guna2GradientPanel1.Controls.Add(lblCusId);
            guna2GradientPanel1.Controls.Add(txtYear);
            guna2GradientPanel1.Controls.Add(txtModel);
            guna2GradientPanel1.Controls.Add(txtPrice);
            guna2GradientPanel1.Controls.Add(txtRentalId);
            guna2GradientPanel1.Controls.Add(cmbCarId);
            guna2GradientPanel1.Controls.Add(lblMake);
            guna2GradientPanel1.Controls.Add(lblYear);
            guna2GradientPanel1.Controls.Add(lblModel);
            guna2GradientPanel1.Controls.Add(lblPrice);
            guna2GradientPanel1.Controls.Add(lblCarId);
            guna2GradientPanel1.Controls.Add(lblRentalId);
            guna2GradientPanel1.CustomizableEdges = customizableEdges11;
            guna2GradientPanel1.Location = new Point(220, 76);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2GradientPanel1.Size = new Size(208, 202);
            guna2GradientPanel1.TabIndex = 74;
            // 
            // cmbCustId
            // 
            cmbCustId.FormattingEnabled = true;
            cmbCustId.Location = new Point(13, 79);
            cmbCustId.Name = "cmbCustId";
            cmbCustId.Size = new Size(81, 23);
            cmbCustId.TabIndex = 77;
            // 
            // txtMake
            // 
            txtMake.AutoSize = true;
            txtMake.BackColor = Color.White;
            txtMake.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMake.ForeColor = Color.Gray;
            txtMake.Location = new Point(11, 176);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(0, 20);
            txtMake.TabIndex = 42;
            // 
            // lblCusId
            // 
            lblCusId.AutoSize = true;
            lblCusId.BackColor = Color.White;
            lblCusId.Font = new Font("Segoe UI", 9F);
            lblCusId.ForeColor = Color.Black;
            lblCusId.Location = new Point(13, 58);
            lblCusId.Name = "lblCusId";
            lblCusId.Size = new Size(44, 15);
            lblCusId.TabIndex = 76;
            lblCusId.Text = "Cust Id";
            // 
            // txtYear
            // 
            txtYear.AutoSize = true;
            txtYear.BackColor = Color.White;
            txtYear.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtYear.ForeColor = Color.Gray;
            txtYear.Location = new Point(110, 128);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(0, 20);
            txtYear.TabIndex = 41;
            // 
            // txtModel
            // 
            txtModel.AutoSize = true;
            txtModel.BackColor = Color.White;
            txtModel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModel.ForeColor = Color.Gray;
            txtModel.Location = new Point(112, 176);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(0, 20);
            txtModel.TabIndex = 40;
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.BackColor = Color.White;
            txtPrice.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.ForeColor = Color.Gray;
            txtPrice.Location = new Point(11, 127);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(0, 20);
            txtPrice.TabIndex = 39;
            // 
            // txtRentalId
            // 
            txtRentalId.AutoSize = true;
            txtRentalId.BackColor = Color.White;
            txtRentalId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRentalId.ForeColor = Color.Gray;
            txtRentalId.Location = new Point(12, 26);
            txtRentalId.Name = "txtRentalId";
            txtRentalId.Size = new Size(70, 20);
            txtRentalId.TabIndex = 38;
            txtRentalId.Text = "R00-001";
            // 
            // cmbCarId
            // 
            cmbCarId.FormattingEnabled = true;
            cmbCarId.Location = new Point(113, 79);
            cmbCarId.Name = "cmbCarId";
            cmbCarId.Size = new Size(81, 23);
            cmbCarId.TabIndex = 37;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.BackColor = Color.White;
            lblMake.Font = new Font("Segoe UI", 9F);
            lblMake.ForeColor = Color.Black;
            lblMake.Location = new Point(12, 156);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(36, 15);
            lblMake.TabIndex = 36;
            lblMake.Text = "Make";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.BackColor = Color.White;
            lblYear.Font = new Font("Segoe UI", 9F);
            lblYear.ForeColor = Color.Black;
            lblYear.Location = new Point(113, 107);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 34;
            lblYear.Text = "Year";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.BackColor = Color.White;
            lblModel.Font = new Font("Segoe UI", 9F);
            lblModel.ForeColor = Color.Black;
            lblModel.Location = new Point(113, 156);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 32;
            lblModel.Text = "Model";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.White;
            lblPrice.Font = new Font("Segoe UI", 9F);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(13, 107);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 32;
            lblPrice.Text = "Price";
            // 
            // lblCarId
            // 
            lblCarId.AutoSize = true;
            lblCarId.BackColor = Color.White;
            lblCarId.Font = new Font("Segoe UI", 9F);
            lblCarId.ForeColor = Color.Black;
            lblCarId.Location = new Point(113, 58);
            lblCarId.Name = "lblCarId";
            lblCarId.Size = new Size(38, 15);
            lblCarId.TabIndex = 30;
            lblCarId.Text = "Car Id";
            // 
            // lblRentalId
            // 
            lblRentalId.AutoSize = true;
            lblRentalId.BackColor = Color.White;
            lblRentalId.Font = new Font("Segoe UI", 9F);
            lblRentalId.ForeColor = Color.Black;
            lblRentalId.Location = new Point(13, 8);
            lblRentalId.Name = "lblRentalId";
            lblRentalId.Size = new Size(53, 15);
            lblRentalId.TabIndex = 28;
            lblRentalId.Text = "Rental Id";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            guna2HtmlLabel2.Location = new Point(449, 54);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(113, 19);
            guna2HtmlLabel2.TabIndex = 77;
            guna2HtmlLabel2.Text = "Car Rental Details";
            // 
            // guna2GradientPanel3
            // 
            guna2GradientPanel3.BackColor = Color.White;
            guna2GradientPanel3.BorderColor = Color.Black;
            guna2GradientPanel3.BorderRadius = 5;
            guna2GradientPanel3.BorderThickness = 1;
            guna2GradientPanel3.Controls.Add(btnRentNow);
            guna2GradientPanel3.Controls.Add(txtTotalCost);
            guna2GradientPanel3.Controls.Add(lblRentalEndDate);
            guna2GradientPanel3.Controls.Add(txtTotalDays);
            guna2GradientPanel3.Controls.Add(dateTimePicker1);
            guna2GradientPanel3.Controls.Add(lblRentalStartDate);
            guna2GradientPanel3.Controls.Add(txtDailyRate);
            guna2GradientPanel3.Controls.Add(txtRentalStartDate);
            guna2GradientPanel3.Controls.Add(lblTotalCost);
            guna2GradientPanel3.Controls.Add(lblTotalDays);
            guna2GradientPanel3.Controls.Add(lblDailyRate);
            guna2GradientPanel3.CustomizableEdges = customizableEdges15;
            guna2GradientPanel3.Location = new Point(449, 76);
            guna2GradientPanel3.Name = "guna2GradientPanel3";
            guna2GradientPanel3.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2GradientPanel3.Size = new Size(235, 202);
            guna2GradientPanel3.TabIndex = 76;
            // 
            // btnRentNow
            // 
            btnRentNow.BorderRadius = 5;
            btnRentNow.CustomizableEdges = customizableEdges13;
            btnRentNow.DisabledState.BorderColor = Color.DarkGray;
            btnRentNow.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRentNow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRentNow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRentNow.FillColor = Color.FromArgb(59, 216, 94);
            btnRentNow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRentNow.ForeColor = Color.White;
            btnRentNow.Location = new Point(122, 167);
            btnRentNow.Name = "btnRentNow";
            btnRentNow.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnRentNow.Size = new Size(97, 29);
            btnRentNow.TabIndex = 86;
            btnRentNow.Text = "RENT NOW";
            // 
            // txtTotalCost
            // 
            txtTotalCost.AutoSize = true;
            txtTotalCost.BackColor = Color.White;
            txtTotalCost.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalCost.ForeColor = Color.Gray;
            txtTotalCost.Location = new Point(11, 176);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.Size = new Size(0, 20);
            txtTotalCost.TabIndex = 85;
            // 
            // lblRentalEndDate
            // 
            lblRentalEndDate.AutoSize = true;
            lblRentalEndDate.BackColor = Color.White;
            lblRentalEndDate.Font = new Font("Segoe UI", 9F);
            lblRentalEndDate.ForeColor = Color.Black;
            lblRentalEndDate.Location = new Point(13, 58);
            lblRentalEndDate.Name = "lblRentalEndDate";
            lblRentalEndDate.Size = new Size(90, 15);
            lblRentalEndDate.TabIndex = 80;
            lblRentalEndDate.Text = "Rental End Date";
            // 
            // txtTotalDays
            // 
            txtTotalDays.AutoSize = true;
            txtTotalDays.BackColor = Color.White;
            txtTotalDays.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalDays.ForeColor = Color.Gray;
            txtTotalDays.Location = new Point(105, 128);
            txtTotalDays.Name = "txtTotalDays";
            txtTotalDays.Size = new Size(0, 20);
            txtTotalDays.TabIndex = 84;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.White;
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker1.CalendarTitleForeColor = Color.White;
            dateTimePicker1.CalendarTrailingForeColor = Color.White;
            dateTimePicker1.Location = new Point(13, 76);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(206, 23);
            dateTimePicker1.TabIndex = 79;
            // 
            // lblRentalStartDate
            // 
            lblRentalStartDate.AutoSize = true;
            lblRentalStartDate.BackColor = Color.White;
            lblRentalStartDate.Font = new Font("Segoe UI", 9F);
            lblRentalStartDate.ForeColor = Color.Black;
            lblRentalStartDate.Location = new Point(13, 8);
            lblRentalStartDate.Name = "lblRentalStartDate";
            lblRentalStartDate.Size = new Size(94, 15);
            lblRentalStartDate.TabIndex = 78;
            lblRentalStartDate.Text = "Rental Start Date";
            // 
            // txtDailyRate
            // 
            txtDailyRate.AutoSize = true;
            txtDailyRate.BackColor = Color.White;
            txtDailyRate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDailyRate.ForeColor = Color.Gray;
            txtDailyRate.Location = new Point(11, 127);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.Size = new Size(0, 20);
            txtDailyRate.TabIndex = 82;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.BackColor = Color.White;
            lblTotalCost.Font = new Font("Segoe UI", 9F);
            lblTotalCost.ForeColor = Color.Black;
            lblTotalCost.Location = new Point(12, 156);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(59, 15);
            lblTotalCost.TabIndex = 81;
            lblTotalCost.Text = "Total Cost";
            // 
            // lblTotalDays
            // 
            lblTotalDays.AutoSize = true;
            lblTotalDays.BackColor = Color.White;
            lblTotalDays.Font = new Font("Segoe UI", 9F);
            lblTotalDays.ForeColor = Color.Black;
            lblTotalDays.Location = new Point(108, 107);
            lblTotalDays.Name = "lblTotalDays";
            lblTotalDays.Size = new Size(60, 15);
            lblTotalDays.TabIndex = 80;
            lblTotalDays.Text = "Total Days";
            // 
            // lblDailyRate
            // 
            lblDailyRate.AutoSize = true;
            lblDailyRate.BackColor = Color.White;
            lblDailyRate.Font = new Font("Segoe UI", 9F);
            lblDailyRate.ForeColor = Color.Black;
            lblDailyRate.Location = new Point(13, 107);
            lblDailyRate.Name = "lblDailyRate";
            lblDailyRate.Size = new Size(59, 15);
            lblDailyRate.TabIndex = 79;
            lblDailyRate.Text = "Daily Rate";
            // 
            // tblRentalDetails
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            tblRentalDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            tblRentalDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            tblRentalDetails.ColumnHeadersHeight = 17;
            tblRentalDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            tblRentalDetails.DefaultCellStyle = dataGridViewCellStyle6;
            tblRentalDetails.GridColor = Color.FromArgb(231, 229, 255);
            tblRentalDetails.Location = new Point(4, 289);
            tblRentalDetails.Name = "tblRentalDetails";
            tblRentalDetails.RowHeadersVisible = false;
            tblRentalDetails.Size = new Size(695, 136);
            tblRentalDetails.TabIndex = 78;
            tblRentalDetails.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            tblRentalDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            tblRentalDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tblRentalDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tblRentalDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tblRentalDetails.ThemeStyle.BackColor = Color.White;
            tblRentalDetails.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            tblRentalDetails.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            tblRentalDetails.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tblRentalDetails.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            tblRentalDetails.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tblRentalDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tblRentalDetails.ThemeStyle.HeaderStyle.Height = 17;
            tblRentalDetails.ThemeStyle.ReadOnly = false;
            tblRentalDetails.ThemeStyle.RowsStyle.BackColor = Color.White;
            tblRentalDetails.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tblRentalDetails.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            tblRentalDetails.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            tblRentalDetails.ThemeStyle.RowsStyle.Height = 25;
            tblRentalDetails.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            tblRentalDetails.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // carImgBox
            // 
            carImgBox.Location = new Point(20, 75);
            carImgBox.Name = "carImgBox";
            carImgBox.Size = new Size(178, 203);
            carImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            carImgBox.TabIndex = 79;
            carImgBox.TabStop = false;
            // 
            // frmManageCarRental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(703, 430);
            Controls.Add(carImgBox);
            Controls.Add(tblRentalDetails);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(guna2GradientPanel3);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(searchIcon);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManageCarRental";
            Text = "ManageCarRental";
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            guna2GradientPanel3.ResumeLayout(false);
            guna2GradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tblRentalDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)carImgBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker txtRentalStartDate;
        private PictureBox searchIcon;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label txtMake;
        private Label txtYear;
        private Label txtModel;
        private Label txtPrice;
        private Label txtRentalId;
        private ComboBox cmbCarId;
        private Label lblMake;
        private Label lblYear;
        private Label lblModel;
        private Label lblPrice;
        private Label lblCarId;
        private Label lblRentalId;
        private ComboBox cmbCustId;
        private Label lblCusId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Label lblRentalStartDate;
        private Label txtTotalCost;
        private Label lblRentalEndDate;
        private Label txtTotalDays;
        private DateTimePicker dateTimePicker1;
        private Label txtDailyRate;
        private Label lblTotalCost;
        private Label lblTotalDays;
        private Label lblDailyRate;
        private Guna.UI2.WinForms.Guna2DataGridView tblRentalDetails;
        private PictureBox carImgBox;
        private Guna.UI2.WinForms.Guna2Button btnRentNow;
    }
}