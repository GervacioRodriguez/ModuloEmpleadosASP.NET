using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace modulosASP.DTO
{
    public class ProyectoDTO
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Nombre Del Proyecto")]
        public string Proyecto { get; set; }
        [Display(Name = "Tipo de Proyecto")]
        public string Tipo { get; set; }
        [Display(Name ="Clave Del Proyecto")]
        public string Clave { get; set; }
        [Display(Name ="Vigencia Del Proyecto")]
        public Nullable<int> Vigente { get; set; }
    }
}