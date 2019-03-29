using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClubCampestre_DAL.CatalogosMantenimientos;

namespace Club_Campestre.Mantenimiento
{
    public partial class Mant_Estados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 Cls_Estado_DAL estado = (Cls_Estado_DAL)Session["Estado"];
                string tipo = Session["tipo"].ToString();
                if (estado != null & tipo == "E")
                {
                    TextBox_Cedula.Text = estado.CIdEstado.ToString();
                    TextBox_Nombre.Text = estado.SPKEstado;
                }
                else
                {
                    TextBox_Cedula.Text = "";
                    TextBox_Nombre.Text = "";
                }
            }


        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Server.Transfer("Estados.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}