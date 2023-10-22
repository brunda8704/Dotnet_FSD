using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    internal class ProductManagement
    {
        public static List<Product> products = new List<Product>();

        public bool AddProduct(string name,string description,int manufacturedyear, double price)
        {
            var checkExists = products.Find(productList => productList.Name.ToLower() == name.ToLower()
            && productList.ManufacturedYear == manufacturedyear);

            if (checkExists == null) 
            {
                int id =products.Count==0 ? 5000 : products.Max(product => product.Id)+1;
                products.Add(new Product
                { 
                    Id = id,
                    Name = name, 
                    Description = description, 
                    ManufacturedYear = manufacturedyear,
                    Price = price
                });
                return true;
            }
            return false;
        }

        public List<Product> ViewAllProducts()
        { 
            return products;
        }

        public List<Product> SearchByPrice(double price)
        {
            var priceCheck = products.FindAll(productlist=>productlist.Price > price);
            return priceCheck;
        }

        public bool RemoveById(int id)
        {
            var removeId =products.Remove(products.Find(productList=>productList.Id==id));
            return removeId;
        }

            
    }
}
