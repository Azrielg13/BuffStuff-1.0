using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BuffStuff.Interfaces;
using System.Linq.Expressions;

namespace BuffStuff.Models
{
    public class ContextDb<TContext> : IDisposable, IContext where TContext : DbContext,  new()
    {
        private TContext _DataContext;
        protected virtual TContext DataContext
        {
            get
            {
                if (_DataContext == null)
                {
                    _DataContext = new TContext();
                }
                return _DataContext;
            }
        }

        public virtual IQueryable<T> GetAll<T>() where T : class
        {                   
            using (DataContext)
                {
                    return DataContext.Set<T>();
                }                   
        }

        public virtual T FindSingleBy<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            if (predicate != null)
            {
                using (DataContext)
                {
                    return DataContext.Set<T>().Where(predicate).SingleOrDefault();
                }
            }
            throw new ArgumentNullException("Predicate value must be passed to FindSingleBy<T>.");
        }

        public virtual IQueryable<T> FindAllBy<T>(Expression<Func<T, bool>> predicate) where T : class 
        {
            if (predicate != null)
            {
                using (DataContext)
                {
                    return DataContext.Set<T>().Where(predicate).AsQueryable<T>(); ;
                }
            }
           throw new ArgumentNullException("Predicate value must be passed to FindBy<T,TKey>.");

        }

        public IQueryable<T> GetIncluding<T>(params Expression<Func<T, object>>[] includeProperties) where T: class
        {
            IQueryable<T> query = _DataContext.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public virtual int Save<T>(T Entity) where T : class
        {
            return DataContext.SaveChanges();
        }

        public virtual int Update<T>(T Entity) where T : class
        {
            return DataContext.SaveChanges();
        }

        public virtual int Delete<T>(T entity) where T : class
        {
            DataContext.Set<T>().Remove(entity);
            return DataContext.SaveChanges();
        }

        public void Dispose()
        {
            if (DataContext != null) DataContext.Dispose();
        }
    }

}
