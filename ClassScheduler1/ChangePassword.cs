using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassScheduler1
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string currentPassword = currentPWTB.Text;
            string newPassword = newPWTB.Text;
            string confirmNewPassword = confirmPWTB.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return;
            }


            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Verify current password
                    string query = "SELECT COUNT(*) FROM adminTB WHERE username = 'Higheradmin' AND password = @currentPassword";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@currentPassword", currentPassword);

                        int userCount = (int)cmd.ExecuteScalar();
                        if (userCount == 0)
                        {
                            MessageBox.Show("Current password is incorrect.");
                            return;
                        }
                    }

                    // Update password
                    query = "UPDATE adminTB SET password = @newPassword WHERE username = 'Higheradmin'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Password changed successfully.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
