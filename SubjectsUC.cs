using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UniversityPortalApp
{
    public partial class SubjectsUC : UserControl
    {
        // Connection string pointing to your specific local path
        private readonly string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Andrew\Desktop\APPSDEV 0909\UniversityPortalApp\DatabaseFinal.accdb";

        public SubjectsUC()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Opens connection and automatically closes it after use
                using OleDbConnection conn = new(connString);

                // FIXED: Changed 'Subjects' to 'Subject' to match image_e2f5b9.png
                // Using brackets [] ensures column names with spaces work correctly
                string query = "SELECT [EDP CODE], [SubjectName], [Units] FROM [Subject]";

                OleDbDataAdapter adapter = new(query, conn);
                DataTable dt = new();

                adapter.Fill(dt);

                // Bind the data to your grid named 'dataGridView2'
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                // This will catch path errors or table name mismatches
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
    }
}