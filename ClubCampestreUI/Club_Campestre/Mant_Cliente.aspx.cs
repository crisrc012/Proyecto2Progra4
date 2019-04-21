﻿using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace Club_Campestre
{
    public partial class Mant_Tipo_Cliente : System.Web.UI.Page
    {
        private string pantallaMantenimiento = "Clientes.aspx";
        protected void Page_Load(object sender, EventArgs e)
        {
            CargaTipoCliente();

            if (!IsPostBack)
            {
                txtidcliente.Disabled = true;
                if ((BD)Session["tipo"] == BD.Actualizar)
                {
                    Cls_Clientes_DAL clientes = (Cls_Clientes_DAL)Session["Clientes"];
                    this.mantenimiento.InnerHtml = "Modificacion de Clientes";
                    this.DropDownTClientes.Text = Session["TipoCliente"].ToString();
                    this.txtidcliente.Value = clientes.sIdCliente.ToString();
                    this.txtidpersona.Value = clientes.sIdPersona.ToString();
                    this.txtidpersona.Disabled = true;
                }
                else
                {
                    this.txtidcliente.Visible = false;
                    this.mantenimiento.InnerHtml = "Nuevos de Clientes";
                    this.txtidcliente.Value = string.Empty;
                    this.DropDownTClientes.SelectedValue = string.Empty;
                    this.txtidpersona.Value = string.Empty;
                }
            }
        }
        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect(pantallaMantenimiento, true);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            Cls_Clientes_DAL Obj_Clientes_DAL = new Cls_Clientes_DAL();
            Obj_Clientes_DAL.sIdCliente = Convert.ToInt16(txtidcliente.Value);
            Obj_Clientes_DAL.bIdTipoCliente = Convert.ToByte(DropDownTClientes.SelectedValue);
            Obj_Clientes_DAL.sIdPersona = txtidpersona.Value.ToString().Trim();
            if ((BD)Session["tipo"] == BD.Actualizar)
            {
                Obj_Clientes_BLL.crudCliente(ref Obj_Clientes_DAL, BD.Actualizar);
            }
            else
            {
                Obj_Clientes_BLL.crudCliente(ref Obj_Clientes_DAL, BD.Insertar);
            }
            Response.Redirect(pantallaMantenimiento, true);
        }

        protected void DropDownListTCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void CargaTipoCliente()
        {
            Cls_TipoCliente_DAL Obj_TipoCliente_DAL = new Cls_TipoCliente_DAL();
            Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();
            Obj_TipoCliente_BLL.crudTipoCliente(ref Obj_TipoCliente_DAL, BD.Listar);
            DropDownTClientes.DataSource = Obj_TipoCliente_DAL.DS.Tables[0];
            DropDownTClientes.DataTextField = "Descripcion";
            DropDownTClientes.DataValueField = "IdTipoCliente";
            DropDownTClientes.DataBind();
        }
    }
}
