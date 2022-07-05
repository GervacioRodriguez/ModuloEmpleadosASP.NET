using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace modulosASP
{
    public class connDB
    {   
        //public ConnectionState 
        public void conn()
        {
            string queryConectar = "Data Source=DESKTOP-DVRD5GT\\SQLEXPRESS01;Initial Catalog=aspempleado;Integrated Security=True";
            SqlConnection conectar = new SqlConnection(queryConectar);
            conectar.Open();
   
        }
    
    }
}