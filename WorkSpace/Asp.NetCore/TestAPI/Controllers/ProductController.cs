using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Model;
using TestAPI.Services;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase

    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var product = _productService.GetAllProducts();
            if (product.Count == 0)
            {
                return NotFound("No products to display");
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            var create = _productService.AddProduct(product);
            if (create)
            {
                return Ok("Product added successfully");
            }
            return NotFound("Product already exists");

        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Product product, int id)
        {
            var update = _productService.UpdateProduct(product, id);
            if (update == false)
            {
                return NotFound($"No product found with this id {id} to update");
            }
            return Ok("Product updated successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var delete = _productService.DeleteProduct(id);
            if (delete == false)
            {
                return NotFound($"No product found with this id {id} to delete");
            }
            return Ok("Product deleted successfully");
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var products = _productService.GetProductById(id);
            if(products == null)
            {
                return NotFound("Product not found!");

            }
            return Ok(products);
        }
    }
}
