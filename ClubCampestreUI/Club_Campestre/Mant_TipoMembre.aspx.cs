using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace Club_Campestre
{
    public partial class Mant_Tipo_Membre : System.Web.UI.Page
    {
        #region Variables Globales
        private Cls_TipoMembresia_BLL Obj_TipoMembresia_BLL = new Cls_TipoMembresia_BLL();
        private Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL;
        private string pantallaMantenimiento = "TipoMembresia.aspx";
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((BD)Session["tipo"] == BD.Actualizar)
                {
                    Obj_TipoMembresia_DAL = (Cls_TipoMembresia_DAL)Session["TipoMembresia"];
                    this.mantenimiento.InnerHtml = "Modificacion Tipo de Membresias";
                    this.txtTipoMembre.Disabled = true;
                    this.txtTipoMembre.Value = Obj_TipoMembresia_DAL.bIdTipoMembresia.ToString();
                    this.txtdescripcion.Value = Obj_TipoMembresia_DAL.sDescripcion;
                    this.txtcosto.Value = Obj_TipoMembresia_DAL.fCosto.ToString();
                }
                else
                {
                    this.mantenimiento.InnerHtml = "Nuevos tipos de Membresias";
                    this.txtTipoMembre.Disabled = true;
                    this.txtTipoMembre.Visible = false;
                    this.txtTipoMembre.Value = string.Empty;
                    this.txtdescripcion.Value = string.Empty;
                    this.txtcosto.Value = string.Empty;
                }
            }

        }
        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect(pantallaMantenimiento, true);
        }

       protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtdescripcion.Value.Trim().Equals(string.Empty) || txtcosto.Value.Trim().Equals(string.Empty))
            {
                //se agrega el label que indique lo que no hay datos 
                lblGuardar.InnerText = "Debe ingresar datos";
                lblGuardar.Visible = true;
            }
            else
            {
                lblGuardar.Visible = false;
                Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
                Obj_TipoMembresia_DAL.sDescripcion = this.txtdescripcion.Value.ToString();
                Obj_TipoMembresia_DAL.fCosto = Convert.ToSingle(txtcosto.Value);
                if ((BD)Session["tipo"] == BD.Actualizar)
                {
                    Obj_TipoMembresia_DAL.bIdTipoMembresia = Convert.ToByte(this.txtTipoMembre.Value);
                    Obj_TipoMembresia_BLL.crudTipoMembresia(ref Obj_TipoMembresia_DAL, BD.Actualizar);
                }
                else
                {
                    Obj_TipoMembresia_BLL.crudTipoMembresia(ref Obj_TipoMembresia_DAL, BD.Insertar);
                }
                Response.Redirect(pantallaMantenimiento, true);
            }
        }
    }
}