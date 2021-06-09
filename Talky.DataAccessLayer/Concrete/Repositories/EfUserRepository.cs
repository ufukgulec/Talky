using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talky.DataAccessLayer.Abstract;
using Talky.EntityLayer.Concrete;

namespace Talky.DataAccessLayer.Concrete.Repositories
{
    public class EfUserRepository : EfGenericRepository<User>, IUserRepository
    {
        public EfUserRepository() : base()
        {

        }
        public List<User> List()
        {
            return GetAll().ToList();
        }

        public List<User> List(Expression<Func<User, bool>> expression)
        {
            return GetAll(expression).ToList();
        }

        public void Remove(User user)
        {
            Delete(user);
        }
    }
}
