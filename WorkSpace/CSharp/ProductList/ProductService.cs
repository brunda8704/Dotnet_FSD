using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductList
{
    internal class ProductService
    {
        bool AddProduct(Product product)
        {
            return true;
        }
        IReadOnlyList<Product> ViewProducts()
        {
          return new List<Product>();
        }

        IReadOnlyList<Product> ViewByPrice(double price)
        {
            return ViewProducts();
        }

        bool RemoveProduct(Product product)
        {
            return true;
        }
    }
}
