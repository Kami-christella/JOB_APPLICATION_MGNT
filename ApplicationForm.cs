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
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void applyBTN_Click(object sender, EventArgs e)
        {
            // Collect data from form fields
            String Email = emailTXT.Text.Trim();
            String Names = namesTXT.Text.Trim();
            String DOB = DOBTXT.Text.Trim();
            String Expertise = expertiseTXT.Text.Trim();
            String Experience = experienceTXT.Text.Trim();
            String Position = positionCOMBO.SelectedItem?.ToString();
            String Description = descrTXT.Text.Trim();

            // Convert Score and Semester to integers for comparison
            if (!int.TryParse(Experience, out int experienceValue))
            {
                MessageBox.Show("Invalid Number. Please enter a valid number.");
                return;
            }

            if (experienceValue <= 2)
            {
                MessageBox.Show("You are not allowed to apply!");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2042M6B\\SQLEXPRESS;Initial Catalog=Job_application_db;Integrated Security=True;TrustServerCertificate=True");
                String query = "INSERT INTO Application (Email,Names,DOB,Expertise,YearsExperience,Position, Description) VALUES (@Email, @Names,@DOB,@Expertise, @Experience,@Position,@Description)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Names", Names);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Expertise", Expertise);  // Use numeric value
                cmd.Parameters.AddWithValue("@Experience", Experience);        // Use numeric value
                cmd.Parameters.AddWithValue("@position", Position);
                cmd.Parameters.AddWithValue("@description", Description);

                // Execute query
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                // Check conditions based on score and semester

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Application saved successfully and your application is being reviewed, We will answer you shortly!!");
                }
                else
                {
                    MessageBox.Show("No data inserted.");
                }
            }
        }

        private void CancelApplication_Click(object sender, EventArgs e)
        {
            //  String SID = positionCombo.SelectedItem?.ToString();
            String Email = SearchEmailTXT.Text.Trim();



            //if (string.IsNullOrEmpty(position) && string.IsNullOrEmpty(description))
            //{
            //    MessageBox.Show("Please insert value.");
            //    return;
            //}



            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2042M6B\\SQLEXPRESS;Initial Catalog=Job_application_db;Integrated Security=True;TrustServerCertificate=True");
            String query = "Delete from  Application where Email=@Email";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", Email);

            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Application cancelled!");
                //this.Hide();
                //Form1 lo = new Form1();
                //lo.Show();
            }
            else
            {
                MessageBox.Show("Application not cancelled!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updateBTN_Click(object sender, EventArgs e)
        {

            // Collect data from form fields
            String Email = emailTXT.Text.Trim();
            String Names = namesTXT.Text.Trim();
            String DOB = DOBTXT.Text.Trim();
            String Expertise = expertiseTXT.Text.Trim();
            String Experience = experienceTXT.Text.Trim();
            String Position = positionCOMBO.SelectedItem?.ToString();
            String Description = descrTXT.Text.Trim();



            //String emailExists = "SELECT COUNT(1) FROM Application WHERE Email = @Email";

            if (!int.TryParse(Experience, out int experienceValue))
            {
                MessageBox.Show("Invalid Number. Please enter a valid number.");
                return;
            }

            if (experienceValue <= 2)
            {
                MessageBox.Show("You are not allowed to apply!");
            }
            else
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2042M6B\\SQLEXPRESS;Initial Catalog=Job_application_db;Integrated Security=True;TrustServerCertificate=True");
                String query = "UPDATE Application set Names=@Names, DOB=@DOB, Expertise=@Expertise, YearsExperience=@Experience, position=@position, description=@description where Email=@Email";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                // Add parameters
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Names", Names);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Expertise", Expertise);
                cmd.Parameters.AddWithValue("@Experience", Experience);
                cmd.Parameters.AddWithValue("@position", Position);
                cmd.Parameters.AddWithValue("@description", Description);

                // Execute query
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                // Check conditions based on score and semester

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Application updated successfully!!");
                }
                else
                {
                    MessageBox.Show("Put valid email please!!");
                }
            }
        }
    }
}
