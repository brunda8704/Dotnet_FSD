namespace Assignment_10_Book_Management_System
{
    internal class Program
    {
        enum Choice
        { AddBook=1,
          ViewAllBook,
          SearchByAuthor,
          RemoveAll,
          Exit
        };
        static void Main(string[] args)
        {
            int choice;
            BookManagement bookManagement = new BookManagement();
            Validation validation = new Validation();
            do
            {
                Console.WriteLine("Amacon book store\n*****************\n");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. View all books available in the store");
                Console.WriteLine("3. Search books by author");
                Console.WriteLine("4. Remove all books");
                Console.WriteLine("5. Exit\n");

                Console.Write("Enter your choice: ");
                int.TryParse(Console.ReadLine(), out choice);

                try
                {
                    switch((Choice)choice)
                    {
                        case Choice.AddBook:
                            Book book = new Book();
                            Console.Write("Enter book title: ");
                            book.Title = Console.ReadLine();

                            Console.Write("Enter book author: ");
                            book.Author = Console.ReadLine();

                            Console.Write("Enter book rating: ");
                            int.TryParse(Console.ReadLine(), out int rating);
                            book.Rating= rating;

                            Console.Write("Enter book price: ");
                            int.TryParse(Console.ReadLine(), out int price);
                            book.Price= price;

                            validation.ValidationCheck(book);
                            var bookAdded = bookManagement.AddBook(book.Title,book.Author,book.Rating,book.Price);
                            if (bookAdded)
                            {
                                Console.WriteLine("Book added successfully!\n");
                            }
                            else
                            {
                                Console.WriteLine("Book already exists\n");
                            }
                            break;

                        case Choice.ViewAllBook:
                            var bookDetails = bookManagement.GetAllBooks();
                            if (bookDetails.Count == 0)
                            {
                                Console.WriteLine("No books to display!\n");
                            }
                            else
                            {
                                Console.Write("Book Details\n---------------");
                                foreach (Book bookOne in bookDetails)
                                {
                                    Console.WriteLine($"\nId: {bookOne.Id}, Title: {bookOne.Title}, Author: {bookOne.Author}, Rating: {bookOne.Rating}, Price: {bookOne.Price}\n");
                                }

                            }
                            break;


                        case Choice.SearchByAuthor:
                            Console.Write("Enter book author to search: ");
                            string author = Console.ReadLine();
                            var bookAuthor = bookManagement.SearchByAuthor(author);
                            if(bookAuthor.Count==0)
                            {
                                Console.WriteLine("No books with this author!\n");
                            }
                            else
                            {
                                foreach(Book bookTwo in bookAuthor)
                                {
                                    Console.WriteLine($"\nId: {bookTwo.Id}, Title: {bookTwo.Title}, Author: {bookTwo.Author}, Rating: {bookTwo.Rating}, Price: {bookTwo.Price}\n");
                                }
                            }
                            break;


                        case Choice.RemoveAll: 
                            var removeBooks = bookManagement.GetAllBooks();
                            if (removeBooks.Count == 0)
                            {
                                Console.WriteLine("No books to remove!\n");
                            }
                            else
                            {
                                removeBooks.Clear();
                                Console.WriteLine("Removed books successfully!\n");
                            }
                            break;
                            

                        case Choice.Exit:
                            Console.WriteLine("Exit successful!\n");
                            Environment.Exit(0);
                            break;

                        default: Console.WriteLine("Invalid choice!!!!\n");
                            break;
                    }
                    
                }
                catch(BookValidationException ex)
                {
                    Console.WriteLine($"Validation error=> {ex.Message}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Unexpected error!!! {ex.Message}\n");
                }
            }

            while (choice!= 5);
        }
    }
}