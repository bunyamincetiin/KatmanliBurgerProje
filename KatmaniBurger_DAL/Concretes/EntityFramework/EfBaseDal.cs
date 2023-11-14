using KatmaniBurger_DAL.Abstracts;
using KatmanliBurger_DATA.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KatmaniBurger_DAL.Concretes.EntityFramework
{
    public class EfBaseDal<TEntity, TContext> : IBaseDal<TEntity> where TEntity : BaseEntitiy, new() where TContext : DbContext, new()
    {
        public void Create(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(expression);
            }
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression = null)
        {
            using (TContext context = new TContext())
            {
                return expression == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(expression).ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (TContext contex = new TContext())
            {
                return contex.Set<TEntity>().Find(id);
            }
        }

        public IEnumerable<TEntity> GetByIdLisy(List<int> ids)
        {
            using (TContext contex = new TContext())
            {
                return contex.Set<TEntity>().Where(x=>ids.Contains(x.Id)).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
