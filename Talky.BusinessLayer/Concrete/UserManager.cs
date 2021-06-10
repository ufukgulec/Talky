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
    public class UserManager : GenericManager<User>, IUserService
    {
        IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> List()
        {
            var list = GetAll().ToList();
            return list;
        }

        public List<User> List(Expression<Func<User, bool>> expression)
        {
            var list = GetAll(expression).ToList();
            return list;
        }

        public void Remove(User user)
        {
            Delete(user);
        }
    }
}
