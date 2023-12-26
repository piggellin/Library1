namespace Library1
{
    partial class LogIn
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
            usernameTextBox = new TextBox();
            passwordtextBox = new TextBox();
            logInbutton1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(110, 31);
            label1.Name = "label1";
            label1.Size = new Size(157, 35);
            label1.TabIndex = 0;
            label1.Text = "Admin Login";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(110, 122);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(157, 27);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(110, 200);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.PlaceholderText = "Password";
            passwordtextBox.Size = new Size(157, 27);
            passwordtextBox.TabIndex = 2;
            // 
            // logInbutton1
            // 
            logInbutton1.Location = new Point(142, 281);
            logInbutton1.Name = "logInbutton1";
            logInbutton1.Size = new Size(94, 29);
            logInbutton1.TabIndex = 3;
            logInbutton1.Text = "Login";
            logInbutton1.UseVisualStyleBackColor = true;
            logInbutton1.Click += logInbutton1_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(389, 395);
            Controls.Add(logInbutton1);
            Controls.Add(passwordtextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LogIn";
            Text = "LogIn";
            FormClosing += LogIn_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernameTextBox;
        private TextBox passwordtextBox;
        private Button logInbutton1;
    }
}