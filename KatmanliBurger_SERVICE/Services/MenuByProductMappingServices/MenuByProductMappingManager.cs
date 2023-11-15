using KatmaniBurger_DAL.Abstracts;
using KatmaniBurger_DAL.Concretes.EntityFramework;
using KatmanliBurger_DATA.Concretes;
using System.Linq.Expressions;

namespace KatmanliBurger_SERVICE.Services.MenuByProductMappingServices
{
    public class MenuByProductMappingManager : IMenuByProductMappingService
    {
        private readonly IMenuByProductMappingDal _menuByProductMappingDal;

        public MenuByProductMappingManager(IMenuByProductMappingDal menuByProductMappingDal)
        {
            _menuByProductMappingDal = menuByProductMappingDal;
        }

        public void Create(IEnumerable<MenuByProductMapping> entities)
        {
           _menuByProductMappingDal.Create(entities);
        }

        public void Delete(IEnumerable<MenuByProductMapping> entities)
        {
           _menuByProductMappingDal.Delete(entities);
        }

        public IEnumerable<MenuByProductMapping> GetAll(Expression<Func<MenuByProductMapping, bool>> expression = null)
        {
            return _menuByProductMappingDal.GetAll(expression);
        }

        public IEnumerable<MenuByProductMapping> GetByMenuId(int id)
        {
            return _menuByProductMappingDal.GetByMenuId(id);
        }

        public IEnumerable<MenuByProductMapping> GetByProductId(int id)
        {
            return _menuByProductMappingDal.GetByProductId(id);
        }

        public void Update(IEnumerable<MenuByProductMapping> entities)
        {
            foreach (var item in entities)
            {
                item.UpdatedDate = DateTime.Now;
            }
            _menuByProductMappingDal.Update(entities);
        }
    }
}
