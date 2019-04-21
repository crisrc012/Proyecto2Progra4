using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Net;

namespace Club_Campestre.Mantenimiento
{
    public partial class Mant_Estados : System.Web.UI.Page
    {
        private string pantallaMantenimiento = "Estados.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((BD)Session["tipo"] == BD.Actualizar)
                {
                    Cls_Estado_DAL estado = (Cls_Estado_DAL)Session["Estado"];
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
            Response.Redirect(pantallaMantenimiento, true);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtdescripcion.Value.Trim().Equals(string.Empty) || txtestado.Value.Trim().Equals(string.Empty))
            {
                //se agrega el label que indique lo que no hay datos 
                lblGuardar.InnerText = "Debe ingresar datos";
                lblGuardar.Visible = true;
            }
            else
            {
                Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
                Cls_Estado_DAL Obj_Estado_DAL = new Cls_Estado_DAL();
                lblGuardar.Visible = false;
                Obj_Estado_DAL.CIdEstado = Convert.ToChar(this.txtestado.Value);
                Obj_Estado_DAL.SEstado = this.txtdescripcion.Value.ToString();
                if ((BD)Session["tipo"] == BD.Actualizar)
                {
                    Obj_Estado_BLL.crudEstado(ref Obj_Estado_DAL, BD.Actualizar);
                }
                else
                {
                    Obj_Estado_BLL.crudEstado(ref Obj_Estado_DAL, BD.Insertar);
                }
                Response.Redirect(pantallaMantenimiento, true);
            }
        }
    }
}
 