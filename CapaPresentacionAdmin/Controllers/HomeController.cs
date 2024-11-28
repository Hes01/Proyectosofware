using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {


        //retorna vista
        public ActionResult Index()
        {
            return View();
        }


    }
}