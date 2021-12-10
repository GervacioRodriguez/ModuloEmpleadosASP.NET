using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace modulosASP
{
    public partial class ModificacionEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //validacion de textbox

        protected void Button2_Click(object sender, EventArgs e)
        {
          
            
            SqlConnection conn = new SqlConnection("Data Source=192.168.11.75; Initial Catalog=Seic;Persist Security Info=True;User ID=sa;Password=Seicsa123;");
            string elemento = "select * from Vi_Empleados_131020 where num_empleado = @elemento";
            SqlCommand buscarElemento = new SqlCommand(elemento,conn);
            SqlCommand buscar = new SqlCommand(elemento, conn);
            buscar.Parameters.AddWithValue("@elemento", txtNum_empleado.Text);
            conn.Open();
            SqlDataReader registro = buscar.ExecuteReader();
            if (registro.Read())
            {
                LBNUM_EMPLEADO.Text = registro["num_empleado"].ToString();
                LBNOMBRE.Text = registro["NOMBRE"].ToString();
                txtEstatus.Text = registro["ESTATUS"].ToString();
                LBESTATUS.Text = registro["ESTATUSN"].ToString();
                txtNSS.Text = registro["nss"].ToString();


                // txtFecha_alta.Text = registro["fecha_alta"].ToString("dd/MM/yyyy");
                // DateTime.Parse();


            }
            else
            {
              //Response.Write("El Elemento que busca no se encuentra en la base de datos");
                //ScriptManager.RegisterStartupScript(this, typeof(Page), "popup", script1, true);

            }


        }
    }
}

