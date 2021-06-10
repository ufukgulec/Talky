using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talky.BusinessLayer.Abstract;
using Talky.DataAccessLayer.Abstract;

namespace Talky.BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _genericRepository;

        public GenericManager(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public void Delete(T entity)
        {
            _genericRepository.Delete(entity);
        }

        public void Delete(int id)
        {
            _genericRepository.Delete(id);
        }

        public T Get(int id)
        {
            return _genericRepository.Get(id);
        }

        public IQueryable<T> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _genericRepository.GetAll(expression);
        }

        public void Insert(T entity)
        {
            _genericRepository.Insert(entity);
        }

        public void Update(T entity)
        {
            _genericRepository.Update(entity);
        }
    }
}
