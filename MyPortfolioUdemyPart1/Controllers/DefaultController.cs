using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyPart1.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
