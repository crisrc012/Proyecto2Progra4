using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class Membresias : System.Web.UI.Page
    {

        #region Variables Globales


         Obj_Estado_BLL = new Cls_Estado_BLL();
        Cls
        Cls_Estado_DAL Obj_Estado_DAL;
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

            if (Obj_Estado_DAL.sMsjError == string.Empty)
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

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

        }


    }
}