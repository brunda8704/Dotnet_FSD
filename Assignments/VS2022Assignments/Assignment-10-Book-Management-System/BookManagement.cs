using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10_Book_Management_System
{
    internal class BookManagement
    {
        public static List<Book> bookList = new List<Book>();
        public bool AddBook(string title,string author,double rating,double price)
        {
            var checkExists = bookList.Find(bookList=>bookList.Title.ToLower() ==  title.ToLower()
                && (bookList.Author.ToLower()== author.ToLower()));
            if (checkExists == null)
            {
                int id = bookList.Count == 0 ? 500 : bookList.Max(book => book.Id) + 1;
                bookList.Add(new Book
                {
                    Id = id,
                    Title = title,
                    Author = author,
                    Rating = rating,
                    Price = price

                });
                return true;
            }

            return false;

        }

        public List<Book> GetAllBooks()
        {
            return bookList;
        }

        public List<Book> SearchByAuthor(string author)
        {
            var authorCheck = bookList.FindAll(bookList => bookList.Author.ToLower() == author.ToLower());
            return authorCheck;
        }
    }
}
