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
    public partial class Mant_Tipo_Servicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cls_TipoServicio_DAL tiposervicio = (Cls_TipoServicio_DAL)Session["TipoServicio"];
                string tipo = Session["tipo"].ToString();
                if (tiposervicio != null & tipo == "E")
                {
                    this.mantenimiento.InnerHtml = "Modificacion de Servicio";
                    //this.txtIdServicio.Value = tiposervicio.BIdTipoServicio.ToString();
                    this.txtdescripcion.Value = tiposervicio.SPKDescripcion.ToString();
                    this.txtcosto.Value = tiposervicio.Fcosto.ToString();

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

            Cls_TipoServicio_BLL Obj_tiposervicio_BLL = new Cls_TipoServicio_BLL();
            Cls_TipoServicio_DAL Obj_tiposervicio_DAL = new Cls_TipoServicio_DAL();
            //Obj_tiposervicio_DAL.BIdTipoServicio = Convert.ToByte(this.txtIdServicio.Value);
            Obj_tiposervicio_DAL.SPKDescripcion = this.txtdescripcion.Value.ToString();
            Obj_tiposervicio_DAL.Fcosto = Convert.ToInt32(this.txtcosto.Value);

            string tipo = Session["tipo"].ToString();
            if (tipo == "E")
            {
                Obj_tiposervicio_BLL.Actualizar(ref Obj_tiposervicio_DAL);
                Server.Transfer("TipoServicio.aspx");
            }
            else
            {
                Obj_tiposervicio_BLL.Insertar(ref Obj_tiposervicio_DAL);
                Server.Transfer("TipoServicio.aspx");
            }

        }
    }
}