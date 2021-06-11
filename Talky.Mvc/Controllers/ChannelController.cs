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

        public ActionResult Index(int id)
        {
            var obj = channelService.Get(id);
            return View(obj);
        }
        public PartialViewResult List(int id)
        {
            var list = channelService.List(x => x.ServerId == id);
            return PartialView(list);
        }
    }
}