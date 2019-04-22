using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Data;
using System.Web.UI.WebControls;


namespace Club_Campestre
{
    public partial class Ingreso : System.Web.UI.Page
    {
        #region Variables Globales
        private Cls_Ingresos_BLL Obj_Ingreso_BLL = new Cls_Ingresos_BLL();
        private Cls_TipoServicio_BLL Obj_TipoServicio_BLL = new Cls_TipoServicio_BLL();
        private Cls_TipoServicio_DAL Obj_TipoServicio_DAL;
        private Cls_Ingreso_Dal Obj_Ingreso_DAL = new Cls_Ingreso_Dal();

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        { 
            if (!IsPostBack)
            {
                this.BindGrid();
            }
        }

        protected void TxtConsultar_Click(object sender, EventArgs e)
        {
            Cls_Ingreso_Dal Obj_Ingreso_Dal = new Cls_Ingreso_Dal();
            Cls_Ingresos_BLL Obj_Ingreso_BLL = new Cls_Ingresos_BLL();
            Obj_Ingreso_Dal.IdPersona = txtCedula.Value;
            Obj_Ingreso_BLL.Cargar(ref Obj_Ingreso_Dal);
            DataTable dt = Obj_Ingreso_Dal.DS.Tables[0];
            if (dt.Rows.Count == 0)
            {
                Response.Write("<script>window.alert('La cedula ingresada no corresponde a ningun cliente. Por favro ingrese un cliente valido');</script>");
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    txtnombre.Value = Convert.ToString(row[1]);
                    TxtTipoCliente.Value = Convert.ToString(row[2]);
                    TxtMembresia.Value = Convert.ToString(row[3]);
                    TxtCosto.Value = Convert.ToString(row[4]);
                }
            }
        }

        private void BindGrid()
        {
            //Se instancia objeto
            Obj_TipoServicio_DAL = new Cls_TipoServicio_DAL();
            //llamado metodo listar estados
            Obj_TipoServicio_BLL.crudTipoServicio(ref Obj_TipoServicio_DAL, BD.Listar);
            
            
            if (Obj_TipoServicio_DAL.sMsjError == string.Empty)
            {
                //Carga de Grid con DataSet instanciado en DAL
                this.ServiciosGridView.DataSource = Obj_TipoServicio_DAL.DS.Tables[0];
                this.ServiciosGridView.DataBind();
            }
            else
            {
                this.errorMensaje.InnerHtml = "Se presento un error a la hora de listar Estados.";
                this.BindGrid();
            }
        }
        
        protected void GridViewIvitados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewInvitados.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }

        protected void ServiciosGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ServiciosGridView.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }

        protected void btnagregarInvitado_Click(object sender, EventArgs e)
        {
            Cls_Ingreso_Dal Obj_Ingreso_Dal = new Cls_Ingreso_Dal();
            Cls_Ingresos_BLL Obj_Ingreso_BLL = new Cls_Ingresos_BLL();
            Obj_Ingreso_Dal.IdPersona = txtInvitado.Value;
            Obj_Ingreso_BLL.Invitado_Beneficiario(ref Obj_Ingreso_Dal);
            DataTable dI = Obj_Ingreso_Dal.DI.Tables[0];
            if (dI.Rows.Count == 0)
            {
                Response.Write("<script>window.alert('La cedula ingresada no existe, por favor corroboré el dato o registrelo primero en el mantenimiento de personas');</script>");
            }
            else
            {
                foreach (DataRow row in dI.Rows)
                {
                   
                    GridViewInvitados.DataSource = dI;
                    GridViewInvitados.DataBind();
                    this.txtInvitado.Value = string.Empty;
                }
            }
        }

        protected void Btntotalizar_Click(object sender, EventArgs e)
        {
            double Total_Adicionales = 0;
            double Total_Servicios = 0;
            double Total = 0;
            foreach (GridViewRow row  in GridViewInvitados.Rows)
            {
                Total_Adicionales += Convert.ToDouble(row.Cells[3].Text);
            }
            foreach (GridViewRow row in ServiciosGridView.Rows)
            {
                if(row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if(chkRow.Checked)
                    {
                        Total_Servicios += Convert.ToDouble(row.Cells[2].Text);
                    }

                    else
                    {
                        //Total_Servicios = Total_Servicios;
                    }
                }
            }
            Total = Total_Adicionales + Total_Servicios;
            TxtTotal.Value = Convert.ToString(Total);
        }

        protected void btnFacturar_Click(object sender, EventArgs e)
        {
            Obj_Ingreso_DAL.IdPersona = Convert.ToString(txtCedula.Value);
            Obj_Ingreso_DAL.Costo = Convert.ToSingle(TxtTotal.Value.ToString());
            Obj_Ingreso_BLL.Insertar_Ingreso_Factura(ref Obj_Ingreso_DAL);

            foreach (GridViewRow row in GridViewInvitados.Rows)
            {
                Obj_Ingreso_DAL.IdPersona = txtCedula.Value;
                Obj_Ingreso_DAL.Costo = Convert.ToSingle(row.Cells[3].Text);
                Obj_Ingreso_DAL.Total = Convert.ToSingle(row.Cells[3].Text);
                Obj_Ingreso_BLL.Insertar_Detalle_Factura(ref Obj_Ingreso_DAL);
            }

            foreach (GridViewRow row in ServiciosGridView.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Obj_Ingreso_DAL.IdPersona = txtCedula.Value;
                        Obj_Ingreso_DAL.Costo = Convert.ToSingle(row.Cells[2].Text);
                        Obj_Ingreso_DAL.IdTipoServicio = Convert.ToByte(row.Cells[0].Text);
                        Obj_Ingreso_DAL.Total = Convert.ToSingle(row.Cells[2].Text);
                        Obj_Ingreso_BLL.Insertar_Detalle_Factura(ref Obj_Ingreso_DAL);
                    }

                    else
                    {
                        //Total_Servicios = Total_Servicios;
                    }
                }
            }


        }
    }
}