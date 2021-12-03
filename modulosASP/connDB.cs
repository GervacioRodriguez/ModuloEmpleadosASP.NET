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
        public SqlConnection GetConnection()
        {
            try
            {
                string cadena = "Data Source=192.168.15.45;Initial Catalog=Seic;User ID=sa;Password=***********";
                SqlConnection cnn = new SqlConnection(cadena);
                cnn.Open();
                return cnn;
            }
            catch
            {
                return null;
            }
        }
    }
}