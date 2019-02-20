using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XiaoChanZui.Models;
using Newtonsoft.Json;
namespace XiaoChanZui.Controllers
{
    public class AddressesController : Controller
    {
        // GET: Addresses
        public ActionResult Index()
        {
            return View(show());
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        //新增
        public string Add(Addresses a)
        {
            string ss = JsonConvert.SerializeObject(a);
            string str = SendHelper.Send("post", "/Addressess/add/", ss);
            if(str=="1")
            {
                return "成功";
            }
            else
            {
                return "失败";
            }
        }
        //显示信息
        public List<Addresses>show()
        {
            string str = SendHelper.Send("get", "/Addressess/show/");
            List<Addresses> list = JsonConvert.DeserializeObject<List<Addresses>>(str);
            return list;
        }
        //删除
        public string Delete(int id)
        {
            string str = SendHelper.Send("delete", "/Addressess/Del/?id="+id);
            if(str=="1")
            {
                return "成功";
            }
            else
            {
                return "失败";
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var qq = show().Where(s => s.AddressId == id).FirstOrDefault();
            return View(qq);
        }
        //修改
        [HttpPost]
        public string Edit(Addresses a)
        {
            string ss = JsonConvert.SerializeObject(a);
            string str = SendHelper.Send("put", "/Addressess/Upd/", ss);
            if(str=="1")
            {
                return "成功";
            }
            else
            {
                return "失败";
            }
        }
    }
}