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

namespace Library1
{
    public partial class AdminForm : Form
    {
        List<Books> bookList;

        public Books books;

        private JsonFileManager jsonFileManager;

        string path = "books.json";

        StartForm startForm;

        public AdminForm(List<Books> books, StartForm startForm)
        {
            jsonFileManager = new JsonFileManager("books.json");
            bookList = books;

            FileInfo file = new FileInfo(path);

            bookList = jsonFileManager.ReadBooks(bookList);

            InitializeComponent();

            foreach (Books book in bookList)
            {
                avalibleListBox.Items.Add($"{book.bookTitle}: {book.bookAuthor}");
            }
            this.startForm = startForm;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string author = authorTextBox.Text;

            if (titleTextBox.Text != "" && authorTextBox.Text != "")
            {

                bookList.Add(new Books(title, author));
                UpdateListBox();
                jsonFileManager.SaveBook(bookList);
                MessageBox.Show("book added to list.");
                titleTextBox.Text = "";
                authorTextBox.Text = "";

            }
            else
            {
                MessageBox.Show("Please write a title and an author.");
                return;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (bookList == null || avalibleListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a book to borrow");
                return;
            }

            bookList.RemoveAt(avalibleListBox.SelectedIndex);
            avalibleListBox.Items.RemoveAt(avalibleListBox.SelectedIndex);
            UpdateListBox();
            jsonFileManager.SaveBook(bookList);
        }

        private void UpdateListBox()
        {
            avalibleListBox.Items.Clear();

            foreach (Books book in bookList)
            {
                avalibleListBox.Items.Add($"{book.bookTitle}: {book.bookAuthor}");
            }

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            this.Hide();
            startForm.ShowDialog();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartForm startForm = new StartForm();
            this.Hide();
            startForm.ShowDialog();
            
        }


    }
}
