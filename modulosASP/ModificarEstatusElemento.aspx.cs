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


        protected void Button2_Click(object sender, EventArgs e)
        {
            string empleado = txtelemento.Text;
            Response.Redirect("UpdateElemento.aspx?empleado="+empleado);
        }

        protected void dtelemento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor1 = dtelemento.SelectedRow.Cells[0].ToString();
            Response.Redirect("UpdateElemento.aspx?valor1="+valor1);
     
        }

        protected void dtelemento_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //string valor1 = dtelemento.Rows[].Cells[1].ToString();
            //Response.Write("UpdateElemento.aspx?valor5="+valor1);
        }

        protected void btnBuscar(object sender, EventArgs e)
        {
            /*
            if (IsValid)
            {
                string empleado = txtnumelento.Text;
                Response.Redirect("UpdateElemento.aspx?empleado=" + empleado);

            }*/

            SqlConnection conn = new SqlConnection("Data Source=192.168.11.75; Initial Catalog=Seic;Persist Security Info=True;User ID=sa;Password=Seicsa123;");
            string elemento = "select Num_empleado,EjecutivoN,proyecto,proyectoN,ServicioN,EstatusN,nombre,fecha_alta,fecha_baja from Vi_Empleados_131020 where num_empleado = @elemento";
            SqlCommand buscar = new SqlCommand(elemento, conn);
            buscar.Parameters.AddWithValue("@elemento",txtelemento.Text);
            SqlDataAdapter da = new SqlDataAdapter(buscar);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtelemento.DataSource = dt;
            dtelemento.DataBind();
        }

        protected void dtelemento_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string valor1 =  dtelemento.SelectedRow.Cells[1].ToString();
            //string valor1 = dtelemento.Rows[].Cells[1].ToString();
            Response.Write("UpdateElemento.aspx?valor5=" + valor1);
        }

        protected void dtelemento_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dtelemento.EditIndex = -1;
            dtelemento.PageIndex = e.NewPageIndex;
            fillgrilla();
        }

        private void fillgrilla()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection("Data Source=192.168.11.75; Initial Catalog=Seic;Persist Security Info=True;User ID=sa;Password=Seicsa123;");
            string elemento = "select Num_empleado,EjecutivoN,proyecto,proyectoN,ServicioN,EstatusN,nombre,fecha_alta,fecha_baja from Vi_Empleados_131020 where num_empleado = @elemento";


            SqlDataAdapter da = new SqlDataAdapter(elemento,conn);
                da.Fill(dt);
            
            dtelemento.DataSource = dt;
            dtelemento.DataBind();
        }

        protected void dtelemento_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //string estatus = "select * from vi_empleado_131020 where estado = 2";
        }

        protected void lbt_ejecutivo_Click(object sender, EventArgs e)
        {
            Response.Redirect("buscarEjecutivo.aspx");
        }

        protected void btnjavascript_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=192.168.11.75; Initial Catalog=Seic;Persist Security Info=True;User ID=sa;Password=Seicsa123;");
            string cambio1 = "update t_fechas set estatus = '1',fecha_baja = null where num_empleado IN (@numElemento)";
            string cambio2 = "update T_m_Estatus set estatus = '1',motivo=null,Comentarios=null where num_empleado IN (@numElemento)";
            string cambio3 = "update T_m_Estatus set estatus = '1',motivo=null,Comentarios=null where num_empleado IN (@numElemento)";
            string cambio4 = "update T_nn set estatus = '1' where num_empleado IN (@numElemento)";
            string cambio5 = "update t_ejecutivo set estatus = '1' where num_empleado IN (@numElemento)";
            string cambio6 = "update t_proyecto set estatus = '1' where num_empleado IN (@numElemento)";
            string cambio7 = "update t_ef set estatus = '1' where num_empleado IN (@numElemento)";
            string cambio8 = "update t_ejecutivo set estatus = '1' where num_empleado IN (@numElemeto)";
            SqlCommand command1 = new SqlCommand(cambio1,conn);
            SqlCommand command2 = new SqlCommand(cambio2, conn);
            SqlCommand command3 = new SqlCommand(cambio3, conn);
            SqlCommand command4 = new SqlCommand(cambio4, conn);
            SqlCommand command5 = new SqlCommand(cambio5, conn);
            SqlCommand command6 = new SqlCommand(cambio6, conn);
            SqlCommand command7 = new SqlCommand(cambio7, conn);
            SqlCommand command8 = new SqlCommand(cambio8, conn);

            command1.Parameters.AddWithValue("@numEmpleado",txtelemento.Text);
            command2.Parameters.AddWithValue("@numEmpleado",txtelemento.Text);
            command3.Parameters.AddWithValue("@numEmpleado", txtelemento.Text);
            command4.Parameters.AddWithValue("@numEmpleado", txtelemento.Text);
            command5.Parameters.AddWithValue("@numEmpleado", txtelemento.Text);
            command6.Parameters.AddWithValue("@numEmpleado", txtelemento.Text);
            command7.Parameters.AddWithValue("@numEmpleado", txtelemento.Text);
            command8.Parameters.AddWithValue("@numEmpleado", txtelemento.Text);

            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            command3.ExecuteNonQuery();
            command4.ExecuteNonQuery();
            command5.ExecuteNonQuery();
            command6.ExecuteNonQuery();
            command7.ExecuteNonQuery();
            command8.ExecuteNonQuery();

            //mensaje de actualizaccion 


        }
    }

        
    
}