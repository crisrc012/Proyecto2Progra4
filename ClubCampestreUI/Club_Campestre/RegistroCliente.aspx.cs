using System;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class RegistroCliente : System.Web.UI.Page
    {
        public enum Rol: byte
        {
            Administrativo = 1,
            Cliente = 2
        }

        public enum Cliente : byte
        {
            Socio = 1,
            Beneficiario = 2
        }
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Registrarse(object sender, EventArgs e)
        {
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();

            Obj_Persona_DAL.sIdPersona = this.cedulaRG.Value.ToString().Trim();
            Obj_Persona_DAL.sNombre = this.nombreRG.Value.ToString().Trim();
            Obj_Persona_DAL.sDireccion = this.direccionRG.Value.ToString().Trim();
            Obj_Persona_DAL.bIdRol = (byte)Rol.Cliente;

            Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Insertar);

            Cls_Telefonos_DAL Obj_Telefonos_DAL = new Cls_Telefonos_DAL();
            Cls_Telefono_BLL Obj_Telefonos_BLL = new Cls_Telefono_BLL();

            Obj_Telefonos_DAL.sTelefono = this.telefonoRG.Value.ToString().Trim();
            Obj_Telefonos_DAL.sIdPersona = this.cedulaRG.Value.ToString().Trim();
            Obj_Telefonos_BLL.crudTelefono(ref Obj_Telefonos_DAL, BD.Insertar);//   insertar

            Cls_Correos_DAL Obj_Correo_DAL = new Cls_Correos_DAL();
            Cls_Correos_BLL Obj_Correo_BLL = new Cls_Correos_BLL();

            Obj_Correo_DAL.sIdPersona = this.cedulaRG.Value.ToString().Trim();
            Obj_Correo_DAL.sCorreo = this.emailRG.Value.ToString().Trim();
            Obj_Correo_BLL.crudCorreos(ref Obj_Correo_DAL,BD.Insertar);//  insertar


            Cls_Clientes_DAL Obj_Cliente_DAL = new Cls_Clientes_DAL();
            Cls_Clientes_BLL Obj_Cliente_BLL = new Cls_Clientes_BLL();

            Obj_Cliente_DAL.sIdPersona = this.cedulaRG.Value.ToString().Trim();
            Obj_Cliente_DAL.bIdTipoCliente = (byte)Cliente.Socio;
            Obj_Cliente_BLL.crudCliente(ref Obj_Cliente_DAL, BD.Insertar);


            Cls_Usuario_DAL Obj_Usuario_DAL = new Cls_Usuario_DAL();
            Cls_Usuario_BLL Obj_Usuario_BLL = new Cls_Usuario_BLL();

            Obj_Usuario_DAL.SIdUsuario = this.cedulaRG.Value.ToString().Trim();
            Obj_Usuario_DAL.SIdPersona = this.cedulaRG.Value.ToString().Trim();
            Obj_Usuario_DAL.SContrasena = this.passwordRG.Value.ToString().Trim();
            Obj_Usuario_BLL.Encripta(ref Obj_Usuario_DAL);
            Obj_Usuario_BLL.crudUsuario(ref Obj_Usuario_DAL, BD.Insertar);


            Obj_Persona_DAL.sIdPersona = this.cedulaRG.Value.ToString().Trim();
            Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Filtrar);

            Session["Login"] = Obj_Persona_DAL;
            Server.Transfer("IndexCliente.aspx");

        }

        protected void Cerrar(object sender, EventArgs e)
        {
           
            Server.Transfer("IndexCliente.aspx");
            
    
        }

    }
}