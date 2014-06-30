using BuffStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace BuffStuff.Interfaces
{
    interface IContext : IDisposable
    {
        int Delete<T>(T entity) where T : class;
        void Dispose();
        IQueryable<T> FindAllBy<T>(Expression<Func<T, bool>> predicate) where T : class;
        T FindSingleBy<T>(Expression<Func<T, bool>> predicate) where T : class;
        IQueryable<T> GetAll<T>() where T : class;
        IQueryable<T> GetIncluding<T>(params Expression<Func<T, object>>[] includeProperties) where T : class;
        int Save<T>(T Entity) where T : class;
        int Update<T>(T Entity) where T : class;
    }
}
