namespace CSharpAssessment
{
    public enum Choice 
    {
        Add=1,
        ViewAll,
        Search,
        Remove,
        Exit


    };

    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            ProductManagement productManagement = new ProductManagement();
            do
            {
                Console.WriteLine("*******iCare retail store*******\n");
                Console.WriteLine("1.Add product");
                Console.WriteLine("2.View all products");
                Console.WriteLine("3.Search products based on price");
                Console.WriteLine("4.Remove a product based on product id");
                Console.WriteLine("5.Exit\n");


                Console.Write("enter your choice=> ");
                bool userChoice=int.TryParse(Console.ReadLine(), out choice);
                Product product= new Product();
                try
                {
                    switch((Choice)choice)
                    {
                        
                        case Choice.Add:
                            Console.WriteLine("enter product name");
                            product.Name=Console.ReadLine();

                            Console.WriteLine("enter product description");
                            product.Description = Console.ReadLine();

                            Console.WriteLine("enter product manufactured year");
                            int.TryParse(Console.ReadLine(), out int year);
                            product.ManufacturedYear= year;

                            Console.WriteLine("enter product price");
                            double.TryParse(Console.ReadLine(), out double price);
                            product.Price= price;

                            Validation.ValidationCheck(product);

                            var addProduct = productManagement.AddProduct(product.Name,product.Description,year,price);
                            if(addProduct)
                            {
                                Console.WriteLine("Product added successfully\n");
                            }
                            else
                            {
                                Console.WriteLine("Product already exists\n");
                            }

                            break;

                        case Choice.ViewAll:
                            var viewProduct = productManagement.ViewAllProducts();
                            if(viewProduct.Count==0)
                            {
                                Console.WriteLine("No products to display!!\n");
                            }
                            else
                            {
                                Console.WriteLine("Product details\n************");
                                foreach(Product productOne in viewProduct)
                                {
                                    Console.WriteLine($"Id:{productOne.Id}");
                                    Console.WriteLine($"Name:{productOne.Name}");
                                    Console.WriteLine($"Description:{productOne.Description}");
                                    Console.WriteLine($"Manufactured Year:{productOne.ManufacturedYear}");
                                    Console.WriteLine($"Price:{productOne.Price}\n");
                                }
                            }
                            break;

                        case Choice.Search:
                            Console.WriteLine("enter the price");
                            price =Convert.ToDouble(Console.ReadLine());
                            var checkPrice = productManagement.SearchByPrice(price);
                            if(checkPrice.Count==0)
                            {
                                Console.WriteLine("No products to display with this price!!\n");
                            }
                            else
                            {
                                Console.WriteLine("Product details\n************");
                                foreach (Product productTwo in checkPrice)
                                {
                                    Console.WriteLine($"Id:{productTwo.Id}");
                                    Console.WriteLine($"Name:{productTwo.Name}");
                                    Console.WriteLine($"Description:{productTwo.Description}");
                                    Console.WriteLine($"Manufactured Year:{productTwo.ManufacturedYear}");
                                    Console.WriteLine($"Price:{productTwo.Price}\n");
                                }

                            }
                            break;

                        case Choice.Remove:
                            Console.WriteLine("enter the id");
                            int Id =Convert.ToInt32(Console.ReadLine());
                            
                            var removeById = productManagement.RemoveById(Id);
                            if(removeById==false)
                            {
                                Console.WriteLine("No product found with this Id to remove!!\n");

                            }
                            else
                            {
                                Console.WriteLine($"Product with Id = {Id} is removed successfully!!\n");
                            }

                            break;

                        case Choice.Exit:
                            Console.WriteLine("Exit successfull!!\n");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid input!!\n");
                            break;

                    }

                }
                catch(ProductValidationException ex)
                {
                    Console.WriteLine($"Validation error-> {ex.Message}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"{ex.Message} ");
                }
            }
            while (choice!=5);
        }
    }
}