using ProductManagement.Model;

namespace ProductManagement.Services
{
    public interface IProductService
    {
        IReadOnlyList<Product> GetAllProducts();
        void AddProduct(Product product);
        bool UpdateProduct(Product product,int id);
        bool DeleteProduct(int id);
        IEnumerable<Product> GetProductsByAmount(double amount);

    }
}
