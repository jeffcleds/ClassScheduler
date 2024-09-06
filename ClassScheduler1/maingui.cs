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
using static ClassScheduler1.Login;

namespace ClassScheduler1
{
    public partial class maingui : Form
    {
        private int selectedEmployeeNo; //para sa pagselect ning rows.

        public maingui()
        {
            InitializeComponent();
            LoadData();
            timer1.Start(); //to move the text

            dataGridView1.CellClick += dataGridView1_CellClick; //para sa pagselect ning rows.
        }

        private void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = @"
                SELECT * FROM ConsolidatedData";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e) //close button can't rename dunno why
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e) //add button can't rename dunno why
        {
            //CreateSchedule createScheduleForm = new CreateSchedule(); || tigribayan ko ning bago
            //createScheduleForm.ShowDialog();
            AddDataForm addDataForm = new AddDataForm();
            addDataForm.Owner = this;
            addDataForm.ShowDialog();
        }

        public void RefreshDataGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = "SELECT * FROM ConsolidatedData";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AddDataForm addDataForm = new AddDataForm();
            addDataForm.Owner = this;
            addDataForm.ShowDialog();
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeNo > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?",
                    "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteRow(selectedEmployeeNo);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                var cellValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                if (cellValue != null && !string.IsNullOrEmpty(cellValue.ToString()))
                {
                    selectedEmployeeNo = Convert.ToInt32(cellValue);
                }
                else
                {
                    //para dae mag error pag blank cell ang naselect
                }
            }
        }


        private void DeleteRow(int employeeNo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = "DELETE FROM ConsolidatedData WHERE EmployeeNo = @EmployeeNo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeNo", employeeNo);

                connection.Open();
                command.ExecuteNonQuery();
            }

            RefreshDataGridView();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //edit button
        {
            EditDataForm editDataForm = new EditDataForm();
            editDataForm.Owner = this;
            editDataForm.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeNo > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DeleteRow(selectedEmployeeNo);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            EditDataForm editDataForm = new EditDataForm();
            editDataForm.Owner = this;
            editDataForm.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e) //settings
        {
            settingsPanel.Visible = !settingsPanel.Visible;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
        }

        private void settingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) //pangmove ning text
        {
            timeLabel.Text = "Welcome to Class Scheduler by BSIT 3B. " +
                "The time and day is brought to you by: STI College Naga: " + DateTime.Now.ToString("dddd, MMMM dd, yyyy hh:mm:ss tt");

            timeLabel.Left -= 2;

            if (timeLabel.Right < 0)
            {

                timeLabel.Left = this.ClientSize.Width;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxProfile.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void label11_Click(object sender, EventArgs e) //change password
        {
            ChangePassword changePasswordForm = new ChangePassword();
            changePasswordForm.Owner = this;
            changePasswordForm.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BS IT - 3B Standalone " +
                "Creators:\nErnie Joseph Cledera" +
                "\nCherry Mea Chan" +
                "\nAllan Aboga-a Jr." +
                "\nGerald Bernisca" +
                "\nJoseph Bino" +
                "\nMelchizedec King Sanchez" +
                "\nJoshua Gamora" +
                "\nOwen Christian Robas" +
                "\nRic Francis Oliva" +
                "\nCogie Ricafort" +
                "\n\n To be Submitted to:" +
                "\n Sebastian Joshua De Leon");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }



        private string GetCurrentLoggedInUsername()
        {
            string username = UserSession.CurrentUsername;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username is not set in the session.");
            }
            return username;
        }


        private void label15_Click(object sender, EventArgs e) // Delete account
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this account?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string currentUsername = GetCurrentLoggedInUsername(); // Get the current logged-in username

                if (string.IsNullOrEmpty(currentUsername))
                {
                    MessageBox.Show("No user is currently logged in.");
                    return;
                }

                string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
                string query = "DELETE FROM adminTB WHERE Username = @Username";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Username", currentUsername);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();



                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Your account has been deleted successfully.");
                            UserSession.CurrentUsername = null;
                            this.Close();
                            Login loginForm = new Login();
                            loginForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("No account found with the specified username.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the account: " + ex.Message);
                }
            }
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            settingsPanel.Visible = false;
        }

        private void label16_Click_1(object sender, EventArgs e)
        {
            InstructorsForm instructorsForm = new InstructorsForm();
            instructorsForm.Owner = this;
            instructorsForm.ShowDialog();
        }
    }

}

