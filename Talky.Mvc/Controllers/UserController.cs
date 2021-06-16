using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Talky.BusinessLayer.Abstract;
using Talky.BusinessLayer.Concrete;
using Talky.DataAccessLayer.Concrete.Repositories;
using Talky.EntityLayer.Concrete;

namespace Talky.Mvc.Controllers
{
    public class UserController : Controller
    {
        IUserService userService = new UserManager(new EfUserRepository());
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var obj = userService.List(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();

            if (obj != null)
            {
                FormsAuthentication.SetAuthCookie(obj.Id.ToString(), false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

        }
    }
}