using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Models.ViewComponents
{
	public class _DefaultContactComponentPartial:ViewComponent
	{
		PortfolioContext context = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Contacts.ToList();
			return View(values);
		}
	}
}
