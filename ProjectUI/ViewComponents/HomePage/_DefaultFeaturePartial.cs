using Microsoft.AspNetCore.Mvc;

namespace ProjectUI.ViewComponents.HomePage
{
    public class _DefaultFeaturePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
