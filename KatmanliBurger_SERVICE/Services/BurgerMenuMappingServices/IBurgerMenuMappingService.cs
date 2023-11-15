using KatmanliBurger_DATA.Concretes;
using System.Linq.Expressions;

namespace KatmanliBurger_SERVICE.Services.BurgerMenuMappingServices
{
    public interface IBurgerMenuMappingService
    {
        void Create(IEnumerable<BurgerMenuMapping> entities);
        void Update(IEnumerable<BurgerMenuMapping> entities);
        void Delete(IEnumerable<BurgerMenuMapping> entities);
        IEnumerable<BurgerMenuMapping> GetByMenuId(int id);
        IEnumerable<BurgerMenuMapping> GetByBurgerId(int id);
        IEnumerable<BurgerMenuMapping> GetAll(Expression<Func<BurgerMenuMapping, bool>> expression = null);
    }
}
