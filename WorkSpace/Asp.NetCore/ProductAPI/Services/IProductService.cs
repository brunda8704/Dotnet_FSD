using ProductAPI.Model;

namespace ProductAPI.Services
{
    public interface IProductService
    {
        IReadOnlyList<Product> GetAllProducts();
        void AddProduct(Product product);
        bool UpdateProduct(Product product,int id);
        bool DeleteProduct(int id);
        IReadOnlyList<Product> GetProductsByAmount(double amount);
    }
}
