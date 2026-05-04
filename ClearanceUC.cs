using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace UniversityPortalApp
{
    public partial class ClearanceUC : UserControl
    {
        // Connection string for your Access database
        private readonly string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Andrew\Desktop\APPSDEV 0909\UniversityPortalApp\DatabaseFinal.accdb";

        public ClearanceUC()
        {
            InitializeComponent();
        }

        // We use Button1_Click because that is likely what the Designer is linked to
        private void Button1_Click(object sender, EventArgs e)
        {
            // 1. Validation for SubjectTXT and EDPTXT
            if (string.IsNullOrWhiteSpace(SubjectTXT.Text) || string.IsNullOrWhiteSpace(EDPTXT.Text))
            {
                MessageBox.Show("Please fill in both the Subject and EDP Code.");
                return;
            }

            try
            {
                // 2. Establish Connection
                using OleDbConnection conn = new(connString);
                conn.Open();

                // 3. SQL Insert Query matching columns in image_840b58.png
                string query = "INSERT INTO [Clearance] ([Username], [Subject], [Status], [Remarks], [DateSubmitted]) " +
                               "VALUES (?, ?, ?, ?, ?)";

                using OleDbCommand cmd = new(query, conn);

                // 4. Map parameters to the '?' placeholders
                cmd.Parameters.AddWithValue("@Username", "Andrew"); // Updated based on image_83fb80.png
                cmd.Parameters.AddWithValue("@Subject", SubjectTXT.Text);
                cmd.Parameters.AddWithValue("@Status", "Pending");

                // Store EDP Code in Remarks since it's not a separate column in your table
                cmd.Parameters.AddWithValue("@Remarks", "EDP Code: " + EDPTXT.Text);

                cmd.Parameters.AddWithValue("@DateSubmitted", DateTime.Now.ToShortDateString());

                // 5. Execute the command
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Clearance request for {SubjectTXT.Text} submitted successfully!");

                // 6. Reset the form
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            SubjectTXT.Clear();
            EDPTXT.Clear();
            // If you have a Units text box named UnitsTXT:
            // UnitsTXT.Clear(); 
        }
    }
}