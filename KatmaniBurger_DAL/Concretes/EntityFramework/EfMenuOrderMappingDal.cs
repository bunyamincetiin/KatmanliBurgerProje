﻿using KatmaniBurger_DAL.Abstracts;
using KatmaniBurger_DAL.Contexts;
using KatmanliBurger_DATA.Concretes;

namespace KatmaniBurger_DAL.Concretes.EntityFramework
{
    public class EfMenuOrderMappingDal : EfBaseDal<MenuOrderMapping, BurgerDbContext>, IMenuOrderMappingDal
    {
        public void Create(IEnumerable<MenuOrderMapping> entities)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                context.MenuOrders.AddRange(entities);
                context.SaveChanges();
            }
        }

        public void Delete(IEnumerable<MenuOrderMapping> entities)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                context.MenuOrders.RemoveRange(entities);
                context.SaveChanges();
            }
        }

        public IEnumerable<MenuOrderMapping> GetByMenuId(int id)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                return context.MenuOrders.Where(x => x.MenuId.Equals(id)).ToList();
            }
        }

        public IEnumerable<MenuOrderMapping> GetByOrderId(int id)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                return context.MenuOrders.Where(x => x.OrderId.Equals(id)).ToList();
            }
        }

        public void Update(IEnumerable<MenuOrderMapping> entities)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                context.MenuOrders.UpdateRange(entities);
                context.SaveChanges();
            }
        }
    }
}
