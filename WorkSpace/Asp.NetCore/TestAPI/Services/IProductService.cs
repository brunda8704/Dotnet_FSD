using TestAPI.Model;

namespace TestAPI.Services
{
    public interface IProductService
    {
        IReadOnlyList<Product> GetAllProducts();

        bool AddProduct(Product product);

        bool UpdateProduct(Product product,int id);

        bool DeleteProduct(int id);

        Product GetProductById(int id);
    }
}
