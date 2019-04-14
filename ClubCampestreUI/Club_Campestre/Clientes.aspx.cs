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
    public partial class Clientes : System.Web.UI.Page
    {
        #region Variables Globales
        Cls_Cliente_BLL Obj_Clientes_BLL = new Cls_Cliente_BLL();
        Cls_Clientes_DAL Obj_Clientes_DAL;
      
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

            if (this.txtFiltraClientes.Text == string.Empty)
                
                {
                Obj_Clientes_BLL.Listar(ref Obj_Clientes_DAL);
            }
            else
            {
                Obj_Clientes_DAL.SIdCliente =Convert.ToByte(this.txtFiltraClientes.Text);
                //Llamado del metodo listar clientes
                Obj_Clientes_BLL.Filtrar(ref Obj_Clientes_DAL);
            }
            if (Obj_Clientes_DAL.SMsjError == string.Empty)
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
            Session["tipo"] = "N";
            Server.Transfer("Mant_Tipo_Cliente.aspx", false);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Se instancia objeto
                Obj_Clientes_DAL = new Cls_Clientes_DAL();
            //Secion tipo Editar
            Session["tipo"] = "E";
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
                        Obj_Clientes_DAL.SIdCliente = Convert.ToSByte(row.Cells[0].Text);
                        Obj_Clientes_DAL.BIdTipoCliente = Convert.ToByte(row.Cells[0].Text);
                        Obj_Clientes_DAL.SIdPersona = row.Cells[2].Text;

                        //Sesion estado lleva el objeto
                        Session["Estado"] = Obj_Clientes_DAL;
                        Server.Transfer("Mant_Tipo_Cliente.aspx");//llama la pantalla 
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

                        Obj_Clientes_DAL.SIdCliente = Convert.ToByte(row.Cells[0].Text);
                        Obj_Clientes_DAL.BIdTipoCliente = Convert.ToByte(row.Cells[0].Text);
                        Obj_Clientes_DAL.SIdPersona = row.Cells[2].Text;
                        //llamado metodo eliminar estados
                        Obj_Clientes_BLL.Eliminar(ref Obj_Clientes_DAL);// eliminar estados
                    }

                }
            }
            if (Obj_Clientes_DAL.SMsjError == string.Empty)
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
        
    }
}