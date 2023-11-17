using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger_UI.Controllers
{
	public class MenuUIController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
