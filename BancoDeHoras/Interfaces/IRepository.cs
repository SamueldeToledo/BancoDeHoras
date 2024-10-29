using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Domain.Interfaces
{
    public interface IRepository <T> where T : class
    {
        IList<T> GetAll(Expression<Func<T, bool>> predicate = null);
        T Get(Expression<Func<T, bool>> predicate);
        void Post(T entity);
        void Put(T entity);
        void Delete(T entity);
        void Commit();
    }
}
