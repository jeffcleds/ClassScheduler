namespace ClassScheduler1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            timeLbl = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            forgotPass = new Label();
            loginBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            passwordTB = new TextBox();
            usernameTB = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(timeLbl);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 460);
            panel1.TabIndex = 0;
            // 
            // timeLbl
            // 
            timeLbl.AutoSize = true;
            timeLbl.Location = new Point(122, 11);
            timeLbl.Name = "timeLbl";
            timeLbl.Size = new Size(30, 15);
            timeLbl.TabIndex = 9;
            timeLbl.Text = "Time";
            timeLbl.TextAlign = ContentAlignment.MiddleCenter;
            timeLbl.Click += timeLabel_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(132, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 37);
            panel3.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(16, 7);
            label1.Name = "label1";
            label1.Size = new Size(163, 23);
            label1.TabIndex = 1;
            label1.Text = "Class Scheduler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Help;
            label4.Font = new Font("Rockwell", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(392, 43);
            label4.Name = "label4";
            label4.Size = new Size(37, 13);
            label4.TabIndex = 7;
            label4.Text = "About";
            label4.Click += label4_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(391, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(170, 317);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGoldenrod;
            panel2.Controls.Add(forgotPass);
            panel2.Controls.Add(loginBtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(passwordTB);
            panel2.Controls.Add(usernameTB);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 100);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // forgotPass
            // 
            forgotPass.AutoSize = true;
            forgotPass.BackColor = Color.Transparent;
            forgotPass.Cursor = Cursors.Hand;
            forgotPass.Font = new Font("Rockwell", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            forgotPass.ForeColor = Color.FromArgb(192, 255, 255);
            forgotPass.Location = new Point(172, 77);
            forgotPass.Name = "forgotPass";
            forgotPass.Size = new Size(96, 13);
            forgotPass.TabIndex = 6;
            forgotPass.Text = "Forgot Password?";
            forgotPass.Click += label4_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Transparent;
            loginBtn.Font = new Font("Rockwell", 10F, FontStyle.Bold);
            loginBtn.Location = new Point(182, 54);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Rockwell", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Azure;
            label3.Location = new Point(229, 10);
            label3.Name = "label3";
            label3.Size = new Size(58, 13);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Azure;
            label2.Location = new Point(25, 10);
            label2.Name = "label2";
            label2.Size = new Size(61, 13);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(229, 26);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(184, 22);
            passwordTB.TabIndex = 3;
            // 
            // usernameTB
            // 
            usernameTB.Location = new Point(25, 26);
            usernameTB.Name = "usernameTB";
            usernameTB.Size = new Size(184, 22);
            usernameTB.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(38, 42);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(438, 450);
            Controls.Add(panel1);
            Font = new Font("Bernard MT Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox passwordTB;
        private TextBox usernameTB;
        private Label label3;
        private PictureBox pictureBox1;
        private Button loginBtn;
        private PictureBox pictureBox2;
        private Label forgotPass;
        private PictureBox pictureBox3;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Panel panel3;
        private Label timeLbl;
        private Button button1;
    }
}
