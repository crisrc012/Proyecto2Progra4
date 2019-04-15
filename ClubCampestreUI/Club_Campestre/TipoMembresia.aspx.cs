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
        Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
        CLS_TipoMembresia_BLL Obj_TipoMembresia_BLL = new CLS_TipoMembresia_BLL();


        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
            ///Meter esto 
            if (!IsPostBack)
            {
                this.BindGrid();

            }


        }
        private void BindGrid()
        {
            Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
            CLS_TipoMembresia_BLL Obj_TipoMembresia_BLL = new CLS_TipoMembresia_BLL();
            Obj_TipoMembresia_BLL.ListaTipoMembresia(ref Obj_TipoMembresia_DAL);
            TipoMembresiaGridView.DataSource = Obj_TipoMembresia_DAL.DS.Tables[0];
            TipoMembresiaGridView.DataBind();
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
            Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
            CLS_TipoMembresia_BLL Obj_TipoMembresia_BLL = new CLS_TipoMembresia_BLL();
            Obj_TipoMembresia_DAL.SPKDescripcion = txtFiltraTipoMembre.Text;
            Obj_TipoMembresia_BLL.Filtrar(ref Obj_TipoMembresia_DAL);
            TipoMembresiaGridView.DataSource = Obj_TipoMembresia_DAL.DS.Tables[0];
            TipoMembresiaGridView.DataBind();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void txtFiltraTipoMembre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}