using System;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class MembresiaCliente : System.Web.UI.Page
    {
        static bool validacion;

        protected void Page_Load(object sender, EventArgs e)
        {

            System.Globalization.CultureInfo customCulture = new System.Globalization.CultureInfo("en-US", true);
            customCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;

            if (!IsPostBack)
            {

                if (Session["Login"] == null)
                {
                    this.guardar.Disabled = true;
                    this.cedulaRG.Value = string.Empty;
                    this.nombreRG.Value = string.Empty;
                }
                else
                {
                    Cls_Persona_DAL persona = (Cls_Persona_DAL)Session["Login"];
                    this.cedulaRG.Value = persona.sNombre;
                    CargarTipoMembresias();
                    this.DropDownMembresias.SelectedIndex = 0;
                    this.fechaInicioRG.Value = DateTime.Today.ToString("yyyy-MM-dd");
                    validaDatos();
                }           
       
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
            if(validacion)
            {
                Cls_Membresias_BLL Obj_Membresia_BLL = new Cls_Membresias_BLL();
                Cls_Membresias_DAL Obj_Membresias_DAL = new Cls_Membresias_DAL();

                Obj_Membresias_DAL.sIdCliente = Convert.ToInt16(returnaIdCliente());
                Obj_Membresias_DAL.bIdTipoMembresia = Convert.ToByte(DropDownMembresias.Value);
                Obj_Membresias_DAL.cIdEstado = 'P';
                Obj_Membresias_DAL.dFechaInicio = Convert.ToDateTime(this.fechaInicioRG.Value.ToString());
                Obj_Membresias_DAL.dFechaVence = Convert.ToDateTime(this.fechaVenceRG.Value.ToString());

                Obj_Membresia_BLL.crudMembresias(ref Obj_Membresias_DAL, BD.Insertar);

                if (Obj_Membresias_DAL.sMsjError == string.Empty)
                {
                    Response.Write("<script>window.alert('sMembresia Registrada con Exito!!!');</script>");
                    Server.Transfer("IndexCliente.aspx");
                }
                else
                {
                    Response.Write("<script>window.alert('Error al Registrar sMembresia intentelo mas tarde');</script>");
                    Server.Transfer("IndexCliente.aspx");
                }
            }

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
            Cls_Usuario_DAL Obj_Usuarios_DAL = new Cls_Usuario_DAL();
            Cls_Usuario_BLL Obj_Usuarios_BLL = new Cls_Usuario_BLL();

            Cls_Persona_DAL persona = (Cls_Persona_DAL)Session["Login"];


            if (passwordRG.Value != string.Empty)
            {
                Obj_Usuarios_DAL.SIdPersona = this.cedulaRG.Value;
                Obj_Usuarios_DAL.SContrasena = this.passwordRG.Value;
                Obj_Usuarios_BLL.Encripta(ref Obj_Usuarios_DAL);
                Obj_Usuarios_BLL.Login(ref Obj_Usuarios_DAL);

                if (Obj_Usuarios_DAL.DS.Tables[0].Rows[0][0].ToString() == persona.sNombre)
                {
                    validacion = true;
                }
            }

        }

        private string returnaIdCliente()
        {
            Cls_Clientes_BLL Obj_Cliente_BLL = new Cls_Clientes_BLL();
            Cls_Clientes_DAL Obj_Cliente_DAL = new Cls_Clientes_DAL();
            Obj_Cliente_DAL.sIdPersona = this.cedulaRG.Value.Trim();
            Obj_Cliente_DAL.sIdCliente = short.MinValue;
            Obj_Cliente_DAL.bIdTipoCliente = byte.MinValue;
            Obj_Cliente_BLL.crudCliente(ref Obj_Cliente_DAL, BD.Filtrar);
            return Obj_Cliente_DAL.DS.Tables[0].Rows[0][0].ToString();
        }

        protected void valida_ServerClick(object sender, EventArgs e)
        {
            validacion = true;
        }
    }
}