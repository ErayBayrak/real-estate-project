using Business.Abstract;
using Core.DTOs.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _productService.GetAll();
            return Ok(values);
        }
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _productService.GetById(id);  
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Add(CreateProductDto dto)
        {
            _productService.Add(dto);
            return Ok(dto);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            _productService.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateProductDto dto)
        {
            _productService.Update(dto);
            return Ok(dto);
        }
        [HttpGet("getallwithcategory")]
        public async Task<IActionResult> GetAllWithCategory()
        {
            var values = await _productService.GetAllWithCategories();
            return Ok(values);
        }
    }
}
