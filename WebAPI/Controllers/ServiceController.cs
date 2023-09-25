using Business.Abstract;
using Core.DTOs.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _serviceService.GetById(id);
            return Ok(value);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _serviceService.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Add(CreateServiceDto dto)
        {
            _serviceService.Add(dto);
            return Ok(dto);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _serviceService.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateServiceDto dto)
        {
            _serviceService.Update(dto);
            return Ok(dto);
        }
    }
}
