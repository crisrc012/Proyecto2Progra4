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
    public partial class Tipo_Clientes : System.Web.UI.Page
    {
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
            Cls_TipoCliente_DAL Obj_TipoCliente_DAL = new Cls_TipoCliente_DAL();
            Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();
            Obj_TipoCliente_BLL.ListaClientes(ref Obj_TipoCliente_DAL);
            TipoClienteGridView.DataSource = Obj_TipoCliente_DAL.DS.Tables[0];
            TipoClienteGridView.DataBind();
        }

        private void Filtrar()
        {
            
        }

        //Falta por modificar

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //Identificcion en lo que estamos trabjanado es un estado N
            Session["tipo"] = "N";
            Server.Transfer("Mant_Tipo_Cliente.aspx", false);
        }


        protected void btnEditar_Click(object sender, EventArgs e)
        {
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            Cls_TipoCliente_DAL Obj_TipoCliente_DAL = new Cls_TipoCliente_DAL();
            Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();
            Obj_TipoCliente_DAL.SPKDescripcion = txtFiltraTipocliente.Text;
            Obj_TipoCliente_BLL.Filtrar(ref Obj_TipoCliente_DAL);
            TipoClienteGridView.DataSource = Obj_TipoCliente_DAL.DS.Tables[0];
            TipoClienteGridView.DataBind();
        }

        protected void txtTipoCliente_TextChanged(object sender, EventArgs e)
        {

           
        }

        
    }
}