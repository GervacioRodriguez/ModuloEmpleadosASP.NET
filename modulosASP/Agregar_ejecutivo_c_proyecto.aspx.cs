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
    public partial class Agregar_ejecutivo_c_proyecto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=192.168.11.75; Initial Catalog=Seic;Persist Security Info=True;User ID=sa;Password=Seicsa123;");
            string nombre = "select * from Tb_Usuarios where Login = @login";
            SqlCommand buscar = new SqlCommand(nombre,conn);
            buscar.Parameters.AddWithValue("@login",txtNum_empleado.Text);
            conn.Open();
            SqlDataReader registro = buscar.ExecuteReader();
            if (registro.Read())
            {
                LBTBusuarios.Text = registro["Num_empleado"].ToString();
                LBLOGIN.Text = registro["login"].ToString();
                LBPASSWORD.Text = registro["Password"].ToString();
            }

        }
    }
}