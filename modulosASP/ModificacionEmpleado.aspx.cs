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

        //validacion de textbox

        protected void Button2_Click(object sender, EventArgs e)
        {
            string script = "window.alert('Texto a mostrar¿);";
            ScriptManager.RegisterStartupScript(this,typeof(Page),"popup",script,true);
            //se hara la comprobación para chechar que solo reciba numero y que sean de 6 digitos
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                
                //string empleado = "select concat('"+txtNum_empleado.Text+"',num_empleado) as num_empleado from T_Fechas union all select concat('"+txtNum_empleado.Text+"',num_empleado) from Vi_Empleados_131020";
                /*
                 string empleado =   @"select " + 
                                     "T_Fechas.Num_Empleado, "+
                                     "Vi_Empleados_131020.Nombre, "+
                                     "Vi_Empleados_131020.Fecha_Alta, "+
                                     "Vi_Empleados_131020.Fecha_Baja, " +
                                     "Vi_Empleados_131020.Fecha_Alta_Imss,"+
                                     "Vi_Empleados_131020.Fecha_Baja_Imss "+
                                     "from T_Fechas inner join Vi_empleados_131020  on " +
                                     "T_Fechas.Num_Empleado = Vi_Empleados_131020.num_empleado";

                si llegara a fallar checar si los espacios estan bien definidos recuerda que la concatenación
                 reconec entre espacios y no

                SqlCommand command = new SqlCommand(empleado,conn);
                SqlDataAdapter dato = new SqlDataAdapter(command);
                dato.SelectCommand.Parameters.Add("@empleado", SqlDbType.NVarChar).Value = Int64.Parse(txtNum_empleado.Text);
                DataTable dt = new DataTable();
                dato.Fill(dt);
                conn.Open();
                if (dt.Rows.Count > 0)
                {
                    DataRow misfilas = dt.Rows[0];
                    Label_NumEmpl.Text = misfilas["Num_empleado"].ToString();
                    Label_Nombre.Text = misfilas["Nombre"].ToString();
                    txtFecha_alta.Text = misfilas["fecha_alta"].ToString();
                    txtFecha_baja.Text = misfilas["fecha_baja"].ToString();

                
                }*/
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