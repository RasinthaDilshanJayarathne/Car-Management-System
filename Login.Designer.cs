namespace CarManagementSystem
{
    partial class Login
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
            loginPicBox = new PictureBox();
            lblPassword = new Label();
            lblEmail = new Label();
            label1 = new Label();
            label2 = new Label();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            lblSignup = new LinkLabel();
            lblNewMember = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)loginPicBox).BeginInit();
            SuspendLayout();
            // 
            // loginPicBox
            // 
            loginPicBox.Image = Properties.Resources.anupam_debnath_artboard_1__1___1_;
            loginPicBox.Location = new Point(-1, 0);
            loginPicBox.Name = "loginPicBox";
            loginPicBox.Size = new Size(776, 434);
            loginPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            loginPicBox.TabIndex = 0;
            loginPicBox.TabStop = false;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(246, 255, 250);
            lblPassword.Font = new Font("Segoe UI", 9.75F);
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(67, 247);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(64, 17);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.FromArgb(246, 255, 250);
            lblEmail.Font = new Font("Segoe UI", 9.75F);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(67, 175);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 17);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(246, 255, 250);
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 66);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 19;
            label1.Text = "WELCOME TO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(246, 255, 250);
            label2.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 97);
            label2.Name = "label2";
            label2.Size = new Size(223, 31);
            label2.TabIndex = 21;
            label2.Text = "ABC CAR TRADERS";
            // 
            // txtEmail
            // 
            txtEmail.BorderColor = Color.FromArgb(255, 252, 247);
            txtEmail.CustomizableEdges = customizableEdges1;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FillColor = Color.FromArgb(246, 255, 250);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(58, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Enter Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmail.Size = new Size(223, 36);
            txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtEmail.TabIndex = 22;
            txtEmail.TextChanged += guna2TextBox1_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 252, 247);
            btnLogin.BorderRadius = 10;
            btnLogin.CustomizableEdges = customizableEdges3;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(59, 216, 94);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(58, 336);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogin.Size = new Size(114, 37);
            btnLogin.TabIndex = 24;
            btnLogin.Text = "LOGIN";
            btnLogin.Click += login;
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.FromArgb(255, 252, 247);
            txtPassword.CustomizableEdges = customizableEdges5;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(246, 255, 250);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(58, 267);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PlaceholderText = "Enter Email";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassword.Size = new Size(223, 36);
            txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPassword.TabIndex = 25;
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSignup.LinkColor = Color.FromArgb(0, 0, 192);
            lblSignup.Location = new Point(146, 381);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(50, 15);
            lblSignup.TabIndex = 26;
            lblSignup.TabStop = true;
            lblSignup.Text = "Sign Up";
            lblSignup.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            lblSignup.LinkClicked += signUp;
            // 
            // lblNewMember
            // 
            lblNewMember.BackColor = Color.Transparent;
            lblNewMember.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewMember.Location = new Point(58, 379);
            lblNewMember.Name = "lblNewMember";
            lblNewMember.Size = new Size(88, 17);
            lblNewMember.TabIndex = 27;
            lblNewMember.Text = "New Member ? ";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 433);
            Controls.Add(lblNewMember);
            Controls.Add(lblSignup);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(loginPicBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)loginPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox loginPicBox;
        private Label lblPassword;
        private Label lblEmail;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private LinkLabel lblSignup;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNewMember;
    }
}