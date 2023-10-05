using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSidebarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
