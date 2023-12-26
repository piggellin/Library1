using Library1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library1
{
    public partial class LibraryForm : Form
    {
        public List<Books> bookList;

        string path = "books.json";

        private JsonFileManager jsonFileManager;

        StartForm startForm;

        public LibraryForm(List<Books> books, StartForm startForm)
        {
            jsonFileManager = new JsonFileManager("books.json");

            bookList = books;

            FileInfo file = new FileInfo(path);

            bookList = jsonFileManager.ReadBooks(bookList);

            InitializeComponent();

            foreach (Books book in bookList)
            {
                booklistBox.Items.Add($"{book.bookTitle}: {book.bookAuthor}");

            }

            this.startForm = startForm;
        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            if (bookList == null || booklistBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a book to borrow");
                return;
            }

            bookList.RemoveAt(booklistBox.SelectedIndex);
            booklistBox.Items.RemoveAt(booklistBox.SelectedIndex);
            UpdateBookListBox();
            jsonFileManager.SaveBook(bookList);

        }
        private void UpdateBookListBox()
        {
            booklistBox.Items.Clear();

            foreach (Books book in bookList)
            {
                booklistBox.Items.Add(book);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            this.Hide();
            startForm.ShowDialog();
        }

        private void LibraryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StartForm startForm = new StartForm();
            this.Hide();
            startForm.ShowDialog();
        }
    }
}
