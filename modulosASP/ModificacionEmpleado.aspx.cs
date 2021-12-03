using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace modulosASP
{
    public partial class ModificacionEmpleado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                string empleado =   "select" + 
                                    "T_Fechas.Num_Empleado,"+
                                    "Vi_Empleados_131020.Nombre,"+
                                    "Vi_Empleados_131020.Fecha_Alta,"+
                                    "Vi_Empleados_131020.Fecha_Baja," +
                                    "Vi_Empleados_131020.Fecha_Alta_Imss,"+
                                    "Vi_Empleados_131020.Fecha_Baja_Imss"+
                                    "from T_Fechas inner join Vi_empleados_131020  on " +
                                    " T_Fechas.Num_Empleado = Vi_Empleados_131020.num_empleado; ";

                SqlCommand command = new SqlCommand(empleado,conn);
                //string borrar = ("DELETE FROM t_FExpediente WHERE num_empleado = '" + txteliminar.Text + "' ");
               // SqlCommand commado = new SqlCommand(borrar, conn);
               // conn.Open();
                //commado.ExecuteNonQuery();
                //Response.Write(" < script> el elemento fue borrado </ script > ");
                //txteliminar.Text = " ";
            }
        }
    }
}

/*
            string query1 = "select Fecha_Alta,Fecha_Baja,Nombre from Vi_Empleados_131020 where num_empleado = @numelemento";
            SqlCommand bajas = new SqlCommand(query1,conn);
            bajas.Parameters.AddWithValue("@numelemento",txttotalbajas.Text);
            //llenar un datagridview
            SqlDataReader registro = bajas.ExecuteReader();
            if (registro.Read())
            {
                lbNombre.Text = registro["Nombre"].ToString();
            }
            else
            {
                MessageBox.Show("ingrese un numero de empleado valido consta de 6 numeros");
            }
            conn.Close();
 
 */