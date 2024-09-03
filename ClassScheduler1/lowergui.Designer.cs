namespace ClassScheduler1
{
    partial class lowergui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lowergui));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(411, 34);
            label1.Name = "label1";
            label1.Size = new Size(276, 33);
            label1.TabIndex = 7;
            label1.Text = "Class Scheduler 1.0";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1046, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(419, 153);
            label3.Name = "label3";
            label3.Size = new Size(280, 21);
            label3.TabIndex = 4;
            label3.Text = "Your permissions are read-only.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(399, 114);
            label2.Name = "label2";
            label2.Size = new Size(322, 29);
            label2.TabIndex = 3;
            label2.Text = "You are the: Lower Admin";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(1041, 470);
            dataGridView1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.No;
            label6.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(967, 212);
            label6.Name = "label6";
            label6.Size = new Size(104, 14);
            label6.TabIndex = 15;
            label6.Text = "Delete Schedule";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.No;
            label5.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(806, 212);
            label5.Name = "label5";
            label5.Size = new Size(89, 14);
            label5.TabIndex = 14;
            label5.Text = "Edit Schedule";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.No;
            label4.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(90, 212);
            label4.Name = "label4";
            label4.Size = new Size(104, 14);
            label4.TabIndex = 13;
            label4.Text = "Create Schedule";
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.No;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(910, 191);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.No;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(730, 191);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 191);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lowergui
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1099, 742);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "lowergui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "lowergui";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}