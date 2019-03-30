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
            if (!IsPostBack)
            {
                //Cls_Estado_DAL estado = (Cls_Estado_DAL)Session["Estado"];
                Cls_TipoCliente_DAL tipo_cliente = (Cls_TipoCliente_DAL)Session["Tipo_Cliente"];
                
                string tipo = Session["tipo"].ToString();
                if (tipo_cliente != null & tipo == "E")
                {
                    
                    TextBox_Tipo_Cliente.Text = tipo_cliente.BIdTipoCliente.ToString();
                    TextBox_Descripcion.Text = tipo_cliente.SPKDescripcion;

                    
                }
                else
                {
                    TextBox_Tipo_Cliente.Text = "";
                    TextBox_Descripcion.Text = "";
                }
            }

        }
        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Server.Transfer("Tipo_Clientes.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}