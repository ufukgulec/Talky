using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Talky.BusinessLayer.Abstract;
using Talky.BusinessLayer.Concrete;
using Talky.DataAccessLayer.Abstract;
using Talky.DataAccessLayer.Concrete.Repositories;

namespace Talky.Mvc.Controllers
{
    public class ServerController : Controller
    {
        // GET: Server
        IServerService serverService = new ServerManager(new EfServerRepository());
        public ActionResult Index(int id)
        {
            ViewBag.serverID = id;
            var obj = serverService.Get(id);
            return View(obj);
        }
        public PartialViewResult List()
        {
            var list = serverService.List();
            return PartialView(list);
        }
    }
}