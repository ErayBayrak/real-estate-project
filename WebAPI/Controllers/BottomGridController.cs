using Business.Abstract;
using Core.DTOs.BottomGrid;
using Core.DTOs.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridController : ControllerBase
    {
        IBottomGridService _bottomGridService;

        public BottomGridController(IBottomGridService bottomGridService)
        {
            _bottomGridService = bottomGridService;
        }
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _bottomGridService.GetById(id);
            return Ok(value);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _bottomGridService.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult Add(CreateBottomGridDto dto)
        {
            _bottomGridService.Add(dto);
            return Ok(dto);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _bottomGridService.Delete(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateBottomGridDto dto)
        {
            _bottomGridService.Update(dto);
            return Ok(dto);
        }
    }
}
