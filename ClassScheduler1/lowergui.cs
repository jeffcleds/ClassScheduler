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
    public partial class lowergui : Form
    {
        public lowergui()
        {
            InitializeComponent();
            LoadData();
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



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Log out?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }
    }
}
