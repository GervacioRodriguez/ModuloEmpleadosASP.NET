using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using modulosASP.DTO;
using modulosASP.Models;

namespace modulosASP.Controllers
{
    public class EjecutivosController : Controller
    {
        // GET: Ejecutivos
        public ActionResult Ejecutivos()
        {
            //llamamos la lista
            List<EjecutivoDto> listaejecutivos = null;
            using (var db = new SEICEntities())
            {
                listaejecutivos = (from ej in db.C_Ejecutivo
                                   select new EjecutivoDto
                                   {
                                       Num_Empleado = ej.Num_Empleado,
                                       Nombre = ej.Nombre,
                                       Correo = ej.Correo
                                   }).ToList();
            }

                return View(listaejecutivos);
        }
    }
}