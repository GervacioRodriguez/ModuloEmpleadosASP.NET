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
        [Required] //este campo es obligatorio
        [StringLength(100,ErrorMessage ="Longitud max 100")]
        public string Proyecto { get; set; }
        [Display(Name = "Tipo de Proyecto")]
        [Required]
        [StringLength(100, ErrorMessage = "longitud max 10")]
        public string Tipo { get; set; } = "";
        [Display(Name = "Clave Del Proyecto")]
        public string Clave { get; set; }
        [Display(Name ="Vigencia Del Proyecto")]
        public Nullable<int> Vigente { get; set; }

        public int Total { get; set; }
    }
}