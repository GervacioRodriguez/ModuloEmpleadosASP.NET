using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace modulosASP
{
    public class operacion
    {
        public bool InsertarPersona(string rut, string nombre,string apellido)
        {
            connDB dB = new connDB();
            try
            {
                string sql = "";
                SqlCommand cmd = new SqlCommand(sql,dB);
            }
            catch
            {

            }
        }
    }
}