using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClubCampestre_DAL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class Mant_Tipo_Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Server.Transfer("Tipo_Clientes.aspx");
        }

       

        protected void Guardar_ServerClick(object sender, EventArgs e)
        {

        }
    }
}