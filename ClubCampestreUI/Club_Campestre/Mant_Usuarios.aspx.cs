using System;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class Mant_Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarDDL();
                Cls_Usuario_DAL Obj_Usuarios_DAL = (Cls_Usuario_DAL)Session["Usuario"];
                Cls_Usuario_BLL Obj_Usuarios_BLL = new Cls_Usuario_BLL();
                string tipo = Session["tipo"].ToString();
                if (Obj_Usuarios_DAL != null & tipo == "E")
                {
                    Obj_Usuarios_BLL.Desencripta(ref Obj_Usuarios_DAL);
                    this.mantenimiento.InnerHtml = "Modificacion de Usuario";
                    this.txtusuario.Value = Obj_Usuarios_DAL.SIdUsuario.ToString();
                    this.DropDownTUsuarios.SelectedValue = this.DropDownTUsuarios.Items.FindByValue(Obj_Usuarios_DAL.SIdPersona).ToString();
                    this.txtcontrasena.Value = Obj_Usuarios_DAL.SContrasena.ToString();
                }
                else
                {
                    this.mantenimiento.InnerHtml = "Nuevos de Usuario";
                    this.txtusuario.Value = string.Empty;
                    this.DropDownTUsuarios.SelectedIndex = 0;
                    this.txtcontrasena.Value = string.Empty;

                }
            }
        }

        private void LlenarDDL() //Llenado del Drop down list
        {
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();
            Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Listar);
            this.DropDownTUsuarios.DataSource = Obj_Persona_DAL.DS.Tables[0];
            this.DropDownTUsuarios.DataValueField = "Identificacion";
            this.DropDownTUsuarios.DataTextField = "Identificacion";
            this.DropDownTUsuarios.DataBind();
            this.DropDownTUsuarios.Items.Insert(0, "Seleccione una Identificación");
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Cls_Usuario_BLL Obj_Usuario_BLL = new Cls_Usuario_BLL();
            Cls_Usuario_DAL Obj_Usuario_DAL = new Cls_Usuario_DAL();
            Obj_Usuario_DAL.SIdUsuario = this.txtusuario.Value.ToString();
            Obj_Usuario_DAL.SIdPersona = this.DropDownTUsuarios.SelectedValue.ToString();
            Obj_Usuario_DAL.SContrasena = this.txtcontrasena.Value.ToString();

            string tipo = Session["tipo"].ToString();
            if (tipo == "E")
            {
                Obj_Usuario_BLL.Encripta(ref Obj_Usuario_DAL);
                Obj_Usuario_BLL.Actualizar(ref Obj_Usuario_DAL);
                Server.Transfer("Usuarios.aspx");
            }
            else
            {
                Obj_Usuario_BLL.Encripta(ref Obj_Usuario_DAL);
                Obj_Usuario_BLL.Insertar(ref Obj_Usuario_DAL);
                Server.Transfer("Usuarios.aspx");
            }
        }

        protected void DropDownTUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}