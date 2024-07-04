namespace CarManagementSystem
{
    partial class CustomerDashboardSummery
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
            SuspendLayout();
            // 
            // CustomerDashboardSummery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(703, 430);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerDashboardSummery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerDashboardSummery";
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel pnlOrder;
        private PictureBox imgOrderBox;
    }
}