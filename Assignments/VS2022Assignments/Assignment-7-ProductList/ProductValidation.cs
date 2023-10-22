using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_ProductList
{
    internal class ProductValidation
    {
        public static void ProductValidations(Product product)
        {
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new ProductValidationException("Product name should not be null or empty\n"); 
            }
            if (string.IsNullOrEmpty(product.Description))
            {
                throw new ProductValidationException("Product description should not be null\n");
            }
            if (string.IsNullOrEmpty(product.ManufacturedBy))
            {
                throw new ProductValidationException("Product manufactureby should not be null\n");
            }
            if (double.IsNegative(product.Price))
            {
                throw new ProductValidationException("Product price should be greater than zero\n");
            }
        }
     
        public class ProductValidationException : Exception
        {  
            public ProductValidationException(string message) : base(message)
            {

            }
        }


    }
}
