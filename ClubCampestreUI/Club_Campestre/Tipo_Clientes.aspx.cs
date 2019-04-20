using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Web.UI.WebControls;

namespace Club_Campestre
{
    public partial class Tipo_Clientes : System.Web.UI.Page
    {
        Cls_TipoCliente_DAL Obj_TipoCliente_DAL = new Cls_TipoCliente_DAL();
        Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
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
            if (Obj_TipoCliente_DAL.DS.Tables.Count > 0) {
                TipoClienteGridView.DataSource = Obj_TipoCliente_DAL.DS.Tables[0];
                TipoClienteGridView.DataBind();
            }
        }

        private void Filtrar()
        {
            
        }

        //Falta por modificar

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //Identificcion en lo que estamos trabjanado es un estado N
            Session["tipo"] = "N";
            Server.Transfer("Mantenimiento_Tipos_De_Clientes.aspx", false);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            
            //Se instancia objeto
            Obj_TipoCliente_DAL = new Cls_TipoCliente_DAL();
            //Secion tipo Editar
            Session["tipo"] = "E";
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in TipoClienteGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_TipoCliente_DAL.BIdTipoCliente = Convert.ToByte(row.Cells[0].Text);
                        Obj_TipoCliente_DAL.SPKDescripcion = row.Cells[1].Text;

                        //Sesion estado lleva el objeto
                        Session["MantenimientoTipoDeClientes"] = Obj_TipoCliente_DAL;
                        Server.Transfer("Mantenimiento_Tipos_De_Clientes.aspx");//llama la pantalla 
                    }
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Obj_TipoCliente_DAL = new Cls_TipoCliente_DAL();
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in TipoClienteGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_TipoCliente_DAL.BIdTipoCliente = Convert.ToByte(row.Cells[0].Text);
                        Obj_TipoCliente_DAL.SPKDescripcion = row.Cells[1].Text;
                        //llamado metodo eliminar
                        Obj_TipoCliente_BLL.Eliminar(ref Obj_TipoCliente_DAL);
                    }
                }
            }
            if (Obj_TipoCliente_DAL.SMsjError == string.Empty)
            {
                this.errorMensaje.InnerHtml = "Tipo de Cliente Eliminado con exito.";
                this.BindGrid();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de Eliminar Tipo de cliente.";
                this.BindGrid();
            }
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

        protected void TipoClienteGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            TipoClienteGridView.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }
    }
}