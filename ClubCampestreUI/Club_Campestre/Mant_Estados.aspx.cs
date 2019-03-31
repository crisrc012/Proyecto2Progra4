﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClubCampestre_DAL.CatalogosMantenimientos;

namespace Club_Campestre.Mantenimiento
{
    public partial class Mant_Estados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cls_Estado_DAL estado = (Cls_Estado_DAL)Session["Estado"];
                string tipo = Session["tipo"].ToString();
                if (estado != null & tipo == "E")
                {
                    this.mantenimiento.InnerHtml = "Modificacion de Estados";
                    this.txtestado.Value = estado.cIdEstado.ToString();
                    this.txtdescripcion.Value = estado.sPKEstado;
                }
                else
                {
                    this.mantenimiento.InnerHtml = "Nuevos de Estados";
                    this.txtestado.Value = string.Empty;
                    this.txtdescripcion.Value = string.Empty;
                }
            }


        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Server.Transfer("Estados.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Cls_Estado_DAL Obj_Estado_DAL = new Cls_Estado_DAL();
            Obj_Estado_DAL.cIdEstado = Convert.ToChar(this.txtestado.Value);
            Obj_Estado_DAL.sPKEstado = this.txtdescripcion.Value.ToString();
            string tipo = Session["tipo"].ToString();
            if ( tipo == "E")
            {
                //metodo update
            }
            else
            {
                //metodo insert
            }
        }
    }
}