using System;
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
    public partial class Mant_Membresias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarTipoMembresias();


        }
        protected void CargaBeneficiarios(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            dt.Columns.Add(new DataColumn("IdPersona", typeof(string)));
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));

            if (BeneficiariosGridView.Rows.Count > 0)
            {
                foreach (GridViewRow row in BeneficiariosGridView.Rows)
                {
                    dr = dt.NewRow();
                    dr["IdPersona"] = row.Cells[0].Text.ToString();
                    dr["IdPersona"] = row.Cells[1].Text.ToString();
                    dt.Rows.Add(dr);
                }
            }
            dr = dt.NewRow();
            dr["IdPersona"] = txtbenefiario.Text;
            dr["IdPersona"] = returnaNombre(txtbenefiario.Text);
            dt.Rows.Add(dr);
            BeneficiariosGridView.DataSource = dt;
            BeneficiariosGridView.DataBind();
        }

        private string returnaNombre(string cedula)
        {
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();

            Obj_Persona_DAL.SIdPersona = cedula;
            Obj_Persona_BLL.Filtrar(ref Obj_Persona_DAL);

            return Obj_Persona_DAL.SNombre;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Value = returnaNombre(this.txtCedula.Value);
            fechavence();
            //guardarmembresia
            //guardarbene
        }

        private void CargarTipoMembresias()
        {
            Cls_TipoMembresia_DAL Obj_Tipo_DAL = new Cls_TipoMembresia_DAL();
            CLS_TipoMembresia_BLL Obj_Tipo_BLL = new CLS_TipoMembresia_BLL();
            Obj_Tipo_BLL.ListaTipoMembresia(ref Obj_Tipo_DAL);

            //DataRow row = Obj_Rol_DAL.DS.Tables[0].NewRow();
            //row["IdRol"] = 0;
            //row["Descripcion"] = "-- Seleccione --";
            //Obj_Rol_DAL.DS.Tables[0].Rows.Add(row);

            DropDownTipoCliente.DataSource = Obj_Tipo_DAL.DS.Tables[0];
            DropDownTipoCliente.DataTextField = "Descripcion";
            DropDownTipoCliente.DataValueField = "IdTipoMembresia";
            DropDownTipoCliente.DataBind();
        }

        private void fechavence()
        {
            DateTime fechainicio;
            fechainicio = Convert.ToDateTime(FechaInicio.Value);
            FechaVence.Value = fechainicio.AddYears(1).ToString();
        }

        private void InsertarBeneficiarios()
        {
            Cls_Beneficiarios_DAL Obj_Beneficiario = new Cls_Beneficiarios_DAL();
            
        }

    }
}