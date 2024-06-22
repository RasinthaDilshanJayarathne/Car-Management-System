namespace CarManagementSystem
{
    partial class frmManageCarPartsDetails
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
            tblCarPartDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colParName = new DataGridViewTextBoxColumn();
            colCarId = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colQtyOnHand = new DataGridViewTextBoxColumn();
            colDescription = new DataGridViewTextBoxColumn();
            colAction = new DataGridViewTextBoxColumn();
            btnCarPartDelete = new Guna.UI2.WinForms.Guna2Button();
            btnCarPartSave = new Guna.UI2.WinForms.Guna2Button();
            lblCarId = new Label();
            txtModel = new Guna.UI2.WinForms.Guna2TextBox();
            lblPartId = new Label();
            txtPartId = new Guna.UI2.WinForms.Guna2TextBox();
            lblPartName = new Label();
            txtMake = new Guna.UI2.WinForms.Guna2TextBox();
            txtQtyOnHand = new Guna.UI2.WinForms.Guna2TextBox();
            lblQtyOnHand = new Label();
            lblPrice = new Label();
            txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)tblCarPartDetails).BeginInit();
            SuspendLayout();
            // 
            // tblCarPartDetails
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            tblCarPartDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tblCarPartDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tblCarPartDetails.ColumnHeadersHeight = 17;
            tblCarPartDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tblCarPartDetails.Columns.AddRange(new DataGridViewColumn[] { colId, colParName, colCarId, colPrice, colQtyOnHand, colDescription, colAction });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tblCarPartDetails.DefaultCellStyle = dataGridViewCellStyle3;
            tblCarPartDetails.GridColor = Color.FromArgb(231, 229, 255);
            tblCarPartDetails.Location = new Point(4, 175);
            tblCarPartDetails.Name = "tblCarPartDetails";
            tblCarPartDetails.RowHeadersVisible = false;
            tblCarPartDetails.Size = new Size(694, 250);
            tblCarPartDetails.TabIndex = 57;
            tblCarPartDetails.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            tblCarPartDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            tblCarPartDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tblCarPartDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tblCarPartDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tblCarPartDetails.ThemeStyle.BackColor = Color.White;
            tblCarPartDetails.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            tblCarPartDetails.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            tblCarPartDetails.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tblCarPartDetails.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            tblCarPartDetails.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tblCarPartDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tblCarPartDetails.ThemeStyle.HeaderStyle.Height = 17;
            tblCarPartDetails.ThemeStyle.ReadOnly = false;
            tblCarPartDetails.ThemeStyle.RowsStyle.BackColor = Color.White;
            tblCarPartDetails.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tblCarPartDetails.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            tblCarPartDetails.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            tblCarPartDetails.ThemeStyle.RowsStyle.Height = 25;
            tblCarPartDetails.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            tblCarPartDetails.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.Name = "colId";
            // 
            // colParName
            // 
            colParName.HeaderText = "Part Name";
            colParName.Name = "colParName";
            // 
            // colCarId
            // 
            colCarId.HeaderText = "Car Id";
            colCarId.Name = "colCarId";
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            // 
            // colQtyOnHand
            // 
            colQtyOnHand.HeaderText = "Qty On Hand";
            colQtyOnHand.Name = "colQtyOnHand";
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";
            // 
            // colAction
            // 
            colAction.HeaderText = "Action";
            colAction.Name = "colAction";
            // 
            // btnCarPartDelete
            // 
            btnCarPartDelete.BorderRadius = 5;
            btnCarPartDelete.CustomizableEdges = customizableEdges1;
            btnCarPartDelete.DisabledState.BorderColor = Color.DarkGray;
            btnCarPartDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCarPartDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCarPartDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCarPartDelete.FillColor = Color.FromArgb(230, 0, 0);
            btnCarPartDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarPartDelete.ForeColor = Color.White;
            btnCarPartDelete.Location = new Point(527, 110);
            btnCarPartDelete.Name = "btnCarPartDelete";
            btnCarPartDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCarPartDelete.Size = new Size(72, 29);
            btnCarPartDelete.TabIndex = 56;
            btnCarPartDelete.Text = "DELETE";
            // 
            // btnCarPartSave
            // 
            btnCarPartSave.BorderRadius = 5;
            btnCarPartSave.CustomizableEdges = customizableEdges3;
            btnCarPartSave.DisabledState.BorderColor = Color.DarkGray;
            btnCarPartSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCarPartSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCarPartSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCarPartSave.FillColor = Color.FromArgb(59, 216, 94);
            btnCarPartSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarPartSave.ForeColor = Color.White;
            btnCarPartSave.Location = new Point(616, 110);
            btnCarPartSave.Name = "btnCarPartSave";
            btnCarPartSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCarPartSave.Size = new Size(72, 29);
            btnCarPartSave.TabIndex = 55;
            btnCarPartSave.Text = "SAVE";
            // 
            // lblCarId
            // 
            lblCarId.AutoSize = true;
            lblCarId.BackColor = Color.White;
            lblCarId.Font = new Font("Segoe UI", 9F);
            lblCarId.ForeColor = Color.Gray;
            lblCarId.Location = new Point(428, 19);
            lblCarId.Name = "lblCarId";
            lblCarId.Size = new Size(38, 15);
            lblCarId.TabIndex = 51;
            lblCarId.Text = "Car Id";
            // 
            // txtModel
            // 
            txtModel.BorderColor = Color.White;
            txtModel.CustomizableEdges = customizableEdges5;
            txtModel.DefaultText = "";
            txtModel.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtModel.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtModel.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtModel.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtModel.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtModel.Font = new Font("Segoe UI", 9F);
            txtModel.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtModel.Location = new Point(418, 37);
            txtModel.Name = "txtModel";
            txtModel.PasswordChar = '\0';
            txtModel.PlaceholderText = "Enter Model";
            txtModel.SelectedText = "";
            txtModel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtModel.Size = new Size(127, 36);
            txtModel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtModel.TabIndex = 53;
            // 
            // lblPartId
            // 
            lblPartId.AutoSize = true;
            lblPartId.BackColor = Color.White;
            lblPartId.Font = new Font("Segoe UI", 9F);
            lblPartId.ForeColor = Color.Gray;
            lblPartId.Location = new Point(141, 19);
            lblPartId.Name = "lblPartId";
            lblPartId.Size = new Size(41, 15);
            lblPartId.TabIndex = 43;
            lblPartId.Text = "Part Id";
            // 
            // txtPartId
            // 
            txtPartId.BorderColor = Color.White;
            txtPartId.CustomizableEdges = customizableEdges7;
            txtPartId.DefaultText = "";
            txtPartId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPartId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPartId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPartId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPartId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPartId.Font = new Font("Segoe UI", 9F);
            txtPartId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPartId.Location = new Point(132, 37);
            txtPartId.Name = "txtPartId";
            txtPartId.PasswordChar = '\0';
            txtPartId.PlaceholderText = "Enter Part Id";
            txtPartId.SelectedText = "";
            txtPartId.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPartId.Size = new Size(127, 36);
            txtPartId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPartId.TabIndex = 45;
            // 
            // lblPartName
            // 
            lblPartName.AutoSize = true;
            lblPartName.BackColor = Color.White;
            lblPartName.Font = new Font("Segoe UI", 9F);
            lblPartName.ForeColor = Color.Gray;
            lblPartName.Location = new Point(285, 19);
            lblPartName.Name = "lblPartName";
            lblPartName.Size = new Size(63, 15);
            lblPartName.TabIndex = 44;
            lblPartName.Text = "Part Name";
            // 
            // txtMake
            // 
            txtMake.BorderColor = Color.White;
            txtMake.CustomizableEdges = customizableEdges9;
            txtMake.DefaultText = "";
            txtMake.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMake.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMake.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMake.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMake.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMake.Font = new Font("Segoe UI", 9F);
            txtMake.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMake.Location = new Point(275, 37);
            txtMake.Name = "txtMake";
            txtMake.PasswordChar = '\0';
            txtMake.PlaceholderText = "Enter Make";
            txtMake.SelectedText = "";
            txtMake.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtMake.Size = new Size(127, 36);
            txtMake.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtMake.TabIndex = 46;
            // 
            // txtQtyOnHand
            // 
            txtQtyOnHand.BorderColor = Color.White;
            txtQtyOnHand.CustomizableEdges = customizableEdges11;
            txtQtyOnHand.DefaultText = "";
            txtQtyOnHand.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtQtyOnHand.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtQtyOnHand.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtQtyOnHand.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtQtyOnHand.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQtyOnHand.Font = new Font("Segoe UI", 9F);
            txtQtyOnHand.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtQtyOnHand.Location = new Point(132, 110);
            txtQtyOnHand.Name = "txtQtyOnHand";
            txtQtyOnHand.PasswordChar = '\0';
            txtQtyOnHand.PlaceholderText = "Enter Qty On Hand";
            txtQtyOnHand.SelectedText = "";
            txtQtyOnHand.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtQtyOnHand.Size = new Size(127, 36);
            txtQtyOnHand.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtQtyOnHand.TabIndex = 50;
            // 
            // lblQtyOnHand
            // 
            lblQtyOnHand.AutoSize = true;
            lblQtyOnHand.BackColor = Color.White;
            lblQtyOnHand.Font = new Font("Segoe UI", 9F);
            lblQtyOnHand.ForeColor = Color.Gray;
            lblQtyOnHand.Location = new Point(141, 92);
            lblQtyOnHand.Name = "lblQtyOnHand";
            lblQtyOnHand.Size = new Size(77, 15);
            lblQtyOnHand.TabIndex = 48;
            lblQtyOnHand.Text = "Qty On Hand";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.White;
            lblPrice.Font = new Font("Segoe UI", 9F);
            lblPrice.ForeColor = Color.Gray;
            lblPrice.Location = new Point(570, 19);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 58;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.BorderColor = Color.White;
            txtPrice.CustomizableEdges = customizableEdges13;
            txtPrice.DefaultText = "";
            txtPrice.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPrice.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPrice.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPrice.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Font = new Font("Segoe UI", 9F);
            txtPrice.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPrice.Location = new Point(561, 37);
            txtPrice.Name = "txtPrice";
            txtPrice.PasswordChar = '\0';
            txtPrice.PlaceholderText = "Enter Price";
            txtPrice.SelectedText = "";
            txtPrice.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtPrice.Size = new Size(127, 36);
            txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPrice.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(285, 92);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 60;
            label1.Text = "Description";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderColor = Color.White;
            guna2TextBox1.CustomizableEdges = customizableEdges15;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(275, 110);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "Enter Description ";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2TextBox1.Size = new Size(127, 36);
            guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            guna2TextBox1.TabIndex = 61;
            // 
            // frmManageCarPartsDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(703, 430);
            Controls.Add(label1);
            Controls.Add(guna2TextBox1);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(tblCarPartDetails);
            Controls.Add(btnCarPartDelete);
            Controls.Add(btnCarPartSave);
            Controls.Add(lblCarId);
            Controls.Add(txtModel);
            Controls.Add(lblQtyOnHand);
            Controls.Add(txtQtyOnHand);
            Controls.Add(lblPartId);
            Controls.Add(txtPartId);
            Controls.Add(lblPartName);
            Controls.Add(txtMake);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManageCarPartsDetails";
            Text = "ManageCarPartsDetails";
            ((System.ComponentModel.ISupportInitialize)tblCarPartDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView tblCarPartDetails;
        private Guna.UI2.WinForms.Guna2Button btnCarPartDelete;
        private Guna.UI2.WinForms.Guna2Button btnCarPartSave;
        private Label lblCarId;
        private Guna.UI2.WinForms.Guna2TextBox txtModel;
        private Label lblPartId;
        private Guna.UI2.WinForms.Guna2TextBox txtPartId;
        private Label lblPartName;
        private Guna.UI2.WinForms.Guna2TextBox txtMake;
        private Guna.UI2.WinForms.Guna2TextBox txtQtyOnHand;
        private Label lblQtyOnHand;
        private Label lblPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colParName;
        private DataGridViewTextBoxColumn colCarId;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colQtyOnHand;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewTextBoxColumn colAction;
    }
}