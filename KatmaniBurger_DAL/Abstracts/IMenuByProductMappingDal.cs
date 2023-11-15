using KatmanliBurger_DATA.Concretes;
using System.Linq.Expressions;

namespace KatmaniBurger_DAL.Abstracts
{
    public interface IMenuByProductMappingDal : IBaseDal<MenuByProductMapping>
    {
        void Create(IEnumerable<MenuByProductMapping> entities);
        void Update(IEnumerable<MenuByProductMapping> entities);
        void Delete(IEnumerable<MenuByProductMapping> entities);
        IEnumerable<MenuByProductMapping> GetByProductId(int id);
        IEnumerable<MenuByProductMapping> GetByMenuId(int id);
        IEnumerable<MenuByProductMapping> GetAll(Expression<Func<MenuByProductMapping, bool>> expression = null);
    }
}
