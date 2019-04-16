﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;


namespace Club_Campestre
{
    public partial class Mant_Persona : System.Web.UI.Page
    {
        #region Variables Globales
        Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
        Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
        Cls_Telefono_BLL Obj_Telefonos_BLL = new Cls_Telefono_BLL();
        Cls_Persona_DAL Obj_Persona_DAL;
        Cls_Correos_DAL Obj_Correos_DAL;
        Cls_Telefonos_DAL Obj_Telefonos_DAL;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            ///Meter esto 
            if (!IsPostBack)
            {
                this.BindGrid();
            }
        }

        //Metodo que listar
        private void BindGrid()
        {
            //Se instancia objeto
            Obj_Persona_DAL = new Cls_Persona_DAL();

            if (this.txtFiltraPersona.Text == string.Empty)//listar
            {
                //llamado metodo listar estados
                Obj_Persona_BLL.Listar(ref Obj_Persona_DAL);
            }
            else
            {
                Obj_Persona_DAL.SIdPersona = this.txtFiltraPersona.Text;
                //llamado metodo listar estados
                Obj_Persona_BLL.Filtrar(ref Obj_Persona_DAL);
            }

            if (Obj_Persona_DAL.SMsjError == string.Empty)
            {
                //Carga de Grid con DataSet instanciado en DAL
                this.PersonaGridView.DataSource = Obj_Persona_DAL.DS.Tables[0];
                this.PersonaGridView.DataBind();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar las Personas.";
                this.BindGrid();
            }
        }

        //Boton nuevo 
        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["tipo"] = "N";
            Server.Transfer("Personas.aspx", false);//llama pantalla
        }

        //boton modificar
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Se instancia objeto

            Obj_Persona_DAL = new Cls_Persona_DAL();
            Obj_Correos_DAL = new Cls_Correos_DAL();
            Obj_Telefonos_DAL = new Cls_Telefonos_DAL();
            //Secion tipo Editar
            Session["tipo"] = "E";
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in PersonaGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_Persona_DAL.SIdPersona = row.Cells[0].Text;
                        Obj_Persona_DAL.SNombre = row.Cells[1].Text;
                        Obj_Persona_DAL.SDireccion = row.Cells[2].Text;
                        Obj_Persona_DAL.BIdRol = Convert.ToByte(row.Cells[3].Text); // Hacer filtar del idRol, por la vista se carga la descripción unicamente //Corregir
                        Obj_Persona_BLL.Actualizar(ref Obj_Persona_DAL);
                        Obj_Correos_DAL.SIdPersona = row.Cells[0].Text;
                        Obj_Correos_DAL.SIdCorreo = 1;//Valor estatico debido a falta de informacion en el view de listar Personas
                        Obj_Correos_DAL.SCorreo = row.Cells[5].Text;
                        Obj_Correos_BLL.Actualizar(ref Obj_Correos_DAL);
                        Obj_Telefonos_DAL.STelefono = row.Cells[4].Text;
                        Obj_Telefonos_DAL.SIdPersona = row.Cells[0].Text;
                        Obj_Telefonos_BLL.Actualizar(ref Obj_Telefonos_DAL);
                        //Sesion estado lleva el objeto
                        Session["Persona"] = Obj_Persona_DAL;
                        Server.Transfer("Mant_Persona.aspx");//llama la pantalla
                    }
                }
            }
        }

        //boton eliminar
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
                            Obj_Persona_DAL = new Cls_Persona_DAL();

                //Recorre Grid buscando chk 
                foreach (GridViewRow row in PersonaGridView.Rows)
                {
                    //busca el la fila
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        //si esta checkeado instancia las propiedades del objeto
                        CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                        if (chkRow.Checked)
                        {
                            Obj_Persona_DAL.SIdPersona = row.Cells[0].Text;

                            //llamado metodo eliminar estados
                            Obj_Persona_BLL.Eliminar(ref Obj_Persona_DAL);// eliminar estados
                        }

                    }
                }
                if (Obj_Persona_DAL.SMsjError == string.Empty)
                {
                    this.errorMensaje.InnerHtml = "Persona Eliminada con exito.";
                    this.BindGrid();
                }
                else
                {
                    this.errorMensaje.InnerHtml = "Se presento un error a la hora de Eliminar la(s) Persona(s).";
                    this.BindGrid();
                }

            

        }

        // evento para Buscar
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BindGrid();
        }

        protected void txtFiltraPersona_TextChanged(object sender, EventArgs e)
        {
                this.BindGrid();
        
        }
        
    }
}