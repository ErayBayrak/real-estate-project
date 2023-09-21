using Business.Abstract;
using Core.DTOs.Category;
using Core.DTOs.WhoWeAreDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        IWhoWeAreDetailService _whoWeAreDetailService;

        public WhoWeAreDetailController(IWhoWeAreDetailService whoWeAreDetailService)
        {
            _whoWeAreDetailService = whoWeAreDetailService;
        }

        [HttpGet("getalldetails")]
        public async Task<IActionResult> GetList()
        {
            var allDetails = await _whoWeAreDetailService.GetAll();
            return Ok(allDetails);
        }
        [HttpPost("createdetail")]
        public IActionResult Add(CreateWhoWeAreDetailDto dto)
        {
            _whoWeAreDetailService.Add(dto);
            return Ok(dto);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _whoWeAreDetailService.Delete(id);
            return Ok("Başarıyla silindi.");
        }
        [HttpPut]
        public IActionResult Update(UpdateWhoWeAreDetailDto dto)
        {
            _whoWeAreDetailService.Update(dto);
            return Ok(dto);
        }
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var detail = await _whoWeAreDetailService.GetById(id);
            return Ok(detail);
        }
    }
}
