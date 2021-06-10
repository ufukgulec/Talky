using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talky.BusinessLayer.Abstract;
using Talky.DataAccessLayer.Abstract;
using Talky.EntityLayer.Concrete;

namespace Talky.BusinessLayer.Concrete
{
    public class ServerManager : GenericManager<Server>, IServerService
    {
        IServerRepository _serverRepository;

        public ServerManager(IServerRepository serverRepository) : base(serverRepository)
        {
            _serverRepository = serverRepository;
        }

        public List<Server> List()
        {
            var list = GetAll().ToList();
            return list;
        }

        public List<Server> List(Expression<Func<Server, bool>> expression)
        {
            var list = GetAll(expression).ToList();
            return list;
        }

        public void Remove(Server server)
        {
            Delete(server);
        }
    }
}
