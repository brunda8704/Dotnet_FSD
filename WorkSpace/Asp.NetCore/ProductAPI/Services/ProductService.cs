using ProductAPI.Model;

namespace ProductAPI.Services
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
            product.Id = products.Count == 0 ? 1 : products.Max(product => product.Id) + 1;
            products.Add(product);
        }

        public bool DeleteProduct(int id)
        {
            var deleteProduct = products.Remove(products.Find(productList => productList.Id == id));
            return deleteProduct;
        }


        public bool UpdateProduct(Product product, int id)
        {
            var update = products.Find(products => products.Id == id);
            if (update != null)
            {
                update.Name = product.Name;
                update.Description = product.Description;
                update.Amount = product.Amount;
                return true;
            }
            return false;
        }

        public IReadOnlyList<Product> GetProductsByAmount(double amount)
        {
            var productByAmount= products.FindAll(productList=> productList.Amount> amount);
            return productByAmount;
        }

    }
}
