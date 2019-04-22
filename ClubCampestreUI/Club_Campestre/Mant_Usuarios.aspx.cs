using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace Club_Campestre
{
    public partial class Mant_Usuarios : System.Web.UI.Page
    {
        private string pantallaMantenimiento = "Usuarios.aspx";
        private Cls_Usuario_DAL Obj_Usuarios_DAL;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarDDL();
                if ((BD)Session["tipo"] == BD.Actualizar)
                {
                    Obj_Usuarios_DAL = (Cls_Usuario_DAL)Session["Usuario"];
                    mantenimiento.InnerHtml = "Modificacion de Usuario";
                    txtusuario.Disabled = true;
                    txtusuario.Value = Obj_Usuarios_DAL.SIdUsuario.ToString();
                    DropDownTUsuarios.Disabled = true;
                    DropDownTUsuarios.Value = Obj_Usuarios_DAL.SIdPersona;
                }
                else if ((BD)Session["tipo"] == BD.Insertar)
                {
                    mantenimiento.InnerHtml = "Nuevos de Usuario";
                    txtusuario.Value = string.Empty;
                    DropDownTUsuarios.SelectedIndex = 0;
                    txtcontrasena.Value = string.Empty;
                }
            }
        }
        private void LlenarDDL() //Llenado del Drop down list
        {
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();
            Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Listar);
            DropDownTUsuarios.DataSource = Obj_Persona_DAL.DS.Tables[0];
            DropDownTUsuarios.DataValueField = "Identificacion";
            DropDownTUsuarios.DataTextField = "Nombre";
            DropDownTUsuarios.DataBind();
            DropDownTUsuarios.Items.Insert(0, "Seleccione una persona");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Value.Trim().Equals(string.Empty) || txtcontrasena.Value.Trim().Equals(string.Empty) || DropDownTUsuarios.SelectedIndex == 0)
            {
                //se agrega el label que indique lo que no hay datos 
                lblGuardar.InnerText = "Debe ingresar datos";
                lblGuardar.Visible = true;
            }
            else
            {
                lblGuardar.Visible = false;
                if (!txtcontrasena.Value.Trim().Equals(string.Empty))
                {
                    Cls_Usuario_BLL Obj_Usuario_BLL = new Cls_Usuario_BLL();
                    Obj_Usuarios_DAL = new Cls_Usuario_DAL();
                    Obj_Usuarios_DAL.SIdUsuario = txtusuario.Value.ToString();
                    Obj_Usuarios_DAL.SIdPersona = DropDownTUsuarios.Value;
                    Obj_Usuarios_DAL.SContrasena = txtcontrasena.Value.Trim();
                    Obj_Usuario_BLL.Encripta(ref Obj_Usuarios_DAL);
                    if ((BD)Session["tipo"] == BD.Actualizar)
                    {
                        Obj_Usuario_BLL.crudUsuario(ref Obj_Usuarios_DAL, BD.Actualizar);
                    }
                    else if ((BD)Session["tipo"] == BD.Insertar)
                    {
                        Obj_Usuario_BLL.crudUsuario(ref Obj_Usuarios_DAL, BD.Insertar);
                    }
                }
                Response.Redirect(pantallaMantenimiento, true);
            }
        }
    }
}