using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XiaoChanZui.Models;
using Newtonsoft.Json;

namespace XiaoChanZui.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        //登录页面
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        //实现登录功能
        public ActionResult Login(string uname, string upwd)
        {
            string str = HttpClientHelper.Send("get", "api/UserAPI/Get?Name=" + uname + "&Pwd=" + upwd, null);
            Users users = JsonConvert.DeserializeObject<Users>(str);
            Session["UserName"] = users.UserName;
            Session["UserId"] = users.UserId;
            Session["UserPwd"] = users.UserPwd;
            Session["Phone"] = users.Phone;
            if (Session["UserName"] != null)
            {
                return Content("<script>alert('登录成功')</script>");
            }
            else
            {
                return Content("<script>alert('登录失败')</script>");
            }
        }
        [HttpGet]
        //注册页面
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        //实现注册功能
        public ActionResult Register(Users user)
        {
            string str = JsonConvert.SerializeObject(user);
            string i = HttpClientHelper.Send("post", "api/UserAPI/Post", str);
            return Content("<script>alert(" + i + ")</script>");
        }
        [HttpGet]
        //修改页面
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        //实现修改功能
        public ActionResult Update(Users user)
        {
            string str = JsonConvert.SerializeObject(user);
            string i = HttpClientHelper.Send("put", "api/UserAPI/Put", str);
            return Content("<script>alert(" + i + ")</script>");
        }
        public ActionResult Helper()
        {
            return View();
        }
    }
}