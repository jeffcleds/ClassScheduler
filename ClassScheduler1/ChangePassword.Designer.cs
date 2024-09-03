namespace ClassScheduler1
{
    partial class ChangePassword
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            currentPWTB = new TextBox();
            newPWTB = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            label4 = new Label();
            confirmPWTB = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(49, 32);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 0;
            label1.Text = "Change Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(28, 89);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Current Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(41, 118);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "New Password";
            // 
            // currentPWTB
            // 
            currentPWTB.Location = new Point(134, 86);
            currentPWTB.Name = "currentPWTB";
            currentPWTB.Size = new Size(100, 23);
            currentPWTB.TabIndex = 1;
            // 
            // newPWTB
            // 
            newPWTB.Location = new Point(134, 115);
            newPWTB.Name = "newPWTB";
            newPWTB.Size = new Size(100, 23);
            newPWTB.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(49, 200);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(135, 200);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Close";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(21, 149);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password";
            // 
            // confirmPWTB
            // 
            confirmPWTB.Location = new Point(134, 144);
            confirmPWTB.Name = "confirmPWTB";
            confirmPWTB.Size = new Size(100, 23);
            confirmPWTB.TabIndex = 3;
            // 
            // ChangePassword
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(257, 235);
            Controls.Add(confirmPWTB);
            Controls.Add(label4);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(newPWTB);
            Controls.Add(currentPWTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox currentPWTB;
        private TextBox newPWTB;
        private Button saveButton;
        private Button cancelButton;
        private Label label4;
        private TextBox confirmPWTB;
    }
}