using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Talky.BusinessLayer.Abstract;
using Talky.BusinessLayer.Concrete;
using Talky.DataAccessLayer.Concrete.Repositories;

namespace Talky.Mvc.Controllers
{

    public class ChannelController : Controller
    {
        IChannelService channelService = new ChannelManager(new EfChannelRepository());
        IMessageService messageService = new MessageManager(new EfMessageRepository());
        public ActionResult Index(int id)
        {
            var obj = channelService.Get(id);
            obj.Messages = messageService.List(x => x.ChannelId == obj.Id);
            return View(obj);
        }
        public PartialViewResult List(int id)
        {
            var list = channelService.List(x => x.ServerId == id);
            return PartialView(list);
        }
    }
}