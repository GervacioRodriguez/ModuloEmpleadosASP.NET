﻿using System;
using System.Collections.Generic;
using modulosASP.DTO;
using modulosASP.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using System.Web.WebPages.Html;

namespace modulosASP.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: AgregarEmpleado
        public ActionResult Empleados()
        { 
            List<EmpleadoDTO> listaempleado = null;
            using (var db = new SEICEntities())
            {
                listaempleado = (from ep in db.T_Empleado
                                 select new EmpleadoDTO
                                 {
                                     Num_Empleado = ep.Num_Empleado,
                                     APaterno = ep.APaterno,
                                     AMaterno = ep.AMaterno,
                                     Nombres = ep.Nombres

                                 }).Take(100).ToList();
            }
                return View(listaempleado);
        }

        public ActionResult EditarEmpleado(string idEmpleado)
        {
            List<EmpleadoDTO> empleadoDTOs = null;

            using (var db = new SEICEntities())
            {
                empleadoDTOs = db.T_Empleado.Where(p => p.Num_Empleado.Equals(idEmpleado)).First();
            }
                return View();
        }

       public ActionResult Notaempleado()
        {
            return View();
        }
    }
}