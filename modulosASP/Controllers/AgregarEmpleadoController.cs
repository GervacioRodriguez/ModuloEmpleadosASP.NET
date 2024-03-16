using System;
using System.Collections.Generic;
using modulosASP.Models.EFConn;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modulosASP.Controllers
{
    public class AgregarEmpleadoController : Controller
    {
        // GET: AgregarEmpleado
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agregarempleado()
        {
            List<DTO.T_Empleado> Em = new List<DTO.T_Empleado>();
            
                return View();
        }

        public ActionResult Notaempleado()
        {
            return View();
        }
    }
}