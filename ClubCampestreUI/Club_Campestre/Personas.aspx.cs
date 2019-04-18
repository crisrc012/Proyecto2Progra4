using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


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

        #region Cls Telefono
        Cls_Telefonos_DAL Cls_Telefonos_DAL = new Cls_Telefonos_DAL();
        Cls_Telefono_BLL Cls_Telefonos_BLL = new Cls_Telefono_BLL();
        List<Cls_Telefonos_DAL> ListaTelefono = new List<Cls_Telefonos_DAL>();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarRoles();

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
            Obj_Rol_BLL.Listar(ref Obj_Rol_DAL);

            //DataRow row = Obj_Rol_DAL.DS.Tables[0].NewRow();
            //row["IdRol"] = 0;
            //row["Descripcion"] = "-- Seleccione --";
            //Obj_Rol_DAL.DS.Tables[0].Rows.Add(row);

            DropDownRol.DataSource = Obj_Rol_DAL.DS.Tables[0];
            DropDownRol.DataTextField = "Descripcion";
            DropDownRol.DataValueField = "IdRol";
            DropDownRol.DataBind();
        }

        //Boton de Telefono 
        protected void btnAgregar2_Click1(object sender, EventArgs e)
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

          
            tabla.Rows.Add(this.txtTelefono.Value.ToString().Trim());

            GridViewTelefono.DataSource = tabla;
            GridViewTelefono.DataBind();

            ViewState["tablatelefono"] = tabla;




        }

        protected void btnRemover2_Click1(object sender, EventArgs e)
        {
            //GridViewTelefono.DataSource = null;
            //GridViewTelefono.DataBind();

            //foreach (GridViewRow row in GridViewTelefono.Rows)
            //{
            //    //busca el la fila
            //    if (row.RowType == DataControlRowType.DataRow)
            //    {
            //        //si esta checkeado instancia las propiedades del objeto
            //        CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
            //        if (chkRow.Checked)
            //        {
            //            Cls_Telefonos_DAL.SIdPersona = row.Cells[0].Text;
            //            Cls_Telefonos_DAL.STelefono = row.Cells[1].Text;
            //            ListaTelefono.Remove(Cls_Telefonos_DAL);

            //            //Cls_Telefonos_BLL.Eliminar(ref Cls_Telefonos_DAL);// eliminar estados
            //        }

            //    }
            //}



            //GridViewTelefono.DataSource = ListaTelefono;
            //GridViewTelefono.DataBind();


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

            tabla.Rows.Add(this.txtemail.Value.ToString().Trim());

            CorreoPersonaGridView.DataSource = tabla;
            CorreoPersonaGridView.DataBind();

            ViewState["tablaCorreo"] = tabla;
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

            for (int i = quitar.Count-1; i >= 0; i--)
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
            Obj_Persona_BLL.Insertar(ref Obj_Persona_DAL);


            //Telefono ingresa 
            #region



            if (Obj_Persona_DAL.SMsjError.Equals(string.Empty))
            {

                foreach (GridViewRow row in GridViewTelefono.Rows)
                {
                    //busca el la fila
                    if (row.RowType == DataControlRowType.DataRow)
                    {

                        {
                            Cls_Telefonos_DAL.STelefono = row.Cells[0].Text;
                            Cls_Telefonos_DAL.SIdPersona = this.txtCedula.Value.ToString().Trim();
                            

                            Cls_Telefonos_BLL.Insertar(ref Cls_Telefonos_DAL);//   insertar
                        }

                    }
                }
                #endregion Telefono 


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

                            Obj_Correo_BLL.Insertar(ref Obj_Correo_DAL);//  insertar
                        }

                    }
                }
                #endregion

                Obj_Persona_BLL.Insertar(ref Obj_Persona_DAL);
                    Server.Transfer("Mant_Persona.aspx");
                

            }

        }



    }
}