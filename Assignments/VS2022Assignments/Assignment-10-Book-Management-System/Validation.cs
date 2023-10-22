using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10_Book_Management_System
{
    internal class Validation
    {
        public void ValidationCheck(Book book)
        {
            if(string.IsNullOrEmpty(book.Title) || string.IsNullOrWhiteSpace(book.Title))
            {
                throw new BookValidationException("enter a valid book title\n");
            }

            if(string.IsNullOrEmpty(book.Author))
            {
                throw new BookValidationException("enter a valid book author\n");

            }

            if(double.IsNaN(book.Rating) || book.Rating<=0 || book.Rating>=5)
            {
                throw new BookValidationException("enter a valid book rating and it should be between 0 to 5");
            }

            if(double.IsNaN(book.Price) ||  book.Price<=0)
            {
                throw new BookValidationException("enter a valid book price and it should be greater than zero");
            }


        }
    }

    public class BookValidationException:Exception 
    { 
        public BookValidationException (string message): base (message)
        { 
        }
    }
}
