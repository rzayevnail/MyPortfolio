using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyPart1.ViewComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
