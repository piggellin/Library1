using Library1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library1
{
    public partial class LogIn : Form
    {
        private List<Books> books;

        StartForm startForm;

        public LogIn()
        {
            InitializeComponent();
        }

        private void logInbutton1_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin";

            if (usernameTextBox.Text == username && passwordtextBox.Text == password)
            {

                AdminForm admin = new AdminForm(books, startForm);
                this.Hide();
                admin.Show();

            }
            else
            {
                MessageBox.Show("Wrong username or password.");
            }
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartForm startForm = new StartForm();
            this.Hide();
            startForm.ShowDialog();
        }
    }
}
