using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomePage
{
    public class _DefaultFeaturePartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
