namespace CarManagementSystem
{
    partial class frmManageCarDetails
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblCarId = new Label();
            txtCarId = new Guna.UI2.WinForms.Guna2TextBox();
            lblMake = new Label();
            txtMake = new Guna.UI2.WinForms.Guna2TextBox();
            lblPrice = new Label();
            txtDailyRate = new Guna.UI2.WinForms.Guna2TextBox();
            lblCarPrice = new Label();
            txtCarPrice = new Guna.UI2.WinForms.Guna2TextBox();
            lblModel = new Label();
            txtModel = new Guna.UI2.WinForms.Guna2TextBox();
            lblYear = new Label();
            txtYear = new Guna.UI2.WinForms.Guna2TextBox();
            btnCarSave = new Guna.UI2.WinForms.Guna2Button();
            btnCarDelete = new Guna.UI2.WinForms.Guna2Button();
            btnUpload = new Guna.UI2.WinForms.Guna2Button();
            carImgBox = new PictureBox();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            searchIcon = new PictureBox();
            tblCarDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            checkVehicleSellOrNo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)carImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tblCarDetails).BeginInit();
            SuspendLayout();
            // 
            // lblCarId
            // 
            lblCarId.AutoSize = true;
            lblCarId.BackColor = Color.White;
            lblCarId.Font = new Font("Segoe UI", 9F);
            lblCarId.ForeColor = Color.Black;
            lblCarId.Location = new Point(142, 101);
            lblCarId.Name = "lblCarId";
            lblCarId.Size = new Size(57, 15);
            lblCarId.TabIndex = 28;
            lblCarId.Text = "Vehicle Id";
            // 
            // txtCarId
            // 
            txtCarId.BorderColor = Color.White;
            txtCarId.CustomizableEdges = customizableEdges1;
            txtCarId.DefaultText = "";
            txtCarId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCarId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCarId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCarId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCarId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCarId.Font = new Font("Segoe UI", 9F);
            txtCarId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCarId.Location = new Point(133, 119);
            txtCarId.Name = "txtCarId";
            txtCarId.PasswordChar = '\0';
            txtCarId.PlaceholderText = "Enter Car Id";
            txtCarId.SelectedText = "";
            txtCarId.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtCarId.Size = new Size(127, 36);
            txtCarId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtCarId.TabIndex = 30;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.BackColor = Color.White;
            lblMake.Font = new Font("Segoe UI", 9F);
            lblMake.ForeColor = Color.Black;
            lblMake.Location = new Point(286, 101);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(36, 15);
            lblMake.TabIndex = 29;
            lblMake.Text = "Make";
            // 
            // txtMake
            // 
            txtMake.BorderColor = Color.White;
            txtMake.CustomizableEdges = customizableEdges3;
            txtMake.DefaultText = "";
            txtMake.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMake.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMake.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMake.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMake.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMake.Font = new Font("Segoe UI", 9F);
            txtMake.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMake.Location = new Point(276, 119);
            txtMake.Name = "txtMake";
            txtMake.PasswordChar = '\0';
            txtMake.PlaceholderText = "Enter Make";
            txtMake.SelectedText = "";
            txtMake.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMake.Size = new Size(127, 36);
            txtMake.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtMake.TabIndex = 31;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.White;
            lblPrice.Font = new Font("Segoe UI", 9F);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(142, 174);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 15);
            lblPrice.TabIndex = 32;
            lblPrice.Text = "Daily Rate";
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
            txtDailyRate.Font = new Font("Segoe UI", 9F);
            txtDailyRate.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtDailyRate.Location = new Point(133, 192);
            txtDailyRate.Name = "txtDailyRate";
            txtDailyRate.PasswordChar = '\0';
            txtDailyRate.PlaceholderText = "Enter Daily Rate";
            txtDailyRate.SelectedText = "";
            txtDailyRate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtDailyRate.Size = new Size(127, 36);
            txtDailyRate.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtDailyRate.TabIndex = 34;
            // 
            // lblCarPrice
            // 
            lblCarPrice.AutoSize = true;
            lblCarPrice.BackColor = Color.White;
            lblCarPrice.Font = new Font("Segoe UI", 9F);
            lblCarPrice.ForeColor = Color.Black;
            lblCarPrice.Location = new Point(286, 174);
            lblCarPrice.Name = "lblCarPrice";
            lblCarPrice.Size = new Size(33, 15);
            lblCarPrice.TabIndex = 33;
            lblCarPrice.Text = "Price";
            // 
            // txtCarPrice
            // 
            txtCarPrice.BorderColor = Color.White;
            txtCarPrice.CustomizableEdges = customizableEdges7;
            txtCarPrice.DefaultText = "";
            txtCarPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtCarPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtCarPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtCarPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtCarPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCarPrice.Font = new Font("Segoe UI", 9F);
            txtCarPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtCarPrice.Location = new Point(277, 192);
            txtCarPrice.Name = "txtCarPrice";
            txtCarPrice.PasswordChar = '\0';
            txtCarPrice.PlaceholderText = "Enter Car Price ";
            txtCarPrice.SelectedText = "";
            txtCarPrice.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtCarPrice.Size = new Size(127, 36);
            txtCarPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtCarPrice.TabIndex = 35;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.BackColor = Color.White;
            lblModel.Font = new Font("Segoe UI", 9F);
            lblModel.ForeColor = Color.Black;
            lblModel.Location = new Point(429, 101);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 36;
            lblModel.Text = "Model";
            // 
            // txtModel
            // 
            txtModel.BorderColor = Color.White;
            txtModel.CustomizableEdges = customizableEdges9;
            txtModel.DefaultText = "";
            txtModel.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtModel.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtModel.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtModel.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtModel.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtModel.Font = new Font("Segoe UI", 9F);
            txtModel.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtModel.Location = new Point(419, 119);
            txtModel.Name = "txtModel";
            txtModel.PasswordChar = '\0';
            txtModel.PlaceholderText = "Enter Model";
            txtModel.SelectedText = "";
            txtModel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtModel.Size = new Size(127, 36);
            txtModel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtModel.TabIndex = 38;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.BackColor = Color.White;
            lblYear.Font = new Font("Segoe UI", 9F);
            lblYear.ForeColor = Color.Black;
            lblYear.Location = new Point(574, 101);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 37;
            lblYear.Text = "Year";
            // 
            // txtYear
            // 
            txtYear.BorderColor = Color.White;
            txtYear.CustomizableEdges = customizableEdges11;
            txtYear.DefaultText = "";
            txtYear.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtYear.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtYear.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtYear.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtYear.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtYear.Font = new Font("Segoe UI", 9F);
            txtYear.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtYear.Location = new Point(565, 119);
            txtYear.Name = "txtYear";
            txtYear.PasswordChar = '\0';
            txtYear.PlaceholderText = "Enter Year";
            txtYear.SelectedText = "";
            txtYear.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtYear.Size = new Size(127, 36);
            txtYear.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtYear.TabIndex = 39;
            // 
            // btnCarSave
            // 
            btnCarSave.BorderRadius = 5;
            btnCarSave.CustomizableEdges = customizableEdges13;
            btnCarSave.DisabledState.BorderColor = Color.DarkGray;
            btnCarSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCarSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCarSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCarSave.FillColor = Color.FromArgb(59, 216, 94);
            btnCarSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarSave.ForeColor = Color.White;
            btnCarSave.Location = new Point(620, 192);
            btnCarSave.Name = "btnCarSave";
            btnCarSave.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnCarSave.Size = new Size(72, 29);
            btnCarSave.TabIndex = 40;
            btnCarSave.Text = "SAVE";
            btnCarSave.Click += btnSaveCar_Click;
            // 
            // btnCarDelete
            // 
            btnCarDelete.BorderRadius = 5;
            btnCarDelete.CustomizableEdges = customizableEdges15;
            btnCarDelete.DisabledState.BorderColor = Color.DarkGray;
            btnCarDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCarDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCarDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCarDelete.FillColor = Color.FromArgb(230, 0, 0);
            btnCarDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarDelete.ForeColor = Color.White;
            btnCarDelete.Location = new Point(531, 192);
            btnCarDelete.Name = "btnCarDelete";
            btnCarDelete.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnCarDelete.Size = new Size(72, 29);
            btnCarDelete.TabIndex = 41;
            btnCarDelete.Text = "DELETE";
            btnCarDelete.Click += btnDeleteCar_Click;
            // 
            // btnUpload
            // 
            btnUpload.BorderRadius = 5;
            btnUpload.CustomizableEdges = customizableEdges17;
            btnUpload.DisabledState.BorderColor = Color.DarkGray;
            btnUpload.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpload.FillColor = Color.FromArgb(59, 216, 94);
            btnUpload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.White;
            btnUpload.Location = new Point(13, 207);
            btnUpload.Name = "btnUpload";
            btnUpload.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnUpload.Size = new Size(104, 21);
            btnUpload.TabIndex = 44;
            btnUpload.Text = "UPLOAD";
            btnUpload.Click += uploadImage;
            // 
            // carImgBox
            // 
            carImgBox.Location = new Point(9, 63);
            carImgBox.Name = "carImgBox";
            carImgBox.Size = new Size(114, 138);
            carImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            carImgBox.TabIndex = 45;
            carImgBox.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderColor = Color.White;
            txtSearch.CustomizableEdges = customizableEdges19;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(9, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search by Car Id / Model / Year ";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtSearch.Size = new Size(213, 36);
            txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtSearch.TabIndex = 47;
            // 
            // searchIcon
            // 
            searchIcon.Image = Properties.Resources.download__1_;
            searchIcon.Location = new Point(198, 27);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(24, 25);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 48;
            searchIcon.TabStop = false;
            searchIcon.Click += btnSearching_Click;
            // 
            // tblCarDetails
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            tblCarDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tblCarDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tblCarDetails.ColumnHeadersHeight = 17;
            tblCarDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tblCarDetails.DefaultCellStyle = dataGridViewCellStyle3;
            tblCarDetails.GridColor = Color.FromArgb(231, 229, 255);
            tblCarDetails.Location = new Point(4, 249);
            tblCarDetails.Name = "tblCarDetails";
            tblCarDetails.ReadOnly = true;
            tblCarDetails.RowHeadersVisible = false;
            tblCarDetails.Size = new Size(695, 176);
            tblCarDetails.TabIndex = 42;
            tblCarDetails.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            tblCarDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            tblCarDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tblCarDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tblCarDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tblCarDetails.ThemeStyle.BackColor = Color.White;
            tblCarDetails.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            tblCarDetails.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            tblCarDetails.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tblCarDetails.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            tblCarDetails.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tblCarDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tblCarDetails.ThemeStyle.HeaderStyle.Height = 17;
            tblCarDetails.ThemeStyle.ReadOnly = true;
            tblCarDetails.ThemeStyle.RowsStyle.BackColor = Color.White;
            tblCarDetails.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tblCarDetails.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            tblCarDetails.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            tblCarDetails.ThemeStyle.RowsStyle.Height = 25;
            tblCarDetails.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            tblCarDetails.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            tblCarDetails.CellContentClick += carDataGridView_CellClick;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // checkVehicleSellOrNo
            // 
            checkVehicleSellOrNo.AutoSize = true;
            checkVehicleSellOrNo.Location = new Point(142, 63);
            checkVehicleSellOrNo.Name = "checkVehicleSellOrNo";
            checkVehicleSellOrNo.Size = new Size(84, 19);
            checkVehicleSellOrNo.TabIndex = 52;
            checkVehicleSellOrNo.Text = "Sell Vehicle";
            checkVehicleSellOrNo.UseVisualStyleBackColor = true;
            // 
            // frmManageCarDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(703, 430);
            Controls.Add(checkVehicleSellOrNo);
            Controls.Add(searchIcon);
            Controls.Add(txtSearch);
            Controls.Add(carImgBox);
            Controls.Add(btnUpload);
            Controls.Add(tblCarDetails);
            Controls.Add(btnCarDelete);
            Controls.Add(btnCarSave);
            Controls.Add(lblModel);
            Controls.Add(txtModel);
            Controls.Add(lblYear);
            Controls.Add(txtYear);
            Controls.Add(lblPrice);
            Controls.Add(txtDailyRate);
            Controls.Add(lblCarPrice);
            Controls.Add(txtCarPrice);
            Controls.Add(lblCarId);
            Controls.Add(txtCarId);
            Controls.Add(lblMake);
            Controls.Add(txtMake);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManageCarDetails";
            Text = "ManageCarDetails";
            ((System.ComponentModel.ISupportInitialize)carImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)tblCarDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCarId;
        private Guna.UI2.WinForms.Guna2TextBox txtCarId;
        private Label lblMake;
        private Guna.UI2.WinForms.Guna2TextBox txtMake;
        private Label lblPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtDailyRate;
        private Label lblCarPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtCarPrice;
        private Label lblModel;
        private Guna.UI2.WinForms.Guna2TextBox txtModel;
        private Label lblYear;
        private Guna.UI2.WinForms.Guna2TextBox txtYear;
        private Guna.UI2.WinForms.Guna2Button btnCarSave;
        private Guna.UI2.WinForms.Guna2Button btnCarDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpload;
        private PictureBox carImgBox;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private PictureBox searchIcon;
        private Guna.UI2.WinForms.Guna2DataGridView tblCarDetails;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private CheckBox checkVehicleSellOrNo;
    }
}