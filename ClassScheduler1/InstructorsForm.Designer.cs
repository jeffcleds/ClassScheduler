namespace ClassScheduler1
{
    partial class InstructorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorsForm));
            label1 = new Label();
            panel1 = new Panel();
            editInstructorPNL = new Panel();
            saveBtn = new Button();
            label11 = new Label();
            txtEdtDepartment = new TextBox();
            label12 = new Label();
            txtEdtMI = new TextBox();
            label13 = new Label();
            txtEdtFirstName = new TextBox();
            label14 = new Label();
            txtEdtLastName = new TextBox();
            label15 = new Label();
            txtEdtEmployeeNo = new TextBox();
            label16 = new Label();
            editCancelBtn = new Button();
            closePB = new PictureBox();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            addInstructorPNL = new Panel();
            AddBtn = new Button();
            label10 = new Label();
            txtDepartment = new TextBox();
            label9 = new Label();
            txtMI = new TextBox();
            label8 = new Label();
            txtFirstName = new TextBox();
            label7 = new Label();
            txtLastName = new TextBox();
            label6 = new Label();
            txtEmployeeNo = new TextBox();
            label5 = new Label();
            cancelBtn = new Button();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            editInstructorPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closePB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            addInstructorPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(223, 2);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 0;
            label1.Text = "Instructors";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(closePB);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 37);
            panel1.TabIndex = 1;
            // 
            // editInstructorPNL
            // 
            editInstructorPNL.Controls.Add(dataGridView2);
            editInstructorPNL.Controls.Add(saveBtn);
            editInstructorPNL.Controls.Add(label11);
            editInstructorPNL.Controls.Add(txtEdtDepartment);
            editInstructorPNL.Controls.Add(label12);
            editInstructorPNL.Controls.Add(txtEdtMI);
            editInstructorPNL.Controls.Add(label13);
            editInstructorPNL.Controls.Add(txtEdtFirstName);
            editInstructorPNL.Controls.Add(label14);
            editInstructorPNL.Controls.Add(txtEdtLastName);
            editInstructorPNL.Controls.Add(label15);
            editInstructorPNL.Controls.Add(txtEdtEmployeeNo);
            editInstructorPNL.Controls.Add(label16);
            editInstructorPNL.Controls.Add(editCancelBtn);
            editInstructorPNL.Location = new Point(0, 36);
            editInstructorPNL.Name = "editInstructorPNL";
            editInstructorPNL.Size = new Size(548, 342);
            editInstructorPNL.TabIndex = 19;
            editInstructorPNL.Visible = false;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(21, 310);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 12;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(29, 255);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 11;
            label11.Text = "Department";
            // 
            // txtEdtDepartment
            // 
            txtEdtDepartment.Location = new Point(29, 273);
            txtEdtDepartment.Name = "txtEdtDepartment";
            txtEdtDepartment.Size = new Size(100, 23);
            txtEdtDepartment.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(29, 212);
            label12.Name = "label12";
            label12.Size = new Size(24, 15);
            label12.TabIndex = 9;
            label12.Text = "M.I";
            // 
            // txtEdtMI
            // 
            txtEdtMI.Location = new Point(29, 229);
            txtEdtMI.Name = "txtEdtMI";
            txtEdtMI.Size = new Size(100, 23);
            txtEdtMI.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(29, 161);
            label13.Name = "label13";
            label13.Size = new Size(64, 15);
            label13.TabIndex = 7;
            label13.Text = "First Name";
            // 
            // txtEdtFirstName
            // 
            txtEdtFirstName.Location = new Point(29, 181);
            txtEdtFirstName.Name = "txtEdtFirstName";
            txtEdtFirstName.Size = new Size(100, 23);
            txtEdtFirstName.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(29, 110);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 5;
            label14.Text = "Last Name";
            // 
            // txtEdtLastName
            // 
            txtEdtLastName.Location = new Point(29, 131);
            txtEdtLastName.Name = "txtEdtLastName";
            txtEdtLastName.Size = new Size(100, 23);
            txtEdtLastName.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(26, 63);
            label15.Name = "label15";
            label15.Size = new Size(81, 15);
            label15.TabIndex = 3;
            label15.Text = "Employee No.";
            // 
            // txtEdtEmployeeNo
            // 
            txtEdtEmployeeNo.Location = new Point(29, 82);
            txtEdtEmployeeNo.Name = "txtEdtEmployeeNo";
            txtEdtEmployeeNo.Size = new Size(100, 23);
            txtEdtEmployeeNo.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(223, 26);
            label16.Name = "label16";
            label16.Size = new Size(118, 21);
            label16.TabIndex = 1;
            label16.Text = "Edit Instructor";
            // 
            // editCancelBtn
            // 
            editCancelBtn.Location = new Point(103, 310);
            editCancelBtn.Name = "editCancelBtn";
            editCancelBtn.Size = new Size(75, 23);
            editCancelBtn.TabIndex = 0;
            editCancelBtn.Text = "Cancel";
            editCancelBtn.UseVisualStyleBackColor = true;
            editCancelBtn.Click += editCancelBtn_Click;
            // 
            // closePB
            // 
            closePB.Cursor = Cursors.Hand;
            closePB.Image = (Image)resources.GetObject("closePB.Image");
            closePB.Location = new Point(515, 4);
            closePB.Name = "closePB";
            closePB.Size = new Size(31, 28);
            closePB.SizeMode = PictureBoxSizeMode.Zoom;
            closePB.TabIndex = 18;
            closePB.TabStop = false;
            closePB.Click += closePB_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(523, 255);
            dataGridView1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(434, 66);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 17;
            label4.Text = "Delete Instructor";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(257, 67);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 16;
            label3.Text = "Edit Instructor";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 68);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 15;
            label2.Text = "Add Instructor";
            label2.Click += label2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(383, 58);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(206, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // addInstructorPNL
            // 
            addInstructorPNL.Controls.Add(AddBtn);
            addInstructorPNL.Controls.Add(label10);
            addInstructorPNL.Controls.Add(txtDepartment);
            addInstructorPNL.Controls.Add(label9);
            addInstructorPNL.Controls.Add(txtMI);
            addInstructorPNL.Controls.Add(label8);
            addInstructorPNL.Controls.Add(txtFirstName);
            addInstructorPNL.Controls.Add(label7);
            addInstructorPNL.Controls.Add(txtLastName);
            addInstructorPNL.Controls.Add(label6);
            addInstructorPNL.Controls.Add(txtEmployeeNo);
            addInstructorPNL.Controls.Add(label5);
            addInstructorPNL.Controls.Add(cancelBtn);
            addInstructorPNL.Location = new Point(-1, 51);
            addInstructorPNL.Name = "addInstructorPNL";
            addInstructorPNL.Size = new Size(549, 326);
            addInstructorPNL.TabIndex = 18;
            addInstructorPNL.Visible = false;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(51, 283);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 12;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 211);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 11;
            label10.Text = "Department";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(51, 229);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(167, 23);
            txtDepartment.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(450, 149);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 9;
            label9.Text = "M.I";
            // 
            // txtMI
            // 
            txtMI.Location = new Point(448, 167);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(56, 23);
            txtMI.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 149);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 7;
            label8.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(238, 167);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(187, 23);
            txtFirstName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 149);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 5;
            label7.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(51, 167);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(167, 23);
            txtLastName.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 96);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 3;
            label6.Text = "Employee No.";
            // 
            // txtEmployeeNo
            // 
            txtEmployeeNo.Location = new Point(51, 114);
            txtEmployeeNo.Name = "txtEmployeeNo";
            txtEmployeeNo.Size = new Size(453, 23);
            txtEmployeeNo.TabIndex = 2;
            txtEmployeeNo.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(223, 30);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 1;
            label5.Text = "Add Instructor";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(143, 283);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 0;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(143, 60);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(392, 236);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // InstructorsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(547, 377);
            Controls.Add(editInstructorPNL);
            Controls.Add(addInstructorPNL);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InstructorsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructors";
            Load += InstructorsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            editInstructorPNL.ResumeLayout(false);
            editInstructorPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closePB).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            addInstructorPNL.ResumeLayout(false);
            addInstructorPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox closePB;
        private Panel addInstructorPNL;
        private Button cancelBtn;
        private Label label5;
        private Label label6;
        private TextBox txtEmployeeNo;
        private Button AddBtn;
        private Label label10;
        private TextBox txtDepartment;
        private Label label9;
        private TextBox txtMI;
        private Label label8;
        private TextBox txtFirstName;
        private Label label7;
        private TextBox txtLastName;
        private Panel editInstructorPNL;
        private Button saveBtn;
        private Label label11;
        private TextBox txtEdtDepartment;
        private Label label12;
        private TextBox txtEdtMI;
        private Label label13;
        private TextBox txtEdtFirstName;
        private Label label14;
        private TextBox txtEdtLastName;
        private Label label15;
        private TextBox txtEdtEmployeeNo;
        private Label label16;
        private Button editCancelBtn;
        private DataGridView dataGridView2;
    }
}