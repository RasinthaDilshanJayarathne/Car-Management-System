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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtpRentalStartDate = new DateTimePicker();
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
            txtDailyRate = new Guna.UI2.WinForms.Guna2TextBox();
            btnRentNow = new Guna.UI2.WinForms.Guna2Button();
            txtTotalCost = new Label();
            lblRentalEndDate = new Label();
            txtTotalDays = new Label();
            dtpRentalEndDate = new DateTimePicker();
            lblRentalStartDate = new Label();
            lblTotalCost = new Label();
            lblTotalDays = new Label();
            lblDailyRate = new Label();
            tblRentalDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            carImgBox = new PictureBox();
            lblCarAvailable = new Label();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            guna2GradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tblRentalDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carImgBox).BeginInit();
            SuspendLayout();
            // 
            // dtpRentalStartDate
            // 
            dtpRentalStartDate.CalendarForeColor = Color.White;
            dtpRentalStartDate.CalendarMonthBackground = Color.White;
            dtpRentalStartDate.CalendarTitleBackColor = SystemColors.ControlText;
            dtpRentalStartDate.CalendarTitleForeColor = Color.White;
            dtpRentalStartDate.CalendarTrailingForeColor = Color.White;
            dtpRentalStartDate.Location = new Point(13, 26);
            dtpRentalStartDate.Name = "dtpRentalStartDate";
            dtpRentalStartDate.Size = new Size(206, 23);
            dtpRentalStartDate.TabIndex = 69;
            dtpRentalStartDate.Value = new DateTime(2024, 6, 30, 0, 0, 0, 0);
            dtpRentalStartDate.ValueChanged += dtpRentalStartDate_ValueChanged;
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
            searchIcon.Click += btnSearching_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderColor = Color.White;
            txtSearch.CustomizableEdges = customizableEdges1;
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
            txtSearch.PlaceholderText = "Search by Car Id  / Mode ";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
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
            guna2GradientPanel1.CustomizableEdges = customizableEdges3;
            guna2GradientPanel1.Location = new Point(220, 76);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            guna2GradientPanel3.Controls.Add(txtDailyRate);
            guna2GradientPanel3.Controls.Add(btnRentNow);
            guna2GradientPanel3.Controls.Add(txtTotalCost);
            guna2GradientPanel3.Controls.Add(lblRentalEndDate);
            guna2GradientPanel3.Controls.Add(txtTotalDays);
            guna2GradientPanel3.Controls.Add(dtpRentalEndDate);
            guna2GradientPanel3.Controls.Add(lblRentalStartDate);
            guna2GradientPanel3.Controls.Add(dtpRentalStartDate);
            guna2GradientPanel3.Controls.Add(lblTotalCost);
            guna2GradientPanel3.Controls.Add(lblTotalDays);
            guna2GradientPanel3.Controls.Add(lblDailyRate);
            guna2GradientPanel3.CustomizableEdges = customizableEdges9;
            guna2GradientPanel3.Location = new Point(449, 76);
            guna2GradientPanel3.Name = "guna2GradientPanel3";
            guna2GradientPanel3.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2GradientPanel3.Size = new Size(235, 202);
            guna2GradientPanel3.TabIndex = 76;
            // 
            // txtDailyRate
            // 
            txtDailyRate.BorderColor = Color.White;
            txtDailyRate.CustomizableEdges = customizableEdges5;
            txtDailyRate.DefaultText = "";
            txtDailyRate.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtDailyRate.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtDailyRate.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtDailyRate.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtDailyRate.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDailyRate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDailyRate.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDailyRate.Location = new Point(14, 125);
            txtDailyRate.Margin = new Padding(3, 4, 3, 4);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.PasswordChar = '\0';
            txtDailyRate.PlaceholderText = "00.00";
            txtDailyRate.SelectedText = "";
            txtDailyRate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtDailyRate.Size = new Size(78, 27);
            txtDailyRate.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtDailyRate.TabIndex = 87;
            // 
            // btnRentNow
            // 
            btnRentNow.BorderRadius = 5;
            btnRentNow.CustomizableEdges = customizableEdges7;
            btnRentNow.DisabledState.BorderColor = Color.DarkGray;
            btnRentNow.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRentNow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRentNow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRentNow.FillColor = Color.FromArgb(59, 216, 94);
            btnRentNow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRentNow.ForeColor = Color.White;
            btnRentNow.Location = new Point(122, 167);
            btnRentNow.Name = "btnRentNow";
            btnRentNow.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnRentNow.Size = new Size(97, 29);
            btnRentNow.TabIndex = 86;
            btnRentNow.Text = "RENT NOW";
            btnRentNow.Click += btnRentNow_Click;
            // 
            // txtTotalCost
            // 
            txtTotalCost.AutoSize = true;
            txtTotalCost.BackColor = Color.White;
            txtTotalCost.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalCost.ForeColor = Color.Gray;
            txtTotalCost.Location = new Point(14, 176);
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
            txtTotalDays.Location = new Point(109, 128);
            txtTotalDays.Name = "txtTotalDays";
            txtTotalDays.Size = new Size(0, 20);
            txtTotalDays.TabIndex = 84;
            // 
            // dtpRentalEndDate
            // 
            dtpRentalEndDate.CalendarForeColor = Color.White;
            dtpRentalEndDate.CalendarMonthBackground = Color.White;
            dtpRentalEndDate.CalendarTitleBackColor = SystemColors.ControlText;
            dtpRentalEndDate.CalendarTitleForeColor = Color.White;
            dtpRentalEndDate.CalendarTrailingForeColor = Color.White;
            dtpRentalEndDate.Location = new Point(13, 76);
            dtpRentalEndDate.Name = "dtpRentalEndDate";
            dtpRentalEndDate.Size = new Size(206, 23);
            dtpRentalEndDate.TabIndex = 79;
            dtpRentalEndDate.Value = new DateTime(2024, 6, 30, 0, 0, 0, 0);
            dtpRentalEndDate.ValueChanged += dtpRentalEndDate_ValueChanged;
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
            dataGridViewCellStyle1.BackColor = Color.White;
            tblRentalDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tblRentalDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tblRentalDetails.ColumnHeadersHeight = 17;
            tblRentalDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tblRentalDetails.DefaultCellStyle = dataGridViewCellStyle3;
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
            // lblCarAvailable
            // 
            lblCarAvailable.AutoSize = true;
            lblCarAvailable.BackColor = Color.FromArgb(59, 216, 94);
            lblCarAvailable.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarAvailable.ForeColor = Color.White;
            lblCarAvailable.Location = new Point(73, 76);
            lblCarAvailable.Name = "lblCarAvailable";
            lblCarAvailable.Size = new Size(73, 20);
            lblCarAvailable.TabIndex = 80;
            lblCarAvailable.Text = "Available";
            // 
            // frmManageCarRental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(703, 430);
            Controls.Add(lblCarAvailable);
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
        private DateTimePicker dtpRentalStartDate;
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
        private DateTimePicker dtpRentalEndDate;
        private Label lblTotalCost;
        private Label lblTotalDays;
        private Label lblDailyRate;
        private Guna.UI2.WinForms.Guna2DataGridView tblRentalDetails;
        private PictureBox carImgBox;
        private Guna.UI2.WinForms.Guna2Button btnRentNow;
        private Guna.UI2.WinForms.Guna2TextBox txtDailyRate;
        private Label lblCarAvailable;
    }
}