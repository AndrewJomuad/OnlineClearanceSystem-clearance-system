using OnlineClearanceSystem.Data;
using OnlineClearanceSystem.Models;

namespace OnlineClearanceSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User? user = DbHelper.GetUserByUsername(username);
            if (user != null && user.Password == password)
            {
                Session.CurrentUser = user;
                DbHelper.LogActivity(user.Id, "Login", $"{user.FullName} logged in");

                if (user.Role == "Admin")
                {
                    new AdminForm().Show();
                }
                else if (user.Role == "Student")
                {
                    new Dashboard().Show();
                }
                else
                {
                    new ApprovalForm().Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }
    }
}