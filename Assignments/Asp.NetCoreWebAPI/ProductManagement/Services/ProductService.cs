using ProductManagement.Model;

namespace ProductManagement.Services
{
    public class ProductService : IProductService
    {
        public static List<Product> products = new List<Product>();

        public IReadOnlyList<Product> GetAllProducts()
        {
            return products;   
        }

        public void AddProduct(Product product)
        {
            product.ProductId = products.Count==0 ? 1: products.Max(product => product.ProductId)+1;
            products.Add(product);
        }

        public bool DeleteProduct(int id)
        {
            var deleteById = products.Remove(products.Find(product=>product.ProductId==id));
            return deleteById;
        }


        public bool UpdateProduct(Product product, int id)
        {
            var update = products.Find(product=>product.ProductId==id);
            if(update!=null)
            {
                update.ProductName = product.ProductName;
                update.ProductDescription = product.ProductDescription;
                update.ProductAmount = product.ProductAmount;

                return true;
            }
            return false;
        }

        public IEnumerable<Product> GetProductsByAmount(double amount)
        {
            var productPrice = products.FindAll(productPrice=>productPrice.ProductAmount>amount);
            return productPrice;
        }
    }
}
