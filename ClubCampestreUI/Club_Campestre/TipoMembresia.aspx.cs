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

namespace Club_Campestre
{
    public partial class TipoMembresia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.BindGrid();
            }


        }
        private void BindGrid()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Tipo_de_Membresia");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Costo");
            dt.Columns.Add("chkRow");

            DataRow dr = dt.NewRow();
            dr["Tipo_de_Membresia"] = 1;
            dr["Descripcion"] = "prueba";
            dr["Costo"] = 1000;
            dr["chkRow"] = false;
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["Tipo_de_Membresia"] = 1;
            dr1["Descripcion"] = "prueba2";
            dr1["Costo"] = 300;
            dr1["chkRow"] = false;
            dt.Rows.Add(dr1);

            this.TipoMebresiaGridView.DataSource = dt;
            this.TipoMebresiaGridView.DataBind();


            //Meter esto ya que es plan B

            // string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            // using (SqlConnection con = new SqlConnection(constr))
            // {
            //     using (SqlCommand cmd = new SqlCommand("SELECT [HobbyId], [Hobby], [IsSelected] FROM Hobbies"))
            //     {
            //         using (SqlDataAdapter sda = new SqlDataAdapter())
            //         {
            //             cmd.Connection = con;
            //             sda.SelectCommand = cmd;
            //             using (DataTable dt = new DataTable())
            //             {
            //                 sda.Fill(dt);
            //                 GridView1.DataSource = dt;
            //                 GridView1.DataBind();
            //             }
            //         }
            //     }
            // }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //Identificcion en lo que estamos trabjanado es un estado N
            Session["tipo"] = "N";
            Server.Transfer("Mant_Tipo_Membre.aspx", false);
        }


        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Session["tipo"] = "E";
            #region Consulta Wilberth tipo de dato de Costo si debo de ponerlo como un int 

            #endregion

            //Pregunta el tipo de dato de Costo lo puse string pero quedo al pendiente por si debo de cambiarlo ya que es numero
            string TipoMembresia = "", Descripcion = "", Costo="";
            foreach (GridViewRow row in TipoMebresiaGridView.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        TipoMembresia = row.Cells[0].Text;
                        Descripcion = row.Cells[1].Text;
                        Costo = row.Cells[2].Text;

                    }
                    Cls_TipoMembresia_DAL tipomembresia = new Cls_TipoMembresia_DAL();
                    tipomembresia.BIdTipoMembresia = Convert.ToByte(TipoMembresia);
                    tipomembresia.SPKDescripcion = Descripcion;
                    tipomembresia.Fcosto = (float)Convert.ToDecimal(Costo);
 
                    Session["TipoMembresia"] = tipomembresia;
                    Server.Transfer("Mant_Tipo_Membre.aspx");
                }
            }
        }



    }
}