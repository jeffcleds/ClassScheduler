using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ClassScheduler1
{

    public partial class Login : Form
    {
        // NOTES: Pag malaag ning login sa query, INSERT INTO adminTB (Username, Password, Role) VALUES ('aliceguo', 'guo12345', 'Higher Admin');
        // Pag ma check man, SELECT * FROM adminTB

        private string data;
        private int length = 0;

        public Login()
        {

            InitializeComponent();
            timer1.Interval = 50; // Set the interval to 100ms or as needed
            timer1.Tick += new EventHandler(timer1_Tick);
            data = "Class Scheduler";
            label1.Text = "";
            timer1.Start();



            this.AcceptButton = loginBtn; //pang select ning enter button para mag direct login without clicking
            passwordTB.PasswordChar = '*'; //pang hide password
        }

        public static class UserSession
        {
            public static string CurrentUsername { get; set; }
        }

        private bool ValidateUser(string username, string password, out string role) //pang validate password
        {
            bool isValid = false;
            role = null;

            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = "SELECT Role FROM adminTB WHERE Username = @username AND Password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        isValid = true;
                        role = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return isValid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string password = passwordTB.Text;
            string role;

            if (ValidateUser(username, password, out role))
            {
                MessageBox.Show("Login successful!");
                UserSession.CurrentUsername = username;

                if (role == "Higher Admin")
                {
                    // Open Higher Admin maingui.cs
                    maingui higherAdminForm = new maingui();
                    higherAdminForm.Show();

                }
                else if (role == "Lower Admin")
                {
                    // Open Lower Admin lowergui.cs
                    lowermaingui lowerAdminForm = new lowermaingui();
                    lowerAdminForm.Show();
                }
                this.Hide(); //pang close ng login form after successful attempt
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void label4_Click(object sender, EventArgs e) //forgot password label
        {
            MessageBox.Show("Please contact admin for account retrieval.\n cledera.279466@naga.sti.edu.ph"); //emerut lang
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e) //close button
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit Class Scheduler?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label4_Click_1(object sender, EventArgs e) //about button
        {
            MessageBox.Show("BS IT - 3B Standalone " +
                "Creators:\nErnie Joseph Cledera" +
                "\nCherry Mea Chan" +
                "\nAllan Aboga-a Jr." +
                "\nChrystian Festin" +
                "\nGerald Bernisca" +
                "\nJoseph Bino" +
                "\nMelchizedec King Sanchez" +
                "\nJoshua Gamora" +
                "\nOwen Christian Robas" +
                "\nRic Francis Oliva" +
                "\nCogie Ricafort");
        }


        private void timer1_Tick(object sender, EventArgs e) //pang move ning text
        {
             if (length < data.Length)
            {
                label1.Text += data[length];
                length++;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

