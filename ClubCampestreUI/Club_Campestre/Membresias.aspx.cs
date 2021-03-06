﻿using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Web.UI.WebControls;

namespace Club_Campestre
{
    public partial class Membresias : System.Web.UI.Page
    {

        #region Variables Globales
        private Cls_Membresias_BLL Obj_Membresias_BLL = new Cls_Membresias_BLL();
        private Cls_Membresias_DAL Obj_Membresias_DAL;
        private string pantallaMantenimiento = "Mant_Membresias.aspx";
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
            if (this.txtFiltrar.Value == string.Empty)//listar
            {
                //llamado metodo listar Membresias
                Obj_Membresias_BLL.crudMembresias(ref Obj_Membresias_DAL,BD.Listar);
            }
            else
            {
                Obj_Membresias_DAL.iIdMembresia = Convert.ToInt16(this.txtFiltrar.Value);
                //llamado metodo filtrar Membresias
                Obj_Membresias_BLL.crudMembresias(ref Obj_Membresias_DAL,BD.Filtrar);
            }
            if (Obj_Membresias_DAL.sMsjError == string.Empty)
            {
                //Carga de Grid con DataSet instanciado en DAL
                this.MembresiasGridView.DataSource = Obj_Membresias_DAL.DS.Tables[0];
                this.MembresiasGridView.DataBind();
                this.errorMensaje.InnerHtml = "Proceso Ejecutado con Exito";
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar Estados.";
                this.BindGrid();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
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
                        Obj_Membresias_DAL = new Cls_Membresias_DAL();
                        Obj_Membresias_DAL.iIdMembresia = Convert.ToInt32(row.Cells[0].Text);
                        //llamado metodo eliminar Membresias
                        Obj_Membresias_BLL.crudMembresias(ref Obj_Membresias_DAL, BD.Eliminar); // eliminar Membresias
                    }
                }
            }
            if (Obj_Membresias_DAL.sMsjError == string.Empty)
            {
                this.errorMensaje.InnerHtml = "sMembresia Eliminada con exito.";
                this.BindGrid();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de Eliminar Membresias.";
                this.BindGrid();
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
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
                        //Se instancia objeto
                        Obj_Membresias_DAL = new Cls_Membresias_DAL();
                        //Secion tipo Editar
                        Session["tipo"] = BD.Actualizar;
                        Obj_Membresias_DAL.iIdMembresia = Convert.ToInt16(row.Cells[0].Text);
                        Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();
                        Obj_Persona_DAL.sIdPersona = row.Cells[1].Text;
                        Obj_Persona_DAL.sNombre = row.Cells[2].Text;
                        //Sesion estado lleva el objeto
                        Session["sMembresia"] = Obj_Membresias_DAL;
                        Session["Persona"] = Obj_Persona_DAL;
                        Response.Redirect(pantallaMantenimiento, false); //llama la pantalla 
                    }
                }
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["tipo"] = BD.Insertar;
            Response.Redirect(pantallaMantenimiento, false); //llama la pantalla 
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BindGrid();
        }

        protected void MembresiasGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            MembresiasGridView.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }
    }
}