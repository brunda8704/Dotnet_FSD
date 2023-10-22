using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Model;
using ProductAPI.Services;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var product = _productService.GetAllProducts();
            if(product.Count==0)
            {
                return NotFound("No product found!");
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            _productService.AddProduct(product);
            return Ok("Product added successfully!");
           
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _productService.DeleteProduct(id);
            if(product==false)
            {
                return NotFound("No product to delete!");
            }
            return Ok("Product deleted successfully!");

        }

        [HttpPut("{id}")]
        public IActionResult Put( [FromBody] Product product, int id)
        {
            var updateProduct = _productService.UpdateProduct(product, id);
            if(updateProduct==false)
            {
                return NotFound("No product with this id to update!");
            }
            return Ok("Product updated successfully");

        }

        [HttpGet("{amount}")]
        public IActionResult Get(double amount)
        {
            var product = _productService.GetProductsByAmount(amount);
            if(product.Count==0)
            {
                return NotFound("No product found with this amount");
            }
            return Ok(product);
        }

    }
}
