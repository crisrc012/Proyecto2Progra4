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
            Login('I');
        }

        private void Login(char tipo)
        {
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();
            Cls_Usuario_DAL Obj_Usuarios_DAL = new Cls_Usuario_DAL();
            Cls_Usuario_BLL Obj_Usuarios_BLL = new Cls_Usuario_BLL();

            Obj_Usuarios_DAL.SIdPersona = this.uname.Value;
            Obj_Usuarios_DAL.SContrasena = this.psw.Value;
            Obj_Usuarios_BLL.Encripta(ref Obj_Usuarios_DAL);
            Obj_Usuarios_BLL.Login(ref Obj_Usuarios_DAL);


            

            if (Obj_Usuarios_DAL.DS.Tables[0].Rows.Count > 0)
            {
                Obj_Persona_DAL.BIdRol = Convert.ToByte(Obj_Usuarios_DAL.DS.Tables[0].Rows[0][2]);
                Obj_Persona_DAL.SNombre = Obj_Usuarios_DAL.DS.Tables[0].Rows[0][1].ToString();
                //this.mensajeError.InnerHtml = Obj_Persona_DAL.SNombre;

                if (Obj_Persona_DAL.BIdRol == 1)
                {
                    Server.Transfer("Index.aspx", false);//llama pantalla
                }
            }
            else
            {
                //this.mensajeError.InnerHtml = "Usuario no Registrado, ir a registro";

            }
        }

    }
}