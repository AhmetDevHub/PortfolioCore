using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Models.ViewComponents
{
    public class _DefaultPortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
