using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Layout
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
