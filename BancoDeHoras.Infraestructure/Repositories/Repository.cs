using BancoDeHoras.Domain.Interfaces;
using BancoDeHoras.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeHoras.Infraestructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate)!;
        }

        public IList<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            try
            {
                if (predicate != null)
                {
                    return  _context.Set<T>().Where(predicate).ToList()!;
                }
                return  _context.Set<T>().ToList()!;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }
        }

        public void Post(T entity)
        {
           _context.Set<T>().Add(entity);
        }

        public void Put(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
    }
}
