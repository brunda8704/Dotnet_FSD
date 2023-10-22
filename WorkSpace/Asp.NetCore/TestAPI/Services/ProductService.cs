using TestAPI.Model;

namespace TestAPI.Services
{
    public class ProductService:IProductService
    {
        public static List<Product> products = new List<Product>();

        public bool AddProduct(Product product)
        {
            var checkList=products.Find(x=>x.Name.ToLower()==product.Name.ToLower());
            if (checkList==null)
            {
                product.Id = products.Count == 0 ? 1 : products.Max(p => p.Id) + 1;
                products.Add(new Product
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                });
                return true;
            }
            return false;
            
            
           
        }

        public bool DeleteProduct(int id)
        {
           var deleteProduct= products.Remove(products.Find(p => p.Id==id));
            return deleteProduct;
        }

        public IReadOnlyList<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            var getbyId=products.Find(p=>p.Id==id);
            return getbyId;
        }

        public bool UpdateProduct(Product product, int id)
        {
           var update=products.Find(p => p.Id==id);
            if(update!=null)
            {
                update.Id = product.Id;
                update.Name = product.Name;
                update.Description = product.Description;
                update.Price = product.Price;
                return true;
            }
            return false;
        }
    }
}
