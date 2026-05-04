using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UniversityPortalApp
{
    public partial class RegisterForm : Form
    {
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Andrew\Desktop\APPSDEV 0909\UniversityPortalApp\DatabaseFinal.accdb;";

        public RegisterForm()
        {
            InitializeComponent();
            SetupPlaceholders();
        }

        private void SetupPlaceholders()
        {
            SetupPlaceholder(txtFullName, "Full Name");
            SetupPlaceholder(txtCourse, "Course");
            SetupPlaceholder(txtUsername, "Username");
            SetupPlaceholder(txtPassword, "Password", true);
            SetupPlaceholder(RoleTxT, "Student/Admin/Staff");
        }

        private static void SetupPlaceholder(TextBox tb, string placeholder, bool isPassword = false)
        {
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;
            if (isPassword) tb.PasswordChar = '\0';

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                    if (isPassword) tb.PasswordChar = '●';
                }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                    if (isPassword) tb.PasswordChar = '\0';
                }
            };
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Validation to ensure placeholders aren't saved
            if (txtFullName.Text == "Full Name" || txtUsername.Text == "Username" || RoleTxT.Text == "Student/Admin/Staff")
            {
                MessageBox.Show("Please fill out all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- FIX FOR CS0103: Using your ComboBox name 'cboYearLevel' ---
            int yearValue = 1;
            string selectedText = cboYearLevel.Text;

            if (selectedText.Contains("2nd")) yearValue = 2;
            else if (selectedText.Contains("3rd")) yearValue = 3;
            else if (selectedText.Contains("4th")) yearValue = 4;

            try
            {
                using OleDbConnection conn = new(connectionString);
                conn.Open();

                // SQL Query updated to match image_1d1d18.png
                // Table: [User] | Columns: Fullname, Username, [Password], [Year Lvl], Course, Role
                string query = "INSERT INTO [User] (Fullname, Username, [Password], [Year Lvl], Course, Role) VALUES (?, ?, ?, ?, ?, ?)";

                using OleDbCommand cmd = new(query, conn);

                // Parameters must be added in the exact order of the '?' marks
                cmd.Parameters.AddWithValue("?", txtFullName.Text);
                cmd.Parameters.AddWithValue("?", txtUsername.Text);
                cmd.Parameters.AddWithValue("?", txtPassword.Text);
                cmd.Parameters.AddWithValue("?", yearValue); // Integer for 'Year Lvl'
                cmd.Parameters.AddWithValue("?", txtCourse.Text);
                cmd.Parameters.AddWithValue("?", RoleTxT.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new LoginForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackToLoginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void RoleTxT_TextChanged(object sender, EventArgs e)
        {
            // Empty method to satisfy the Designer reference
        }
    }
}