using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Conexion
{
    public class ConnSql
    { 

        private SqlConnection conn;
        public void constructor()
        {
           string ConnSql1 = ConfigurationManager.ConnectionStrings["SEICConnectionString"].ToString();
            conn = new SqlConnection(ConnSql1);
        } 
    }
}
