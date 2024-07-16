using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyPart1.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
