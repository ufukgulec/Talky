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
    public class EfServerRepository : EfGenericRepository<Server>, IServerRepository
    {
        public EfServerRepository() : base()
        {

        }
        public List<Server> List()
        {
            return GetAll().ToList();
        }

        public List<Server> List(Expression<Func<Server, bool>> expression)
        {
            return GetAll(expression).ToList();
        }

        public void Remove(Server server)
        {
            Delete(server);
        }
    }
}
