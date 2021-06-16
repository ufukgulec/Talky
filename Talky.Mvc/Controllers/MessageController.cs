using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Talky.BusinessLayer.Abstract;
using Talky.BusinessLayer.Concrete;
using Talky.DataAccessLayer.Concrete.Repositories;
using Talky.EntityLayer.Concrete;

namespace Talky.Mvc.Controllers
{
    public class MessageController : Controller
    {
        IMessageService messageService = new MessageManager(new EfMessageRepository());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List(int id)
        {
            var list = messageService.List(x => x.ChannelId == id);
            return View(list);
        }
        [HttpPost]
        public ActionResult Send(Message message)
        {
            message.SendingTime = DateTime.Now;
            messageService.Insert(message);
            return View();
        }
    }
}