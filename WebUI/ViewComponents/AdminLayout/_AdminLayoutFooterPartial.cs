using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutFooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
