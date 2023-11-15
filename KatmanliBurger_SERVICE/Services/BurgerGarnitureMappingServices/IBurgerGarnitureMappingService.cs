using KatmaniBurger_DAL.Abstracts;
using KatmanliBurger_DATA.Concretes;
using System.Linq.Expressions;

namespace KatmanliBurger_SERVICE.Services.BurgerGarnitureMappingServices
{
    public interface IBurgerGarnitureMappingService 
    {
        void Create(IEnumerable<BurgerGarnitureMapping> entities);
        void Update(IEnumerable<BurgerGarnitureMapping> entities);
        void Delete(IEnumerable<BurgerGarnitureMapping> entities);
        IEnumerable<BurgerGarnitureMapping> GetAll(Expression<Func<BurgerGarnitureMapping, bool>> expression = null);
        IEnumerable<BurgerGarnitureMapping> GetbyBurgerId(int id);
    }
}
