using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
                Cls_Rol_DAL rol = (Cls_Rol_DAL)Session["Estado"];
                string tipo = Session["tipo"].ToString();
                if (rol != null & tipo == "E")
                {
                    this.mantenimiento.InnerHtml = "Modificacion de Roles";
                    this.txtRoles.Value = rol.bIdRol.ToString();
                    this.txtdescripcion.Value = rol.sDescripcion;
                }
                else
                {
                    this.mantenimiento.InnerHtml = "Nuevos Roles";
                    this.txtRoles.Value = string.Empty;
                    this.txtdescripcion.Value = string.Empty;
                }
            }

        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            Cls_Rol_DAL Obj_Rol_DAL = new Cls_Rol_DAL();
            Obj_Rol_DAL.bIdRol = Convert.ToByte(this.txtRoles.Value);
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