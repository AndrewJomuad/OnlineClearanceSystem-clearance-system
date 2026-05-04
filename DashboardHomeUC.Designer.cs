namespace UniversityPortalApp
{
    partial class DashboardHomeUC
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
            pnlWelcome = new Panel();
            label1 = new Label();
            lblWelcome = new Label();
            pnlPending = new Panel();
            PendingTXT = new Label();
            pnlApproved = new Panel();
            ApproveTXT = new Label();
            pnlRejected = new Panel();
            RejectTXT = new Label();
            dgvRecentActivity = new DataGridView();
            pnlWelcome.SuspendLayout();
            pnlPending.SuspendLayout();
            pnlApproved.SuspendLayout();
            pnlRejected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivity).BeginInit();
            SuspendLayout();
            // 
            // pnlWelcome
            // 
            pnlWelcome.Controls.Add(label1);
            pnlWelcome.Controls.Add(lblWelcome);
            pnlWelcome.Location = new Point(1, 0);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(850, 100);
            pnlWelcome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 49);
            label1.Name = "label1";
            label1.Size = new Size(291, 30);
            label1.TabIndex = 2;
            label1.Text = "Track your clearance progress.";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(11, 11);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(115, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome Name";
            // 
            // pnlPending
            // 
            pnlPending.BorderStyle = BorderStyle.FixedSingle;
            pnlPending.Controls.Add(PendingTXT);
            pnlPending.Location = new Point(12, 102);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(139, 71);
            pnlPending.TabIndex = 1;
            // 
            // PendingTXT
            // 
            PendingTXT.AutoSize = true;
            PendingTXT.Location = new Point(18, 16);
            PendingTXT.Name = "PendingTXT";
            PendingTXT.Size = new Size(62, 30);
            PendingTXT.TabIndex = 0;
            PendingTXT.Text = "Pending\n Clearance";
            // 
            // pnlApproved
            // 
            pnlApproved.BorderStyle = BorderStyle.FixedSingle;
            pnlApproved.Controls.Add(ApproveTXT);
            pnlApproved.Location = new Point(167, 102);
            pnlApproved.Name = "pnlApproved";
            pnlApproved.Size = new Size(120, 71);
            pnlApproved.TabIndex = 2;
            // 
            // ApproveTXT
            // 
            ApproveTXT.AutoSize = true;
            ApproveTXT.Location = new Point(26, 31);
            ApproveTXT.Name = "ApproveTXT";
            ApproveTXT.Size = new Size(52, 15);
            ApproveTXT.TabIndex = 1;
            ApproveTXT.Text = "Approve\n";
            // 
            // pnlRejected
            // 
            pnlRejected.BorderStyle = BorderStyle.FixedSingle;
            pnlRejected.Controls.Add(RejectTXT);
            pnlRejected.Location = new Point(309, 102);
            pnlRejected.Name = "pnlRejected";
            pnlRejected.Size = new Size(120, 71);
            pnlRejected.TabIndex = 3;
            // 
            // RejectTXT
            // 
            RejectTXT.AutoSize = true;
            RejectTXT.Location = new Point(46, 31);
            RejectTXT.Name = "RejectTXT";
            RejectTXT.Size = new Size(39, 15);
            RejectTXT.TabIndex = 2;
            RejectTXT.Text = "Reject";
            // 
            // dgvRecentActivity
            // 
            dgvRecentActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentActivity.Dock = DockStyle.Bottom;
            dgvRecentActivity.Location = new Point(0, 293);
            dgvRecentActivity.Name = "dgvRecentActivity";
            dgvRecentActivity.Size = new Size(800, 157);
            dgvRecentActivity.TabIndex = 4;
            
            // 
            // DashboardHomeUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvRecentActivity);
            Controls.Add(pnlRejected);
            Controls.Add(pnlApproved);
            Controls.Add(pnlPending);
            Controls.Add(pnlWelcome);
            Name = "DashboardHomeUC";
            Size = new Size(800, 450);
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            pnlApproved.ResumeLayout(false);
            pnlApproved.PerformLayout();
            pnlRejected.ResumeLayout(false);
            pnlRejected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentActivity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlWelcome;
        private Label lblWelcome;
        private Label label1;
        private Panel pnlPending;
        private Label PendingTXT;
        private Panel pnlApproved;
        private Label ApproveTXT;
        private Panel pnlRejected;
        private Label RejectTXT;
        private DataGridView dgvRecentActivity;
    }
}