using System;
using System.Web.UI.WebControls;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class Roles : System.Web.UI.Page
    {
        #region Variables Globales
        Cls_Rol_BLL Obj_Rol_BLL = new Cls_Rol_BLL();
        Cls_Rol_DAL Obj_Rol_DAL;
        bool vFiltra = true;
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

            if (this.FiltrarRol.Text == string.Empty)//listar
            {
                //llamado metodo listar estados
                Obj_Rol_BLL.Listar(ref Obj_Rol_DAL);

            }
            else
            {
                Obj_Rol_DAL.sDescripcion = this.FiltrarRol.Text;
                //llamado metodo listar estados
                Obj_Rol_BLL.Filtrar(ref Obj_Rol_DAL);
            }

            if (Obj_Rol_DAL.sMsjError == string.Empty)
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
            Session["tipo"] = "N";
            Server.Transfer("Mant_Rol.aspx", false);//llama pantalla
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Se instancia objeto
            Obj_Rol_DAL = new Cls_Rol_DAL();
            //Secion tipo Editar
            Session["tipo"] = "E";
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
                        Obj_Rol_DAL.bIdRol = Convert.ToByte(row.Cells[0].Text.Trim());
                        Obj_Rol_DAL.sDescripcion = row.Cells[1].Text.Trim();

                        //Sesion estado lleva el objeto
                        Session["Rol"] = Obj_Rol_DAL;
                        Server.Transfer("Mant_Rol.aspx");//llama la pantalla 
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
                            Obj_Rol_DAL.sDescripcion = row.Cells[1].Text;

                            //llamado metodo eliminar estados
                            Obj_Rol_BLL.Eliminar(ref Obj_Rol_DAL);// eliminar estados
                        }

                    }
                }
                if (Obj_Rol_DAL.sMsjError == string.Empty)
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
    }
}