using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyPart1.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
