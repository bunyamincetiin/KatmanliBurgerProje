﻿using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger_UI.ViewComponents.DefaultComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
