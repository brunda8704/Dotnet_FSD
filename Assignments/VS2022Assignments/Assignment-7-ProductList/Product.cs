using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_ProductList
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ManufacturedBy { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }
        public static void Display()
        {
            Console.WriteLine($"1.Add product\n2.View all products\n3.View all products with price>1000\n4.Remove all products\n5.Exit\n");
        }
        public static void Add(List<Product> productsList)
        {
            Product product = new Product();
            Console.WriteLine($"Adding product\n--------------");
            Console.WriteLine("Enter product name");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter product description");
            product.Description = Console.ReadLine();
            Console.WriteLine("Enter product ManufacturedBy");
            product.ManufacturedBy = Console.ReadLine();
            Console.WriteLine("Enter product price");
            product.Price = Convert.ToDouble(Console.ReadLine());
            try
            {
                ProductValidation.ProductValidations(product);
                //checks if product name already exists
                var selected = productsList.Find(newProduct => newProduct.Name.ToLower() == product.Name);
                if (selected != null)
                {
                    Console.WriteLine("Product already exists!!\n");
                }
                else
                {
                    var productId = productsList.Count==0?1000 :productsList.Max(p => p.Id)+1;
                    productsList.Add(new Product
                    {
                        Id = productId,
                        Name = product.Name,
                        Description = product.Description,
                        ManufacturedBy = product.ManufacturedBy,
                        Price = product.Price
                    });
                    Console.WriteLine("Product successfully added!!\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errors during Validations:\n {ex.Message}\n");
            }

        }

        public static void ViewAllProducts(List<Product> productsList)
        {
            if (productsList.Count == 0)
            {
                Console.WriteLine("No products\n");
            }
            else
            {
                Console.WriteLine("Available products\n--------------");
                foreach (Product product in productsList)
                {
                    Console.WriteLine($"Product Id:{product.Id}\nProduct Name:{product.Name}\nProduct Description:{product.Description}\nProduct ManufacturedBy:{product.ManufacturedBy}\nProduct price:{product.Price}\n");
                }
            }
        }

        public static void ViewAllPriceGreaterThanThousand(List<Product> productsList)
        {
            if (productsList.Count == 0)
            {
                Console.WriteLine("No products with price>1000\n");
            }
            else
            {
                var checkingPrice = productsList.FindAll(product => product.Price > 1000);
                foreach (Product product in checkingPrice)
                {
                    Console.WriteLine($"Product Id:{product.Id}\nProduct Name:{product.Name}\nProduct ManufacturedBy:{product.ManufacturedBy}\nProduct price:{product.Price}\n");
                }
            }
        }
        

        public static void RemoveAllProducts(List<Product> productsList)
        {
            if (productsList.Count == 0)
            {
                Console.WriteLine("No products to remove\n");
            }
            else
            {
                productsList.Clear();
                Console.WriteLine("All products removed successfully!!\n");
            }
        }

    }
}
