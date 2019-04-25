using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Net;
using System.Web.UI.WebControls;

namespace Club_Campestre
{
    public partial class Mant_Persona : System.Web.UI.Page
    {
        #region Variables Globales
        private Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
        private Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
        private Cls_Telefono_BLL Obj_Telefonos_BLL = new Cls_Telefono_BLL();
        private Cls_Persona_DAL Obj_Persona_DAL;
        private Cls_Correos_DAL Obj_Correos_DAL;
        private Cls_Telefonos_DAL Obj_Telefonos_DAL;
        private string pantallaMantenimiento = "Personas.aspx";
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

            if (this.txtFiltraPersona.Value == string.Empty)//listar
            {
                //llamado metodo listar estados
                Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Listar);
            }
            else
            {
                Obj_Persona_DAL.sIdPersona = this.txtFiltraPersona.Value;
                //llamado metodo listar estados
                Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Filtrar);
            }

            if (Obj_Persona_DAL.sMsjError == string.Empty)
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
            Session["tipo"] = BD.Insertar;
            Response.Redirect(pantallaMantenimiento, false);
        }

        //boton modificar
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Recorre Grid buscando chk 
            foreach (GridViewRow row in PersonaGridView.Rows)
            {
                //busca el la fila
                if (row.RowType == DataControlRowType.DataRow)
                {
                    //si esta checkeado instancia las propiedades del objeto
                    if ((row.Cells[0].FindControl("chkRow") as CheckBox).Checked)
                    {
                        //Se instancia objeto
                        Obj_Persona_DAL = new Cls_Persona_DAL();
                        //Secion tipo Editar
                        Session["tipo"] = BD.Actualizar;
                        Obj_Persona_DAL.sIdPersona = row.Cells[0].Text;
                        Obj_Persona_DAL.sNombre = WebUtility.HtmlDecode(row.Cells[1].Text);
                        Obj_Persona_DAL.sDireccion = WebUtility.HtmlDecode(row.Cells[2].Text);
                        // INICIO: Obtener Rol
                        Cls_Rol_BLL Obj_Rol_BLL = new Cls_Rol_BLL();
                        Cls_Rol_DAL Obj_Rol_DAL = new Cls_Rol_DAL();
                        Obj_Rol_DAL.sDescripcion = row.Cells[3].Text;
                        Obj_Rol_BLL.crudRol(ref Obj_Rol_DAL, BD.Filtrar);
                        Obj_Persona_DAL.bIdRol = Convert.ToByte(Obj_Rol_DAL.DS.Tables[0].Rows[0][0].ToString());
                        // FIN: Obtener Rol
                        //Sesion persona lleva el objeto
                        Session["Persona"] = Obj_Persona_DAL;
                        Response.Redirect(pantallaMantenimiento, false);
                    }
                }
            }
        }

        //boton eliminar
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Obj_Persona_DAL = new Cls_Persona_DAL();
            Obj_Telefonos_DAL = new Cls_Telefonos_DAL();
            Obj_Correos_DAL = new Cls_Correos_DAL();
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
                        Obj_Persona_DAL.sIdPersona = row.Cells[0].Text;
                        Obj_Correos_DAL.sCorreo = row.Cells[0].Text;
                        Obj_Telefonos_DAL.sTelefono = row.Cells[0].Text;
                        Obj_Persona_BLL.crudPersona(ref Obj_Persona_DAL, BD.Eliminar);
                        Obj_Telefonos_BLL.crudTelefono(ref Obj_Telefonos_DAL, BD.Eliminar);
                        Obj_Correos_BLL.crudCorreos(ref Obj_Correos_DAL, BD.Eliminar);
                    }
                }
            }
            if (Obj_Persona_DAL.sMsjError == string.Empty)
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

        protected void PersonaGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            PersonaGridView.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }
    }
}