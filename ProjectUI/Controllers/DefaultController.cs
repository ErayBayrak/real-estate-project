using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
