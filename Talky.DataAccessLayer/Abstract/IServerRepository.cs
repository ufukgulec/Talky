using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talky.EntityLayer.Concrete;

namespace Talky.DataAccessLayer.Abstract
{
    public interface IServerRepository : IGenericRepository<Server>
    {
        /// <summary>
        /// İlişkili tabloda listeleme metodudur.
        /// </summary>
        /// <returns></returns>
        List<Server> List();
        /// <summary>
        /// İlişkili tabloda listeleme metodudur.
        /// </summary>
        /// <param name="expression">Koşul</param>
        /// <returns></returns>
        List<Server> List(Expression<Func<Server, bool>> expression);
        /// <summary>
        /// İlişkili tabloda silme metodudur.
        /// </summary>
        /// <param name="server">Silinecek server</param>
        void Remove(Server server);
    }
}
