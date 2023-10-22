using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;
using ProductAPI.Repository;
using ProductAPI.ViewModel;

namespace ProductAPI.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        [Route("getallproduct")]
        public async Task<IActionResult> Get()
        {
            var products = await _productRepository.GetAllProductsAsync();
            return Ok(products);

        }

        [HttpPost]
        [Route("addproduct")]
        public async Task<IActionResult> Post([FromBody] AddProductViewModel addProductViewModel)
        {
            if (ModelState.IsValid)
            {
                var product = new Product
                {
                    ProductName = addProductViewModel.ProductName,
                    ProductDescription = addProductViewModel.ProductDescription,
                };
                var addedproduct = await _productRepository.AddProduct(product);
                return Ok(addedproduct);
            }
            return BadRequest(ModelState);

        }

        [HttpPut]
        [Route("updateproductbyid")]
        public async Task<IActionResult> Put( int id, [FromBody] UpdateProductViewModel updateProductViewModel)
        {
            var product = new Product
            {
                ProductName = updateProductViewModel.ProductName,
                ProductDescription = updateProductViewModel.ProductDescription,
            };
            var updateproduct = await _productRepository.UpdateProduct(id, product);
            return Ok(updateproduct);
        }

        [HttpGet]
        [Route("getproductbyid")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _productRepository.GetProductById(id);
            return Ok(product);
        }

        [HttpDelete]
        [Route("deleteproductbyid")]
        public async Task<IActionResult> Delete(int id)
        {
           var product = await _productRepository.DeleteProductById(id);
           return Ok(product);
            
        }

        [HttpDelete]
        [Route("deleteallproducts")]
        public async Task<IActionResult> Delete()
        {
            var product = await _productRepository.DeleteAllProductAsync();
            return Ok(product);
        }
    }
}
