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
            string queryConectar = "Data Source=192.168.11.75;Initial Catalog=Seic;Persist Security Info=True;User ID=sa;Password=Seicsa123";
            SqlConnection conectar = new SqlConnection(queryConectar);
            conectar.Open();
   
        }
    
    }
}