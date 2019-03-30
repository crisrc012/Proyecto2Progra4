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
    public partial class Estados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ///Meter esto 
            if (!IsPostBack)
            {
                this.BindGrid();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// 


            //Metodo que agregar 
        private void BindGrid()
        {
            Cls_Estado_DAL Obj_Estado_DAL = new Cls_Estado_DAL();
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Obj_Estado_BLL.listarEstado(ref Obj_Estado_DAL);

            /*
            DataTable dt = new DataTable();

            dt.Columns.Add("Estado");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("chkRow");

            DataRow dr = dt.NewRow();
            dr["Estado"] = "A";
            dr["Descripcion"] = "Activo";
            dr["chkRow"] = false;
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["Estado"] = "I";
            dr1["Descripcion"] = "Inactivo";
            dr1["chkRow"] = false;
            dt.Rows.Add(dr1);
            */

            this.EstadoGridView.DataSource = Obj_Estado_DAL.DS.Tables[0];
            this.EstadoGridView.DataBind();


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


        //Boton nuevo 
        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //Identificcion en lo que estamos trabjanado es un estado N
            Session["tipo"] = "N";
            Server.Transfer("Mant_Estados.aspx", false);
        }



        //boton 2 
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Session["tipo"] = "E";
            string Estado = "", Descripcion = "";
            foreach (GridViewRow row in EstadoGridView.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = (row.Cells[0].FindControl("chkRow") as CheckBox);
                    if (chkRow.Checked)
                    {
                        Estado = row.Cells[0].Text;
                        Descripcion = row.Cells[1].Text;

                    }

                    Cls_Estado_DAL estado = new Cls_Estado_DAL();
                    //Usuario Usu1 = new Usuario(nombre, cedula);
                    estado.CIdEstado = Convert.ToChar(Estado);
                    estado.SPKEstado = Descripcion;
                    Session["Estado"] = estado;
                    Server.Transfer("Mant_Estados.aspx");
                }
            }
        }
    }
}