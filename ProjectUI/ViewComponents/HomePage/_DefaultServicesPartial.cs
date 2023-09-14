using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.HomePage
{
    public class _DefaultServicesPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
