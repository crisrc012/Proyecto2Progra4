using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using ClubCampestre_DAL.BD;
using System.Data.SqlClient;

namespace ClubCampestre_BLL.BD
{
    public class Cls_BD_BLL
    {
        public DataTable ExecuteDataAdapter(string sNombre_SP, string sNombreParametro,
            SqlDbType DbType, string sValorParametro, ref string sMsjError)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            try
            {
                // Se obtiene la cadena de conexión
                Obj_BD_DAL.sCadena_conexion = ConfigurationManager.ConnectionStrings["Win_aut"].ToString().Trim();
                // Se crea el objeto de conexión
                Obj_BD_DAL.Obj_sql_cnx = new SqlConnection(Obj_BD_DAL.sCadena_conexion);
                // Si la conexión está cerrada
                if (Obj_BD_DAL.Obj_sql_cnx.State == ConnectionState.Closed)
                {
                    // Se abre la cadena de conexión
                    Obj_BD_DAL.Obj_sql_cnx.Open();
                }
                // Se inicializa el DataAdapter con el SP y la conexión abierta
                Obj_BD_DAL.Obj_sql_adap = new SqlDataAdapter(sNombre_SP, Obj_BD_DAL.Obj_sql_cnx);
                if (sValorParametro != string.Empty)
                {
                    Obj_BD_DAL.Obj_sql_adap.SelectCommand.Parameters.Add(sNombreParametro, DbType).Value = sValorParametro;
                }
                // Se especifica el tipo de comando de SP
                Obj_BD_DAL.Obj_sql_adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                // Se inicializa el DataSet
                DataSet DS = new DataSet();
                // Se carga el DataSet
                Obj_BD_DAL.Obj_sql_adap.Fill(DS);
                // Se establece en vacío el mensaje de error
                Obj_BD_DAL.sMsj_error = string.Empty;
                sMsjError = string.Empty;
                return DS.Tables[0];
            }
            catch (SqlException e)
            {
                sMsjError = e.ToString().Trim();
                Obj_BD_DAL.sMsj_error = e.ToString().Trim();
                return null;
            }
            finally
            {
                if (Obj_BD_DAL.Obj_sql_cnx != null)
                {
                    if (Obj_BD_DAL.Obj_sql_cnx.State == ConnectionState.Open)
                    {
                        Obj_BD_DAL.Obj_sql_cnx.Close();
                    }
                    Obj_BD_DAL.Obj_sql_cnx.Dispose();
                }
            }
        }
    }
}
