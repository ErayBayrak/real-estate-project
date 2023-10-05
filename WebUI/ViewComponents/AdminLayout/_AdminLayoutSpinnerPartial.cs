using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSpinnerPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
