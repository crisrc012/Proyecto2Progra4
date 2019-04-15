﻿using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Club_Campestre
{
    public partial class Servicios : System.Web.UI.Page
    {
        #region Variables Globales
        Cls_Servicio_BLL Obj_Servicio_BLL = new Cls_Servicio_BLL();
        Cls_Servicio_DAL Obj_Servicio_DAL;
        bool vFiltra = true;
        #endregion
        private void BindGrid()
        {
            //Se instancia objeto
            Obj_Servicio_DAL = new Cls_Servicio_DAL();

            if (this.txtFiltraServicio.Text == string.Empty)//listar
            {
                //llamado metodo listar estados
                Obj_Servicio_BLL.Listar(ref Obj_Servicio_DAL);
            }
            else
            {
                //Obj_Servicio_DAL.sDescripcion = this.FiltrarServicio.Text;
                //llamado metodo listar estados
                Obj_Servicio_BLL.Filtrar(ref Obj_Servicio_DAL);
            }

            if (Obj_Servicio_DAL.SMsjError == string.Empty)
            {
                //Carga de Grid con DataSet instanciado en DAL
                this.ServicioGridView.DataSource = Obj_Servicio_DAL.DS.Tables[0];
                this.ServicioGridView.DataBind();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar Servicio.";
                this.BindGrid();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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

        protected void txtServicio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}