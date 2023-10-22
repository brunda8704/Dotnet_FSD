using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Assessment_2_Book_Management_System
{
    internal class Program
    {
        public enum Choice
        {
            Add = 1,
            ViewAll,
            Search,
            RemoveAll
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Book Management System");
            Book book = new Book();
            BookOperations bookoperations = new BookOperations();

            int option,choice;

            int ratings;


            try
            {
                do
                {
                    
                    Console.WriteLine("1.Add a book\n2.View all books available in book store\n3.Search books by Author\n4.Remove all books\n");
                    Console.WriteLine("Enter your choice");
                    choice=Convert.ToInt32(Console.ReadLine());
                    switch ((Choice)choice)
                    {
                        case Choice.Add:
                            Console.WriteLine("Enter book title");
                            book.Title = Console.ReadLine();
                            Console.WriteLine("Enter book Author");
                            book.Author = Console.ReadLine();
                            Console.WriteLine("Enter book rating");
                            book.Rating = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter bookprice");
                            book.Price = Convert.ToDouble(Console.ReadLine());
                            BookValidation bookValidation = new BookValidation();
                            bookValidation.Validation(book);

                            var bookdata = bookoperations.AddBook(book);
                            if (bookdata)
                            {
                                Console.WriteLine("Book added successfully ");

                            }
                            else
                            {
                                Console.WriteLine("no book added");

                            }

                            break;

                        case Choice.ViewAll:
                            var bookDatas = bookoperations.GetBookList();
                            if (bookDatas.Count == 0)
                            {
                                Console.WriteLine("No books to display\n");
                            }
                            else
                            {
                                Console.WriteLine("Book details\n");
                                foreach (Book books in bookDatas)
                                {
                                    Console.WriteLine($"Id:{books.Id}\nTitle:{books.Title}\nAuthor:{books.Author}\nRating:{books.Rating}\nPrice:{books.Price}\n");
                                }
                            }
                            break;

                        case Choice.Search:
                            var bookSearch = bookoperations.SearchAuthor(book);
                            break;

                        case Choice.RemoveAll:
                            var removeBook = bookoperations.RemoveBook();
                            if (removeBook.Count == 0)
                            {
                                Console.WriteLine("No books to remove\n");
                            }
                            else
                            {
                                removeBook.Clear();
                                Console.WriteLine("All books removed successfully\n");
                            }
                            break;

                            //default:
                            //    Console.WriteLine("Invalid input");
                            //    break;


                    }
                    Console.WriteLine("Do you want to continue?\nPress 1 for continue\n0 for exit\n");
                    option = Convert.ToInt32(Console.ReadLine());
                }
                while (option == 1);
                

                
            }


            catch (BookValidation.BookValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}



           
                
           
        
   
