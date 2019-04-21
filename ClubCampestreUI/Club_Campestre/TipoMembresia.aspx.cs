using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Net;
using System.Web.UI.WebControls;

namespace Club_Campestre
{
    public partial class TipoMembresia : System.Web.UI.Page
    {
        private Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL;
        private Cls_TipoMembresia_BLL Obj_TipoMembresia_BLL = new Cls_TipoMembresia_BLL();
        private string pantallaMantenimiento = "Mant_TipoMembre.aspx";
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
            Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
            Obj_TipoMembresia_BLL.crudTipoMembresia(ref Obj_TipoMembresia_DAL, BD.Listar);
            if (Obj_TipoMembresia_DAL.DS.Tables.Count > 0)
            {
                TipoMembresiaGridView.DataSource = Obj_TipoMembresia_DAL.DS.Tables[0];
                TipoMembresiaGridView.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //aca tiene que programar el boton Nuevo 
            Session["tipo"] = BD.Insertar;
            Response.Redirect(pantallaMantenimiento, false);
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in TipoMembresiaGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        //Se instancia objeto
                        Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
                        //Secion tipo Editar
                        Session["tipo"] = BD.Actualizar;
                        Obj_TipoMembresia_DAL.bIdTipoMembresia = Convert.ToByte(row.Cells[0].Text);
                        Obj_TipoMembresia_DAL.sDescripcion = WebUtility.HtmlDecode(row.Cells[1].Text);
                        Obj_TipoMembresia_DAL.fCosto = Convert.ToSingle(row.Cells[2].Text);
                        //Sesion estado lleva el objeto
                        Session["TipoMembresia"] = Obj_TipoMembresia_DAL;
                        Response.Redirect(pantallaMantenimiento, false);
                    }
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
            Obj_TipoMembresia_DAL.sDescripcion = txtFiltraTipoMembre.Text;
            Obj_TipoMembresia_BLL.crudTipoMembresia(ref Obj_TipoMembresia_DAL, BD.Filtrar);
            TipoMembresiaGridView.DataSource = Obj_TipoMembresia_DAL.DS.Tables[0];
            TipoMembresiaGridView.DataBind();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in TipoMembresiaGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
                        Obj_TipoMembresia_DAL.bIdTipoMembresia = Convert.ToByte(row.Cells[0].Text);
                        Obj_TipoMembresia_DAL.sDescripcion = row.Cells[1].Text;
                        Obj_TipoMembresia_DAL.fCosto = Convert.ToSingle(row.Cells[2].Text);
                        //llamado metodo eliminar estados
                        Obj_TipoMembresia_BLL.crudTipoMembresia(ref Obj_TipoMembresia_DAL, BD.Eliminar);// eliminar estados
                    }
                }
            }
            if (Obj_TipoMembresia_DAL.sMsjError == string.Empty)
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

        protected void txtFiltraTipoMembre_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TipoMembresiaGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
           TipoMembresiaGridView.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }
    }
}