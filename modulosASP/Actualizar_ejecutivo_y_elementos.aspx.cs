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
    public partial class Actualizar_ejecutivo_y_elementos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=192.168.11.75; Initial Catalog=Seic;Persist Security Info=True;User ID=sa;Password=Seicsa123;");
            string ejecutivo = "select * from Vi_Empleados_131020 where num_empleado = @ejecutivo";
            
            SqlCommand Bejecutivo = new SqlCommand(ejecutivo,conn);
            Bejecutivo.Parameters.AddWithValue("@ejecutivo",txtEjecutivo.Text);
            SqlDataReader eje = Bejecutivo.ExecuteReader();
            conn.Open();
            if (eje.Read())
            {
                LBNOMBRE.Text = eje["Nombre"].ToString();
                LBAREA.Text = eje["AreaN"].ToString();
                conn.Close();
            }
        }
    }
}