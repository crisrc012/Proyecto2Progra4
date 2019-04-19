using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Web.UI.WebControls;

namespace Club_Campestre
{
    public partial class Membresias : System.Web.UI.Page
    {

        #region Variables Globales
        Cls_Membresias_BLL Obj_Membresias_BLL = new Cls_Membresias_BLL();
        Cls_Membresias_DAL Obj_Membresias_DAL;
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
            Obj_Membresias_DAL = new Cls_Membresias_DAL();

            if (this.txtFiltrarMembresias.Text == string.Empty)//listar
            {
                //llamado metodo listar estados
                Obj_Membresias_BLL.Listar(ref Obj_Membresias_DAL);

            }
            else
            {
                Obj_Membresias_DAL.iIdMembresia = Convert.ToInt16(this.txtFiltrarMembresias.Text);
                //llamado metodo listar estados
                Obj_Membresias_BLL.Filtrar(ref Obj_Membresias_DAL);
            }

            if (Obj_Membresias_DAL.sMsjError == string.Empty)
            {
                //Carga de Grid con DataSet instanciado en DAL
                this.MembresiasGridView.DataSource = Obj_Membresias_DAL.DS.Tables[0];
                this.MembresiasGridView.DataBind();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar Estados.";
                this.BindGrid();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Obj_Membresias_DAL = new Cls_Membresias_DAL();

            //Recorre Grid buscando chk 
            foreach (GridViewRow row in MembresiasGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_Membresias_DAL.iIdMembresia = Convert.ToChar(row.Cells[0].Text);
                        //llamado metodo eliminar estados
                        Obj_Membresias_BLL.Eliminar(ref Obj_Membresias_DAL);// eliminar estados
                    }
                }
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Se instancia objeto
            Obj_Membresias_DAL = new Cls_Membresias_DAL();
            //Secion tipo Editar
            Session["tipo"] = "E";
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in MembresiasGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_Membresias_DAL.iIdMembresia = Convert.ToInt16(row.Cells[0].Text);
                        Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();
                        Obj_Persona_DAL.SIdPersona = row.Cells[1].Text;
                        Obj_Persona_DAL.SNombre = row.Cells[2].Text;

                        //Sesion estado lleva el objeto
                        Session["Membresia"] = Obj_Membresias_DAL;
                        Session["Persona"] = Obj_Persona_DAL;
                        Server.Transfer("Mant_Membresias.aspx");//llama la pantalla 
                    }
                }
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["tipo"] = "N";
            Server.Transfer("Mant_Membresias.aspx", false);//llama pantalla
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BindGrid();
        }
    }
}