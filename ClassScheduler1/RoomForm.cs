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
    public partial class RoomForm : Form
    {
        string selectedRoomNo;
        public RoomForm()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.CellClick += dataGridView1_CellClick;
            this.dataGridView2.CellClick += new DataGridViewCellEventHandler(this.dataGridView2_CellClick);
        }

        private void LoadData() //pag open kang data kang mga nasa instructors table
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = @"
                SELECT * FROM Room";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView2.DataSource = dataTable;
            }
        }
        public void RefreshDataGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = "SELECT * FROM Room"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView2.DataSource = dataTable;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void closePB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            addRoomPNL.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            addRoomPNL.Visible = !addRoomPNL.Visible;
            if (addRoomPNL.Visible)
            {
                editRoomPNL.Visible = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            addRoomPNL.Visible = !addRoomPNL.Visible;
            if (addRoomPNL.Visible)
            {
                editRoomPNL.Visible = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string roomNo = txtRoomNo.Text;
                string roomName = txtRoomName.Text;
                int roomCapacity;
                if (!int.TryParse(txtRoomCapacity.Text, out roomCapacity))
                {
                    MessageBox.Show("Please enter a valid room capacity.");
                    return;
                }
                string floor = txtRoomFloor.Text;

                string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
                string query = @"INSERT INTO Room (RoomNo, RoomName, RoomCapacity, Floor) 
                                 VALUES (@RoomNo, @RoomName, @RoomCapacity, @Floor)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RoomNo", roomNo);
                    command.Parameters.AddWithValue("@RoomName", roomName);
                    command.Parameters.AddWithValue("@RoomCapacity", roomCapacity);
                    command.Parameters.AddWithValue("@Floor", floor);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                RefreshDataGridView();
                MessageBox.Show("Room successfully added.");
                RefreshDataGridView();
                addRoomPNL.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void editCancelBtn_Click(object sender, EventArgs e)
        {
            editRoomPNL.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            editRoomPNL.Visible = !editRoomPNL.Visible;
            addRoomPNL.Visible = false;

        }

        private void InstructorsForm_Load(object sender, EventArgs e)
        {
            addRoomPNL.Visible = false;
            editRoomPNL.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            editRoomPNL.Visible = !editRoomPNL.Visible;
            addRoomPNL.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Get the RoomNo value as a string
                selectedRoomNo = selectedRow.Cells["RoomNo"].Value?.ToString();

                if (string.IsNullOrEmpty(selectedRoomNo))
                {
                    MessageBox.Show("The selected row does not have a valid RoomNo.");
                    selectedRoomNo = null; // Or handle accordingly
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEdtRoomNo.Text) ||
                string.IsNullOrEmpty(txtEdtRoomName.Text) ||
                string.IsNullOrEmpty(txtEdtRoomCapacity.Text) ||
                string.IsNullOrEmpty(txtEdtRoomFloor.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string oldRoomNo = txtRoomNo.Text.Trim(); // The original RoomNo before editing
            string newRoomNo = txtEdtRoomNo.Text.Trim(); // The new RoomNo
            string roomName = txtEdtRoomName.Text;
            int roomCapacity;
            if (!int.TryParse(txtEdtRoomCapacity.Text, out roomCapacity))
            {
                MessageBox.Show("Invalid room capacity.");
                return;
            }
            string floor = txtEdtRoomFloor.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;

            // Check if the new RoomNo already exists
            string checkQuery = "SELECT COUNT(*) FROM Room WHERE RoomNo = @NewRoomNo";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@NewRoomNo", newRoomNo);
                connection.Open();
                int count = (int)checkCommand.ExecuteScalar();
                if (count > 0 && oldRoomNo != newRoomNo)
                {
                    MessageBox.Show("The new RoomNo already exists. Please choose a different RoomNo.");
                    return;
                }
            }

            string updateQuery = @"UPDATE Room 
                           SET RoomNo = @NewRoomNo, 
                               RoomName = @RoomName, 
                               RoomCapacity = @RoomCapacity, 
                               Floor = @Floor 
                           WHERE RoomNo = @OldRoomNo";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@NewRoomNo", newRoomNo);
                    command.Parameters.AddWithValue("@RoomName", roomName);
                    command.Parameters.AddWithValue("@RoomCapacity", roomCapacity);
                    command.Parameters.AddWithValue("@Floor", floor);
                    command.Parameters.AddWithValue("@OldRoomNo", oldRoomNo);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"Rows affected: {rowsAffected}");

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully updated.");
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Please check the RoomNo.");
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                txtEdtRoomNo.Text = selectedRow.Cells["RoomNo"].Value.ToString();
                txtEdtRoomName.Text = selectedRow.Cells["RoomName"].Value.ToString();
                txtEdtRoomCapacity.Text = selectedRow.Cells["RoomCapacity"].Value.ToString();
                txtEdtRoomFloor.Text = selectedRow.Cells["Floor"].Value.ToString();
            }
        }


        private void pictureBox4_Click(object sender, EventArgs e) // delete button
        {
            HandleDelete();
        }

        private void label4_Click(object sender, EventArgs e) // delete button
        {
            HandleDelete();
        }

        private void HandleDelete()
        {
            if (!string.IsNullOrEmpty(selectedRoomNo))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this room?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteRoom(selectedRoomNo); // Pass roomNo as a string
                }
            }
            else
            {
                MessageBox.Show("Please select a room to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteRoom(string roomNo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = "DELETE FROM Room WHERE RoomNo = @RoomNo";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RoomNo", roomNo); // Treat roomNo as a string

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                RefreshDataGridView();
                MessageBox.Show("Room successfully deleted.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the room: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            HandleDelete();
        }
    }
}

