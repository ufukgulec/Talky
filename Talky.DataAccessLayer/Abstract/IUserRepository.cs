using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talky.EntityLayer.Concrete;

namespace Talky.DataAccessLayer.Abstract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        /// <summary>
        /// İlişkili tabloda listeleme metodudur.
        /// </summary>
        /// <returns></returns>
        List<User> List();
        /// <summary>
        /// İlişkili tabloda listeleme metodudur.
        /// </summary>
        /// <param name="expression">Koşul</param>
        /// <returns></returns>
        List<User> List(Expression<Func<User, bool>> expression);
        /// <summary>
        /// İlişkili tabloda silme metodudur.
        /// </summary>
        /// <param name="user">Silinecek server</param>
        void Remove(User user);
    }
}
