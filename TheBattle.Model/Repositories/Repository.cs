using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace TheBattle.Model.Repositories
{
    public abstract class Repository<C, T> : IRepository<T>
        where T : class
        where C : DbContext, new()
    {

        private C _entities = new C();
        protected C Context
        {
            get { return _entities; }
            set { _entities = value; }
        }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public virtual IRepository<T> Add(T entity)
        {
            _entities.Set<T>().Add(entity);
            return this;
        }

        public virtual IRepository<T> Add(params T[] items)
        {
            foreach (T item in items)
                Add(item);

            return this;
        }

        public virtual IRepository<T> Add(IEnumerable<T> items)
        {
            foreach (T item in items)
                this.Add(item);

            return this;
        }

        public virtual IRepository<T> Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
            return this;
        }

        public virtual IRepository<T> Update(T entity)
        {
            _entities.Entry(entity).State = System.Data.EntityState.Modified;
            return this;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }


    }
}
