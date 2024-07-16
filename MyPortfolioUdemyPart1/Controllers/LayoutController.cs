using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyPart1.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
