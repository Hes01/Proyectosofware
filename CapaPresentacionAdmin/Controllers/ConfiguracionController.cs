using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacionAdmin.Controllers
{
    public class ConfiguracionController : Controller
    {
        // GET: Configuración
        public ActionResult Usuarios()
        {
            return View();
        }

        public ActionResult Configuracion()
        {
            return View();
        }

        [HttpGet]//SIN CAMBIOS DEVUELVE INFO 
        public JsonResult ListarUsuarios()
        {
            List<Usuario> oLista = new CN_Usuarios().Listar(); // Pasar el estado al método correcto
            return Json(new {data = oLista}, JsonRequestBehavior.AllowGet);
        }

    }
}