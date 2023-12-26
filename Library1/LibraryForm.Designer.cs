namespace Library1
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            booklistBox = new ListBox();
            borrowButton = new Button();
            backButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // booklistBox
            // 
            booklistBox.FormattingEnabled = true;
            booklistBox.ItemHeight = 20;
            booklistBox.Location = new Point(114, 82);
            booklistBox.Name = "booklistBox";
            booklistBox.Size = new Size(258, 324);
            booklistBox.TabIndex = 0;
            // 
            // borrowButton
            // 
            borrowButton.Location = new Point(402, 347);
            borrowButton.Name = "borrowButton";
            borrowButton.Size = new Size(94, 29);
            borrowButton.TabIndex = 1;
            borrowButton.Text = "Borrow";
            borrowButton.UseVisualStyleBackColor = true;
            borrowButton.Click += borrowButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(673, 395);
            backButton.Name = "backButton";
            backButton.Size = new Size(94, 29);
            backButton.TabIndex = 2;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(368, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 35);
            label1.TabIndex = 3;
            label1.Text = "Library";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(114, 49);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 4;
            label2.Text = "Avalible Books:";
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(borrowButton);
            Controls.Add(booklistBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "LibraryForm";
            Text = "LibraryForm";
            FormClosing += LibraryForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox booklistBox;
        private Button borrowButton;
        private Button backButton;
        private Label label1;
        private Label label2;
    }
}