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
    public partial class ModificarEstatusElemento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=192.168.11.75; Initial Catalog=Seic;Persist Security Info=True;User ID=sa;Password=Seicsa123;");
            string elemento = "select Num_empleado,EjecutivoN,proyecto,proyectoN,ServicioN,EstatusN,nombre,fecha_alta,fecha_baja from Vi_Empleados_131020 where num_empleado = @elemento";
            SqlCommand buscar = new SqlCommand(elemento,conn);
            buscar.Parameters.AddWithValue("@elemento",txtnumelento.Text);
            /*------------
            SqlDataReader registro = buscar.ExecuteReader();
            if (registro.Read())
            {
                lb_ejecutivo.Text = registro["ejecutivo"].ToString();
            }
            ------------*/
            SqlDataAdapter da = new SqlDataAdapter(buscar);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtelemento.DataSource = dt;
            dtelemento.DataBind();

            /*
            string valor1;
            string valor2;
         

            foreach (GridViewRow rows in this.dtelemento.Rows)
            {
                valor1 = dtelemento.DataKeys[rows.RowIndex]["0"].ToString();

                valor2 = dtelemento.DataKeys[rows.RowIndex]["1"].ToString();

                Session["valor1"] = valor1;
                Session["valor2"] = valor2;


            }*/
            /*
            SqlCommand ejecutivo = new SqlCommand(elemento,conn);
            buscar.Parameters.AddWithValue("@elemento",txtnumelento.Text);
            conn.Open();
            SqlDataReader registro = ejecutivo.ExecuteReader();
            if (registro.Read())
            {
                lb_ejecutivo.Text = registro["num_empleado"].ToString();
                
                conn.Close();
            }
          */
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateElemento.aspx");
        }

        protected void dtelemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            
     

            string valor1;
            string valor2;


            foreach (GridViewRow rows in this.dtelemento.Rows)
            {
                valor1 = dtelemento.DataKeys[rows.RowIndex]["0"].ToString();
                Response.Redirect("UpdateElemento.aspx?valor1"+valor1);

                valor2 = dtelemento.DataKeys[rows.RowIndex]["1"].ToString();

               


            }
        }
    }
}