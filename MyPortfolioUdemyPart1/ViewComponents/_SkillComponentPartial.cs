using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemyPart1.DAL.Context;

namespace MyPortfolioUdemyPart1.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = myPortfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
