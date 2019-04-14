using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class TipoMembresia : System.Web.UI.Page
    {
        ////Wil
        //#region Variables Globales
        //Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
        //Cls_Estado_DAL Obj_Estado_DAL;
        //bool vFiltra = true;
        //#endregion
        ////Will


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindGrid();
            }


        }
        private void BindGrid()
        {
            //Aca tiene que programar el Grid Milton 

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //aca tiene que programar el boton Nuevo 
            Session["tipo"] = "N";
            Server.Transfer("Mant_Tipo_Membre.aspx", false);//llama pantalla

        }


        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Aca programar el boton editar
           
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //Botn Buscar
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void txtFiltraTipoMembre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}