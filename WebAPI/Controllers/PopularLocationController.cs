using Business.Abstract;
using Core.DTOs.PopularLocation;
using Core.DTOs.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationController : ControllerBase
    {
        IPopularLocationService _popularLocationService;

        public PopularLocationController(IPopularLocationService popularLocationService)
        {
            _popularLocationService = popularLocationService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _popularLocationService.GetAll();
            return Ok(values);
        }
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _popularLocationService.GetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult Add(CreatePopularLocationDto dto)
        {
            _popularLocationService.Add(dto);
            return Ok(dto);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _popularLocationService.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdatePopularLocationDto dto)
        {
            _popularLocationService.Update(dto);
            return Ok(dto);
        }
    }
}
