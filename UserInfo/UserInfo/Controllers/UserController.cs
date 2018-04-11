using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using UserInfo.Models;
using UserInfo.Repo;

namespace UserInfo.Controllers
{
    public class UserController : Controller
    {
        IUserRepository _user;
        public UserController(IUserRepository userRepository)
        {
            _user = userRepository;
        }
        // GET: User
        public ActionResult Login()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Validate(string txtUserName, string txtPassword)
        {

            //var container = new UnityContainer();
            //var data = container.Resolve<IUserRepository>();
            var xx = _user.GetUsers();
            if (_user.GetUsers().Where(x=> (x.UserName == txtUserName && x.UserPassword == txtPassword)).Any())
            {
                ViewBag.Message("Valid users");

            }
            else
            {
                ViewBag.Message("Invalid users");
            }

            return View("Login");


        }
    }
}