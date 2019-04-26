using System;
using System.Web.UI.WebControls;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class Roles : System.Web.UI.Page
    {
        #region Variables Globales
        private Cls_Rol_BLL Obj_Rol_BLL = new Cls_Rol_BLL();
        private Cls_Rol_DAL Obj_Rol_DAL;
        private bool vFiltra = true;
        private string pantallaMantenimiento = "Mant_Rol.aspx";
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
            Obj_Rol_DAL = new Cls_Rol_DAL();

            if (this.txtFiltrar.Value == string.Empty)//listar
            {
                //llamado metodo listar roles
                Obj_Rol_BLL.crudRol(ref Obj_Rol_DAL, BD.Listar);
            }
            else
            {
                Obj_Rol_DAL.sDescripcion = this.txtFiltrar.Value;
                //llamado metodo listar roles
                Obj_Rol_BLL.crudRol(ref Obj_Rol_DAL, BD.Filtrar);
            }

            if (Obj_Rol_DAL.SMsjError == string.Empty)
            {
                //Carga de Grid con DataSet instanciado en DAL
                this.RolesGridView.DataSource = Obj_Rol_DAL.DS.Tables[0];
                this.RolesGridView.DataBind();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar Estados.";
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
            foreach (GridViewRow row in RolesGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        //Se instancia objeto
                        Obj_Rol_DAL = new Cls_Rol_DAL();
                        Obj_Rol_DAL.bIdRol = Convert.ToByte(row.Cells[0].Text.Trim());
                        Obj_Rol_DAL.sDescripcion = row.Cells[1].Text.Trim();
                        //Secion tipo Editar
                        Session["tipo"] = BD.Actualizar;
                        //Sesion estado lleva el objeto
                        Session["Rol"] = Obj_Rol_DAL;
                        Response.Redirect(pantallaMantenimiento, false);
                    }
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (vFiltra)
            {
                Obj_Rol_DAL = new Cls_Rol_DAL();

                //Recorre Grid buscando chk 
                foreach (GridViewRow row in RolesGridView.Rows)
                {
                    //busca el la fila
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        //si esta checkeado instancia las propiedades del objeto
                        CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                        if (chkRow.Checked)
                        {
                            Obj_Rol_DAL.bIdRol = Convert.ToByte(row.Cells[0].Text);
                            //llamado metodo eliminar estados
                            Obj_Rol_BLL.crudRol(ref Obj_Rol_DAL, BD.Eliminar);// eliminar estados
                        }
                    }
                }
                if (Obj_Rol_DAL.SMsjError == string.Empty)
                {
                    this.errorMensaje.InnerHtml = "Rol Eliminado con exito.";
                    this.BindGrid();
                }
                else
                {
                    this.errorMensaje.InnerHtml = "Se presento un error a la hora de Eliminar Rol.";
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

        protected void RolesGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RolesGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            RolesGridView.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }
    }
}