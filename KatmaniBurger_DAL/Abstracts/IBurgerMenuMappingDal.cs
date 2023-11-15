using KatmanliBurger_DATA.Concretes;
using System.Linq.Expressions;

namespace KatmaniBurger_DAL.Abstracts
{
    public interface IBurgerMenuMappingDal : IBaseDal<BurgerMenuMapping>
    {
        void Create(IEnumerable<BurgerMenuMapping> entities);
        void Update(IEnumerable<BurgerMenuMapping> entities);
        void Delete(IEnumerable<BurgerMenuMapping> entities);
        IEnumerable<BurgerMenuMapping> GetByMenuId(int id);
        IEnumerable<BurgerMenuMapping> GetByBurgerId(int id);
        
    }
}
