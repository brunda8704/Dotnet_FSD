using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    internal class Validation
    {
        public static void ValidationCheck(Product product)
        {
            if(string.IsNullOrEmpty(product.Name) || string.IsNullOrWhiteSpace(product.Name))
            {
                throw new ProductValidationException("enter a valid product name!!\n");
            }
            if(string.IsNullOrEmpty(product.Description) || string.IsNullOrWhiteSpace(product.Description))
            {
                throw new ProductValidationException("enter a valid product description!!\n");
            }
            if(product.ManufacturedYear<=0 )
            {
                throw new ProductValidationException("Manufacturedyear should be greater than zero!!\n");
            }
            if(product.Price<=0)
            {
                throw new ProductValidationException("Price should be greater than zero!!\n");
            }

        }
    }

    public class ProductValidationException : Exception
    {
        public ProductValidationException(string message) : base(message) { }
    }
}
