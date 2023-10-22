using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Model;
using ProductManagement.Services;

namespace ProductManagement.Controllers
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
            var products = _productService.GetAllProducts();
            if (products.Count == 0)
            {
                return NotFound("No products to display");
            }
            return Ok("Product added successfully");
           //return Ok(products);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            _productService.AddProduct(product);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _productService.DeleteProduct(id);
            if(product==false)
            {
                return NotFound("No product found with this Id to delete");
            }
            return Ok("Product deleted successfully");
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Product product, int id)
        {
            var products = _productService.UpdateProduct(product,id);
            if (products==false)
            {
                return NotFound("No products found with this Id to update");
            }
            return Ok("Product updated successfully");
        }

        [HttpGet("{amount}")]
        public IActionResult Get(double amount)
        {
            var getByAmount = _productService.GetProductsByAmount(amount);
            if(getByAmount.Count()==0)
            {
                return NotFound("No product found with this amount");
            }
            return Ok(getByAmount);
        }
    }
}
