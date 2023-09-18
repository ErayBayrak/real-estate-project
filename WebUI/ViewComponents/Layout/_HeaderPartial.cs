using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Layout
{
    public class _HeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
