using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClubCampestre_DAL.CatalogosMantenimientos;


namespace Club_Campestre
{
    public partial class Mant_Tipo_Membre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                Cls_TipoMembresia_DAL tipomembresia = (Cls_TipoMembresia_DAL)Session["TipoMembresia"];
                string tipo = Session["tipo"].ToString();
                if (tipomembresia != null & tipo == "E")
                {
                    TextBox_Descripcion.Text = tipomembresia.SPKDescripcion;
                    TextBox_Costo.Text = tipomembresia.Fcosto.ToString();

                }
                else
                {
                    TextBox_Descripcion.Text = "";
                    TextBox_Costo.Text = "";
                }
            }

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