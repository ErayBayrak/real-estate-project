using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomePage
{
    public class _DefaultDiscountOfDayComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
