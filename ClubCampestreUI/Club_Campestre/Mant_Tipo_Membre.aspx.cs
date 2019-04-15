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
    public partial class Mant_Tipo_Membre : System.Web.UI.Page
    {
        #region Variables Globales
        CLS_TipoMembresia_BLL Obj_Estado_BLL = new CLS_TipoMembresia_BLL();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cls_TipoMembresia_DAL TipoMembresia = (Cls_TipoMembresia_DAL)Session["TipoMembresia"];
                string tipo = Session["tipo"].ToString();
                if (TipoMembresia != null & tipo == "E")
                {
                    this.mantenimiento.InnerHtml = "Modificacion Tipo de Membresias";
                    this.txtTipoMembre.Value = TipoMembresia.BIdTipoMembresia.ToString();
                    this.txtdescripcion.Value = TipoMembresia.SPKDescripcion;
                    this.txtcosto.Value = TipoMembresia.Fcosto.ToString();
                }
                else
                {
                    this.mantenimiento.InnerHtml = "Nuevos tipos de Membresias";
                    this.txtTipoMembre.Value = string.Empty;
                    this.txtdescripcion.Value = string.Empty;
                    this.txtcosto.Value = string.Empty;
                }
            }

        }
        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Server.Transfer("TipoMembresia.aspx");
        }

       protected void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS_TipoMembresia_BLL Obj_TipoMembresia_BLL = new CLS_TipoMembresia_BLL();
            Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
           
            Obj_TipoMembresia_DAL.SPKDescripcion = this.txtdescripcion.Value.ToString();
            Obj_TipoMembresia_DAL.Fcosto = Convert.ToInt64(txtcosto.Value);
            string tipo = Session["tipo"].ToString();
            if (tipo == "E")
            {
                Obj_TipoMembresia_DAL.BIdTipoMembresia = Convert.ToByte(this.txtTipoMembre.Value);
                Obj_TipoMembresia_BLL.Actualizar(ref Obj_TipoMembresia_DAL);
                Server.Transfer("TipoMembresia.aspx");
            }
            else
            {

                Obj_TipoMembresia_BLL.Insertar(ref Obj_TipoMembresia_DAL);
                Server.Transfer("TipoMembresia.aspx");
            }
        }
        
       

      
    }
}