using KatmaniBurger_DAL.Abstracts;
using KatmaniBurger_DAL.Contexts;
using KatmanliBurger_DATA.Concretes;

namespace KatmaniBurger_DAL.Concretes.EntityFramework
{
    public class EfMenuByProductMappingDal : EfBaseDal<MenuByProductMapping, BurgerDbContext>, IMenuByProductMappingDal
    {
        public void Create(IEnumerable<MenuByProductMapping> entities)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                context.MenuByProducts.AddRange(entities);
                context.SaveChanges();
            }
        }

        public void Delete(IEnumerable<MenuByProductMapping> entities)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                context.MenuByProducts.RemoveRange(entities);
                context.SaveChanges();
            }
        }

        public IEnumerable<MenuByProductMapping> GetByProductId(int id)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                return context.MenuByProducts.Where(x=>x.ByProductId.Equals(id)).ToList();
            }
        }

        public IEnumerable<MenuByProductMapping> GetByMenuId(int id)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                return context.MenuByProducts.Where(x => x.MenuId == id).ToList();
            }
        }

        public void Update(IEnumerable<MenuByProductMapping> entities)
        {
            using (BurgerDbContext context = new BurgerDbContext())
            {
                context.MenuByProducts.UpdateRange(entities);
                context.SaveChanges();
            }
        }
    }
}
