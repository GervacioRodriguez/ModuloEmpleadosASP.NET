//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace modulosASP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Usuarios_I
    {
        public int Id { get; set; }
        public string RFC { get; set; }
        public string HOMOCLAVE { get; set; }
        public Nullable<int> ACTIVO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOPATERNO { get; set; }
        public string APELLIDOMATERNO { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<int> IDAREA { get; set; }
        public string TELEFONO { get; set; }
        public string EXTENSION { get; set; }
        public Nullable<int> IDPUESTO { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> IDNivelUSUARIO { get; set; }
    }
}
