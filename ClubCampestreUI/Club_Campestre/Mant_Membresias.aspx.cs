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
            returnaNombre(this.txtCedula.Value);
        }
    }
}