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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.GetByID(id);
            _categoryService.TDelete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var values = _categoryService.GetByID(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return Ok();
        }
    }
}