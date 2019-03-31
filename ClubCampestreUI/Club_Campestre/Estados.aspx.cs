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
    public partial class Estados : System.Web.UI.Page
    {
        #region Variables Globales
        Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
        Cls_Estado_DAL Obj_Estado_DAL;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            ///Meter esto 
            if (!IsPostBack)
            {
                this.BindGrid();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// 


            //Metodo que listat 
        private void BindGrid()
        {
            //Se instancia objeto
            Obj_Estado_DAL = new Cls_Estado_DAL();

            if (this.txtFiltrar.Text == string.Empty)//listar
            {
                //llamado metodo listar estados
                Obj_Estado_BLL.listarEstado(ref Obj_Estado_DAL);
               
            }
            else
            {                
                //llamado metodo listar estados
                //Obj_Estado_BLL.filtrarEstados(ref Obj_Estado_DAL);
            }

            if(Obj_Estado_DAL.sMsjError == string.Empty)
            {
                //Carga de Grid con DataSet instanciado en DAL
                this.EstadoGridView.DataSource = Obj_Estado_DAL.DS.Tables[0];
                this.EstadoGridView.DataBind();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar Estados: [" + Obj_Estado_DAL.sMsjError + "].";
            }
            
            
        }

        //Boton nuevo 
        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["tipo"] = "N";
            Server.Transfer("Mant_Estados.aspx", false);//llama pantalla
        }

        //boton modificar
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Se instancia objeto
            Obj_Estado_DAL = new Cls_Estado_DAL();
            //Secion tipo Editar
            Session["tipo"] = "E";
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in EstadoGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_Estado_DAL.cIdEstado = Convert.ToChar(row.Cells[0].Text);
                        Obj_Estado_DAL.sPKEstado = row.Cells[1].Text;

                        //Sesion estado lleva el objeto
                        Session["Estado"] = Obj_Estado_DAL;
                        Server.Transfer("Mant_Estados.aspx");//llama la pantalla 
                    }
                    
                }
            }
        }

        //boton eliminar
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            //Se instancia objeto
            Obj_Estado_DAL = new Cls_Estado_DAL();

            //Recorre Grid buscando chk 
            foreach (GridViewRow row in EstadoGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_Estado_DAL.cIdEstado = Convert.ToChar(row.Cells[0].Text);
                        Obj_Estado_DAL.sPKEstado = row.Cells[1].Text;

                        //llamado metodo eliminar estados
                        //Obj_Estado_BLL.eliminarEstados(ref Obj_Estado_DAL);// eliminar estados
                    }

                }
            }
            if (Obj_Estado_DAL.sMsjError == string.Empty)
            {
                this.errorMensaje.InnerHtml = "Estado Eliminado con exito.";
                this.BindGrid();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar Estados: [" + Obj_Estado_DAL.sMsjError + "].";
            }
           

        }

        // evento para filtrar
        protected void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            this.BindGrid();
        }

    }
}