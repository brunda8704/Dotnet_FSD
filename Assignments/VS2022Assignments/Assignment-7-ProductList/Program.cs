using static Assignment_7_ProductList.ProductValidation;

namespace Assignment_7_ProductList
{
    public enum Choice
    {
        Add=1,
        ViewAll,
        ViewPrice,
        RemoveAll,
        Exit
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            List<Product> productsList = new List<Product>();
            Console.WriteLine("--: Welcome to FlipKo Store :--\n");
            try
            {
                do
                {
                    Product.Display();
                    Console.WriteLine("Enter your choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch ((Choice)choice)
                    {
                        case Choice.Add:
                            Product.Add(productsList);
                            break;

                        case Choice.ViewAll:
                            Product.ViewAllProducts(productsList);
                            break;


                        case Choice.ViewPrice:
                            Product.ViewAllPriceGreaterThanThousand(productsList);
                            break;


                        case Choice.RemoveAll:
                            Product.RemoveAllProducts(productsList);
                            break;

                        case Choice.Exit:
                            Console.WriteLine("Exit successful\n");
                            break;

                        default:
                            Console.WriteLine("Invalid Input\n");
                            break;

                    }
                    
                }
                while (choice!=5);
            }
            catch(ProductValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error!!");

            }

        }

    }
}