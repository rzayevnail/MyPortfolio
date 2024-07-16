using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemyPart1.DAL.Context;

namespace MyPortfolioUdemyPart1.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        MyPortfolioContext context =new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
