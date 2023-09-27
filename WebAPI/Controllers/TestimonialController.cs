using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _testimonialService.GetAll();
            return Ok(values);
        }
    }
}
