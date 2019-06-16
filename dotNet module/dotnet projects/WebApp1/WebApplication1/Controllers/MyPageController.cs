using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MyPageController : Controller
    {

        
        // GET: MyPage
        public ActionResult Index()
        {
            int data = 420;
            ViewBag.Data = data;
            return View();
        }

        public ActionResult UsingId(int id=0,string name = "Suraj")
        {
            ViewBag.id = id;
            ViewBag.name = name;
            return View();
        }

    }
}