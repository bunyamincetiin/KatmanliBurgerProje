﻿using KatmanliBurger_DATA.Concretes;

namespace KatmaniBurger_DAL.Abstracts
{
    public interface IBurgerGarnitureMappingDal : IBaseDal<BurgerGarnitureMapping>
    {
        void Create(IEnumerable<BurgerGarnitureMapping> entities);
        void Update(IEnumerable<BurgerGarnitureMapping> entities);
        void Delete(IEnumerable<BurgerGarnitureMapping> entities);
        IEnumerable<BurgerGarnitureMapping> GetByBurgerId(int id);
    }
}
