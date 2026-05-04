using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UniversityPortalApp
{
    public partial class HistoryUC : UserControl
    {
        // Use your specific database path
        private readonly string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Andrew\Desktop\APPSDEV 0909\UniversityPortalApp\DatabaseFinal.accdb";

        public HistoryUC()
        {
            InitializeComponent();
            LoadActivityLogs();
        }

        private void LoadActivityLogs()
        {
            try
            {
                using OleDbConnection conn = new(connString);

                // Matches the columns exactly as seen in image_84829d.png
                // Brackets [] are required for 'STUDENT ID' and 'Date Created' because they contain spaces
                string query = "SELECT [LogID], [STUDENT ID], [Action], [Description], [Date Created] FROM [ACTIVITYLOGS]";

                OleDbDataAdapter adapter = new(query, conn);
                DataTable dt = new();

                adapter.Fill(dt);

                // Binds the database table to your DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs: " + ex.Message);
            }
        }
    }
}