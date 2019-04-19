using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.CatalogosMantenimientos;

namespace Club_Campestre
{
    public partial class Mantenimiento_Tipos_De_Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Cls_Estado_DAL estado = (Cls_Estado_DAL)Session["Estado"];
                Cls_TipoCliente_DAL TipoCliente = (Cls_TipoCliente_DAL)Session["TipoCliente"];
                //string tipo = Session["tipo"].ToString();
                string tipo = Session["tipo"].ToString();
                if (TipoCliente != null & tipo == "E")
                {
                    this.mantenimiento.InnerHtml = "Modificacion de Tipo Cliente";
                    this.txtIdTipoCLiente.Value = TipoCliente.BIdTipoCliente.ToString();
                    
                    this.txtdescripcion.Value = TipoCliente.SPKDescripcion.ToString();
                    
                }
                else
                {
                    this.mantenimiento.InnerHtml = "Nuevos de Tipos Cliente";
                    this.txtIdTipoCLiente.Visible = false;
                    this.txtIdTipoCLiente.Value = string.Empty;
                    this.txtdescripcion.Value = string.Empty;
                }
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Cls_TipoCliente_DAL Obj_TipoCliente_DAL = new Cls_TipoCliente_DAL();
            Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();

            //Obj_TipoCliente_DAL.SPKDescripcion = this.txtdescripcion.Value.ToString();
            //string tipo = Session["tipo"].ToString();
            //if (tipo == "E")
            //{
            //    Obj_TipoCliente_BLL.Actualizar(ref Obj_TipoCliente_DAL);

            //    Server.Transfer("Tipo_Clientes.aspx");
            //}
            //else
            //{
            //    Obj_TipoCliente_BLL.Insertar(ref Obj_TipoCliente_DAL);
            //    Server.Transfer("Tipo_Clientes.aspx");
            //}

           
            if (Session["tipo"].ToString() == "E") // Si se edita se debe de obtener el ID
            {
                Obj_TipoCliente_DAL.BIdTipoCliente = Convert.ToByte(this.txtIdTipoCLiente.Value);
            }
            Obj_TipoCliente_DAL.SPKDescripcion = this.txtdescripcion.Value.ToString();
            string tipo = Session["tipo"].ToString();
            if (tipo == "E")
            {
                Obj_TipoCliente_BLL.Actualizar(ref Obj_TipoCliente_DAL);
                Server.Transfer("Tipo_Clientes.aspx");
            }
            else
            {
                Obj_TipoCliente_BLL.Insertar(ref Obj_TipoCliente_DAL);
                Server.Transfer("Tipo_Clientes.aspx");
            }





        }
    }
}