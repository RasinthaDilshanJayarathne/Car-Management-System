namespace CarManagementSystem
{
    partial class frmCustomerCarRentalHistory
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
            pnlOrderContainer = new Guna.UI2.WinForms.Guna2GradientPanel();
            searchIcon = new PictureBox();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlOrderContainer
            // 
            pnlOrderContainer.AutoScroll = true;
            pnlOrderContainer.CustomizableEdges = customizableEdges1;
            pnlOrderContainer.Location = new Point(12, 65);
            pnlOrderContainer.Name = "pnlOrderContainer";
            pnlOrderContainer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlOrderContainer.Size = new Size(679, 353);
            pnlOrderContainer.TabIndex = 54;
            // 
            // searchIcon
            // 
            searchIcon.Image = Properties.Resources.download__1_;
            searchIcon.Location = new Point(201, 18);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(24, 25);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 53;
            searchIcon.TabStop = false;
            // 
            // txtSearch
            // 
            txtSearch.BorderColor = Color.White;
            txtSearch.CustomizableEdges = customizableEdges3;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search by Car Rent Id";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearch.Size = new Size(213, 36);
            txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtSearch.TabIndex = 52;
            // 
            // frmCustomerCarRentalHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(703, 430);
            Controls.Add(pnlOrderContainer);
            Controls.Add(searchIcon);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCustomerCarRentalHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerCarRentalHistory";
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlOrderContainer;
        private PictureBox searchIcon;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}