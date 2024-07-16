using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemyPart1.DAL.Context;

namespace MyPortfolioUdemyPart1.ViewComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v=context.ToDoLists.Where(x=>x.Status==false).Count();
            var value = context.ToDoLists.Where(x=>x.Status==false).ToList();
            return View(value);
        }
    }
}
