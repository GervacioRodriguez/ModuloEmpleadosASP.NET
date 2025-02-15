using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using modulosASP.Models;
using modulosASP.DTO;
using modulosASP.Funciones;

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
                    C_Proyecto objProyecto = new C_Proyecto(); //Aqui llamamos al modelo de la entidad para guardar el dato
                    objProyecto.Proyecto = DtoProyecto.Proyecto;
                    objProyecto.Tipo = DtoProyecto.Tipo;
                    objProyecto.Vigente = DtoProyecto.Vigente;
                    objProyecto.Clave = DtoProyecto.Clave;
                    //agregamos
                    db.C_Proyecto.Add(objProyecto);
                    db.SaveChanges();
                   
                 }
            }
            return View("Proyectos");
        }
    }
}