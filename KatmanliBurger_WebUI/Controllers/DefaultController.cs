using KatmanliBurger_DATA.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger_UI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public DefaultController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager = null)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                TempData["message"] = " Logout";
                TempData["adress"] = "/Default/Logout";
            }
            else
            {
                TempData["message"] = " Login";
                TempData["adress"] = "/Login/Index";
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Login()
        {
            return RedirectToAction("Index");
        }

    }
}
