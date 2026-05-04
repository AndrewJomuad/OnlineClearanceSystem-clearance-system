namespace UniversityPortalApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cardPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.loginHeaderLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.forgotPasswordLabel = new System.Windows.Forms.LinkLabel();
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccountLabel = new System.Windows.Forms.LinkLabel();
            this.mainPanel.SuspendLayout();
            this.cardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.mainPanel.Controls.Add(this.cardPanel);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(450, 600);
            this.mainPanel.TabIndex = 0;
            // 
            // cardPanel
            // 
            this.cardPanel.BackColor = System.Drawing.Color.White;
            this.cardPanel.Controls.Add(this.loginHeaderLabel);
            this.cardPanel.Controls.Add(this.usernameTextBox);
            this.cardPanel.Controls.Add(this.passwordTextBox);
            this.cardPanel.Controls.Add(this.rememberMeCheckBox);
            this.cardPanel.Controls.Add(this.forgotPasswordLabel);
            this.cardPanel.Controls.Add(this.loginButton);
            this.cardPanel.Controls.Add(this.createAccountLabel);
            this.cardPanel.Location = new System.Drawing.Point(50, 100);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(350, 420);
            this.cardPanel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(450, 80);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "UNIVERSITY PORTAL LOGIN";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginHeaderLabel
            // 
            this.loginHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.loginHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.loginHeaderLabel.Location = new System.Drawing.Point(30, 30);
            this.loginHeaderLabel.Name = "loginHeaderLabel";
            this.loginHeaderLabel.Size = new System.Drawing.Size(290, 40);
            this.loginHeaderLabel.TabIndex = 0;
            this.loginHeaderLabel.Text = "Student Login";
            this.loginHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.usernameTextBox.Location = new System.Drawing.Point(30, 90);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(290, 27);
            this.usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.passwordTextBox.Location = new System.Drawing.Point(30, 140);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(290, 27);
            this.passwordTextBox.TabIndex = 2;
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rememberMeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.rememberMeCheckBox.Location = new System.Drawing.Point(30, 195);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(120, 25);
            this.rememberMeCheckBox.TabIndex = 3;
            this.rememberMeCheckBox.Text = "Remember Me";
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.forgotPasswordLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotPasswordLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.forgotPasswordLabel.Location = new System.Drawing.Point(190, 195);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(130, 25);
            this.forgotPasswordLabel.TabIndex = 4;
            this.forgotPasswordLabel.TabStop = true;
            this.forgotPasswordLabel.Text = "Forgot Password?";
            this.forgotPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(30, 240);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(290, 45);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.createAccountLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.createAccountLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.createAccountLabel.Location = new System.Drawing.Point(30, 350);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(290, 30);
            this.createAccountLabel.TabIndex = 6;
            this.createAccountLabel.TabStop = true;
            this.createAccountLabel.Text = "Create an account";
            this.createAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccountLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Portal Login";
            this.mainPanel.ResumeLayout(false);
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label loginHeaderLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.LinkLabel forgotPasswordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.LinkLabel createAccountLabel;
    }
}
