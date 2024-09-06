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
        public InstructorsForm()
        {
            InitializeComponent();
            LoadData();
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
        }

        private void label2_Click(object sender, EventArgs e)
        {
            addInstructorPNL.Visible = !addInstructorPNL.Visible;
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

            this.Close();
        }


    }

    
}
