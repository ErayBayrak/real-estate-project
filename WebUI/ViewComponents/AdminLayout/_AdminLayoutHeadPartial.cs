using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeadPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
