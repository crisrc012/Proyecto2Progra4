using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Net;

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
                    this.mantenimiento.InnerHtml = "Modificacion de Estados";
                    this.txtestado.Disabled = true;
                    this.txtestado.Value = estado.CIdEstado.ToString();
                    this.txtdescripcion.Value = WebUtility.HtmlDecode(estado.SEstado);
                }
                else
                {
                    this.mantenimiento.InnerHtml = "Nuevos de Estados";
                    this.txtestado.Value = string.Empty;
                    this.txtdescripcion.Value = string.Empty;
                }
            }


        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Server.Transfer("Estados.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Cls_Estado_DAL Obj_Estado_DAL = new Cls_Estado_DAL();
            Obj_Estado_DAL.CIdEstado = Convert.ToChar(this.txtestado.Value);
            Obj_Estado_DAL.SEstado = this.txtdescripcion.Value.ToString();
            string tipo = Session["tipo"].ToString();
            if (tipo == "E")
            {
                Obj_Estado_BLL.Actualizar(ref Obj_Estado_DAL);
                Server.Transfer("Estados.aspx");
            }
            else
            {
                Obj_Estado_BLL.Insertar(ref Obj_Estado_DAL);
                Server.Transfer("Estados.aspx");
            }
        }
    }
}
 