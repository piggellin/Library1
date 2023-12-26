using Library1.Classes;

namespace Library1
{
    public partial class StartForm : Form
    {
        private List<Books> books;

        public StartForm()
        {

            InitializeComponent();

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            this.Hide();
            logIn.Show();
        }

        private void toLibraryButton_Click(object sender, EventArgs e)
        {
            LibraryForm libraryForm = new LibraryForm(books, this);
            this.Hide();
            libraryForm.Show();

        }


        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}