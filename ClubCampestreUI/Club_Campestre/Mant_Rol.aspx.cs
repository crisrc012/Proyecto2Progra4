using System;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class Mant_Rol : System.Web.UI.Page
    {
        #region Variables Globales
        Cls_Rol_BLL Obj_Rol_BLL = new Cls_Rol_BLL();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cls_Rol_DAL rol = (Cls_Rol_DAL)Session["Rol"];
                string tipo = Session["tipo"].ToString();
                this.txtRoles.Disabled = true;
                if (rol != null & tipo == "E")
                {
                    this.mantenimiento.InnerHtml = "Modificacion de Roles";
                    this.txtRoles.Value = rol.bIdRol.ToString();
                    this.txtdescripcion.Value = rol.sDescripcion;
                }
                else
                {
                    this.mantenimiento.InnerHtml = "Nuevos Roles";
                    this.txtRoles.Visible = false; // Este campo es Identity se debe de ocultar al ser nuevo
                    this.txtRoles.Value = string.Empty;
                    this.txtdescripcion.Value = string.Empty;
                }
            }

        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            Cls_Rol_DAL Obj_Rol_DAL = new Cls_Rol_DAL();
            if (Session["tipo"].ToString() == "E") // Si se edita se debe de obtener el ID
            {
                Obj_Rol_DAL.bIdRol = Convert.ToByte(this.txtRoles.Value);
            }
            Obj_Rol_DAL.sDescripcion = this.txtdescripcion.Value.ToString();
            string tipo = Session["tipo"].ToString();
            if (tipo == "E")
            {
                Obj_Rol_BLL.Actualizar(ref Obj_Rol_DAL);
                Server.Transfer("Roles.aspx");
            }
            else
            {
                Obj_Rol_BLL.Insertar(ref Obj_Rol_DAL);
                Server.Transfer("Roles.aspx");
            }
        }
    }
}