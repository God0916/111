using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XiaoChanZui.Models;

namespace XiaoChanZui.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        //登录页面
        public ActionResult Login(string uname,string upwd)
        {
            return View();
        }
        //注册页面
        public ActionResult Register(Users u)
        {
            return View();
        }
    }
}