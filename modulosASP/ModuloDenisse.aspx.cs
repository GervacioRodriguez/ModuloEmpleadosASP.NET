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
            
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
            {
                string borrar = ("DELETE FROM t_FExpediente WHERE num_empleado = '" + txteliminar.Text + "'");
                SqlCommand commado = new SqlCommand(borrar, conn);
                conn.Open();
                commado.ExecuteNonQuery();
                Response.Redirect("ModuloDenisse.aspx");

            }
        }
    }
}