using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Club_Campestre
{
    public partial class Mant_Membresias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }
        }


        

        protected void CargaBeneficiarios(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow dr = null;

            if (BeneficiariosGridView.Rows.Count > 0)
            {
                dt.Columns.Add(new DataColumn("IdPersona", typeof(string)));
                foreach (GridViewRow row in BeneficiariosGridView.Rows)
                {

                    dr = dt.NewRow();
                    dr["IdPersona"] = row.Cells[0].Text.ToString();
                    dt.Rows.Add(dr);
                }
                ViewState["datos"] = dt;
            }
            else
            {
                dt.Columns.Add(new DataColumn("IdPersona", typeof(string)));
                dr = dt.NewRow();
                dr["IdPersona"] = this.bencel.Value;
                dt.Rows.Add(dr);
                //ViewState["datos"] = dt;
                BeneficiariosGridView.DataSource = dt;
                BeneficiariosGridView.DataBind();
            }         

        }

        

    }
}