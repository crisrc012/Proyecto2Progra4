using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre.Mantenimiento
{
    public partial class Mant_Tipo_Cliente : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Cls_Clientes_DAL clientes = (Cls_Clientes_DAL)Session["Clientes"];
                string tipo = Session["tipo"].ToString();
                if(clientes != null & tipo == "E")
                {
            
                  /*  this.mantenimiento.InnerHtml = "Modificacion de Clientes";
                    this.txtidcliente.Value = clientes.SIdCliente.ToString();
                    this.txtidpersona.Value = clientes.SIdPersona.ToString();*/
                }
                else
                {
                  /*  this.mantemimiento.InnerHtml = "Nuevos de Clientes";
                    this.txtidcliente.Value = string.Empty;
                    this.txtidpersona.Value = string.Empty;*/
                }
            }


        }
        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Server.Transfer("Clientes.aspx");
        }

       

        protected void Guardar_ServerClick(object sender, EventArgs e)
        {
            Cls_Cliente_BLL Obj_Clientes_BLL = new Cls_Cliente_BLL();
            Cls_Clientes_DAL Obj_Clientes_DAL = new Cls_Clientes_DAL();
           // Obj_Clientes_DAL.SIdCliente = Convert.ToChar(this.txtidcliente.Value);
           // Obj_Clientes_DAL.SIdCliente = Convert.ToChar(this.txtidcliente.Value);
            string tipo = Session["tipo"].ToString();
            if (tipo == "E")
            {
                Obj_Clientes_BLL.Actualizar(ref Obj_Clientes_DAL);
                Server.Transfer("Clientes.aspx");
            }
            else
            {
                Obj_Clientes_BLL.Insertar(ref Obj_Clientes_DAL);
                Server.Transfer("Clientes.aspx");
            }
            }

        }
    }
