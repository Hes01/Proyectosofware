using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmin.Controllers
{
    public class GestionController : Controller
    {
        // GET: Gestion
        public ActionResult Clientes()
        {
            return View();
        }
        public ActionResult Productos()
        {
            return View();
        }
    }
}