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
    public partial class InstructorsForm : Form
    {
        private int selectedEmployeeNo;
        public InstructorsForm()
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
                SELECT * FROM Instructors";

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
            string query = "SELECT * FROM Instructors";

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
            addInstructorPNL.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            addInstructorPNL.Visible = !addInstructorPNL.Visible;
            if (addInstructorPNL.Visible)
            {
                editInstructorPNL.Visible = false;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            addInstructorPNL.Visible = !addInstructorPNL.Visible;
            if (addInstructorPNL.Visible)
            {
                editInstructorPNL.Visible = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int employeeNo = int.Parse(txtEmployeeNo.Text);
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            char mi = txtMI.Text[0];
            string department = txtDepartment.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = @"INSERT INTO Instructors
            (EmployeeNo, LastName, FirstName, MI, Department)
            VALUES (@EmployeeNo, @LastName, @FirstName, @MI, @Department)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeNo", employeeNo);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@MI", mi);
                command.Parameters.AddWithValue("@Department", department);
                connection.Open();
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Successfully added");
            RefreshDataGridView();
            addInstructorPNL.Visible = false;
        }

        private void editCancelBtn_Click(object sender, EventArgs e)
        {
            editInstructorPNL.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            editInstructorPNL.Visible = !editInstructorPNL.Visible;
            addInstructorPNL.Visible = false;

        }

        private void InstructorsForm_Load(object sender, EventArgs e)
        {
            addInstructorPNL.Visible = false;
            editInstructorPNL.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            editInstructorPNL.Visible = !editInstructorPNL.Visible;
            addInstructorPNL.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    // Check if the EmployeeNo column exists and has a value
                    if (selectedRow.Cells["EmployeeNo"].Value != null &&
                        !string.IsNullOrEmpty(selectedRow.Cells["EmployeeNo"].Value.ToString()))
                    {
                        selectedEmployeeNo = Convert.ToInt32(selectedRow.Cells["EmployeeNo"].Value);
                    }
                    else
                    {
                        // Reset selectedEmployeeNo if the cell is invalid or empty
                        selectedEmployeeNo = 0;
                        MessageBox.Show("The selected row does not have a valid EmployeeNo.");
                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Make sure all required fields are filled
            if (string.IsNullOrEmpty(txtEdtEmployeeNo.Text) ||
                string.IsNullOrEmpty(txtEdtLastName.Text) ||
                string.IsNullOrEmpty(txtEdtFirstName.Text) ||
                string.IsNullOrEmpty(txtEdtMI.Text) ||
                string.IsNullOrEmpty(txtEdtDepartment.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int employeeNo = int.Parse(txtEdtEmployeeNo.Text);
            string lastName = txtEdtLastName.Text;
            string firstName = txtEdtFirstName.Text;
            char mi = txtEdtMI.Text[0];
            string department = txtEdtDepartment.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = @"UPDATE Instructors 
                     SET LastName = @LastName, 
                         FirstName = @FirstName, 
                         MI = @MI, 
                         Department = @Department 
                     WHERE EmployeeNo = @EmployeeNo"; // Specify the record to update using EmployeeNo

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeNo", employeeNo);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@MI", mi);
                command.Parameters.AddWithValue("@Department", department);

                connection.Open(); // Open the connection
                command.ExecuteNonQuery(); // Execute the command
            }


            RefreshDataGridView();

            MessageBox.Show("Successfully updated");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];

                // Populate the textboxes with the selected row data using the correct column names
                txtEdtEmployeeNo.Text = selectedRow.Cells["EmployeeNo"].Value.ToString();
                txtEdtLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
                txtEdtFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
                txtEdtMI.Text = selectedRow.Cells["MI"].Value.ToString();
                txtEdtDepartment.Text = selectedRow.Cells["Department"].Value.ToString();
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
            if (selectedEmployeeNo > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteRow(selectedEmployeeNo);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteRow(int employeeNo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = "DELETE FROM Instructors WHERE EmployeeNo = @EmployeeNo";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeNo", employeeNo);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                RefreshDataGridView();
                MessageBox.Show("Record successfully deleted.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            HandleDelete();
        }
    }
}

