namespace CarManagementSystem
{
    partial class frmSplashScreen
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            progressCircle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            lblPercentage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            progressCircle.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3751179131;
            pictureBox1.Location = new Point(31, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // progressCircle
            // 
            progressCircle.Controls.Add(pictureBox1);
            progressCircle.FillColor = Color.White;
            progressCircle.FillThickness = 8;
            progressCircle.Font = new Font("Segoe UI", 12F);
            progressCircle.ForeColor = Color.White;
            progressCircle.Location = new Point(233, 83);
            progressCircle.Minimum = 0;
            progressCircle.Name = "progressCircle";
            progressCircle.ProgressColor = Color.FromArgb(0, 192, 0);
            progressCircle.ProgressColor2 = Color.FromArgb(0, 192, 0);
            progressCircle.ProgressThickness = 8;
            progressCircle.ShadowDecoration.CustomizableEdges = customizableEdges1;
            progressCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            progressCircle.Size = new Size(167, 167);
            progressCircle.TabIndex = 1;
            progressCircle.Text = "guna2CircleProgressBar1";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPercentage.Location = new Point(308, 256);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(19, 17);
            lblPercentage.TabIndex = 1;
            lblPercentage.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 39);
            label2.Name = "label2";
            label2.Size = new Size(223, 31);
            label2.TabIndex = 23;
            label2.Text = "ABC CAR TRADERS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 8);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 22;
            label1.Text = "WELCOME TO";
            // 
            // frmSplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(618, 296);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPercentage);
            Controls.Add(progressCircle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash Screen";
            Load += frmSplashScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            progressCircle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressCircle;
        private System.Windows.Forms.Timer timer1;
        private Label lblPercentage;
        private Label label2;
        private Label label1;
    }
}