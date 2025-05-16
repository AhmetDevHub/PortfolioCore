using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Models.ViewComponents
{
    public class _DefaultInformationComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
