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
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int employeeNo = int.Parse(txtEmployeeNo.Text);
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            char mi = txtMI.Text[0];
            string department = txtDepartment.Text;

            string roomNo = txtRoomNo.Text;
            string roomName = txtRoomName.Text;
            int roomCapacity = int.Parse(txtRoomCapacity.Text);
            string floor = txtFloor.Text;

            TimeSpan time = TimeSpan.Parse(txtTime.Text);
            string meridiem = txtMeridiem.Text;

            int dayNo = int.Parse(txtDayNo.Text);
            string day = txtDay.Text;
            string status = txtStatus.Text;

            int courseID = int.Parse(txtCourseID.Text);
            string courseCode = txtCourseCode.Text;
            string courseSubject = txtCourseSubject.Text;

            string courseStrand = txtCourseStrand.Text;
            int yearLevel = int.Parse(txtYearLevel.Text);
            string section = txtSection.Text;

            // Insert into ConsolidatedData table
            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = @"INSERT INTO ConsolidatedData 
                    (EmployeeNo, LastName, FirstName, MI, Department, 
                    RoomNo, RoomName, RoomCapacity, Floor, 
                    Time, Meridiem, 
                    DayNo, Day, Status, 
                    CourseID, CourseCode, CourseSubject, 
                    CourseStrand, YearLevel, Section)
                    VALUES 
                    (@EmployeeNo, @LastName, @FirstName, @MI, @Department, 
                    @RoomNo, @RoomName, @RoomCapacity, @Floor, 
                    @Time, @Meridiem, 
                    @DayNo, @Day, @Status, 
                    @CourseID, @CourseCode, @CourseSubject, 
                    @CourseStrand, @YearLevel, @Section)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeNo", employeeNo);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@MI", mi);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@RoomNo", roomNo);
                command.Parameters.AddWithValue("@RoomName", roomName);
                command.Parameters.AddWithValue("@RoomCapacity", roomCapacity);
                command.Parameters.AddWithValue("@Floor", floor);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Meridiem", meridiem);
                command.Parameters.AddWithValue("@DayNo", dayNo);
                command.Parameters.AddWithValue("@Day", day);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@CourseID", courseID);
                command.Parameters.AddWithValue("@CourseCode", courseCode);
                command.Parameters.AddWithValue("@CourseSubject", courseSubject);
                command.Parameters.AddWithValue("@CourseStrand", courseStrand);
                command.Parameters.AddWithValue("@YearLevel", yearLevel);
                command.Parameters.AddWithValue("@Section", section);

                connection.Open();
                command.ExecuteNonQuery();
            }


            var mainForm = (maingui)this.Owner;
            mainForm.RefreshDataGridView();

            MessageBox.Show("Successfully added"); //emerut lang

            this.Close();
        }





        private void txtMeridiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDataForm_Load(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e) //save button
        {
            // Gather data from textboxes
            int employeeNo = int.Parse(txtEmployeeNo.Text);
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            char mi = txtMI.Text[0];
            string department = txtDepartment.Text;

            string roomNo = txtRoomNo.Text;
            string roomName = txtRoomName.Text;
            int roomCapacity = int.Parse(txtRoomCapacity.Text);
            string floor = txtFloor.Text;

            TimeSpan time = TimeSpan.Parse(txtTime.Text);
            string meridiem = txtMeridiem.Text;

            int dayNo = int.Parse(txtDayNo.Text);
            string day = txtDay.Text;
            string status = txtStatus.Text;

            int courseID = int.Parse(txtCourseID.Text);
            string courseCode = txtCourseCode.Text;
            string courseSubject = txtCourseSubject.Text;

            string courseStrand = txtCourseStrand.Text;
            int yearLevel = int.Parse(txtYearLevel.Text);
            string section = txtSection.Text;

            // Update the database
            string connectionString = ConfigurationManager.ConnectionStrings["ClassSchedDBConnectionString"].ConnectionString;
            string query = @"UPDATE ConsolidatedData SET 
                        LastName = @LastName, FirstName = @FirstName, MI = @MI, Department = @Department, 
                        RoomNo = @RoomNo, RoomName = @RoomName, RoomCapacity = @RoomCapacity, Floor = @Floor, 
                        Time = @Time, Meridiem = @Meridiem, 
                        DayNo = @DayNo, Day = @Day, Status = @Status, 
                        CourseCode = @CourseCode, CourseSubject = @CourseSubject, 
                        CourseStrand = @CourseStrand, YearLevel = @YearLevel, Section = @Section
                      WHERE EmployeeNo = @EmployeeNo AND CourseID = @CourseID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmployeeNo", employeeNo);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@MI", mi);
                command.Parameters.AddWithValue("@Department", department);
                command.Parameters.AddWithValue("@RoomNo", roomNo);
                command.Parameters.AddWithValue("@RoomName", roomName);
                command.Parameters.AddWithValue("@RoomCapacity", roomCapacity);
                command.Parameters.AddWithValue("@Floor", floor);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Meridiem", meridiem);
                command.Parameters.AddWithValue("@DayNo", dayNo);
                command.Parameters.AddWithValue("@Day", day);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@CourseID", courseID);
                command.Parameters.AddWithValue("@CourseCode", courseCode);
                command.Parameters.AddWithValue("@CourseSubject", courseSubject);
                command.Parameters.AddWithValue("@CourseStrand", courseStrand);
                command.Parameters.AddWithValue("@YearLevel", yearLevel);
                command.Parameters.AddWithValue("@Section", section);

                connection.Open();
                command.ExecuteNonQuery();
            }

            var mainForm = (maingui)this.Owner;
            mainForm.RefreshDataGridView();

            MessageBox.Show("Successfully updated");

            this.Close();
        }
    }


}


