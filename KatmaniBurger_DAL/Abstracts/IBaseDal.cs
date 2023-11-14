﻿using KatmanliBurger_DATA.Abstracts;
using System.Linq.Expressions;

namespace KatmaniBurger_DAL.Abstracts
{
    public interface IBaseDal<T> where T : BaseEntitiy,new()
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetByIdLisy(List<int> ids);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> expression = null);
        T Get(Expression<Func<T, bool>> expression);
    }
}
