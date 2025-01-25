using System;
using System.Collections.Generic;
using modulosASP.DTO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Conexion;
using System.Web.Helpers;

namespace modulosASP.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: AgregarEmpleado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agregarempleado()
        {
          
            List<EmpleadoDTO> ListaEmpleados = new List<EmpleadoDTO>();
            return View();
                //Json (Em);
        }

        public ActionResult Notaempleado()
        {
            return View();
        }
    }
}