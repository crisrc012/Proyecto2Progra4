using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace Club_Campestre
{
    public partial class Mant_Tipo_Servicio : System.Web.UI.Page
    {
        private string pantallaMantenimiento = "TipoServicio.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((BD)Session["tipo"] == BD.Actualizar)
                {
                    Cls_TipoServicio_DAL tiposervicio = (Cls_TipoServicio_DAL)Session["TipoServicio"];
                    this.mantenimiento.InnerHtml = "Modificacion de Servicio";
                    //this.txtIdServicio.Value = tiposervicio.bIdTipoServicio.ToString();
                    this.txtdescripcion.Value = tiposervicio.sDescripcion.ToString();
                    this.txtcosto.Value = tiposervicio.fCosto.ToString();
                }
                else
                {
                    this.mantenimiento.InnerHtml = "Nuevos de Tipo Servicio";
                    //this.txtIdServicio.Value = string.Empty;
                    this.txtdescripcion.Value = string.Empty;
                    this.txtcosto.Value = string.Empty;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //Le metimos un IF  y usamos un OR para validar losm dos campos de texto 
            if (txtdescripcion.Value.Trim().Equals(string.Empty) || txtcosto.Value.Trim().Equals(string.Empty))
            {
                //se agrega el label que indique lo que no hay datos 
                lblGuardar.InnerText = "Debe ingresar datos";
                lblGuardar.Visible = true;
            }
            else
            {
                // se oculta el label 
                lblGuardar.Visible = false;
                Cls_TipoServicio_BLL Obj_tiposervicio_BLL = new Cls_TipoServicio_BLL();
                Cls_TipoServicio_DAL Obj_tiposervicio_DAL = new Cls_TipoServicio_DAL();
                Obj_tiposervicio_DAL.sDescripcion = this.txtdescripcion.Value.ToString();
                Obj_tiposervicio_DAL.fCosto = Convert.ToInt32(this.txtcosto.Value);
                if ((BD)Session["tipo"] == BD.Actualizar)
                {
                    Obj_tiposervicio_BLL.crudTipoServicio(ref Obj_tiposervicio_DAL, BD.Actualizar);
                }
                else
                {
                    Obj_tiposervicio_BLL.crudTipoServicio(ref Obj_tiposervicio_DAL, BD.Insertar);
                }
                Response.Redirect(pantallaMantenimiento, true);
            }
        }
    }
}