using System;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class RegistroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Registrarse(object sender, EventArgs e)
        {
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();

            Obj_Persona_DAL.SIdPersona = this.cedulaRG.Value.ToString().Trim();
            Obj_Persona_DAL.SNombre = this.nombreRG.Value.ToString().Trim();
            Obj_Persona_DAL.SDireccion = this.direccionRG.Value.ToString().Trim();
            Obj_Persona_DAL.BIdRol = 2;

            Obj_Persona_BLL.Insertar(ref Obj_Persona_DAL);

            Cls_Telefonos_DAL Obj_Telefonos_DAL = new Cls_Telefonos_DAL();
            Cls_Telefono_BLL Obj_Telefonos_BLL = new Cls_Telefono_BLL();

            Obj_Telefonos_DAL.STelefono = this.telefonoRG.Value.ToString().Trim();
            Obj_Telefonos_DAL.SIdPersona = this.cedulaRG.Value.ToString().Trim();
            Obj_Telefonos_BLL.Insertar(ref Obj_Telefonos_DAL);//   insertar

            Cls_Correos_DAL Obj_Correo_DAL = new Cls_Correos_DAL();
            Cls_Correos_BLL Obj_Correo_BLL = new Cls_Correos_BLL();

            Obj_Correo_DAL.SIdPersona = this.cedulaRG.Value.ToString().Trim();
            Obj_Correo_DAL.SCorreo = this.emailRG.Value.ToString().Trim();
            Obj_Correo_BLL.Insertar(ref Obj_Correo_DAL);//  insertar


            Cls_Clientes_DAL Obj_Cliente_DAL = new Cls_Clientes_DAL();
            Cls_Cliente_BLL Obj_Cliente_BLL = new Cls_Cliente_BLL();

            Obj_Cliente_DAL.SIdPersona = this.cedulaRG.Value.ToString().Trim();
            Obj_Cliente_DAL.BIdTipoCliente = 2;
            Obj_Cliente_BLL.Insertar(ref Obj_Cliente_DAL);


            Cls_Usuario_DAL Obj_Usuario_DAL = new Cls_Usuario_DAL();
            Cls_Usuario_BLL Obj_Usuario_BLL = new Cls_Usuario_BLL();

            Obj_Usuario_DAL.SIdUsuario = "Cliente";
            Obj_Usuario_DAL.SIdPersona = this.cedulaRG.Value.ToString().Trim();
            Obj_Usuario_DAL.SContrasena = this.passwordRG.Value.ToString().Trim();
            Obj_Usuario_BLL.Encripta(ref Obj_Usuario_DAL);
            Obj_Usuario_BLL.Insertar(ref Obj_Usuario_DAL);

            Session["Login"] = Obj_Usuario_DAL;
            Server.Transfer("IndexCliente.aspx");

        }

        protected void Cerrar(object sender, EventArgs e)
        {
           
            Server.Transfer("IndexCliente.aspx");
            
    
        }

    }
}