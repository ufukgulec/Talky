using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talky.EntityLayer.Concrete;

namespace Talky.BusinessLayer.Abstract
{
    public interface IChannelService : IGenericService<Channel>
    {
        /// <summary>
        /// İlişkili tabloda listeleme metodudur.
        /// </summary>
        /// <returns></returns>
        List<Channel> List();
        /// <summary>
        /// İlişkili tabloda listeleme metodudur.
        /// </summary>
        /// <param name="expression">Koşul</param>
        /// <returns></returns>
        List<Channel> List(Expression<Func<Channel, bool>> expression);
        /// <summary>
        /// İlişkili tabloda silme metodudur.
        /// </summary>
        /// <param name="channel">Silinecek server</param>
        void Remove(Channel channel);
    }
}
