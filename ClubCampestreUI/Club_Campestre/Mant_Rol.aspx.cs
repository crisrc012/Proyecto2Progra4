using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Net;

namespace Club_Campestre
{
    public partial class Mant_Rol : System.Web.UI.Page
    {
        #region Variables Globales
        private string pantallaMantenimiento = "Roles.aspx";
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.txtRoles.Disabled = true;
                if ((BD)Session["tipo"] == BD.Actualizar)
                {
                    Cls_Rol_DAL rol = (Cls_Rol_DAL)Session["Rol"];
                    this.mantenimiento.InnerHtml = "Modificacion de Roles";
                    this.txtRoles.Value = rol.bIdRol.ToString();
                    this.txtdescripcion.Value = WebUtility.HtmlDecode(rol.sDescripcion);
                }
                else if ((BD)Session["tipo"] == BD.Insertar)
                {
                    lbltxtroles.Visible = false;
                    this.mantenimiento.InnerHtml = "Nuevos Roles";
                    this.txtRoles.Visible = false; // Este campo es Identity se debe de ocultar al ser nuevo
                    this.txtRoles.Value = string.Empty;
                    this.txtdescripcion.Value = string.Empty;
                }
            }
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            //Validar Campos en Blanco 
            if (txtdescripcion.Value.Trim().Equals(string.Empty))
            {
                //se agrega el label que indique lo que no hay datos 
                lblGuardar.InnerText = "Debe ingresar datos";
                lblGuardar.Visible = true;
            }
            else
            {
                lblGuardar.Visible = false;
                Cls_Rol_DAL Obj_Rol_DAL = new Cls_Rol_DAL();
                Cls_Rol_BLL Obj_Rol_BLL = new Cls_Rol_BLL();
                Obj_Rol_DAL.sDescripcion = this.txtdescripcion.Value.ToString();
                if ((BD)Session["tipo"] == BD.Actualizar)
                {
                    Obj_Rol_DAL.bIdRol = Convert.ToByte(this.txtRoles.Value); // Si se edita se debe de obtener el ID
                    Obj_Rol_BLL.crudRol(ref Obj_Rol_DAL, BD.Actualizar);
                }
                else if ((BD)Session["tipo"] == BD.Insertar)
                {
                    Obj_Rol_BLL.crudRol(ref Obj_Rol_DAL, BD.Insertar);
                }
                Response.Redirect(pantallaMantenimiento, true);
            }
            //Validar campos en Blanco 
        }
    }
}