namespace Library1
{
    partial class AdminForm
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
            titleTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            authorTextBox = new TextBox();
            label3 = new Label();
            addButton = new Button();
            logOutButton = new Button();
            avalibleListBox = new ListBox();
            label4 = new Label();
            removeButton = new Button();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(60, 141);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(150, 27);
            titleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(311, 22);
            label1.Name = "label1";
            label1.Size = new Size(158, 35);
            label1.TabIndex = 1;
            label1.Text = "Admin Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(60, 106);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Title of book:";
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(60, 239);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(150, 27);
            authorTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Location = new Point(60, 206);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 4;
            label3.Text = "Author of book:";
            // 
            // addButton
            // 
            addButton.Location = new Point(63, 301);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(694, 409);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(94, 29);
            logOutButton.TabIndex = 6;
            logOutButton.Text = "Log out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // avalibleListBox
            // 
            avalibleListBox.FormattingEnabled = true;
            avalibleListBox.ItemHeight = 20;
            avalibleListBox.Location = new Point(455, 115);
            avalibleListBox.Name = "avalibleListBox";
            avalibleListBox.Size = new Size(236, 244);
            avalibleListBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.Location = new Point(455, 80);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 8;
            label4.Text = "Avalible Books:";
            // 
            // removeButton
            // 
            removeButton.Location = new Point(455, 374);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(126, 29);
            removeButton.TabIndex = 9;
            removeButton.Text = "Remove Book";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bok;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(removeButton);
            Controls.Add(label4);
            Controls.Add(avalibleListBox);
            Controls.Add(logOutButton);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(authorTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(titleTextBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AdminForm";
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private Label label1;
        private Label label2;
        private TextBox authorTextBox;
        private Label label3;
        private Button addButton;
        private Button logOutButton;
        private ListBox avalibleListBox;
        private Label label4;
        private Button removeButton;
    }
}