namespace Library1
{
    partial class StartForm
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
            label1 = new Label();
            label2 = new Label();
            logInButton = new Button();
            label3 = new Label();
            toLibraryButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(181, 49);
            label1.Name = "label1";
            label1.Size = new Size(274, 35);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the library!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(411, 151);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 3;
            label2.Text = "Admin Login";
            // 
            // logInButton
            // 
            logInButton.Location = new Point(422, 226);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(94, 29);
            logInButton.TabIndex = 4;
            logInButton.Text = "Login";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(85, 151);
            label3.Name = "label3";
            label3.Size = new Size(208, 25);
            label3.TabIndex = 5;
            label3.Text = "Want to borrow books?";
            // 
            // toLibraryButton
            // 
            toLibraryButton.BackColor = SystemColors.Control;
            toLibraryButton.Location = new Point(129, 226);
            toLibraryButton.Name = "toLibraryButton";
            toLibraryButton.Size = new Size(94, 29);
            toLibraryButton.TabIndex = 6;
            toLibraryButton.Text = "see books";
            toLibraryButton.UseVisualStyleBackColor = false;
            toLibraryButton.Click += toLibraryButton_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(628, 428);
            Controls.Add(toLibraryButton);
            Controls.Add(label3);
            Controls.Add(logInButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "StartForm";
            Text = "Form1";
            FormClosing += StartForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button logInButton;
        private Label label3;
        private Button toLibraryButton;
    }
}