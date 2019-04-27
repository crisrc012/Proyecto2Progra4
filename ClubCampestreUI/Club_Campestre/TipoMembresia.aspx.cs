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
        private string pantallaMantenimiento = "Mant_Tipo_Membre.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Meter esto 
            if (!IsPostBack)
            {
                BindGrid(new Cls_TipoMembresia_DAL());
            }
        }
        private void BindGrid(Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL, BD Accion = BD.Listar)
        {
            Obj_TipoMembresia_BLL.crudTipoMembresia(ref Obj_TipoMembresia_DAL, Accion);
            if (Obj_TipoMembresia_DAL.DS.Tables.Count > 0)
            {
                TipoMembresiaGridView.DataSource = Obj_TipoMembresia_DAL.DS.Tables[0];
                TipoMembresiaGridView.DataBind();
            }
            else
            {
                // Mostrar error, no hay datos para mostrar
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
            Obj_TipoMembresia_DAL.sDescripcion = txtFiltrar.Value;
            BindGrid(Obj_TipoMembresia_DAL, BD.Filtrar);
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
                        //llamado metodo eliminar tipo membresia
                        Obj_TipoMembresia_BLL.crudTipoMembresia(ref Obj_TipoMembresia_DAL, BD.Eliminar);// eliminar tipo membresia
                    }
                }
            }
            if (Obj_TipoMembresia_DAL.sMsjError == string.Empty)
            {
                errorMensaje.InnerHtml = "Estado Eliminado con exito.";
                BindGrid(new Cls_TipoMembresia_DAL());
            }
            else
            {
                errorMensaje.InnerHtml = "Se presento un error a la hora de Eliminar Estados.";
                BindGrid(new Cls_TipoMembresia_DAL());
            }
        }

        protected void TipoMembresiaGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
           TipoMembresiaGridView.PageIndex = e.NewPageIndex;
            BindGrid(new Cls_TipoMembresia_DAL());
        }
    }
}