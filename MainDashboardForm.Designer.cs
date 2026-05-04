namespace UniversityPortalApp
{
    partial class MainDashboardForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblWelcome = new Label();
            lblStudentID = new Label();
            button1 = new Button();
            pnlTop = new Panel();
            lblTitle = new Label();
            pnlSidebar = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            pnlContent = new Panel();
            pnlTop.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Navy;
            lblWelcome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(435, 23);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(115, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Name";
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.BackColor = Color.Navy;
            lblStudentID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentID.ForeColor = Color.White;
            lblStudentID.Location = new Point(634, 26);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(20, 17);
            lblStudentID.TabIndex = 1;
            lblStudentID.Text = "ID";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(8, 336);
            button1.Name = "button1";
            button1.Size = new Size(200, 45);
            button1.TabIndex = 2;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.Navy;
            pnlTop.Controls.Add(lblStudentID);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(lblWelcome);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 60);
            pnlTop.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Franklin Gothic Medium Cond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(29, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "University Clearance Portal";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.DarkSlateBlue;
            pnlSidebar.Controls.Add(button5);
            pnlSidebar.Controls.Add(button4);
            pnlSidebar.Controls.Add(button3);
            pnlSidebar.Controls.Add(button2);
            pnlSidebar.Controls.Add(button1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 60);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(224, 390);
            pnlSidebar.TabIndex = 4;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(8, 6);
            button5.Name = "button5";
            button5.Size = new Size(200, 45);
            button5.TabIndex = 6;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(8, 89);
            button4.Name = "button4";
            button4.Size = new Size(200, 45);
            button4.TabIndex = 5;
            button4.Text = "Subject";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(10, 173);
            button3.Name = "button3";
            button3.Size = new Size(200, 45);
            button3.TabIndex = 4;
            button3.Text = "Clearance";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(8, 258);
            button2.Name = "button2";
            button2.Size = new Size(200, 45);
            button2.TabIndex = 3;
            button2.Text = "History";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Button2_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(224, 60);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(576, 390);
            pnlContent.TabIndex = 5;
            // 
            // MainDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlTop);
            Name = "MainDashboardForm";
            Text = "MainDashboardForm";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Button button1;
        private Panel pnlTop;
        private Panel pnlSidebar;
        private Label lblTitle;
        private Panel pnlContent;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}