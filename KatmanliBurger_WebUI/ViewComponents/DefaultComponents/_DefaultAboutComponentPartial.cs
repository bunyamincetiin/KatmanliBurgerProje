﻿using KatmaniBurger_DAL.Abstracts;
using KatmanliBurger_SERVICE.Services.BurgerService;
using KatmanliBurger_SERVICE.Services.ByProductServices;
using KatmanliBurger_SERVICE.Services.CategoryServices;
using KatmanliBurger_SERVICE.Services.MenuServices;
using KatmanliBurger_WebUI.DTOs.MenuProductViewDtos;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger_UI.ViewComponents.DefaultComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly IBurgerService _burgerManager;
        private readonly IMenuService _menuManager;
        private readonly IByProductService _byProductManager;
        private readonly ICategoryService _categoryManager;

        public _DefaultAboutComponentPartial(IBurgerService burgerManager, IMenuService menuManager, IByProductService byProductManager, ICategoryService categoryManager)
        {
            _burgerManager = burgerManager;
            _menuManager = menuManager;
            _byProductManager = byProductManager;
            _categoryManager = categoryManager;
        }

        public IViewComponentResult Invoke()
        {
            MenuProductViewDto model= new MenuProductViewDto();
            model.Burgers = _burgerManager.GetAll();
            model.Menus=_menuManager.GetAll();
            model.ByProducts= _byProductManager.GetAll();
            return View();
        }
    }
}