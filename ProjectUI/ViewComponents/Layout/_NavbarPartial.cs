using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.Layout
{
    public class _NavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
