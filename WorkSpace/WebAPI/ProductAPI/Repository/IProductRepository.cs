using ProductAPI.Models;
using System.Collections;

namespace ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> AddProduct(Product product);
        Task<bool> UpdateProduct(int id,Product product);
        Task<Product> GetProductById(int id);
        Task<bool> DeleteProductById(int id);
        Task<bool> DeleteAllProductAsync();

    }
    
}
