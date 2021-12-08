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
    public partial class AdministracionVacantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                iniciarllenadodropdwon();

            }
        }
        private void iniciarllenadodropdwon()
        {
            DPproyecto.DataSource = consultar("select * from c_proyecto");
            DPproyecto.DataTextField = "proyecto";
            DPproyecto.DataValueField = "id";
            DPproyecto.DataBind();
            DPproyecto.Items.Insert(0,new ListItem("[Seleccionar]","0"));
        }

        public DataSet consultar(string stringSQL)
        {
            string stconn = "Data Source=192.168.11.75;Initial Catalog=Seic;User ID=sa; Password = Seicsa123";
            SqlConnection con = new SqlConnection(stconn);
            con.Open();
            SqlCommand cmd = new SqlCommand(stringSQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);   //no puedes pasar de un char a un int
            return ds; 
         }

        protected void DPporyecto(object sender, EventArgs e)
        {
            int idSubproyecto = Convert.ToInt32(DPproyecto.SelectedValue);
            DPsubproyecto.DataSource = consultar("select * from C_SubProyecto where subproyecto =" + idSubproyecto);
            DPsubproyecto.DataTextField = "sub proyecto";
            DPsubproyecto.DataValueField = "ID sub proyecto";
            DPsubproyecto.DataBind();
            DPsubproyecto.Items.Insert(0, new ListItem("[Seleccionar]", "0"));

        }
    }
}