using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace modulosASP
{
    public partial class Alta_de_nuevo_candidato : System.Web.UI.Page
    {
        protected void calendario()
        {
            if (!IsPostBack)
            {
                CalendarFecha.Visible = false;
            }
        }

        protected void calcular_edad()
        {
               
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            calendario();
            calcular_edad();
        }

        protected void idCalendario_Click(object sender, EventArgs e)
        {
            CalendarFecha.Visible = !CalendarFecha.Visible;
        }

        protected void CalendarFecha_SelectionChanged(object sender, EventArgs e)
        {
            //solo mostrar la fecha en el texbox y que no puedan modificarla
            //nos vamos al texbox y buscamos la propiedad ReadOnly y lo marcamos como true
            txtFechaNacimiento.Text = CalendarFecha.SelectedDate.ToShortDateString();
        }
    }
}