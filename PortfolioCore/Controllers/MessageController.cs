using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
