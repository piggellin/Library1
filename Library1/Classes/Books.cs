using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1.Classes
{
    public class Books
    {
        public string bookTitle { get; set; }
        public string bookAuthor { get; set; }


        public Books(string title, string author)
        {
            bookTitle = title;
            bookAuthor = author;
        }

        public override string ToString()
        {
            return $"{bookTitle}: {bookAuthor}";
        }

    }


}
