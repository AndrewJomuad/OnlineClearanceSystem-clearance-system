namespace UniversityPortalApp
{
    partial class RegisterForm
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
            mainPanel = new Panel();
            cardPanel = new Panel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtCourse = new TextBox();
            txtFullName = new TextBox();
            label1 = new Label();
            cboYearLevel = new ComboBox();
            headerLabel = new Label();
            registerButton = new Button();
            backToLoginLabel = new LinkLabel();
            titleLabel = new Label();
            txtYearLevel = new TextBox();
            RoleTxT = new TextBox();
            mainPanel.SuspendLayout();
            cardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(30, 90, 170);
            mainPanel.Controls.Add(cardPanel);
            mainPanel.Controls.Add(titleLabel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(450, 650);
            mainPanel.TabIndex = 0;
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.White;
            cardPanel.Controls.Add(RoleTxT);
            cardPanel.Controls.Add(txtPassword);
            cardPanel.Controls.Add(txtUsername);
            cardPanel.Controls.Add(txtCourse);
            cardPanel.Controls.Add(txtFullName);
            cardPanel.Controls.Add(label1);
            cardPanel.Controls.Add(cboYearLevel);
            cardPanel.Controls.Add(headerLabel);
            cardPanel.Controls.Add(registerButton);
            cardPanel.Controls.Add(backToLoginLabel);
            cardPanel.Location = new Point(50, 53);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(350, 568);
            cardPanel.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(28, 254);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(290, 27);
            txtPassword.TabIndex = 20;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(28, 192);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(290, 27);
            txtUsername.TabIndex = 18;
            // 
            // txtCourse
            // 
            txtCourse.Font = new Font("Segoe UI", 11F);
            txtCourse.Location = new Point(28, 133);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(290, 27);
            txtCourse.TabIndex = 16;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11F);
            txtFullName.Location = new Point(30, 79);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(290, 27);
            txtFullName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 367);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 10;
            label1.Text = "Year Level";
            // 
            // cboYearLevel
            // 
            cboYearLevel.FormattingEnabled = true;
            cboYearLevel.Items.AddRange(new object[] { "1st Year", "2nd Year", "3rd Year", "4th Year" });
            cboYearLevel.Location = new Point(30, 397);
            cboYearLevel.Name = "cboYearLevel";
            cboYearLevel.Size = new Size(290, 23);
            cboYearLevel.TabIndex = 9;
            // 
            // headerLabel
            // 
            headerLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            headerLabel.ForeColor = Color.FromArgb(20, 40, 80);
            headerLabel.Location = new Point(30, 7);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(290, 40);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Create an account";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(30, 90, 170);
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(30, 471);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(290, 45);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += RegisterButton_Click;
            // 
            // backToLoginLabel
            // 
            backToLoginLabel.Font = new Font("Segoe UI", 10F);
            backToLoginLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            backToLoginLabel.LinkColor = Color.FromArgb(30, 90, 170);
            backToLoginLabel.Location = new Point(30, 519);
            backToLoginLabel.Name = "backToLoginLabel";
            backToLoginLabel.Size = new Size(290, 30);
            backToLoginLabel.TabIndex = 6;
            backToLoginLabel.TabStop = true;
            backToLoginLabel.Text = "Already have an account? Login";
            backToLoginLabel.TextAlign = ContentAlignment.MiddleCenter;
            backToLoginLabel.LinkClicked += BackToLoginLabel_LinkClicked;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(450, 60);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "UNIVERSITY PORTAL";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtYearLevel
            // 
            txtYearLevel.Location = new Point(0, 0);
            txtYearLevel.Name = "txtYearLevel";
            txtYearLevel.Size = new Size(100, 23);
            txtYearLevel.TabIndex = 0;
            // 
            // RoleTxT
            // 
            RoleTxT.Font = new Font("Segoe UI", 11F);
            RoleTxT.Location = new Point(28, 311);
            RoleTxT.Name = "RoleTxT";
            RoleTxT.Size = new Size(290, 27);
            RoleTxT.TabIndex = 21;
            RoleTxT.TextChanged += RoleTxT_TextChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 650);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "University Portal - Create Account";
            mainPanel.ResumeLayout(false);
            cardPanel.ResumeLayout(false);
            cardPanel.PerformLayout();
            ResumeLayout(false);
        }

        // CORRECTED DECLARATIONS
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.LinkLabel backToLoginLabel;
        private System.Windows.Forms.ComboBox cboYearLevel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtYearLevel;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private TextBox RoleTxT;
    }
}