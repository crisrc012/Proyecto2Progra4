using System;
using System.Web.UI.WebControls;
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
            if (Obj_TipoMembresia_DAL.DS.Tables.Count > 0)
            {
                TipoMembresiaGridView.DataSource = Obj_TipoMembresia_DAL.DS.Tables[0];
                TipoMembresiaGridView.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //aca tiene que programar el boton Nuevo 
            Session["tipo"] = "N";
            Server.Transfer("Mant_Tipo_Membre.aspx", false);//llama pantalla

        }


        protected void btnEditar_Click(object sender, EventArgs e)
        {

            //Se instancia objeto
            Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
            //Secion tipo Editar
            Session["tipo"] = "E";
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
                        Obj_TipoMembresia_DAL.BIdTipoMembresia = Convert.ToByte(row.Cells[0].Text);
                        Obj_TipoMembresia_DAL.SPKDescripcion = row.Cells[1].Text;
                        Obj_TipoMembresia_DAL.Fcosto = Convert.ToSingle(row.Cells[2].Text);

                        //Sesion estado lleva el objeto
                        Session["TipoMembresia"] = Obj_TipoMembresia_DAL;
                        Server.Transfer("Mant_Tipo_Membre.aspx");//llama la pantalla 
                    }

                }
            }
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
            Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();

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
                        Obj_TipoMembresia_DAL.BIdTipoMembresia = Convert.ToByte(row.Cells[0].Text);
                        Obj_TipoMembresia_DAL.SPKDescripcion = row.Cells[1].Text;
                        Obj_TipoMembresia_DAL.Fcosto = Convert.ToSingle(row.Cells[2].Text);


                        //llamado metodo eliminar estados
                        Obj_TipoMembresia_BLL.Eliminar(ref Obj_TipoMembresia_DAL);// eliminar estados
                    }

                }
            }
            if (Obj_TipoMembresia_DAL.SMsjError == string.Empty)
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