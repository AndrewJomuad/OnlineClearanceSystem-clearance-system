using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UniversityPortalApp
{
    public partial class LoginForm : Form
    {
        // Path to your database
        private readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Andrew\Desktop\APPSDEV 0909\UniversityPortalApp\DatabaseFinal.accdb;";

        public LoginForm()
        {
            InitializeComponent();
            SetupPlaceholders();
        }

        private void SetupPlaceholders()
        {
            usernameTextBox.Text = "Username";
            usernameTextBox.ForeColor = Color.Gray;
            passwordTextBox.Text = "Password";
            passwordTextBox.ForeColor = Color.Gray;
            passwordTextBox.PasswordChar = '\0';

            usernameTextBox.Enter += (s, e) =>
            {
                if (usernameTextBox.Text == "Username")
                {
                    usernameTextBox.Text = "";
                    usernameTextBox.ForeColor = Color.Black;
                }
            };

            usernameTextBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
                {
                    usernameTextBox.Text = "Username";
                    usernameTextBox.ForeColor = Color.Gray;
                }
            };

            passwordTextBox.Enter += (s, e) =>
            {
                if (passwordTextBox.Text == "Password")
                {
                    passwordTextBox.Text = "";
                    passwordTextBox.ForeColor = Color.Black;
                    passwordTextBox.PasswordChar = '●';
                }
            };

            passwordTextBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                {
                    passwordTextBox.Text = "Password";
                    passwordTextBox.ForeColor = Color.Gray;
                    passwordTextBox.PasswordChar = '\0';
                }
            };
        }

        private void CreateAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm register = new(); // Simplified 'new' (IDE0090)
            register.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "Username" || passwordTextBox.Text == "Password" || string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Simplified 'using' (IDE0063) and 'new' (IDE0090)
                using var conn = new OleDbConnection(connectionString);
                conn.Open();

                string query = "SELECT [Auto Genarate ID number], Fullname FROM [User] WHERE Username = ? AND [Password] = ?";

                using var cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("?", usernameTextBox.Text.Trim());
                cmd.Parameters.AddWithValue("?", passwordTextBox.Text.Trim());

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string fullName = reader["Fullname"].ToString() ?? "Student";
                    int rawID = Convert.ToInt32(reader["Auto Genarate ID number"]);
                    string formattedID = "STUDENT-" + rawID.ToString("D2");

                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    // Simplified 'new' (IDE0090) and passing required parameters
                    MainDashboardForm dashboard = new(fullName, formattedID);
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}