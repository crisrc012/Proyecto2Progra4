using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Web.UI.WebControls;

namespace Club_Campestre
{
    public partial class Clientes : System.Web.UI.Page
    {
        #region Variables Globales
        private Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
        private Cls_Clientes_DAL Obj_Clientes_DAL;
        private string pantallaMantenimiento = "Mant_Cliente.aspx";
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindGrid();
            }
        }
        //Metodo Listar
        private void BindGrid()
        {
            //Instancia del Objeto
            Obj_Clientes_DAL = new Cls_Clientes_DAL();

            if (this.txtFiltrar.Value.Trim() == string.Empty)
            {
                Obj_Clientes_BLL.crudCliente(ref Obj_Clientes_DAL, BD.Listar);
            }
            else
            {
                Obj_Clientes_DAL.sIdPersona = this.txtFiltrar.Value.Trim();
                //Llamado del metodo filtrar clientes
                Obj_Clientes_BLL.crudCliente(ref Obj_Clientes_DAL, BD.FiltrarVista);
            }
            if (Obj_Clientes_DAL.sMsjError == string.Empty)
            {
                //Se cargan los datos con DS con la instancia del DAL
                this.ClientesGridView.DataSource = Obj_Clientes_DAL.DS.Tables[0];
                this.ClientesGridView.DataBind();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar los Clientes.";
                this.BindGrid();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["tipo"] = BD.Insertar;
            Response.Redirect(pantallaMantenimiento, false);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in ClientesGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        //Se instancia objeto
                        Obj_Clientes_DAL = new Cls_Clientes_DAL();
                        //Secion tipo Editar
                        Session["tipo"] = BD.Actualizar;
                        Obj_Clientes_DAL.sIdCliente = Convert.ToInt16(row.Cells[0].Text);
                        string sTipoCliente = row.Cells[1].Text;
                        Obj_Clientes_DAL.sIdPersona = row.Cells[2].Text;
                        //Sesion estado lleva el objeto
                        Session["Clientes"] = Obj_Clientes_DAL;
                        Session["sTipoCliente"] = sTipoCliente;
                        Response.Redirect(pantallaMantenimiento, false);
                    }
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Obj_Clientes_DAL = new Cls_Clientes_DAL();
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in ClientesGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_Clientes_DAL.sIdCliente = Convert.ToInt16(row.Cells[0].Text);
                        //llamado metodo eliminar cliente
                        Obj_Clientes_BLL.crudCliente(ref Obj_Clientes_DAL, BD.Eliminar);// eliminar cliente
                    }
                }
            }
            if (Obj_Clientes_DAL.sMsjError == string.Empty)
            {
                this.errorMensaje.InnerHtml = "Clientes Eliminado con exito.";
                this.BindGrid();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de Eliminar Clientes.";
                this.BindGrid();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BindGrid();
        }
        
        protected void ClientesGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ClientesGridView.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }
    }
}