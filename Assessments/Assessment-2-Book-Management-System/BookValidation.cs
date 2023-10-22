using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_2_Book_Management_System
{
    internal class BookValidation
    {
      public void Validation(Book book)
        {
         if(string.IsNullOrEmpty(book.Title))
         {
                throw new BookValidationException("Title cannot be null or empty");

         }
         if(string.IsNullOrEmpty(book.Author))
         {
                throw new BookValidationException("Author name cannot be null or empty");
         }

         if(book.Rating<=0)
         {
                throw new BookValidationException("Rating cannot be less than or equal to zero");
         }

         if(book.Price<=0)
         {
                throw new BookValidationException("Price cannot be less than or equal to zero");
         }
        
        }

        public class BookValidationException : Exception
        {
            public BookValidationException(string message) : base(message) { }
        }
        


       



    }
}
