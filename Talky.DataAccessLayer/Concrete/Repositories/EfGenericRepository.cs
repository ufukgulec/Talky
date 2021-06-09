using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talky.DataAccessLayer.Abstract;
using Talky.DataAccessLayer.Concrete.Context;

namespace Talky.DataAccessLayer.Concrete.Repositories
{
    public class EfGenericRepository<T> : IGenericRepository<T> where T : class
    {
        TalkyContext context = new TalkyContext();
        public DbSet<T> _object;
        public EfGenericRepository()
        {
            _object = context.Set<T>();
        }
        public void Delete(T entity)
        {
            _object.Remove(entity);
            context.SaveChanges();
        }

        public T Get(int id)
        {
            return _object.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _object.AsNoTracking();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _object.AsNoTracking().Where(expression);
        }

        public void Insert(T entity)
        {
            _object.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            _object.AddOrUpdate(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            _object.Remove(Get(id));
            context.SaveChanges();
        }
    }
}
