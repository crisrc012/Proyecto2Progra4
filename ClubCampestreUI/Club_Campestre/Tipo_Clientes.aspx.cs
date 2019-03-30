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
    public partial class Tipo_Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Meter esto 
            if (!IsPostBack)
            {
                this.BindGrid();
            }

        }

        private void BindGrid()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Tipo_CLiente");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("chkRow");

            DataRow dr = dt.NewRow();
            dr["Tipo_CLiente"] = 1;
            dr["Descripcion"] = "Prueba";
            dr["chkRow"] = false;
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["Tipo_CLiente"] = 2;
            dr1["Descripcion"] = "Inactivo";
            dr1["chkRow"] = false;
            dt.Rows.Add(dr1);

            this.Tipo_ClienteGridView.DataSource = dt;
            this.Tipo_ClienteGridView.DataBind();

            //this.EstadoGridView.DataSource = dt;
            //this.EstadoGridView.DataBind();


            //Metr esto ya que es plan B

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



        //Falta por modificar

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //Identificcion en lo que estamos trabjanado es un estado N
            Session["tipo"] = "N";
            Server.Transfer("Mant_Tipo_Cliente.aspx", false);
        }


        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Session["tipo"] = "E";
            string Tipo_Cliente = "", Descripcion = "";
            foreach (GridViewRow row in Tipo_ClienteGridView.Rows)
                
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Tipo_Cliente = row.Cells[0].Text;
                        Descripcion = row.Cells[1].Text;

                    }

                    //Cls_Estado_DAL estado = new Cls_Estado_DAL();
                    Cls_TipoCliente_DAL tipocliente = new Cls_TipoCliente_DAL();
                    //Usuario Usu1 = new Usuario(nombre, cedula);
                    //estado.CIdEstado = Convert.ToChar(Estado);
                    //estado.SPKEstado = Descripcion;
                    tipocliente.BIdTipoCliente = Convert.ToByte(Tipo_Cliente);
                    tipocliente.SPKDescripcion = Descripcion;
                    Session["Tipo_Cliente"] = tipocliente;
                    Server.Transfer("Mant_Tipo_Cliente.aspx");
                }
            }
        }

    }
}