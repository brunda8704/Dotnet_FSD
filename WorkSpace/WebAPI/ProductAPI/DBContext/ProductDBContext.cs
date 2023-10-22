using Microsoft.EntityFrameworkCore;
using ProductAPI.DBContext.Configuration;
using ProductAPI.Models;

namespace ProductAPI.DBContext
{

    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions options) : base(options) 
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

        public DbSet<Product> Products { get; set; }
    }
   


}
