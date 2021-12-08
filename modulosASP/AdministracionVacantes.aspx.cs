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
                iniciaarllenado();

            }
        }
        private void iniciarllenado dropdwon()
        {
            
        }
        
        public DataSet consultar(string stringsql)
        {

        }
    }
}