using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
