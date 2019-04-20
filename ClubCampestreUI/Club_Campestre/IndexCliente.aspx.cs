using System;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class IndexCliente : System.Web.UI.Page
    {
   

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IniciarSesion(object sender, EventArgs e)
        {
            Cls_Usuario_DAL Obj_Usuarios_DAL = new Cls_Usuario_DAL();
            Cls_Usuario_BLL Obj_Usuarios_BLL = new Cls_Usuario_BLL();

            // buscar usuario por correo o por usuario
            //devolver idUsuario
            
            Obj_Usuarios_DAL.SContrasena = this.psw.Value;
            Obj_Usuarios_BLL.Encripta(ref Obj_Usuarios_DAL);

            //validar usuario y contrasenia y devolver nombre y rol
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();
            Obj_Persona_DAL.BIdRol = 1;

            if (Obj_Persona_DAL.BIdRol == 1)
            {
                Server.Transfer("Index.aspx", false);//llama pantalla

            }

            
        }
    }
}