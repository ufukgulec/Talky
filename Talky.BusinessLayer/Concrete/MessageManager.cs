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
    public class MessageManager : GenericManager<Message>, IMessageService
    {
        IMessageRepository _messageRepository;

        public MessageManager(IMessageRepository messageRepository) : base(messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public List<Message> List()
        {
            var list = GetAll().ToList();
            return list;
        }

        public List<Message> List(Expression<Func<Message, bool>> expression)
        {
            var list = GetAll(expression).ToList();
            return list;
        }

        public void Remove(Message message)
        {
            Delete(message);
        }
    }
}
