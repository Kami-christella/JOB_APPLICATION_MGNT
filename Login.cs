using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Job_Application
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash returns a byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string of hexadecimal digits
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Convert each byte to hex
                }
                return builder.ToString();
            }
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            String NamesOrId = IDorNamesTXT.Text.Trim();
            String password = passwordTXT.Text.Trim();
            String Role = roleCOMBO.Text.Trim();
            String hashedPassword = HashPassword(password);


            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2042M6B\\SQLEXPRESS;Initial Catalog=Job_application_db;Integrated Security=True;TrustServerCertificate=True");
            string query = "SELECT COUNT(1) FROM Users WHERE Names = @NamesOrId AND password = @password AND Role=@Role";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NamesOrId", NamesOrId);
            cmd.Parameters.AddWithValue("@Role", Role);
            cmd.Parameters.AddWithValue("@password", hashedPassword);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (count == 1 && Role == "Admin")
            {
                MessageBox.Show("Login Successfull");

                AdminDashboard admin = new AdminDashboard();
                this.Hide();
                admin.Show();
            }
            else if (count == 1 && Role == "Applicant")
            {
                MessageBox.Show("Login Successfull");

                ApplicationForm land = new ApplicationForm();
                this.Hide();
                land.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Credentials");
            }
        }
    }
}
