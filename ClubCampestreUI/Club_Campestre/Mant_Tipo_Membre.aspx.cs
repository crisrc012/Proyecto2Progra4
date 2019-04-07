using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;


namespace Club_Campestre
{
    public partial class Mant_Tipo_Membre : System.Web.UI.Page
    {
        #region Variables Globales
        Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Server.Transfer("TipoMembresia.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}