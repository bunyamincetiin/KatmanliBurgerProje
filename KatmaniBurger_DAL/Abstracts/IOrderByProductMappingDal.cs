using KatmanliBurger_DATA.Concretes;
using System.Linq.Expressions;

namespace KatmaniBurger_DAL.Abstracts
{
    public interface IOrderByProductMappingDal : IBaseDal<OrderByProductMapping>
    {
        void Create(IEnumerable<OrderByProductMapping> entities);
        void Update(IEnumerable<OrderByProductMapping> entities);
        void Delete(IEnumerable<OrderByProductMapping> entities);
        IEnumerable<OrderByProductMapping> GetByOrderId(int id);
        IEnumerable<OrderByProductMapping> GetByProductId(int id);
        IEnumerable<OrderByProductMapping> GetAll(Expression<Func<OrderByProductMapping, bool>> expression = null);
    }
}
