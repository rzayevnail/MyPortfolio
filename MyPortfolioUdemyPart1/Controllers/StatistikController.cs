using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemyPart1.DAL.Context;

namespace MyPortfolioUdemyPart1.Controllers
{
	public class StatistikController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Index()
		{
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2 = context.Messages.Count();
			ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
			ViewBag.v4= context.Messages.Where(x => x.IsRead == true).Count();
			return View();
		}
	}
}
