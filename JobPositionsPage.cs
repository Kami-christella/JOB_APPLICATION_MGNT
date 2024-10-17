using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application
{
    public partial class JobPositionsPage : Form
    {
        public JobPositionsPage()
        {
            InitializeComponent();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            String position = positionCombo.SelectedItem?.ToString();
            String description = descrTXT.Text.Trim();



            if (string.IsNullOrEmpty(position) && string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please insert value.");
                return;
            }



            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2042M6B\\SQLEXPRESS;Initial Catalog=Job_application_db;Integrated Security=True;TrustServerCertificate=True");
            String query = "INSERT INTO Job_positions (Position, Description) VALUES (@position, @description)";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@position", position);
            cmd.Parameters.AddWithValue("@description", description);

            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Position saved successfully!");
                //this.Hide();
                //Form1 lo = new Form1();
                //lo.Show();
            }
            else
            {
                MessageBox.Show("No data inserted.");
            }
        }
    }
}
