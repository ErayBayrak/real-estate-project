using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.HomePage
{
    public class _DefaultProductListExplorerCitiesPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
