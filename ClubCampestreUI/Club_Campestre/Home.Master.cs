using System;
using ClubCampestre_DAL.CatalogosMantenimientos;


namespace Club_Campestre
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();

            if (Session["Persona"] != null)
            {
                Cls_Persona_DAL persona = (Cls_Persona_DAL)Session["Persona"];
                this.idUsuario.InnerText = persona.sNombre;
            }
        }
      }
}