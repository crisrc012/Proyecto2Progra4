using System;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class IndexCliente : System.Web.UI.Page
    {
        private string sistemaMantenimiento = "Index.aspx";
        private string sistemaCliente = "IndexCliente.aspx";

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
                Obj_Persona_DAL.bIdRol = Convert.ToByte(Obj_Usuarios_DAL.DS.Tables[0].Rows[0][1]);
                Obj_Persona_DAL.sNombre = Obj_Usuarios_DAL.DS.Tables[0].Rows[0][0].ToString();
                Session["Persona"] = Obj_Persona_DAL;

                if (Obj_Persona_DAL.bIdRol == 1)
                {
                    Response.Redirect(sistemaMantenimiento, false);                    
                }
                else
                {
                    Response.Redirect(sistemaCliente, false);
                }
            }
            else
            {
                Response.Write("<script>window.alert('Usuario No se puede Registrar o ya se encuentra registrado');</script>");

            }
        }

    }
}