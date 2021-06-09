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
    public class EfMessageRepository : EfGenericRepository<Message>, IMessageRepository
    {
        public EfMessageRepository() : base()
        {

        }
        public List<Message> List()
        {
            return GetAll().ToList();
        }

        public List<Message> List(Expression<Func<Message, bool>> expression)
        {
            return GetAll(expression).ToList();
        }

        public void Remove(Message message)
        {
            Delete(message);
        }
    }
}
