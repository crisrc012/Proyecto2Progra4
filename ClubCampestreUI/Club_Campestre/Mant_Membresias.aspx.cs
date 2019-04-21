using System;
using System.Web.UI.WebControls;
using System.Data;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class Mant_Membresias : System.Web.UI.Page
    {
        #region Variables Globales
        Cls_Membresias_BLL Obj_Membresias_BLL = new Cls_Membresias_BLL();
        public static int IdMembresia;
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = new System.Globalization.CultureInfo("en-US", true);
            customCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;

            if (!IsPostBack)
            {
                CargarTipoMembresias();
                Cls_Membresias_DAL Obj_Membresias_DAL = (Cls_Membresias_DAL)Session["Membresia"];
                Cls_Persona_DAL Obj_Persona_DAL = (Cls_Persona_DAL)Session["Persona"];
                string tipo = Session["tipo"].ToString();
                txtNombre.Disabled = true;
                IDCliente.Disabled = true;
                if (Obj_Membresias_DAL != null & tipo == "E")
                {
                    IdMembresia = Obj_Membresias_DAL.iIdMembresia;
                    Obj_Membresias_BLL.crudMembresias(ref Obj_Membresias_DAL, BD.Filtrar);
                    this.mantenimiento.InnerHtml = "Modificacion de Membresias";
                    this.txtCedula.Value = Obj_Persona_DAL.SIdPersona;
                    this.txtNombre.Value = Obj_Persona_DAL.SNombre;
                    this.DropDownTipoCliente.Text = Obj_Membresias_DAL.DS.Tables[0].Rows[0][2].ToString(); // idTipoMemebresia
                    this.FechaInicio.Value = Convert.ToDateTime(Obj_Membresias_DAL.DS.Tables[0].Rows[0][4], customCulture).ToString("yyyy-MM-dd");
                    validaDatos();
                    BindGridBeneficiarios();
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
                    if (BeneficiariosGridView.Rows.Count >= 4)
                    {
                        this.mensajeError.InnerHtml = "No puede exceder el maximo de 4 beneficiarios";
                    }
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
                    if (BeneficiariosGridView.Rows.Count != 4)
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
            Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Filtrar);
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
            if (this.checkok.Checked)
            {
                string tipo = Session["tipo"].ToString();
                if (tipo == "E")
                {
                    ActualizarMembresia();
                    ActualizarBeneficiarios();
                    Server.Transfer("Membresias.aspx");
                }
                else
                {
                    InsertarMembresia();
                    InsertarBeneficiarios();
                    Server.Transfer("Membresias.aspx");
                }
            }
        }

        private void CargarTipoMembresias()
        {
            Cls_TipoMembresia_DAL Obj_Tipo_DAL = new Cls_TipoMembresia_DAL();
            Cls_TipoMembresia_BLL Obj_Tipo_BLL = new Cls_TipoMembresia_BLL();
            Obj_Tipo_BLL.crudTipoMembresia(ref Obj_Tipo_DAL, BD.Listar);
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
                    Obj_Beneficiario_DAL.SIdBeneficiario = short.MinValue;
                    Obj_Beneficiario_DAL.SIdCliente = Convert.ToInt16(IDCliente.Value);
                    Obj_Beneficiario_DAL.SIdPersona = row.Cells[0].Text.ToString();
                    Obj_Beneficiario_DAL.CIdEstado = 'A';

                    Obj_Beneficiario_BLL.crudBeneficiarios(ref Obj_Beneficiario_DAL, BD.Insertar);
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
            Obj_Membresias_BLL.crudMembresias(ref Obj_Membresias_DAL, BD.Insertar);

            if (Obj_Membresias_DAL.SMsjError == string.Empty)
            {
                this.mensajeError.InnerHtml = " Membresia Registrada Correctamente";
            }
            else
            {
                this.mensajeError.InnerHtml = "Error al consultar persona, Contactar TI";
            }
        }

        private string returnaIdCliente(string cedula)
        {
            Cls_Cliente_BLL Obj_Cliente_BLL = new Cls_Cliente_BLL();
            Cls_Clientes_DAL Obj_Cliente_DAL = new Cls_Clientes_DAL();
            Obj_Cliente_DAL.SIdPersona = cedula;
            Obj_Cliente_DAL.SIdCliente = short.MinValue;
            Obj_Cliente_DAL.BIdTipoCliente = byte.MinValue;
            Obj_Cliente_BLL.crudCliente(ref Obj_Cliente_DAL, BD.Filtrar);
            return Obj_Cliente_DAL.DS.Tables[0].Rows[0][0].ToString();
        }

        private void validaDatos()
        {
            if (this.txtNombre.Value == null || this.txtNombre.Value == string.Empty)
            {
                this.txtNombre.Value = returnaNombre(this.txtCedula.Value.Trim());
            }
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
            Obj_Beneficiario_DAL.SIdCliente = Convert.ToInt16(this.IDCliente.Value);
            Obj_Beneficiario_DAL.SIdPersona = string.Empty;
            Obj_Beneficiario_DAL.SIdBeneficiario = short.MinValue;
            Obj_Beneficiario_DAL.CIdEstado = ' ';
            Obj_Beneficiario_BLL.crudBeneficiarios(ref Obj_Beneficiario_DAL, BD.Filtrar);

            // Si no hay beneficiaros
            if (Obj_Beneficiario_DAL.DS.Tables.Count > 0)
            {
                this.BeneficiariosGridView.DataSource = Obj_Beneficiario_DAL.DS.Tables[0];
                this.BeneficiariosGridView.DataBind();
            }
        }
        
        private void ActualizarMembresia()
        {
            Cls_Membresias_DAL Obj_Membresias_DAL = new Cls_Membresias_DAL();
            Cls_Membresias_BLL Obj_Membresias_BLL = new Cls_Membresias_BLL();
            Obj_Membresias_DAL.iIdMembresia = IdMembresia;
            Obj_Membresias_DAL.BFKIdTipoMembresia = Convert.ToByte(DropDownTipoCliente.SelectedValue);
            Obj_Membresias_DAL.SPKIdCliente = Convert.ToInt16(IDCliente.Value);
            Obj_Membresias_DAL.dFechaInicio = Convert.ToDateTime(FechaInicio.Value);
            Obj_Membresias_DAL.dFechaVence = Convert.ToDateTime(FechaVence.Value);
            Obj_Membresias_DAL.CFKIdEstado = 'A';
            Obj_Membresias_BLL.crudMembresias(ref Obj_Membresias_DAL, BD.Actualizar);
        }

        private void ActualizarBeneficiarios()
        {
            Cls_Beneficiarios_DAL Obj_Beneficiario_DAL = new Cls_Beneficiarios_DAL();
            Cls_Beneficiarios_BLL Obj_Beneficiario_BLL = new Cls_Beneficiarios_BLL();
            if (BeneficiariosGridView.Rows.Count > 0)
            {
                Obj_Beneficiario_DAL.SIdCliente = Convert.ToInt16(IDCliente.Value);
                Obj_Beneficiario_DAL.SIdPersona = string.Empty;
                Obj_Beneficiario_DAL.SIdBeneficiario = short.MinValue;
                Obj_Beneficiario_DAL.CIdEstado = ' ';
                Obj_Beneficiario_BLL.crudBeneficiarios(ref Obj_Beneficiario_DAL, BD.Eliminar);
                foreach (GridViewRow row in BeneficiariosGridView.Rows)
                {
                    Obj_Beneficiario_DAL.SIdBeneficiario = short.MinValue;
                    Obj_Beneficiario_DAL.SIdCliente = Convert.ToInt16(IDCliente.Value);
                    Obj_Beneficiario_DAL.SIdPersona = row.Cells[0].Text.ToString();
                    Obj_Beneficiario_DAL.CIdEstado = 'A';
                    Obj_Beneficiario_BLL.crudBeneficiarios(ref Obj_Beneficiario_DAL, BD.Insertar);
                }
            }
        }

        protected void BeneficiariosGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            BeneficiariosGridView.PageIndex = e.NewPageIndex;
            this.BindGridBeneficiarios();
        }
    }
}