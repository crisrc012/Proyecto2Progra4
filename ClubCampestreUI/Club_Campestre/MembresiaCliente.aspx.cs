using System;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class MembresiaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = new System.Globalization.CultureInfo("en-US", true);
            customCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;

            if (!IsPostBack)
            {
                CargarTipoMembresias();
                this.cedulaRG.Value = string.Empty;
                this.DropDownMembresias.SelectedValue = "0";
                this.nombreRG.Value = string.Empty;
                this.fechaInicioRG.Value = DateTime.Today.ToString("yyyy-MM-dd");
                fechavence();

            }

        }

        private void CargarTipoMembresias()
        {
            Cls_TipoMembresia_DAL Obj_Tipo_DAL = new Cls_TipoMembresia_DAL();
            CLS_TipoMembresia_BLL Obj_Tipo_BLL = new CLS_TipoMembresia_BLL();
            Obj_Tipo_BLL.ListaTipoMembresia(ref Obj_Tipo_DAL);
            DropDownMembresias.DataSource = Obj_Tipo_DAL.DS.Tables[0];
            DropDownMembresias.DataTextField = "Descripcion";
            DropDownMembresias.DataValueField = "IdTipoMembresia";
            DropDownMembresias.DataBind();
        }

        private void fechavence()
        {
            DateTime fechainicio;
            if (fechaInicioRG.Value != string.Empty)
            {
                fechainicio = Convert.ToDateTime(fechaInicioRG.Value);
                fechaVenceRG.Value = fechainicio.AddYears(1).ToString("yyyy-MM-dd");
            }
        }

        protected void Membresias(object sender, EventArgs e)
        {

        }

        protected void Cerrar(object sender, EventArgs e)
        {
            Server.Transfer("IndexCliente.aspx");
        }
    }
}