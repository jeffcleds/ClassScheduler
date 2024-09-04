namespace ClassScheduler1
{
    partial class lowermaingui
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lowermaingui));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            label9 = new Label();
            label2 = new Label();
            label8 = new Label();
            label7 = new Label();
            pictureBoxProfile = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            settingsPanel = new Panel();
            button1 = new Button();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            panel4 = new Panel();
            timeLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            settingsPanel.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1101, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1053, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(516, 26);
            label1.Name = "label1";
            label1.Size = new Size(353, 43);
            label1.TabIndex = 1;
            label1.Text = "Class Scheduler 1.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(40, 258);
            label3.Name = "label3";
            label3.Size = new Size(172, 14);
            label3.TabIndex = 2;
            label3.Text = "(Your permissions are read-only).";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(269, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.No;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(750, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.No;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(928, 120);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.No;
            label4.Font = new Font("Rockwell", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(331, 139);
            label4.Name = "label4";
            label4.Size = new Size(104, 14);
            label4.TabIndex = 6;
            label4.Text = "Create Schedule";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.No;
            label5.Font = new Font("Rockwell", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(815, 139);
            label5.Name = "label5";
            label5.Size = new Size(89, 14);
            label5.TabIndex = 7;
            label5.Text = "Edit Schedule";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.No;
            label6.Font = new Font("Rockwell", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(985, 139);
            label6.Name = "label6";
            label6.Size = new Size(104, 14);
            label6.TabIndex = 8;
            label6.Text = "Delete Schedule";
            label6.Click += label6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(269, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(820, 540);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.BackgroundImage = Properties.Resources.Dashboard_Yellow;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBoxProfile);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, -31);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 852);
            panel2.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Cursor = Cursors.Hand;
            label9.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(92, 709);
            label9.Name = "label9";
            label9.Size = new Size(67, 19);
            label9.TabIndex = 15;
            label9.Text = "Settings";
            label9.Click += label9_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(94, 744);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 14;
            label2.Text = "Log out";
            label2.Click += label2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(68, 236);
            label8.Name = "label8";
            label8.Size = new Size(114, 19);
            label8.TabIndex = 13;
            label8.Text = "Lower Admin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(56, 195);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 12;
            label7.Text = "WELCOME!";
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.BackColor = Color.Transparent;
            pictureBoxProfile.Image = Properties.Resources.user;
            pictureBoxProfile.Location = new Point(26, 43);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(194, 141);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 11;
            pictureBoxProfile.TabStop = false;
            // 
            // settingsPanel
            // 
            settingsPanel.Controls.Add(button1);
            settingsPanel.Controls.Add(label15);
            settingsPanel.Controls.Add(label14);
            settingsPanel.Controls.Add(label13);
            settingsPanel.Controls.Add(label12);
            settingsPanel.Controls.Add(label11);
            settingsPanel.Controls.Add(label10);
            settingsPanel.Location = new Point(251, 102);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(850, 646);
            settingsPanel.TabIndex = 11;
            settingsPanel.Visible = false;
            settingsPanel.Paint += settingsPanel_Paint;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(400, 355);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Cursor = Cursors.Hand;
            label15.Font = new Font("Rockwell", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.Highlight;
            label15.Location = new Point(378, 307);
            label15.Name = "label15";
            label15.Size = new Size(120, 19);
            label15.TabIndex = 20;
            label15.Text = "Delete Account";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Cursor = Cursors.Hand;
            label14.Font = new Font("Rockwell", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(412, 260);
            label14.Name = "label14";
            label14.Size = new Size(53, 19);
            label14.TabIndex = 19;
            label14.Text = "About";
            label14.Click += label14_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Rockwell", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.Highlight;
            label13.Location = new Point(372, 214);
            label13.Name = "label13";
            label13.Size = new Size(134, 19);
            label13.TabIndex = 18;
            label13.Text = "Recently Deleted";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Rockwell", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Highlight;
            label12.Location = new Point(353, 128);
            label12.Name = "label12";
            label12.Size = new Size(173, 19);
            label12.TabIndex = 17;
            label12.Text = "Change Profile Picture";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Cursor = Cursors.Hand;
            label11.Font = new Font("Rockwell", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Highlight;
            label11.Location = new Point(369, 168);
            label11.Name = "label11";
            label11.Size = new Size(141, 19);
            label11.TabIndex = 16;
            label11.Text = "Change Password";
            label11.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(379, 53);
            label10.Name = "label10";
            label10.Size = new Size(131, 36);
            label10.TabIndex = 16;
            label10.Text = "Settings";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            panel4.Controls.Add(timeLabel);
            panel4.Location = new Point(851, 726);
            panel4.Name = "panel4";
            panel4.Size = new Size(238, 22);
            panel4.TabIndex = 25;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.BackColor = Color.Transparent;
            timeLabel.Font = new Font("Rockwell", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeLabel.ForeColor = SystemColors.ActiveCaptionText;
            timeLabel.Location = new Point(15, 0);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(79, 14);
            timeLabel.TabIndex = 16;
            timeLabel.Text = "Moving Time";
            // 
            // lowermaingui
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1101, 746);
            Controls.Add(settingsPanel);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Font = new Font("Rockwell", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "lowermaingui";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "maingui";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label9;
        private Label label2;
        private Label label8;
        private Label label7;
        private PictureBox pictureBoxProfile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Panel settingsPanel;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Panel panel4;
        private Label timeLabel;
    }
}