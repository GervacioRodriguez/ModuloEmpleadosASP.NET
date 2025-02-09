using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using modulosASP.Models;
using modulosASP.DTO;

namespace modulosASP.Controllers
{
    public class ProyectoController : Controller
    {
        // GET: Proyecto
        public ActionResult Proyectos()
        {
            //generamos la lista de datos a imprimir
            List<ProyectoDTO> listaproyectos = null;
            //llamamos la conexion de la base de datos
            using (var db = new SEICEntities())
            {
                listaproyectos = (from pr in db.C_Proyecto
                                  select new ProyectoDTO
                                  {
                                  
                                      Proyecto = pr.Proyecto,
                                      Tipo = pr.Tipo
                                  
                                  }).ToList();
            }

                return View(listaproyectos);
        }
    }
}