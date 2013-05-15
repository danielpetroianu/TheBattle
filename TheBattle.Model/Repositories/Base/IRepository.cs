using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace TheBattle.Model.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> query);
        
        IRepository<T> Add(T item);
        IRepository<T> Add(params T[] items);
        IRepository<T> Add(IEnumerable<T> items);
        IRepository<T> Update(T item);
        IRepository<T> Delete(T item);
        void Save();
    }
}
