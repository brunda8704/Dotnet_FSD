using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_Book_Management_System
{
    
    internal class BookOperations
    {
        List<Book> bookList = new List<Book>();

        public bool AddBook(Book book)
        {
            var titleCheck = bookList.FindAll(book => book.Title.ToLower() == book.Title.ToLower());
            var authorCheck = bookList.FindAll(book => book.Author.ToLower() == book.Author.ToLower());

            book.Id=bookList.Count==0? 500: bookList.Max(x => x.Id+1);
            bookList.Add(book);
            return true;
        }

        public List<Book> GetBookList() 
        {
            return bookList;
        }
        public bool SearchAuthor(Book book)
        {
          
            return true;
        }
        public List<Book> RemoveBook()
        {
            return bookList;
        }
    }
}
