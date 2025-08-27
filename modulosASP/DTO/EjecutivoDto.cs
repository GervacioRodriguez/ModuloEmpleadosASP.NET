using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace modulosASP.DTO
{
    public class EjecutivoDto
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Ejecutivos a su cargo")]
        public Nullable<int> Ejecutivo { get; set; }
        [Display(Name ="Nombre")]
        public string Nombre { get; set; }
        [Display(Name ="Correo Electronico")]
        public string Correo { get; set; }
        [Display(Name ="Numero de Ejecutivo")]
        public string Num_Empleado { get; set; }
    }
}