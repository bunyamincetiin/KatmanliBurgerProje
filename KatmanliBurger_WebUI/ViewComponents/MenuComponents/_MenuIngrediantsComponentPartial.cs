using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger_UI.ViewComponents.MenuComponents
{
	public class _MenuIngrediantsComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
