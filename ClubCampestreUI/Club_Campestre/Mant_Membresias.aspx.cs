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
            if (!IsPostBack)
            {
                CargarTipoMembresias();
            }
            else
            {
                validaDatos();
            }
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
                    dr["Nombre"] = row.Cells[1].Text.ToString();
                    dt.Rows.Add(dr);
                }
            }
            dr = dt.NewRow();
            dr["IdPersona"] = txtbenefiario.Text;
            dr["Nombre"] = returnaNombre(txtbenefiario.Text);
            dt.Rows.Add(dr);
            BeneficiariosGridView.DataSource = dt;
            BeneficiariosGridView.DataBind();
        }

        private string returnaNombre(string cedula)
        {
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();

            Obj_Persona_DAL.SIdPersona = cedula.Trim();
            Obj_Persona_BLL.Filtrar(ref Obj_Persona_DAL);

            return Obj_Persona_DAL.DS.Tables[0].Rows[0][1].ToString(); ;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
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
            //DateTime fechainicio;
            //fechainicio = Convert.ToDateTime(FechaInicio.Value);
            //FechaVence.Value = fechainicio.AddYears(1).ToString();
        }

        private void InsertarBeneficiarios()
        {
            Cls_Beneficiarios_DAL Obj_Beneficiario_DAL = new Cls_Beneficiarios_DAL();
            Cls_Beneficiarios_BLL Obj_Beneficiario_BLL = new Cls_Beneficiarios_BLL();

            if (BeneficiariosGridView.Rows.Count > 0)
            {
                foreach (GridViewRow row in BeneficiariosGridView.Rows)
                {
                    Obj_Beneficiario_DAL.SIdCliente = Convert.ToInt16(IDCliente.Value);
                    Obj_Beneficiario_DAL.SIdPersona = row.Cells[0].Text.ToString();
                    Obj_Beneficiario_DAL.CIdEstado = 'A';

                    Obj_Beneficiario_BLL.Insertar(ref Obj_Beneficiario_DAL);
                }
            }
        }

        private void InsertarMembresia()
        {
            Cls_Membresias_DAL Obj_Membresias_DAL = new Cls_Membresias_DAL();
            Cls_Membresias_BLL Obj_Membresias_BLL = new Cls_Membresias_BLL();

            Obj_Membresias_DAL.BFKIdTipoMembresia = Convert.ToByte(DropDownTipoCliente.SelectedValue);
            Obj_Membresias_DAL.SPKIdCliente = Convert.ToInt16(IDCliente.Value);
            Obj_Membresias_DAL.dFechaInicio = Convert.ToDateTime(FechaInicio.Value);
            Obj_Membresias_DAL.dFechaVence = Convert.ToDateTime(FechaVence.Value);
            Obj_Membresias_DAL.CFKIdEstado = 'A';

            Obj_Membresias_BLL.Insertar(ref Obj_Membresias_DAL);
        }

        private short returnaIdCliente(string cedula)
        {
            Cls_Cliente_BLL Obj_Cliente_BLL = new Cls_Cliente_BLL();
            Cls_Clientes_DAL Obj_Cliente_DAL = new Cls_Clientes_DAL();

            Obj_Cliente_DAL.SIdPersona = cedula;
            Obj_Cliente_BLL.Filtrar(ref Obj_Cliente_DAL);

            return Obj_Cliente_DAL.SIdCliente;
        }

        private void validaDatos()
        {
            this.txtNombre.Value = returnaNombre(this.txtCedula.Value.Trim());
            this.IDCliente.Value = returnaIdCliente(this.txtCedula.Value.Trim()).ToString();
            fechavence();
        }

    }
}