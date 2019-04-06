using System;
using System.Configuration;
using System.Data;
using ClubCampestre_DAL.BD;
using System.Data.SqlClient;

namespace ClubCampestre_BLL.BD
{

    public class Cls_BD_BLL
    {
        #region Miembros privados
        private SqlDbType volverDatoSQL(Type Obj)
        {
            return (Obj.GetType() == typeof(string)) ? SqlDbType.VarChar :
                (Obj.GetType() == typeof(int)) ? SqlDbType.Int :
                (Obj.GetType() == typeof(short)) ? SqlDbType.SmallInt :
                (Obj.GetType() == typeof(float)) ? SqlDbType.Float :
                (Obj.GetType() == typeof(byte)) ? SqlDbType.TinyInt :
                (Obj.GetType() == typeof(DateTime)) ? SqlDbType.DateTime :
                (Obj.GetType() == typeof(char)) ? SqlDbType.Char :
                SqlDbType.VarChar;
        }
        #endregion
        #region Miembros públicos
        public DataTable ExecuteDataAdapter(DataTable dtParams, string sNombre_SP, ref string sMsj_error)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            try
            {
                // Se crea el objeto de conexión
                Obj_BD_DAL.Obj_sql_cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["Win_aut"].ToString().Trim());
                // Se inicializa el DataAdapter con el SP y la conexión abierta
                Obj_BD_DAL.Obj_sql_adap = new SqlDataAdapter(sNombre_SP, Obj_BD_DAL.Obj_sql_cnx);
                // Asignar parámetros
                if (dtParams != null)
                {
                    if (dtParams.Rows.Count > 0)
                    {
                        foreach (DataRow Row in dtParams.Rows)
                        {
                            Obj_BD_DAL.Obj_sql_adap.SelectCommand.Parameters.Add(Row[0].ToString()
                                , volverDatoSQL(Row[0].GetType())).Value = Row[1];
                        }
                    }
                }
                // Se especifica el tipo de comando de SP
                Obj_BD_DAL.Obj_sql_adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                // Si la conexión está cerrada
                if (Obj_BD_DAL.Obj_sql_cnx.State == ConnectionState.Closed)
                {
                    // Se abre la cadena de conexión
                    Obj_BD_DAL.Obj_sql_cnx.Open();
                }
                // Se inicializa el DataSet
                DataSet DS = new DataSet();
                // Se carga el DataSet
                Obj_BD_DAL.Obj_sql_adap.Fill(DS);
                // Se retorna el DataTable de índice 0 que está en el DataSet
                return DS.Tables[0];
            }
            catch (SqlException e)
            {
                sMsj_error = e.ToString().Trim();
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
        public bool ExecuteNonQuery(DataTable dtParams, string sNombre_SP, ref string sMsj_error)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            try
            {
                // Se crea el objeto de conexión y Se obtiene la cadena de conexión
                Obj_BD_DAL.Obj_sql_cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["Win_aut"].ToString().Trim());
                // Si la conexión está cerrada
                if (Obj_BD_DAL.Obj_sql_cnx.State == ConnectionState.Closed)
                {
                    // Se abre la cadena de conexión
                    Obj_BD_DAL.Obj_sql_cnx.Open();
                }
                // Se inicializa el SQL Command con el SP y la conexión abierta
                Obj_BD_DAL.Obj_sql_cmd = new SqlCommand(sNombre_SP, Obj_BD_DAL.Obj_sql_cnx);
                // Asignar parámetros
                if (dtParams != null)
                {
                    if (dtParams.Rows.Count > 0)
                    {
                        foreach (DataRow Row in dtParams.Rows)
                        {
                            Obj_BD_DAL.Obj_sql_cmd.Parameters.Add(Row[0].ToString()
                                , volverDatoSQL(Row[0].GetType())).Value = Row[1];
                        }
                    }
                }
                // Se especifica el tipo de comando de SP
                Obj_BD_DAL.Obj_sql_cmd.CommandType = CommandType.StoredProcedure;
                // Se ejecuta la consulta
                Obj_BD_DAL.Obj_sql_cmd.ExecuteNonQuery();
                // Se establece en vacío el mensaje de error
                sMsj_error = string.Empty;
                // Se retorna valor exitoso
                return true;
            }
            catch (SqlException e)
            {
                sMsj_error = e.ToString().Trim();
                // Se retorna valor fallido
                return false;
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
        public string ExecuteScalar(DataTable dtParams, string sNombre_SP, ref string sMsj_error)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            try
            {
                // Se obtiene la cadena de conexión y Se crea el objeto de conexión
                Obj_BD_DAL.Obj_sql_cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["Win_aut"].ToString().Trim());
                // Si la conexión está cerrada
                if (Obj_BD_DAL.Obj_sql_cnx.State == ConnectionState.Closed)
                {
                    // Se abre la cadena de conexión
                    Obj_BD_DAL.Obj_sql_cnx.Open();
                }
                // Se inicializa el SQL Command con el SP y la conexión abierta
                Obj_BD_DAL.Obj_sql_cmd = new SqlCommand(sNombre_SP, Obj_BD_DAL.Obj_sql_cnx);
                // Asignar parámetros
                if (dtParams != null)
                {
                    if (dtParams.Rows.Count > 0)
                    {
                        foreach (DataRow Row in dtParams.Rows)
                        {
                            Obj_BD_DAL.Obj_sql_cmd.Parameters.Add(Row[0].ToString()
                                , volverDatoSQL(Row[0].GetType())).Value = Row[1];
                        }
                    }
                }
                // Se especifica el tipo de comando de SP
                Obj_BD_DAL.Obj_sql_cmd.CommandType = CommandType.StoredProcedure;
                // Se retorna valor escalar
                // Se ejecuta la consulta y se carga el valor retornado al scalar
                return Obj_BD_DAL.Obj_sql_cmd.ExecuteScalar().ToString();
            }
            catch (SqlException e)
            {
                sMsj_error = e.ToString().Trim();
                // Se retorna valor escalar, posiblemente vacío
                return string.Empty;
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
        #endregion
    }
}
