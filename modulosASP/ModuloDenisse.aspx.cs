using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace modulosASP
{
    public partial class ModuloDenisse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnborrar_Click(object sender, EventArgs e)
        {
            string jv = "window.confirm('El usuario ya existe')";
            //string jv = "alert('Time OutAlert');";
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "msg", jv, true);
            //Response.Redirect("ModificacionEmpleado.aspx");

            //string alerta_existencia = "alerta_usuarios.j";
            //ClientScript.RegisterStartupScript(GetType(), "mostrar mensaje", "alerta_de_existencia();", true);
            /*
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            { //string valor = txteliminar.Text;
                string existente = ("select * from  T_Fexpediente where num_empleado = @buscar");
                conn.Open();
                SqlCommand bajas = new SqlCommand(existente, conn);
                bajas.Parameters.AddWithValue("@buscar",txteliminar.Text);
                SqlDataReader num_empleado = bajas.ExecuteReader();
                if (num_empleado.Read())
                {
                   
              
                    //Response.Write("<script type='text / javascript'>  alert('Hola Mundo!'); </script >");
                }
                
                string borrar = ("DELETE FROM t_FExpediente WHERE num_empleado = '"+ txteliminar.Text +"'");
                SqlCommand commado = new SqlCommand(borrar, conn);
                conn.Open();
                commado.ExecuteNonQuery();
                Response.Write(" <script> el elemento fue borrado </script > ");
                txteliminar.Text = " "; */

        }
    }
}