using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using modulosASP.Models;
using modulosASP.DTO;
using System;
using Microsoft.AspNetCore.Mvc;
using ActionResult = System.Web.Mvc.ActionResult;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace modulosASP.Controllers
{
    public class ProyectoController : Controller
    {

        private List<SelectListItem> ObtenerTiposProyectos()
        {
            return new List<SelectListItem>
        {
            new SelectListItem { Value = "PUBLICO",Text="PUBLICO"},
            new SelectListItem { Value="PRIVADO",Text="PRIVADO"}

        };
        }


       [HttpPost]
        public ActionResult EditarId(string Clave,string Proyecto)
        {
    
            try {
                if (string.IsNullOrEmpty(Clave) || string.IsNullOrEmpty(Proyecto)) {

                    return Json(new { success = false, menssage = "Comprobar que clave o proyecto no vengan vacios" });

                }
                else
                {
                    var db = new SEICEntities();
         
            //consulta
            var IdData = db.C_Proyecto.FirstOrDefault(
                m => m.Clave ==Clave && m.Proyecto == Proyecto
                );

            if (IdData==null)
            {
                return HttpNotFound();
            }

                    ProyectoDTO dto = new ProyectoDTO
                    {
                        Clave = IdData.Clave,
                        Proyecto = IdData.Proyecto,
                        Tipo = IdData.Tipo
                    };

                    ViewBag.TiposProyectos = ObtenerTiposProyectos();
            return View(IdData);
          
            }
            }catch(Exception ex)
            {
                return Json(new { success = false, menssage = "Comprobar que clave o proyecto no vengan vacios" });

            }
        }
        public ActionResult EditarProyecto()
        {

            return View();
        }

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
                                      Tipo = pr.Tipo,
                                      Clave = pr.Clave

                                  }).ToList();
            }

            return View(listaproyectos);
        }

        public ActionResult AgregarProyecto()
        {

            return View();

        }

        [HttpPost]
        public ActionResult AgregarProyecto(ProyectoDTO DtoProyecto)
        {
            //aqui se guardara la informacion en metodo post
            //validamos modelo
            if (!ModelState.IsValid)
            {
                return View(DtoProyecto);
            }
            else
            {
                //si es valido ponemos la misma marca
                using (var db = new SEICEntities()) //AQUI LLAMAMOS LA CONEXION
                { 
                    var objProyecto = new C_Proyecto(); //Aqui llamamos al modelo de la entidad para guardar el dato
                    objProyecto.Proyecto = DtoProyecto.Proyecto;
                    objProyecto.Tipo = DtoProyecto.Tipo;
                    objProyecto.Vigente = DtoProyecto.Vigente;
                    objProyecto.Clave = DtoProyecto.Clave;
                    //agregamos
                    db.C_Proyecto.Add(objProyecto);
                    db.SaveChanges();
                   
                 }
                return Json(new { mensaje = "Proyecto guardado correctamente", exito = true });
            }
            //return View("Proyectos");
        }
    }
}