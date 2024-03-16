using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace modulosASP.Models
{
    public class MantenimientoPeoducto
    {
        private SqlConnection conn;

        private void conectar()
        {
            string Constrig = ConfigurationManager.ConnectionStrings["Base1"].ToString();
            conn = new SqlConnection(Constrig);
        }

        public int Alta(producto pro)
        {
            conectar();
            String GuardarProducto = "INSERT INTO productos(descripcion,pc,pp VALUES(@descripcion,@pc,@pp))";
            SqlCommand comando = new SqlCommand(GuardarProducto, conn);
            comando.Parameters.Add("@descripcion",SqlDbType.VarChar);
            comando.Parameters.Add("@pc", SqlDbType.Float);
            comando.Parameters.Add("@pp", SqlDbType.Float);
            conn.Open();
            int i = comando.ExecuteNonQuery();
            conn.Close();
            return i;
        }


        //listar producto

        //public List<producto> RecuperarTodo()
        //{
        //    conectar();
        //    List<producto> producto = new List<producto>();
        //    String Verproducto = "SELECT descripcion,pc,pp FROM Productos";
        //    SqlCommand comando = new SqlCommand(Verproducto, conn);
        //    conn.Open();
        //    SqlDataReader registros = comando.ExecuteReader();
        //    while (registros.Read())
        //    {
        //        descripcion = registros["descripcion"].ToString();
        //    }
        //}
    }
}