//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace modulosASP.Models.EFConn
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Empleado
    {
        public int Id { get; set; }
        public string Num_Empleado { get; set; }
        public Nullable<int> Empresa { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Nombres { get; set; }
        public Nullable<int> Tipo { get; set; }
        public Nullable<int> Area { get; set; }
        public Nullable<int> Modalidad { get; set; }
        public Nullable<int> Puesto { get; set; }
        public string Peso { get; set; }
        public string Estatura { get; set; }
    
        public virtual C_Area C_Area { get; set; }
        public virtual C_Empresa C_Empresa { get; set; }
        public virtual C_Tipo C_Tipo { get; set; }
    }
}