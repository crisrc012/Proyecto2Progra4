using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Web.UI.WebControls;

namespace Club_Campestre
{
    public partial class Usuarios : System.Web.UI.Page
    {
        #region Variables Globales
        private string pantallaMantenimiento = "Mant_Usuarios.aspx";
        private Cls_Usuario_BLL Obj_Usuario_BLL = new Cls_Usuario_BLL();
        private Cls_Usuario_DAL Obj_Usuario_DAL;
        private bool vFiltra = true;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindGrid();
            }
        }

        private void BindGrid()
        {
            //Se instancia objeto
            Obj_Usuario_DAL = new Cls_Usuario_DAL();

            if (this.FiltrarUsuarios.Text == string.Empty)//listar
            {
                //llamado metodo listar estados
                Obj_Usuario_BLL.crudUsuario(ref Obj_Usuario_DAL, BD.Listar);
            }
            else
            {
                Obj_Usuario_DAL.SIdUsuario = this.FiltrarUsuarios.Text;
                //llamado metodo listar estados
                Obj_Usuario_BLL.crudUsuario(ref Obj_Usuario_DAL, BD.Filtrar);
            }

            if (Obj_Usuario_DAL.sMsjError == string.Empty)
            {
                //Carga de Grid con DataSet instanciado en DAL
                this.UsuariosGridView.DataSource = Obj_Usuario_DAL.DS.Tables[0];
                this.UsuariosGridView.DataBind();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar Usuarios.";
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
            foreach (GridViewRow row in UsuariosGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    if ((row.Cells[0].FindControl("chkRow") as CheckBox).Checked)
                    {
                        //Secion tipo Editar
                        Session["tipo"] = BD.Actualizar;
                        //Se instancia objeto
                        Obj_Usuario_DAL = new Cls_Usuario_DAL();
                        Obj_Usuario_DAL.SIdUsuario = row.Cells[0].Text.Trim();
                        Obj_Usuario_DAL.SIdPersona = row.Cells[1].Text.Trim();
                        //Sesion estado lleva el objeto
                        Session["Usuario"] = Obj_Usuario_DAL;
                        Response.Redirect(pantallaMantenimiento, false);
                    }
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (vFiltra)
            {
                Obj_Usuario_DAL = new Cls_Usuario_DAL();

                //Recorre Grid buscando chk 
                foreach (GridViewRow row in UsuariosGridView.Rows)
                {
                    //busca el la fila
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        //si esta checkeado instancia las propiedades del objeto
                        CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                        if (chkRow.Checked)
                        {
                            Obj_Usuario_DAL.SIdUsuario = row.Cells[0].Text;
                            //llamado metodo eliminar estados
                            Obj_Usuario_BLL.crudUsuario(ref Obj_Usuario_DAL, BD.Eliminar);// eliminar estados
                        }
                    }
                }
                if (Obj_Usuario_DAL.sMsjError == string.Empty)
                {
                    this.errorMensaje.InnerHtml = "Usuario Eliminado con exito.";
                    this.BindGrid();
                }
                else
                {
                    this.errorMensaje.InnerHtml = "Se presento un error a la hora de Eliminar Usuario.";
                    this.BindGrid();
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BindGrid();
        }

        protected void Filtrar_TextChanged(object sender, EventArgs e)
        {
            vFiltra = false;
            if (vFiltra == false)
            {
                this.BindGrid();
            }
            vFiltra = true;
        }

        protected void UsuariosGridView_PageIndexChanged(object sender, EventArgs e)
        {

        }

        protected void UsuariosGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            UsuariosGridView.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }
    }
}