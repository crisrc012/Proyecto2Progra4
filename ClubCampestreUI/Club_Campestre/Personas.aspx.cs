using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.UI.WebControls;


namespace Club_Campestre
{
    public partial class Personas : System.Web.UI.Page
    {
        #region Cls Persona 
        Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();
        Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
        #endregion

        #region Cls Correo 
        Cls_Correos_DAL Obj_Correo_DAL = new Cls_Correos_DAL();
        Cls_Correos_BLL Obj_Correo_BLL = new Cls_Correos_BLL();
        List<Cls_Correos_DAL> ListaCorreo = new List<Cls_Correos_DAL>();
        #endregion

        private string tipoSession = "N";

        #region Cls Telefono
        Cls_Telefonos_DAL Obj_Telefonos_DAL = new Cls_Telefonos_DAL();
        Cls_Telefono_BLL Obj_Telefonos_BLL = new Cls_Telefono_BLL();
        List<Cls_Telefonos_DAL> ListaTelefono = new List<Cls_Telefonos_DAL>();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarRoles(); // Carga combo con posibles valores
                Cls_Persona_DAL persona = (Cls_Persona_DAL)Session["Persona"];
                string tipo = Session["tipo"].ToString();
                tipoSession = tipo;
                if (persona != null & tipo == "E")
                {
                    //this.mantenimiento.InnerHtml = "Modificacion de Persona";
                    // Carga de datos persona
                    this.txtCedula.Disabled = true;
                    this.txtCedula.Value = persona.SIdPersona;
                    txtnombre.Value = persona.SNombre;
                    TextAreadireccion.Value = persona.SDireccion;
                    // Carga Rol
                    DropDownRol.SelectedValue = persona.BIdRol.ToString();
                    // carga grid teléfonos
                    Obj_Telefonos_DAL = new Cls_Telefonos_DAL();
                    Obj_Telefonos_DAL.SIdPersona = persona.SIdPersona;
                    Obj_Telefonos_BLL.crudTelefono(ref Obj_Telefonos_DAL, BD.Filtrar);
                    GridViewTelefono.DataSource = Obj_Telefonos_DAL.DS.Tables[0];
                    GridViewTelefono.DataBind();
                    // carga grid de correos
                    Obj_Correo_DAL = new Cls_Correos_DAL();
                    Obj_Correo_DAL.SIdPersona = persona.SIdPersona;
                    Obj_Correo_BLL.crudCorreos(ref Obj_Correo_DAL, BD.Filtrar);
                    CorreoPersonaGridView.DataSource = Obj_Correo_DAL.DS.Tables[0];
                    CorreoPersonaGridView.DataBind();
                }
                else
                {
                    //this.mantenimiento.InnerHtml = "Nuevos de Estados";
                    // establecer controles en empty
                }
            }
        }

        protected void DropDownListRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void CorreoPersonaGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TelefonoPersonaGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarRoles()
        {
            Cls_Rol_DAL Obj_Rol_DAL = new Cls_Rol_DAL();
            Cls_Rol_BLL Obj_Rol_BLL = new Cls_Rol_BLL();
            Obj_Rol_BLL.crudRol(ref Obj_Rol_DAL, BD.Listar);
            DropDownRol.DataSource = Obj_Rol_DAL.DS.Tables[0];
            DropDownRol.DataTextField = "Descripcion";
            DropDownRol.DataValueField = "IdRol";
            DropDownRol.DataBind();
        }

        //Boton de Telefono 
        protected void btnAgregar2_Click1(object sender, EventArgs e)
        {
            // Agregra Telefono
            if (txtTelefono.Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            DataTable tabla;
            if (GridViewTelefono.Rows.Count > 0)
            {
                tabla = new DataTable();
                tabla.Columns.Add("telefono");
                ViewState["tablatelefono"] = tabla;

                foreach (GridViewRow row in GridViewTelefono.Rows)
                {
                    tabla.Rows.Add(row.Cells[0].Text);
                }
            }
            if (ViewState["tablatelefono"] == null)
            {
                tabla = new DataTable();
                tabla.Columns.Add("telefono");
                ViewState["tablatelefono"] = tabla;
            }
            else
            {
                tabla = (DataTable)ViewState["tablatelefono"];
            }
            tabla.Rows.Add(this.txtTelefono.Value.ToString().Trim());
            GridViewTelefono.DataSource = tabla;
            GridViewTelefono.DataBind();
            ViewState["tablatelefono"] = tabla;
            txtTelefono.Value = string.Empty;
        }

        protected void btnRemover2_Click1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("telefono");
            if (ViewState["tablatelefono"] == null)
            {
                ViewState["tablatelefono"] = tabla;
            }
            else
            {
                tabla = (DataTable)ViewState["tablatelefono"];
            }
            List<int> quitar = new List<int>();
            foreach (GridViewRow row in GridViewTelefono.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        quitar.Add(row.RowIndex);
                    }
                }
            }
            for (int i = quitar.Count - 1; i >= 0; i--)
            {
                tabla.Rows.RemoveAt(quitar[i]);
            }
            GridViewTelefono.DataSource = tabla;
            GridViewTelefono.DataBind();
            ViewState["tablatelefono"] = tabla;
        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            // Agregar Correo
            if (txtemail.Value.ToString().Trim() == string.Empty)
            {
                return;
            }
            DataTable tabla;
            if (CorreoPersonaGridView.Rows.Count > 0)
            {
                tabla = new DataTable();
                tabla.Columns.Add("correo");
                ViewState["tablacorreo"] = tabla;
                foreach (GridViewRow row in GridViewTelefono.Rows)
                {
                    tabla.Rows.Add(row.Cells[0].Text);
                }
            }
            if (ViewState["tablaCorreo"] == null)
            {
                tabla = new DataTable();
                tabla.Columns.Add("correo");
                ViewState["tablacorreo"] = tabla;
            }
            else
            {
                tabla = (DataTable)ViewState["tablaCorreo"];
            }
            tabla.Rows.Add(this.txtemail.Value.ToString().Trim());
            CorreoPersonaGridView.DataSource = tabla;
            CorreoPersonaGridView.DataBind();
            ViewState["tablaCorreo"] = tabla;
            txtemail.Value = string.Empty;
        }

        protected void btnRemover_Click1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("correo");
            if (ViewState["tablaCorreo"] == null)
            {
                ViewState["tablaCorreo"] = tabla;
            }
            else
            {
                tabla = (DataTable)ViewState["tablaCorreo"];
            }
            List<int> quitar = new List<int>();
            foreach (GridViewRow row in CorreoPersonaGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        quitar.Add(row.RowIndex);
                    }
                }
            }
            for (int i = quitar.Count - 1; i >= 0; i--)
            {
                tabla.Rows.RemoveAt(quitar[i]);
            }
            CorreoPersonaGridView.DataSource = tabla;
            CorreoPersonaGridView.DataBind();
            ViewState["tablaCorreo"] = tabla;
        }

        protected void btnGuardar_Click1(object sender, EventArgs e)
        {
            Cls_Persona_DAL Obj_Persona_DAL = new Cls_Persona_DAL();
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            Cls_Rol_DAL Obj_Rol_DAL = new Cls_Rol_DAL();
            Cls_Rol_BLL Obj_Rol_BLL = new Cls_Rol_BLL();
            Obj_Persona_DAL.SIdPersona = this.txtCedula.Value;
            Obj_Persona_DAL.SNombre = this.txtnombre.Value;
            Obj_Persona_DAL.SDireccion = this.TextAreadireccion.Value;
            Obj_Persona_DAL.BIdRol = Convert.ToByte(DropDownRol.SelectedValue);
            Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Insertar);
            //Telefono ingresa 
            #region Telefono 
            if (Obj_Persona_DAL.SMsjError.Equals(string.Empty))
            {
                foreach (GridViewRow row in GridViewTelefono.Rows)
                {
                    //busca el la fila
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        {
                            Obj_Telefonos_DAL.STelefono = row.Cells[0].Text;
                            Obj_Telefonos_DAL.SIdPersona = this.txtCedula.Value.ToString().Trim();
                            Obj_Telefonos_BLL.crudTelefono(ref Obj_Telefonos_DAL, BD.Insertar);//   insertar
                        }
                    }
                }
                #endregion 
                //-Aqui agrego el de correo foreach 
                #region Correo
                foreach (GridViewRow row in CorreoPersonaGridView.Rows)
                {
                    //busca el la fila
                    if (row.RowType == DataControlRowType.DataRow)
                    {
                        {
                            Obj_Correo_DAL.SIdPersona = this.txtCedula.Value.ToString().Trim();
                            Obj_Correo_DAL.SCorreo = row.Cells[0].Text;
                            Obj_Correo_BLL.crudCorreos(ref Obj_Correo_DAL, BD.Insertar);//  insertar
                        }
                    }
                }
                #endregion
                if (tipoSession == "E")
                {
                    Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Actualizar);
                }
                else
                {
                    Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Insertar);
                }
                Server.Transfer("Mant_Persona.aspx");
            }
        }

        protected void GridViewTelefono_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewTelefono.PageIndex = e.NewPageIndex;
            //this.**MetodoparaTraerlosTelefonosdelaBasedeDatos;
        }

        protected void CorreoPersonaGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            CorreoPersonaGridView.PageIndex = e.NewPageIndex;
            //this.**MetodoparaTraerlosCorreosdelaBasedeDatos;
        }
    }
}