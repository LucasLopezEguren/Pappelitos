using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Pappelitos.DataAccess.Interface
{
    public interface IRepository<T> : IDisposable where T : class
    {
        void Add(T entity);
        void Save();
        void Delete(T entity);
        void Update(T entity);
        bool Has(T entity);
        IEnumerable<T> GetAll();
        T GetByName(string name);
        T GetById(int id);
        IEnumerable<T> GetByCondition(Expression<Func<T, bool>> expression);
        T GetFirst(Expression<Func<T, bool>> expression);
    }
}
