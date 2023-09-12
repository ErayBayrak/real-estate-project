using Business.Abstract;
using Core.DTOs.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getallcategories")]
        public async Task<IActionResult> GetList()
        {
            var allCategories = await _categoryService.GetAllCategories();
            return Ok(allCategories);
        }
        [HttpPost("createcategory")]
        public async Task<IActionResult> Add(CreateCategoryDto categoryDto)
        {
            _categoryService.AddCategory(categoryDto);
            return Ok(categoryDto);
        }
    }
}
