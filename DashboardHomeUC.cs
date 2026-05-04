using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UniversityPortalApp
{
    public partial class DashboardHomeUC : UserControl
    {
        private readonly string _connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Andrew\Desktop\APPSDEV 0909\UniversityPortalApp\DatabaseFinal.accdb;";
        private readonly string _currentUsername;

        public DashboardHomeUC(string username)
        {
            InitializeComponent();
            _currentUsername = username ?? "Andrew";
        }

        private void DashboardHomeUC_Load(object sender, EventArgs e)
        {
            LoadDashboardGrid();
        }

        public void LoadDashboardGrid()
        {
            try
            {
                // IDE0063 & IDE0090: Simplified 'using' and 'new'
                using OleDbConnection conn = new(_connString);
                string query = "SELECT ClearanceID, Subject, Status, Remarks, DateSubmitted FROM Clearance WHERE Username = ?";

                using OleDbCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("?", _currentUsername);
                conn.Open();

                using OleDbDataAdapter adapter = new(cmd);
                DataTable dt = new();
                adapter.Fill(dt);

                dgvRecentActivity.DataSource = dt;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }
        }

        private void FormatGrid()
        {
            if (dgvRecentActivity.Columns.Count > 0)
            {
                dgvRecentActivity.Columns["ClearanceID"].Visible = false;
                dgvRecentActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvRecentActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        // IDE1006: Renamed to satisfy naming rules (PascalCase)
        private void BtnApprove_Click(object sender, EventArgs e) => UpdateStatus("Approved");

        private void BtnReject_Click(object sender, EventArgs e) => UpdateStatus("Rejected");

        private void UpdateStatus(string newStatus)
        {
            if (dgvRecentActivity.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first!");
                return;
            }

            int id = Convert.ToInt32(dgvRecentActivity.SelectedRows[0].Cells["ClearanceID"].Value);

            try
            {
                using OleDbConnection conn = new(_connString);
                string query = "UPDATE Clearance SET Status = ? WHERE ClearanceID = ?";

                using OleDbCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("?", newStatus);
                cmd.Parameters.AddWithValue("?", id);

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Status updated to {newStatus}");
                LoadDashboardGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
        }
    }
}