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
    public class ChannelManager : GenericManager<Channel>, IChannelService
    {
        IChannelRepository _channelRepository;

        public ChannelManager(IChannelRepository channelRepository) : base(channelRepository)
        {
            _channelRepository = channelRepository;
        }

        public List<Channel> List()
        {
            var list = GetAll().ToList();
            return list;
        }

        public List<Channel> List(Expression<Func<Channel, bool>> expression)
        {
            var list = GetAll(expression).ToList();
            return list;
        }

        public void Remove(Channel channel)
        {
            Delete(channel);
        }
    }
}
