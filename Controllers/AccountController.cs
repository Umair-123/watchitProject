using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchIt.Models;
namespace WatchIt.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        UsersDataContext db = new UsersDataContext();
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Successful()
        {
            return View();
        }
        public ActionResult SuccessfulAdmin()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginCheck(User us )
        {
            var type= Request["optradio"];
            //User us = new User();
            //us.UserName=Request["email"];
            //us.Password=Request["password"];
            //var usr=db.Users.First(x=>x.UserName==us.UserName && x.Password==us.Password);
            var usr = from x in db.Users
                      where (x.UserName == us.UserName && x.Password == us.Password)
                      select x;
            
            
            if (usr != null )
            {
                if (type.ToString() == "User")
                {
                    return RedirectToAction("Successful");
                }
                else if(type.ToString() =="Admin")
                {
                    return RedirectToAction("SuccessfulAdmin");
                }
            }
            return RedirectToAction("Login");
            
        }

    }
}
