using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class VentaController : Controller
    {
        // GET: Venta
        public ActionResult Vender()
        {
            return View();
        }


        public ActionResult Reportes()
        {
            return View();
        }
    }
}