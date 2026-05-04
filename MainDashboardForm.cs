using System;
using System.Windows.Forms;

namespace UniversityPortalApp
{
    public partial class MainDashboardForm : Form
    {
        private readonly string _currentUserName;
        private readonly string _currentStudentID;

        public MainDashboardForm(string userName, string studentID)
        {
            InitializeComponent();

            _currentUserName = userName;
            _currentStudentID = studentID;

            lblWelcome.Text = $"Welcome, {_currentUserName}!";
            lblStudentID.Text = $"Student ID: {_currentStudentID}";

            // Initial load
            LoadControl(new DashboardHomeUC(_currentStudentID));
        }

        /// <summary>
        /// Centralized method to handle swapping UserControls.
        /// Calling Dispose() on the old control helps release database locks.
        /// </summary>
        private void LoadControl(UserControl uc)
        {
            if (pnlContent.Controls.Count > 0)
            {
                // Crucial: Dispose the old control to trigger its 'using' blocks 
                // and release any hung OleDb connections.
                pnlContent.Controls[0].Dispose();
            }

            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

        // --- Optimized Navigation Events ---

        private void BtnDashboard_Click(object sender, EventArgs e) => LoadControl(new DashboardHomeUC(_currentStudentID));

        private void BtnSubjects_Click(object sender, EventArgs e) => LoadControl(new SubjectsUC());

        private void BtnClearance_Click(object sender, EventArgs e) => LoadControl(new ClearanceUC());

        private void BtnHistory_Click(object sender, EventArgs e) => LoadControl(new HistoryUC());

        // Alternative Click Events (Buttons 2-5)
        private void Button5_Click(object sender, EventArgs e) => BtnDashboard_Click(sender, e);
        private void Button4_Click(object sender, EventArgs e) => BtnSubjects_Click(sender, e);
        private void Button3_Click(object sender, EventArgs e) => BtnClearance_Click(sender, e);
        private void Button2_Click(object sender, EventArgs e) => BtnHistory_Click(sender, e);

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Ensure we open a new login and close this one to release file locks
                LoginForm login = new();
                login.Show();
                this.Close();
            }
        }
    }
}