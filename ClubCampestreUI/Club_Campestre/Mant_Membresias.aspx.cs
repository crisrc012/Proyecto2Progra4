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
        #region Variables Globales
        Cls_Membresias_BLL Obj_Membresias_BLL = new Cls_Membresias_BLL();
        Cls_Membresias_DAL Obj_Membresias_DAL;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTipoMembresias();

                Cls_Membresias_DAL membresia = (Cls_Membresias_DAL)Session["Membresia"];
                string tipo = Session["tipo"].ToString();
                if (membresia != null & tipo == "E")
                {
                    Obj_Membresias_DAL = new Cls_Membresias_DAL();
                    Obj_Membresias_DAL.iIdMembresia = membresia.iIdMembresia;
                    Obj_Membresias_BLL.Filtrar(ref Obj_Membresias_DAL);

                    this.mantenimiento.InnerHtml = "Modificacion de Membresias";
                    this.txtCedula.Value = Obj_Membresias_DAL.DS.Tables[0].Rows[0][1].ToString();
                    this.DropDownTipoCliente.Text = Obj_Membresias_DAL.DS.Tables[0].Rows[0][3].ToString();
                    this.FechaInicio.Value = Obj_Membresias_DAL.DS.Tables[0].Rows[0][6].ToString();
                    this.FechaVence.Value = Obj_Membresias_DAL.DS.Tables[0].Rows[0][7].ToString();
                    BindGridBeneficiarios();
                    validaDatos();
                }
                else
                {
                    this.mantenimiento.InnerHtml = "Ingreso de Membresias";
                    this.txtCedula.Value = string.Empty;
                    this.DropDownTipoCliente.SelectedValue = "0";
                    this.IDCliente.Value = string.Empty;
                    this.FechaInicio.Value = DateTime.Today.ToString("yyyy-MM-dd");
                    fechavence();
                }                   
            }
            else
            {
                this.mensajeError.InnerHtml = "";
                validaDatos();
            }
        }
        protected void CargaBeneficiarios(object sender, EventArgs e)
        {
            if (txtbenefiario.Text != string.Empty)
            {
                DataTable dt = new DataTable();
                DataRow dr = null;
                string nombre;
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
                nombre = returnaNombre(txtbenefiario.Text);
                if (nombre == string.Empty)
                {
                    this.mensajeError.InnerHtml = "Beneficiario no se encuentra registrado en Personas";
                    this.txtbenefiario.Text = string.Empty;
                }
                else
                {
                    dr = dt.NewRow();
                    dr["IdPersona"] = txtbenefiario.Text;
                    dr["Nombre"] = nombre;
                    dt.Rows.Add(dr);
                    BeneficiariosGridView.DataSource = dt;
                    BeneficiariosGridView.DataBind();
                    this.txtbenefiario.Text = string.Empty;
                }
            }
            else
            {
                this.mensajeError.InnerHtml = "Debe Ingresar el numero de cedula del Beneficiario";

            }
            
        }

        private string returnaNombre(string cedula)
        {
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();

            Obj_Persona_DAL.SIdPersona = cedula.Trim();
            Obj_Persona_BLL.Filtrar(ref Obj_Persona_DAL);

            if(Obj_Persona_DAL.SMsjError == string.Empty)
            {
                if (Obj_Persona_DAL.DS.Tables[0].Rows.Count > 0)
                {
                    return Obj_Persona_DAL.DS.Tables[0].Rows[0][1].ToString();
                }
                else
                {
                    this.mensajeError.InnerHtml = "PERSONA NO REGISTRADA INGRESE AL BOTON DE PERSONAS";
                    return "";
                }
            }
            else
            {
                this.mensajeError.InnerHtml = "Error al consultar persona, Contactar TI";
                return "";
            }
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InsertarMembresia();
                InsertarBeneficiarios();
            }
                
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
            if(FechaInicio.Value != string.Empty)
            {
                fechainicio = Convert.ToDateTime(FechaInicio.Value);
                FechaVence.Value = fechainicio.AddYears(1).ToString("yyyy-MM-dd");
            }
           
        }

        private void InsertarBeneficiarios()
        {
            Cls_Beneficiarios_DAL Obj_Beneficiario_DAL = new Cls_Beneficiarios_DAL();
            Cls_Beneficiarios_BLL Obj_Beneficiario_BLL = new Cls_Beneficiarios_BLL();

            if (BeneficiariosGridView.Rows.Count > 0)
            {
                foreach (GridViewRow row in BeneficiariosGridView.Rows)
                {
                    Obj_Beneficiario_DAL.SIdCliente = 1; // Convert.ToInt16(IDCliente.Value);
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
            Obj_Membresias_DAL.SPKIdCliente = 1; //Convert.ToInt16(IDCliente.Value);
            Obj_Membresias_DAL.dFechaInicio = Convert.ToDateTime(FechaInicio.Value);
            Obj_Membresias_DAL.dFechaVence = Convert.ToDateTime(FechaVence.Value);
            Obj_Membresias_DAL.CFKIdEstado = 'A';

            Obj_Membresias_BLL.Insertar(ref Obj_Membresias_DAL);
        }

        private string returnaIdCliente(string cedula)
        {
            Cls_Cliente_BLL Obj_Cliente_BLL = new Cls_Cliente_BLL();
            Cls_Clientes_DAL Obj_Cliente_DAL = new Cls_Clientes_DAL();

            Obj_Cliente_DAL.SIdPersona = cedula;
            //Obj_Cliente_BLL.Filtrar(ref Obj_Cliente_DAL);
            //return Obj_Cliente_DAL.DS.Tables[0].Rows[0][0].ToString();

            return "Socio";
        }

        private void validaDatos()
        {
            this.txtNombre.Value = returnaNombre(this.txtCedula.Value.Trim());
            this.IDCliente.Value = returnaIdCliente(this.txtCedula.Value.Trim());
            fechavence();
        }

        protected void QuitarBeneficiarios(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow dr = null;
            dt.Columns.Add(new DataColumn("IdPersona", typeof(string)));
            dt.Columns.Add(new DataColumn("Nombre", typeof(string)));

            foreach (GridViewRow row in BeneficiariosGridView.Rows)
            {
                dr = dt.NewRow();
                dr["IdPersona"] = row.Cells[0].Text.ToString();
                dr["Nombre"] = row.Cells[1].Text.ToString();
                dt.Rows.Add(dr);
            }

            foreach (GridViewRow row in BeneficiariosGridView.Rows)
            {
                
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        dt.Rows[row.RowIndex].Delete();
                     }

                }
            }
            BeneficiariosGridView.DataSource = dt;
            BeneficiariosGridView.DataBind();
        }

        private void BindGridBeneficiarios()
        {
            Cls_Beneficiarios_DAL Obj_Beneficiario_DAL = new Cls_Beneficiarios_DAL();
            Cls_Beneficiarios_BLL Obj_Beneficiario_BLL = new Cls_Beneficiarios_BLL();

            Obj_Beneficiario_DAL.SIdCliente = 1;
            Obj_Beneficiario_BLL.Filtrar(ref Obj_Beneficiario_DAL);

            this.BeneficiariosGridView.DataSource = Obj_Beneficiario_DAL.DS.Tables[0];
            this.BeneficiariosGridView.DataBind();

        }

    }
}