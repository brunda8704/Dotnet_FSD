using Microsoft.EntityFrameworkCore;
using ProductAPI.DBContext;
using ProductAPI.Models;

namespace ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDBContext _context;
        public ProductRepository(ProductDBContext context) 
        { 
            _context = context;
        }

        public async Task<Product> AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<bool> DeleteAllProductAsync()
        {
           var deleteAllProduct = await GetAllProductsAsync();
           if (deleteAllProduct!=null)
            {
                await _context.Products.ExecuteDeleteAsync();
                await _context.SaveChangesAsync();
            }
           return true;
        }

        public async Task<bool> DeleteProductById(int id)
        {
            var deleteProduct = await GetProductById(id);
            if (deleteProduct != null)
            {
                deleteProduct.ProductName= deleteProduct.ProductName;
                deleteProduct.ProductDescription= deleteProduct.ProductDescription;
            }
               _context.Products.Remove(deleteProduct);
               await _context.SaveChangesAsync();
            return true;
            
            
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<bool> UpdateProduct(int id, Product product)
        {
           var products = await GetProductById(id);

            if (products != null) {
                products.ProductName = product.ProductName;
                products.ProductDescription = product.ProductDescription;
            }
            await _context.SaveChangesAsync();
            return true;
           
        }
    }
}
