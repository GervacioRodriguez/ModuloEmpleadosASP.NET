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
                
          */
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string empleado = txtnumelento.Text;
            Response.Redirect("UpdateElemento.aspx?empleado="+empleado);
        }

        protected void dtelemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor1 = dtelemento.SelectedRow.Cells[0].ToString();
            //string valor2 = ;
            Response.Redirect("UpdateElemento.aspx?valor1="+valor1);
            /*foreach (GridView Rows in this.dtelemento.Rows)
            {
                string valor1,valor2,valor3,valor4,valor5;

                //valor1 = dtelemento.Rows[0].Cells[0].ToString();
                //valor1 = dtelemento.DataKeys[Rows.SelectedIndex]["0"].ToString();
                valor1 = dtelemento.DataKeys[Rows.SelectedIndex]["1"].ToString();
                valor2 = dtelemento.DataKeys[Rows.SelectedIndex]["1"].ToString();
                valor3 = dtelemento.DataKeys[Rows.SelectedIndex]["2"].ToString();
                valor4 = dtelemento.DataKeys[Rows.SelectedIndex]["3"].ToString();
                valor5 = dtelemento.DataKeys[Rows.SelectedIndex]["4"].ToString();

                Response.Redirect("UpdateElemento.aspx?valor1="+valor1);
                Response.Redirect("UpdateElemento.aspx?valor2="+valor2);
                Response.Redirect("UpdateElemento.aspx?valor3="+valor3);
                Response.Redirect("UpdateElemento.aspx?valor4="+valor4);
                Response.Redirect("UpdateElemento.aspx?valor5="+valor5);
            */
        }

        protected void dtelemento_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //string valor1 = dtelemento.Rows[].Cells[1].ToString();
            //Response.Write("UpdateElemento.aspx?valor5="+valor1);
        }
    }
    
}