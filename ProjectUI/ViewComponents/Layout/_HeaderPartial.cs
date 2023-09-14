using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.Layout
{
    public class _HeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
