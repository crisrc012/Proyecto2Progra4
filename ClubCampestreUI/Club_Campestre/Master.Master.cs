using System;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System.Web.Security;

namespace Club_Campestre
{
    public partial class Master : System.Web.UI.MasterPage
    {
        private string pantallaInicio = "IndexCliente.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();

            if (Session["Login"] != null)
            {
                Cls_Persona_DAL persona = (Cls_Persona_DAL)Session["Login"];
                this.idUsuario.InnerText = persona.sNombre;
            }
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            Response.Cache.SetNoServerCaching();
            Response.Cache.SetNoStore();
            Request.Cookies.Clear();
            this.idUsuario.InnerText = string.Empty;
            Response.Redirect(pantallaInicio, true);
        }
    }
}