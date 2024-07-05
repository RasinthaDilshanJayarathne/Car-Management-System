namespace CarManagementSystem
{
    partial class frmSearchCars
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
            pnlContainer = new Guna.UI2.WinForms.Guna2GradientPanel();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.AutoScroll = true;
            pnlContainer.CustomizableEdges = customizableEdges1;
            pnlContainer.Location = new Point(12, 48);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlContainer.Size = new Size(679, 377);
            pnlContainer.TabIndex = 59;
            // 
            // frmSearchCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(703, 430);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSearchCars";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchCars";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnlContainer;
        private PictureBox searchIcon;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}