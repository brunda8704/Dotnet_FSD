using System.ComponentModel.Design;
using System.Diagnostics;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Assignment_9_MobileManagement
{
    internal class Program
    {
        enum Choice
        {
            AddMobile = 1,
            ViewAllMobiles,
            SearchByMaxPrice,
            SearchByManufacturer,
            ViewByPriceRange,
            RemoveByPriceRange,
            Exit
        };
        static void Main(string[] args)
        {
            int choice;

            Mobile mobile = new Mobile();
            MobileManagement mobileManagement = new MobileManagement();
            do
            {
                Console.WriteLine("\n-:JoMart Retail Store:-\n------------------------\n");
                Console.WriteLine("1. Add mobile");
                Console.WriteLine("2. View all mobiles available in the store");
                Console.WriteLine("3. Search mobiles whose price is less than the max price of mobiles");
                Console.WriteLine("4. Search all mobiles by Manufacturer");
                Console.WriteLine("5. View all mobiles whose price is greater than the minimum mobile price and less than the maximum mobile price");
                Console.WriteLine("6. Remove mobiles whose price is greater than the minimum mobile price and less than the maximum mobile price");
                Console.WriteLine("7. Exit\n");

                Console.Write("Enter your choice:");
                bool userChoice = int.TryParse(Console.ReadLine(), out choice);

                try
                {
                    switch ((Choice)choice)
                    {
                        case Choice.AddMobile:
                            Console.Write("Enter mobile name: ");
                            string _name = Console.ReadLine();
                            Validation.CheckValidName(_name);

                            Console.Write("Enter mobile description: ");
                            string _description = Console.ReadLine();
                            Validation.CheckValidDescription(_description);

                            Console.Write("Enter manufacturer name: ");
                            string _manufacturedBy = Console.ReadLine();
                            Validation.CheckValidManufacturedBy(_manufacturedBy);   

                            Console.Write("Enter mobile price: ");
                            double.TryParse(Console.ReadLine(), out double _price);
                            Validation.CheckValidPrice(_price);
                            
                            var isMobileAdded = mobileManagement.AddMobile(_name, _description, _manufacturedBy, _price);
                            if (isMobileAdded)
                            {
                                Console.WriteLine("\nMobile added successfully!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nMobile already exists!\n");
                            }
                            break;

                        case Choice.ViewAllMobiles:
                            var viewAllMobiles = mobileManagement.ViewAllMobiles();
                            if (viewAllMobiles.Count == 0)
                            {
                                Console.WriteLine("No mobiles found!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nAvailable Mobile Details\n--------------------------");
                                foreach (Mobile mobileData in viewAllMobiles)
                                {
                                    Console.WriteLine($"Id: {mobileData.Id}\nName: {mobileData.Name}\nDescription: {mobileData.Description}\nManufacturedBy: {mobileData.ManufacturedBy}\nPrice: {mobileData.Price}\n");
                                }
                            }
                            break;

                        case Choice.SearchByMaxPrice:
                            var searchByMaxPrice = mobileManagement.SearchByMaxPrice();
                            if (searchByMaxPrice.Count == 0)
                            {
                                Console.WriteLine("No mobiles found with this price!\n");
                            }
                            else
                            {
                                Console.WriteLine("Mobiles with price less than the maximum price:");
                                Console.WriteLine("----------------------------------------------");

                                foreach (Mobile mobilePriceCheck in searchByMaxPrice)
                                {

                                    Console.WriteLine($"Id: {mobilePriceCheck.Id}");
                                    Console.WriteLine($"Name: {mobilePriceCheck.Name}");
                                    Console.WriteLine($"Description: {mobilePriceCheck.Description}");
                                    Console.WriteLine($"Manufacturer: {mobilePriceCheck.ManufacturedBy}");
                                    Console.WriteLine($"Price: {mobilePriceCheck.Price}\n");
                                }
                            }

                            break;

                        case Choice.SearchByManufacturer:
                            Console.Write("\nEnter manufacturer name: ");
                            string manufacturer = Console.ReadLine();
                            var filteredMobileList = mobileManagement.SearchByManufacturer(manufacturer);
                            if (filteredMobileList.Count == 0)
                            {
                                Console.WriteLine($"No mobiles found with this manufacturer!\n");
                            }
                            else
                            {
                                Console.WriteLine("Available mobiles with manufacturer:");
                                Console.WriteLine("----------------------------------------------");

                                foreach (Mobile mobileOne in filteredMobileList)
                                {

                                    Console.WriteLine($"Id: {mobileOne.Id}");
                                    Console.WriteLine($"Name: {mobileOne.Name}");
                                    Console.WriteLine($"Description: {mobileOne.Description}");
                                    Console.WriteLine($"Manufacturer: {mobileOne.ManufacturedBy}");
                                    Console.WriteLine($"Price: {mobileOne.Price}\n");
                                }
                            }

                            break;

                        case Choice.ViewByPriceRange:
                            var viewByPriceRange = mobileManagement.ViewByPriceRange();

                            if (viewByPriceRange.Count== 0)
                            {
                                Console.WriteLine("No mobiles found within this price range!");
                            }
                            else
                            {

                                Console.WriteLine("Mobiles with the price range:");
                                Console.WriteLine("----------------------------------------------");

                                foreach (Mobile mobilePriceChecks in viewByPriceRange)
                                {

                                    Console.WriteLine($"Id: {mobilePriceChecks.Id}");
                                    Console.WriteLine($"Name: {mobilePriceChecks.Name}");
                                    Console.WriteLine($"Description: {mobilePriceChecks.Description}");
                                    Console.WriteLine($"Manufacturer: {mobilePriceChecks.ManufacturedBy}");
                                    Console.WriteLine($"Price: {mobilePriceChecks.Price}\n");
                                }
                            }
                            break;

                        case Choice.RemoveByPriceRange:
                            var removeByPrice = mobileManagement.ViewByPriceRange();
                            if (removeByPrice.Count == 0)
                            {
                                Console.WriteLine("No mobiles available within this range for removing\n");
                            }
                            else
                            {
                                mobileManagement.RemoveByPriceRange();
                                Console.WriteLine("Removed mobiles successfully\n");
                            }

                            break;

                        case Choice.Exit:
                            Console.WriteLine("Exit successful\n");
                            break;

                        default:
                            Console.WriteLine("Invalid choice!\n");
                            break;

                    }
                }
                catch (MobileException ex)
                {
                    Console.WriteLine($"\nValidation Error!\n {ex.Message}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Mobile details not found!");
                }

            }
            while (choice!=7);
        }
    }
}