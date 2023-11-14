﻿using KatmaniBurger_DAL.Abstracts;
using KatmaniBurger_DAL.Contexts;
using KatmanliBurger_DATA.Concretes;

namespace KatmaniBurger_DAL.Concretes.EntityFramework
{
    public class EfBurgerMenuMappingDal : EfBaseDal<BurgerMenuMapping, BurgerDbContext>, IBurgerMenuMappingDal
    {
    }
}
