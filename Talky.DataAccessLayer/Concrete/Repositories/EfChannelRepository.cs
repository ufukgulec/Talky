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
    public class EfChannelRepository : EfGenericRepository<Channel>, IChannelRepository
    {
        public EfChannelRepository() : base()
        {

        }
        public List<Channel> List()
        {
            return GetAll().ToList();
        }

        public List<Channel> List(Expression<Func<Channel, bool>> expression)
        {
            return GetAll(expression).ToList();
        }

        public void Remove(Channel channel)
        {
            Delete(channel);
        }
    }
}
