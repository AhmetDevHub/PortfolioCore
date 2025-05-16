using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PortfolioCore.Context;

namespace PortfolioCore.Models.ViewComponents
{
    public class _DefaultResumeComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Resumes.ToList();
            return View(values);
        }
    }
}
