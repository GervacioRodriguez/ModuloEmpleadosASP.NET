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
            string nombre = "select * from c_ejecutivo where Num_empleado = @ejecutivo";
            SqlCommand buscar = new SqlCommand(nombre,conn);
            buscar.Parameters.AddWithValue("@ejecutivo",txtNum_empleado.Text);
            conn.Open();
            SqlDataReader registro = buscar.ExecuteReader();
            if (registro.Read())
            {
                lbusuarios.Text = registro["Num_empleado"].ToString();
                LBLOGIN.Text = registro["nombre"].ToString();
                LBPASSWORD.Text = registro["ejecutivo"].ToString();
            }

        }

        protected void lblink_home_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarEstatusElemento.aspx");
        }
    }
}