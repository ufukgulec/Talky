using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talky.EntityLayer.Concrete;

namespace Talky.BusinessLayer.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        /// <summary>
        /// İlişkili tabloda listeleme metodudur.
        /// </summary>
        /// <returns></returns>
        List<Message> List();
        /// <summary>
        /// İlişkili tabloda listeleme metodudur.
        /// </summary>
        /// <param name="expression">Koşul</param>
        /// <returns></returns>
        List<Message> List(Expression<Func<Message, bool>> expression);
        /// <summary>
        /// İlişkili tabloda silme metodudur.
        /// </summary>
        /// <param name="message">Silinecek server</param>
        void Remove(Message message);
    }
}
