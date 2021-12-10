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
                iniciar_llenadodropdwon();

            }
        }
        private void iniciar_llenadodropdwon()
        {
            DPproyecto.DataSource = consultar("select * from c_proyecto");
            DPproyecto.DataTextField = "proyecto";
            DPproyecto.DataValueField = "id";
            DPproyecto.DataBind();
            DPproyecto.Items.Insert(0,new ListItem("[Seleccione un Proyecto]","0"));
            DPsubproyecto.Items.Insert(0,new ListItem("[Seleccione un Sub-proyecto]","0"));
            DPservicio.Items.Insert(0,new ListItem("[Seleccione un Servicio]","0"));

            //llenado del dropdown de estado y municipio

            DPestado.DataSource = consultar("Select * from c_estado");
            DPestado.DataTextField = "Estado";
            DPestado.DataValueField = "id";
            DPestado.DataBind();
            DPestado.Items.Insert(0,new ListItem("[Seleccione el estado]","0"));
            DPmunicipio.Items.Insert(0,new ListItem("[Seleccione el municipio]","0"));
        }

        public DataSet consultar(string stringSQL)
        {
            string stconn = "Data Source=192.168.11.75; Initial Catalog=Seic;Persist Security Info=True;User ID=sa;Password=Seicsa123;";
            SqlConnection con = new SqlConnection(stconn);
            con.Open();
            SqlCommand cmd = new SqlCommand(stringSQL,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);  
            return ds; 
         }

        protected void DPporyecto(object sender, EventArgs e)
        {
            int idSubproyecto = Convert.ToInt32(DPproyecto.SelectedValue);
            DPsubproyecto.DataSource = consultar("select * from C_SubProyecto where proyecto ="+idSubproyecto);
            DPsubproyecto.DataTextField = "subproyecto";
            DPsubproyecto.DataValueField = "proyecto";
            DPsubproyecto.DataBind();
            DPsubproyecto.Items.Insert(0, new ListItem("[Seleccionar]","0"));
        }

        protected void DPservicio_index(object sender, EventArgs e)
        {
            int idServicio = Convert.ToInt32(DPsubproyecto.SelectedValue);
            DPservicio.DataSource = consultar("select * from c_servicio where =" +idServicio);
            DPservicio.DataTextField = "servicio";
            DPservicio.DataValueField = "proyecto";
            DPservicio.DataBind();
            DPservicio.Items.Insert(0,new ListItem("[Seleccionar el sub proyecto]","0"));
        }

        protected void DPestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idEstado = Convert.ToInt32(DPservicio.SelectedValue);
            DPestado.DataSource = consultar("select * from c_municipio=" +idEstado);
            DPestado.DataTextField = "municipio";
            DPestado.DataValueField = "id_estado";
            DPestado.DataBind();
            DPestado.Items.Insert(0,new ListItem("[Seleccione el municipio]","0"));
        }
    }
}