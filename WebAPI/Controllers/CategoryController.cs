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
            var allCategories = await _categoryService.GetAll();
            return Ok(allCategories);
        }
        [HttpPost("createcategory")]
        public IActionResult Add(CreateCategoryDto categoryDto)
        {
            _categoryService.Add(categoryDto);
            return Ok(categoryDto);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _categoryService.Delete(id);
            return Ok("Başarıyla silindi.");
        }
        [HttpPut]
        public IActionResult Update(UpdateCategoryDto categoryDto)
        {
            _categoryService.Update(categoryDto);
            return Ok(categoryDto);
        }
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetById(id);
            return Ok(category);
        }
    }
}
