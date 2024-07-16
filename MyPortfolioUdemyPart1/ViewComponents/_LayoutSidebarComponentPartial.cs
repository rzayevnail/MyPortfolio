using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyPart1.ViewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
