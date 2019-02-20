using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XiaoChanZui.Models;
using Newtonsoft.Json;

namespace XiaoChanZui.Controllers
{
    public class AdressController : Controller
    {
        // GET: Adress
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AdressAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdressAdd(Addresses addresses,string Sheng,string Shi,string Qu)
        {
            addresses.Region = Sheng + Shi + Qu;
            return View();
        }
    }
}