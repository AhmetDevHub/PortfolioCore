using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using PortfolioCore.Context;

namespace PortfolioCore.Models.ViewComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
       public IViewComponentResult Invoke()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
    }
}
