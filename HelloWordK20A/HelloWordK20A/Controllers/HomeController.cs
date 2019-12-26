using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWordK20A.Models;

namespace HelloWordK20A.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int gio = 0;
            gio = DateTime.Now.Hour;
            if (gio < 12)
                ViewBag.xinchao = "Chào buổi sáng";
            else
                ViewBag.xinchao = "Chào buổi chiều";

            return View();
        }

        [HttpGet]
        public ViewResult XuLy()
        {
            return View();
        }

        [HttpPost]

        public ViewResult XuLy(GuestResponse khachmoi)
        {
            return View("HoanThanh", khachmoi);
        }        
    }
}