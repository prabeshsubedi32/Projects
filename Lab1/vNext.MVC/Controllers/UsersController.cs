using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vNext.MVC.Repository;


namespace vNext.MVC.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Login()
        {
            ViewBag.Message = "";
            return View();
        }

        public ActionResult Validate(string txtusername,string txtuserpassword)
        {
          if(UserRepository.GetUsers().Where(x=>x.UserNamed== txtusername && x.Password== txtuserpassword).Any())
            {
                ViewBag.Message = "You're Welcome " + txtusername;
            }
          else
            {
                ViewBag.Message = "Access Denied";
            }
            return View("Login");
        }
        
    }
}