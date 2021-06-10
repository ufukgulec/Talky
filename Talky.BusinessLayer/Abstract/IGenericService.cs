using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Talky.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    }
}
