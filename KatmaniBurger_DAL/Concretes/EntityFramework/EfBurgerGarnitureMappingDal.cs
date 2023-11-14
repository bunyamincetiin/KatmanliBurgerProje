using KatmaniBurger_DAL.Abstracts;
using KatmaniBurger_DAL.Contexts;
using KatmanliBurger_DATA.Concretes;
using Microsoft.EntityFrameworkCore;

namespace KatmaniBurger_DAL.Concretes.EntityFramework
{
    public class EfBurgerGarnitureMappingDal : EfBaseDal<BurgerGarnitureMapping, BurgerDbContext>, IBurgerGarnitureMappingDal
    {
        public void Create(IEnumerable<BurgerGarnitureMapping> entities)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                context.BurgerGarnitures.AddRange(entities);
                context.SaveChanges();
            }
        }

        public void Update(IEnumerable<BurgerGarnitureMapping> entities)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                context.BurgerGarnitures.UpdateRange(entities);
                context.SaveChanges();
            }
        }
    }
}
