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
            else
            {
                validaDatos();
            }

        }

        private void CargarTipoMembresias()
        {
            Cls_TipoMembresia_DAL Obj_Tipo_DAL = new Cls_TipoMembresia_DAL();
            Cls_TipoMembresia_BLL Obj_Tipo_BLL = new Cls_TipoMembresia_BLL();
            Obj_Tipo_BLL.crudTipoMembresia(ref Obj_Tipo_DAL, BD.Listar);
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

        private void returnaNombre()
        {
            if(this.cedulaRG.Value != string.Empty)
            {
                Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
                Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();
                Obj_Persona_DAL.sIdPersona = this.cedulaRG.Value.Trim();
                Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Filtrar);
                if (Obj_Persona_DAL.sMsjError == string.Empty)
                {
                    if (Obj_Persona_DAL.DS.Tables[0].Rows.Count > 0)
                    {
                        this.nombreRG.Value = Obj_Persona_DAL.DS.Tables[0].Rows[0][1].ToString();
                    }
                    else
                    {
                        Response.Write("<script>window.alert('La cedula ingresada no corresponde a ningun cliente. Por favro ingrese un cliente valido');</script>");
                        this.nombreRG.Value = string.Empty;
                    }
                }
                else
                {
                    Response.Write("<script>window.alert('Error a consultar datos, comunicarse con la administracion');</script>");
                    this.nombreRG.Value = string.Empty;
                }
            }
           
        }

        private void validaDatos()
        {
            returnaNombre();
            fechavence();
            validaPassword();
        }

        private void validaPassword()
        {
            if(passwordRG.Value != string.Empty)
            {

            }

        }

    }
}