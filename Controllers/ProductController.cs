using JwtOrnekProje.Models;
using JwtOrnekProje.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtOrnekProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult ProductAdd(Product product)
        {
            _productService.TInsert(product);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult ProductDelete(int id)
        {
            var values = _productService.GetByID(id);
            _productService.TDelete(values);
            return Ok();

        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.GetByID(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return Ok();
        }
        [HttpGet("GetProductWithCategories")]
        public IActionResult GetProductWithCategories()
        {
            var values = _productService.GetProductWithCategories();
            return Ok(values);
        }
    }
}
