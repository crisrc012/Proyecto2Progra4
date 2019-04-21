using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace Club_Campestre
{
    public partial class Mant_Tipo_Membre : System.Web.UI.Page
    {
        #region Variables Globales
        private CLS_TipoMembresia_BLL Obj_Estado_BLL = new CLS_TipoMembresia_BLL();
        private string pantallaMantenimiento = "TipoMembresia.aspx";
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
                    this.txtTipoMembre.Disabled = true;
                    this.txtTipoMembre.Value = TipoMembresia.BIdTipoMembresia.ToString();
                    this.txtdescripcion.Value = TipoMembresia.SPKDescripcion;
                    this.txtcosto.Value = TipoMembresia.Fcosto.ToString();
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
            Server.Transfer(pantallaMantenimiento);
        }

       protected void btnGuardar_Click(object sender, EventArgs e)
        {
            CLS_TipoMembresia_BLL Obj_TipoMembresia_BLL = new CLS_TipoMembresia_BLL();
            Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
            if (txtdescripcion.Value.Trim().Equals(string.Empty) || txtcosto.Value.Trim().Equals(string.Empty))
            {
                //se agrega el label que indique lo que no hay datos 
                lblGuardar.InnerText = "Debe ingresar datos";
                lblGuardar.Visible = true;
            }
            else
            {
                lblGuardar.Visible = false;
                Obj_TipoMembresia_DAL.SPKDescripcion = this.txtdescripcion.Value.ToString();
                Obj_TipoMembresia_DAL.Fcosto = Convert.ToSingle(txtcosto.Value);
                string tipo = Session["tipo"].ToString();
                if (tipo == "E")
                {
                    Obj_TipoMembresia_DAL.BIdTipoMembresia = Convert.ToByte(this.txtTipoMembre.Value);
                    Obj_TipoMembresia_BLL.Actualizar(ref Obj_TipoMembresia_DAL);
                    Server.Transfer(pantallaMantenimiento);
                }
                else
                {
                    Obj_TipoMembresia_BLL.Insertar(ref Obj_TipoMembresia_DAL);
                    Server.Transfer(pantallaMantenimiento);
                }
            }
        }
    }
}