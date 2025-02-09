using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulosASP.DTO
{
    public class EmpleadoDTO
    {
        [Key]
        public int Id { get; set; }
        [Display(Name =("Matricula"))]
        public string Num_Empleado { get; set; }
        [Display(Name ="Empresa")]
        public Nullable<int> Empresa { get; set; }
        [Display(Name ="Apellido Paterno")]
        public string APaterno { get; set; }
        [Display(Name ="Apellido Materno")]
        public string AMaterno { get; set; }
        [Display(Name ="Nombres")]
        public string Nombres { get; set; }
        public Nullable<int> Tipo { get; set; }
        public Nullable<int> Area { get; set; }
        public Nullable<int> Modalidad { get; set; }
        public Nullable<int> Puesto { get; set; }
        public string Peso { get; set; }
        public string Estatura { get; set; }

    }
}
