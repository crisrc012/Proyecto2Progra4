using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System.Data;

namespace Club_Campestre
{
    public partial class Ingreso : System.Web.UI.Page
    {
        #region Variables Globales
        Cls_TipoServicio_BLL Obj_TipoServicio_BLL = new Cls_TipoServicio_BLL();
        Cls_TipoServicio_DAL Obj_TipoServicio_DAL;
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindGrid();
            }
        }

        protected void TxtConsultar_Click(object sender, EventArgs e)
        {
            Cls_Ingreso_Dal Obj_Ingreso_Dal = new Cls_Ingreso_Dal();
            Cls_Ingresos_BLL Obj_Ingreso_BLL = new Cls_Ingresos_BLL();
            Obj_Ingreso_Dal.IdPersona = txtCedula.Value;
            Obj_Ingreso_Dal.Nombre = "";
            Obj_Ingreso_Dal.TipoCliente = "";
            Obj_Ingreso_Dal.Membresia = "";
            Obj_Ingreso_Dal.Costo = 0;
            Obj_Ingreso_BLL.Cargar(ref Obj_Ingreso_Dal);
            DataTable dt = Obj_Ingreso_Dal.DS.Tables[0];

            foreach(DataRow row in dt.Rows)
            {
                txtnombre.Value = Convert.ToString(row[1]);
                TxtTipoCliente.Value = Convert.ToString(row[2]);
                TxtMembresia.Value = Convert.ToString(row[3]);
                TxtCosto.Value = Convert.ToString(row[4]);

            }
        }

        private void BindGrid()
        {
            //Se instancia objeto
            Obj_TipoServicio_DAL = new Cls_TipoServicio_DAL();

            
           
                //llamado metodo listar estados
                Obj_TipoServicio_BLL.Listar(ref Obj_TipoServicio_DAL);
            
            
            if (Obj_TipoServicio_DAL.sMsjError == string.Empty)
            {
                //Carga de Grid con DataSet instanciado en DAL
                this.ServiciosGridView.DataSource = Obj_TipoServicio_DAL.DS.Tables[0];
                this.ServiciosGridView.DataBind();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar Estados.";
                this.BindGrid();
            }
        }
    }
}