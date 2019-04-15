using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace Club_Campestre
{
    public partial class Personas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            //Prueba Will para Milton 
        }

        protected void btnRemover_Click1(object sender, EventArgs e)
        {

        }

  

        protected void btnGuardar2_Click1(object sender, EventArgs e)
        {

        }

        protected void btnRemover2_Click1(object sender, EventArgs e)
        {

        }



        protected void DropDownListRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        protected void CorreoPersonaGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TelefonoPersonaGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DropDownRol.Text =this.DropDownRol.SelectedValue;
        }

        

        private void CargarRoles()
        {
            Cls_Rol_DAL Obj_Rol_DAL = new Cls_Rol_DAL();
            Cls_Rol_BLL Obj_Rol_BLL = new Cls_Rol_BLL();
            Obj_Rol_BLL.Listar(ref Obj_Rol_DAL);
                       
            //DataRow row = Obj_Rol_DAL.DS.Tables[0].NewRow();
            //row["IdRol"] = 0;
            //row["Descripcion"] = "-- Seleccione --";
            //Obj_Rol_DAL.DS.Tables[0].Rows.Add(row);

            DropDownRol.DataSource = Obj_Rol_DAL.DS.Tables[0];          
            DropDownRol.DataTextField = "Descripcion";
            DropDownRol.DataValueField = "IdRol";
            DropDownRol.DataBind();
        }
    }
}