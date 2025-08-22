using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using modulosASP.DTO;
using modulosASP.Models;

namespace modulosASP.Controllers
{
    public class GraficasController : Controller
    {
        // GET: Graficas
        public ActionResult Index()
        {

            List<ProyectoDTO> GraficaProyecto = null;
            using (var db = new SEICEntities())
            {
                GraficaProyecto = db.C_Proyecto
                                .GroupBy(p => p.Tipo.Trim())
                                .Select(g => new ProyectoDTO
                                {
                                    Tipo = g.Key,
                                    Total = g.Count()
                                }).ToList();
            }


            return View(GraficaProyecto);
            
        }

        public ActionResult GraficaTipoProyecto()
        {
            return View();
        }
    }
}