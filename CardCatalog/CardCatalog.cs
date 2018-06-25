using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace CardCatalog
{
    class CardCatalog
    {
        private string _filename; //4 
        private string _fileExtension = ".txt"; //2 setting up type of file
        private List<Book> _booksfrommemory; //5 setting up a memory list called books
        

        public CardCatalog(string userFileName)  //1 constructor activated by program, user inputs filename
        {
            this._filename = userFileName + this._fileExtension; //3 appending filename and type "filename.txt"
            this._booksfrommemory = this.ReadBooksFromFile(this._filename); //6
        }

        public void AddBook(Book book) //this goes into (5), which adds book to memory
        {
            this._booksfrommemory.Add(book); 
        }

        public void ListAllBooks() //this activated by user, then grabs from (5), which retrieves all books from memory, see next step: Printbook
        {
            this._booksfrommemory.ForEach(book => this.printBook(book));
        }

        private List<Book> ReadBooksFromFile(string _filename) //7
        {
            if (File.Exists(_filename))
            {
                FileStream fs = new FileStream(_filename, FileMode.Open);
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<Book>)formatter.Deserialize(fs);
                }
                catch (SerializationException e)
                {
                    return new List<Book>();
                }
                finally
                {
                    fs.Close();
                }
            }
            else
                return new List<Book>();
        }

        private void printBook(Book book) //this displays books in a nice format to console, comes from ListAllBooks (private method)
        {
            Console.WriteLine("\nTitle: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.WriteLine("ISBN: " + book.ISBN + "\n");

        }

        public void savememorytofile()
        {
            FileStream fs = new FileStream(_filename, FileMode.Create);

          
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, _booksfrommemory);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        



    }
}
    