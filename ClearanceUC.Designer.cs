namespace UniversityPortalApp
{
    partial class ClearanceUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            SubjectTXT = new TextBox();
            EDPTXT = new TextBox();
            unitTXT = new TextBox();
            Subject = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 34);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Submit Clearance Request";
            // 
            // button1
            // 
            button1.Location = new Point(136, 249);
            button1.Name = "button1";
            button1.Size = new Size(102, 28);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // SubjectTXT
            // 
            SubjectTXT.Location = new Point(140, 96);
            SubjectTXT.Name = "SubjectTXT";
            SubjectTXT.Size = new Size(100, 23);
            SubjectTXT.TabIndex = 3;
            // 
            // EDPTXT
            // 
            EDPTXT.Location = new Point(138, 144);
            EDPTXT.Name = "EDPTXT";
            EDPTXT.Size = new Size(100, 23);
            EDPTXT.TabIndex = 4;
            // 
            // unitTXT
            // 
            unitTXT.Location = new Point(140, 191);
            unitTXT.Name = "unitTXT";
            unitTXT.Size = new Size(100, 23);
            unitTXT.TabIndex = 5;
            // 
            // Subject
            // 
            Subject.AutoSize = true;
            Subject.Location = new Point(75, 99);
            Subject.Name = "Subject";
            Subject.Size = new Size(46, 15);
            Subject.TabIndex = 6;
            Subject.Text = "Subject";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 152);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 7;
            label2.Text = "EDP CODE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 199);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 8;
            label3.Text = "Units";
            // 
            // ClearanceUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Subject);
            Controls.Add(unitTXT);
            Controls.Add(EDPTXT);
            Controls.Add(SubjectTXT);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ClearanceUC";
            Size = new Size(443, 321);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox SubjectTXT;
        private TextBox EDPTXT;
        private TextBox unitTXT;
        private Label Subject;
        private Label label2;
        private Label label3;
    }
}
