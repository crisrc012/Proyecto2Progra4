using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Net;

namespace Club_Campestre
{
    public partial class Mantenimiento_Tipos_De_Clientes : System.Web.UI.Page
    {
        private string pantallaMantenimiento = "TipoCliente.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cls_TipoCliente_DAL TipoCliente = (Cls_TipoCliente_DAL)Session["TipoCliente"];
                string tipo = Session["tipo"].ToString();
                txtIdTipoCliente.Disabled = true;
                if (TipoCliente != null & tipo == "E")
                {
                    this.mantenimiento.InnerHtml = "Modificacion de Tipo Cliente";
                    this.txtIdTipoCliente.Value = TipoCliente.BIdTipoCliente.ToString();
                    this.txtdescripcion.Value = WebUtility.HtmlDecode(TipoCliente.sDescripcion.ToString());
                }
                else
                {
                    this.mantenimiento.InnerHtml = "Nuevos de Tipos Cliente";
                    this.txtIdTipoCliente.Visible = false;
                    this.txtIdTipoCliente.Value = string.Empty;
                    this.txtdescripcion.Value = string.Empty;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Cls_TipoCliente_DAL Obj_TipoCliente_DAL = new Cls_TipoCliente_DAL();
            Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();


            if (txtdescripcion.Value.Trim().Equals(string.Empty))
            {
                //se agrega el label que indique lo que no hay datos 
                lblGuardar.InnerText = "Debe ingresar datos";
                lblGuardar.Visible = true;
            }
            else
            {
                lblGuardar.Visible = false;
                if (Session["tipo"].ToString() == "E") // Si se edita se debe de obtener el ID
                {
                    Obj_TipoCliente_DAL.BIdTipoCliente = Convert.ToByte(this.txtIdTipoCliente.Value);
                }
                Obj_TipoCliente_DAL.sDescripcion = this.txtdescripcion.Value.ToString();
                string tipo = Session["tipo"].ToString();
                if (tipo == "E")
                {
                    Obj_TipoCliente_BLL.crudTipoCliente(ref Obj_TipoCliente_DAL, BD.Actualizar);
                    Response.Redirect(pantallaMantenimiento, true);
                }
                else
                {
                    Obj_TipoCliente_BLL.crudTipoCliente(ref Obj_TipoCliente_DAL, BD.Insertar);
                    Response.Redirect(pantallaMantenimiento, true);
                }
            }

        }
    }
}