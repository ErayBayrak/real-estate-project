using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomePage
{
    public class _DefaultOurClientsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
