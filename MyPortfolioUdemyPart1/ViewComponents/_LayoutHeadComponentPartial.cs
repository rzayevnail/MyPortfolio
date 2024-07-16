using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyPart1.ViewComponents
{
	public class _LayoutHeadComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
