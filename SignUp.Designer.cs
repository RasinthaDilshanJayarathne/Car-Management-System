namespace CarManagementSystem
{
    partial class SignUp
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
            signupPicBox = new PictureBox();
            panel1 = new Panel();
            lblAlreadyAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblLogin = new LinkLabel();
            txtConPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtPhoneNo = new Guna.UI2.WinForms.Guna2TextBox();
            txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblPhoneNo = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConPassword = new Label();
            ((System.ComponentModel.ISupportInitialize)signupPicBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // signupPicBox
            // 
            signupPicBox.Image = Properties.Resources.bg;
            signupPicBox.Location = new Point(-3, -3);
            signupPicBox.Name = "signupPicBox";
            signupPicBox.Size = new Size(761, 478);
            signupPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            signupPicBox.TabIndex = 0;
            signupPicBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblAlreadyAccount);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(txtConPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPhoneNo);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(btnSignUp);
            panel1.Location = new Point(362, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 364);
            panel1.TabIndex = 1;
            // 
            // lblAlreadyAccount
            // 
            lblAlreadyAccount.BackColor = Color.Transparent;
            lblAlreadyAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlreadyAccount.Location = new Point(17, 339);
            lblAlreadyAccount.Name = "lblAlreadyAccount";
            lblAlreadyAccount.Size = new Size(146, 17);
            lblAlreadyAccount.TabIndex = 33;
            lblAlreadyAccount.Text = "Already have an account ?";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.LinkColor = Color.FromArgb(0, 0, 192);
            lblLogin.Location = new Point(164, 341);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 32;
            lblLogin.TabStop = true;
            lblLogin.Text = "Login";
            lblLogin.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            lblLogin.LinkClicked += goBackLogin;
            // 
            // txtConPassword
            // 
            txtConPassword.BorderColor = Color.White;
            txtConPassword.CustomizableEdges = customizableEdges1;
            txtConPassword.DefaultText = "";
            txtConPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConPassword.Font = new Font("Segoe UI", 9F);
            txtConPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConPassword.Location = new Point(169, 233);
            txtConPassword.Name = "txtConPassword";
            txtConPassword.PasswordChar = '●';
            txtConPassword.PlaceholderText = "Enter Password ";
            txtConPassword.SelectedText = "";
            txtConPassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtConPassword.Size = new Size(143, 36);
            txtConPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtConPassword.TabIndex = 31;
            txtConPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.BorderColor = Color.White;
            txtPassword.CustomizableEdges = customizableEdges3;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(14, 233);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPassword.Size = new Size(143, 36);
            txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPassword.TabIndex = 30;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.BorderColor = Color.White;
            txtEmail.CustomizableEdges = customizableEdges5;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(169, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Enter Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtEmail.Size = new Size(143, 36);
            txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtEmail.TabIndex = 29;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.BorderColor = Color.White;
            txtPhoneNo.CustomizableEdges = customizableEdges7;
            txtPhoneNo.DefaultText = "";
            txtPhoneNo.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPhoneNo.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPhoneNo.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPhoneNo.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPhoneNo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhoneNo.Font = new Font("Segoe UI", 9F);
            txtPhoneNo.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPhoneNo.Location = new Point(14, 160);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.PasswordChar = '\0';
            txtPhoneNo.PlaceholderText = "Enter Phone Number";
            txtPhoneNo.SelectedText = "";
            txtPhoneNo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtPhoneNo.Size = new Size(143, 36);
            txtPhoneNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtPhoneNo.TabIndex = 28;
            // 
            // txtLastName
            // 
            txtLastName.BorderColor = Color.White;
            txtLastName.CustomizableEdges = customizableEdges9;
            txtLastName.DefaultText = "";
            txtLastName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLastName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLastName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLastName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLastName.Font = new Font("Segoe UI", 9F);
            txtLastName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLastName.Location = new Point(169, 89);
            txtLastName.Name = "txtLastName";
            txtLastName.PasswordChar = '\0';
            txtLastName.PlaceholderText = "Enter Last Name";
            txtLastName.SelectedText = "";
            txtLastName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtLastName.Size = new Size(143, 36);
            txtLastName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtLastName.TabIndex = 27;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderColor = Color.White;
            txtFirstName.CustomizableEdges = customizableEdges11;
            txtFirstName.DefaultText = "";
            txtFirstName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtFirstName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtFirstName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtFirstName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFirstName.Font = new Font("Segoe UI", 9F);
            txtFirstName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtFirstName.Location = new Point(14, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PasswordChar = '\0';
            txtFirstName.PlaceholderText = "Enter First Name";
            txtFirstName.SelectedText = "";
            txtFirstName.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtFirstName.Size = new Size(143, 36);
            txtFirstName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            txtFirstName.TabIndex = 26;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(255, 252, 247);
            btnSignUp.BorderRadius = 10;
            btnSignUp.CustomizableEdges = customizableEdges13;
            btnSignUp.DisabledState.BorderColor = Color.DarkGray;
            btnSignUp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignUp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignUp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignUp.FillColor = Color.FromArgb(59, 216, 94);
            btnSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(17, 300);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSignUp.Size = new Size(95, 33);
            btnSignUp.TabIndex = 25;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.Click += signUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 56);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 2;
            label1.Text = "WELCOME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(379, 87);
            label2.Name = "label2";
            label2.Size = new Size(117, 13);
            label2.TabIndex = 3;
            label2.Text = "Let's get you started !";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.White;
            lblFirstName.Font = new Font("Segoe UI", 9F);
            lblFirstName.ForeColor = Color.Gray;
            lblFirstName.Location = new Point(384, 119);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.White;
            lblLastName.Font = new Font("Segoe UI", 9F);
            lblLastName.ForeColor = Color.Gray;
            lblLastName.Location = new Point(539, 119);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // lblPhoneNo
            // 
            lblPhoneNo.AutoSize = true;
            lblPhoneNo.BackColor = Color.White;
            lblPhoneNo.Font = new Font("Segoe UI", 9F);
            lblPhoneNo.ForeColor = Color.Gray;
            lblPhoneNo.Location = new Point(386, 190);
            lblPhoneNo.Name = "lblPhoneNo";
            lblPhoneNo.Size = new Size(41, 15);
            lblPhoneNo.TabIndex = 6;
            lblPhoneNo.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.White;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.ForeColor = Color.Gray;
            lblEmail.Location = new Point(540, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(386, 263);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lblConPassword
            // 
            lblConPassword.AutoSize = true;
            lblConPassword.BackColor = Color.White;
            lblConPassword.Font = new Font("Segoe UI", 9F);
            lblConPassword.ForeColor = Color.Gray;
            lblConPassword.Location = new Point(539, 263);
            lblConPassword.Name = "lblConPassword";
            lblConPassword.Size = new Size(108, 15);
            lblConPassword.TabIndex = 9;
            lblConPassword.Text = "Conform Password";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 433);
            Controls.Add(lblConPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneNo);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(signupPicBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)signupPicBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox signupPicBox;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNo;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConPassword;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtConPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAlreadyAccount;
        private LinkLabel lblLogin;
    }
}