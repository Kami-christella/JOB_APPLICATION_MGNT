using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Job_Application
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Connection string for your database
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2042M6B\\SQLEXPRESS;Initial Catalog=Job_application_db;Integrated Security=True;TrustServerCertificate=True");

            // SQL query to select all applicants from the Application table
            String query = "SELECT * FROM Application";

            try
            {
                // Open connection
                conn.Open();

                // Create the SqlDataAdapter to execute the query and fill the DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                // Fill the DataTable with the query result
                adapter.Fill(dataTable);

                // Bind the data to the DataGridView control
                dataGridView1.DataSource = dataTable;

                MessageBox.Show("Applicants listed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Optional: You can load the applicants automatically when the form loads
            // button5_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
