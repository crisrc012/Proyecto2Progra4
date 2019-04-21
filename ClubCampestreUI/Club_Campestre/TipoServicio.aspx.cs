using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Net;
using System.Web.UI.WebControls;

namespace Club_Campestre
{
    public partial class TipoServicio : System.Web.UI.Page
    {
        #region Variables Globales
        private Cls_TipoServicio_BLL Obj_TipoServicio_BLL = new Cls_TipoServicio_BLL();
        private Cls_TipoServicio_DAL Obj_TipoServicio_DAL;
        private string pantallaMantenimiento = "Mant_TipoServicio.aspx";
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindGrid();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Obj_TipoServicio_DAL = new Cls_TipoServicio_DAL();
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in TipoServicioGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_TipoServicio_DAL.bIdTipoServicio= Convert.ToByte(row.Cells[0].Text);
                        //llamado metodo eliminar estados
                        Obj_TipoServicio_BLL.crudTipoServicio(ref Obj_TipoServicio_DAL, BD.Eliminar);// eliminar estados
                    }
                }
            }
            if (Obj_TipoServicio_DAL.sMsjError == string.Empty)
            {
                this.errorMensaje.InnerHtml = "Estado Eliminado con exito.";
                this.BindGrid();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de Eliminar Estados.";
                this.BindGrid();
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in TipoServicioGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_TipoServicio_DAL = new Cls_TipoServicio_DAL();
                        //Secion tipo Editar
                        Session["tipo"] = BD.Actualizar;
                        Obj_TipoServicio_DAL.bIdTipoServicio = Convert.ToByte(row.Cells[0].Text);
                        Obj_TipoServicio_DAL.sDescripcion = WebUtility.HtmlDecode(row.Cells[1].Text);
                        Obj_TipoServicio_DAL.fCosto = Convert.ToSingle(row.Cells[2].Text);
                        //Sesion estado lleva el objeto
                        Session["TipoServicio"] = Obj_TipoServicio_DAL;
                        Response.Redirect(pantallaMantenimiento, false);
                    }
                }
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["tipo"] = BD.Insertar;
            Response.Redirect(pantallaMantenimiento, false);
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BindGrid();
        }

        protected void txtTipoServicio_TextChanged(object sender, EventArgs e)
        {
            this.BindGrid();
        }

        private void BindGrid()
        {
            //Se instancia objeto
            Obj_TipoServicio_DAL = new Cls_TipoServicio_DAL();

            if (this.txtFiltraTipoServicio.Text == string.Empty)//listar
            {
                //llamado metodo listar estados
                Obj_TipoServicio_BLL.crudTipoServicio(ref Obj_TipoServicio_DAL, BD.Listar);
            }
            else
            {
                Obj_TipoServicio_DAL.sDescripcion = this.txtFiltraTipoServicio.Text;
                //llamado metodo listar estados
                Obj_TipoServicio_BLL.crudTipoServicio(ref Obj_TipoServicio_DAL, BD.Filtrar);
            }
            if (Obj_TipoServicio_DAL.sMsjError == string.Empty)
            {
                //Carga de Grid con DataSet instanciado en DAL
                this.TipoServicioGridView.DataSource = Obj_TipoServicio_DAL.DS.Tables[0];
                this.TipoServicioGridView.DataBind();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar Estados.";
                this.BindGrid();
            }
        }

        protected void TipoServicioGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            TipoServicioGridView.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }
    }
}