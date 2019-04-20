using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Web.UI.WebControls;

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
            if (!IsPostBack)
            {
                this.BindGrid();
            }
        }

            //Metodo que listar 
        private void BindGrid()
        {
            //Se instancia objeto
            Obj_Estado_DAL = new Cls_Estado_DAL();

            if (this.txtFiltraEstados.Text == string.Empty)//listar
            {
                //llamado metodo listar estados
                Obj_Estado_BLL.Listar(ref Obj_Estado_DAL);
               
            }
            else
            {
                Obj_Estado_DAL.SEstado = this.txtFiltraEstados.Text;
                //llamado metodo listar estados
                Obj_Estado_BLL.Filtrar(ref Obj_Estado_DAL);
            }

            if(Obj_Estado_DAL.sMsjError == string.Empty)
            {
                //Carga de Grid con DataSet instanciado en DAL
                this.EstadoGridView.DataSource = Obj_Estado_DAL.DS.Tables[0];
                this.EstadoGridView.DataBind();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar Estados.";
                this.BindGrid();
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
                        Obj_Estado_DAL.CIdEstado = Convert.ToChar(row.Cells[0].Text);
                        Obj_Estado_DAL.SEstado = row.Cells[1].Text;

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
                        Obj_Estado_DAL.CIdEstado = Convert.ToChar(row.Cells[0].Text);
                        Obj_Estado_DAL.SEstado = row.Cells[1].Text;

                        //llamado metodo eliminar estados
                        Obj_Estado_BLL.Eliminar(ref Obj_Estado_DAL);// eliminar estados
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
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de Eliminar Estados.";
                this.BindGrid();
            }
        }

        // evento para Buscar
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BindGrid();
        }

        protected void txtFiltraEstados_TextChanged(object sender, EventArgs e)
        {
            this.BindGrid();
        }
    }
}