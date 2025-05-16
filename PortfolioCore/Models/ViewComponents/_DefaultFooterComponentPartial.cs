using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Models.ViewComponents
{
    public class _DefaultFooterComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var valuess = context.Footers.ToList();
            return View(valuess);
        }
    }
}
