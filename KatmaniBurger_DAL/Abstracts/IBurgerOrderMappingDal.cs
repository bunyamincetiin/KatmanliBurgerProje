using KatmanliBurger_DATA.Concretes;
using System.Linq.Expressions;

namespace KatmaniBurger_DAL.Abstracts
{
    public interface IBurgerOrderMappingDal : IBaseDal<BurgerOrderMapping>
    {
        void Create(IEnumerable<BurgerOrderMapping> entities);
        void Update(IEnumerable<BurgerOrderMapping> entities);
        void Delete(IEnumerable<BurgerOrderMapping> entities);
        IEnumerable<BurgerOrderMapping> GetByOrderId(int id);
        IEnumerable<BurgerOrderMapping> GetByBurgerId(int id);
        IEnumerable<BurgerOrderMapping> GetAll(Expression<Func<BurgerOrderMapping, bool>> expression = null);
    }
}
