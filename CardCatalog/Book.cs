using System;
using System.Collections.Generic;
using System.Text;

namespace CardCatalog
{
    [Serializable]
    public class Book
    {
        public Book(string author, string title, string ISBN)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = ISBN;
        }

        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
    }
}
