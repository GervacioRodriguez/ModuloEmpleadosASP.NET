using System;
using System.Collections.Generic;
using modulosASP.Models.EFConn;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

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
            using (SEICEntities db = new SEICEntities())
            {
                Em = (
                    from ep in db.T_Empleado
                    select new DTO.T_Empleado
                    {
                        Empresa = ep.Empresa,
                        Nombres = ep.Nombres
                    }).ToList();
            }
            return View(Em);
                //Json (Em);
        }

        public ActionResult Notaempleado()
        {
            return View();
        }
    }
}