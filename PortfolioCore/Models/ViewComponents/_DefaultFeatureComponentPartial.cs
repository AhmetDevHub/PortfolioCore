using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Models.ViewComponents
{
    public class _DefaultFeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
