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

        [HttpPost]
        public ActionResult BurcarEmpleado(string NumEmpleado)
        {
            var empleado = new SEICEntities();
            var Encontrado = empleado.C_Ejecutivo.FirstOrDefault(
                e => e.Num_Empleado ==  NumEmpleado
                );

            if (Encontrado !=null)
            {
                return Json(new
                {
                    success = true,
                    data = new
                    {
                        Num_Empleado = Encontrado.Num_Empleado,
                        Nombre = Encontrado.Nombre,
                        Correo = Encontrado.Correo
                    }
                
                });
            }
            else
            {
                return Json(
                    new {
                        success = false,
                        mensaje = "Empleado no encontrado"
                    });
            }
        }

        [HttpPost]
        public ActionResult GuardarDatos(C_Ejecutivo objejecutivo)
        {
            try
            {
                var db = new SEICEntities();
                db.C_Ejecutivo.Add(objejecutivo);
                db.SaveChanges();
                return Json(new
                { //objeto de la respuesta
                    success = true,
                    message = "Nuevo Ejecutivo guardado Correctamente"
                });
            }
            catch (Exception ex)
            {
                return Json(
                    new
                    {
                        success = false,
                        message = "Error Al Guardar Datos " + ex.Message
                    });
            }
        }

        [HttpPut]
        public ActionResult ActualizarDatos(C_Ejecutivo ActualizarEjecutivo)
        {
            //generamos el context0
            try {
                var db = new SEICEntities();
                var ejExiste =
                    db.C_Ejecutivo
                    .FirstOrDefault(e => e.Num_Empleado == ActualizarEjecutivo.Num_Empleado);
                //Realizamos la existencia del los datos su el numero de empleado existe adelante

                if (ejExiste != null)
                {
                    ejExiste.Nombre = ActualizarEjecutivo.Nombre;
                    ejExiste.Correo = ActualizarEjecutivo.Correo;

                    //Guardamos Cambios

                    db.SaveChanges();
                    //generamos la respuesta 

                    return Json(
                        new
                        {
                            success = true,
                            message = "Actualizacion Correcta"
                        });
                }
                else
                {
                    return Json(
                        new
                        {
                            success = false,
                            message = "No se pudo actualizar "
                        });
                }
            }
            catch (Exception ex)
            {
                return Json(
                    new
                    {
                        success = false,
                        message = "No se Pudo Actualizar "+ ex.Message
                    });
            }

        }
    }
}