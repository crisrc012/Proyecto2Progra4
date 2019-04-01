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
            if (Obj.GetType() == typeof(string))
            {
                return SqlDbType.VarChar;
            }
            if (Obj.GetType() == typeof(int))
            {
                return SqlDbType.Int;
            }
            if (Obj.GetType() == typeof(short))
            {
                return SqlDbType.SmallInt;
            }
            if (Obj.GetType() == typeof(float))
            {
                return SqlDbType.Float;
            }
            if (Obj.GetType() == typeof(byte))
            {
                return SqlDbType.TinyInt;
            }
            if (Obj.GetType() == typeof(DateTime))
            {
                return SqlDbType.DateTime;
            }
            if (Obj.GetType() == typeof(char))
            {
                return SqlDbType.Char;
            }
            return SqlDbType.VarChar;
        }
        #endregion
        #region Miembros públicos
        public DataTable ExecuteDataAdapter(ref Cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                // Se obtiene la cadena de conexión
                Obj_BD_DAL.sCadena_conexion = ConfigurationManager.ConnectionStrings["Win_aut"].ToString().Trim();
                // Se crea el objeto de conexión
                Obj_BD_DAL.Obj_sql_cnx = new SqlConnection(Obj_BD_DAL.sCadena_conexion);
                // Se inicializa el DataAdapter con el SP y la conexión abierta
                Obj_BD_DAL.Obj_sql_adap = new SqlDataAdapter(Obj_BD_DAL.sNombre_SP, Obj_BD_DAL.Obj_sql_cnx);
                if (Obj_BD_DAL.Obj_dtparam.Rows.Count >= 1)
                {
                    foreach (DataRow Celda in Obj_BD_DAL.Obj_dtparam.Rows)
                    {
                            Obj_BD_DAL.Obj_sql_adap.SelectCommand.Parameters.Add(Celda[0].ToString()
                                , volverDatoSQL(Celda[0].GetType())).Value = Celda[1];
                    }
                }
                // Se especifica el tipo de comando de SP
                Obj_BD_DAL.Obj_sql_adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                // Se inicializa el DataSet
                DataSet DS = new DataSet();
                // Si la conexión está cerrada
                if (Obj_BD_DAL.Obj_sql_cnx.State == ConnectionState.Closed)
                {
                    // Se abre la cadena de conexión
                    Obj_BD_DAL.Obj_sql_cnx.Open();
                }
                // Se carga el DataSet
                Obj_BD_DAL.Obj_sql_adap.Fill(DS);
                // Se establece en vacío el mensaje de error
                Obj_BD_DAL.sMsj_error = string.Empty;
                // Se retorna el DataTable de índice 0 que está en el DataSet
                return DS.Tables[0];
            }
            catch (SqlException e)
            {
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
        public bool ExecuteNonQuery(ref Cls_BD_DAL Obj_BD_DAL)
        {
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
                // Se inicializa el SQL Command con el SP y la conexión abierta
                Obj_BD_DAL.Obj_sql_cmd = new SqlCommand(Obj_BD_DAL.sNombre_SP, Obj_BD_DAL.Obj_sql_cnx);
                if (Obj_BD_DAL.Obj_dtparam.Rows.Count >= 1)
                {
                    foreach (DataRow Celda in Obj_BD_DAL.Obj_dtparam.Rows)
                    {
                        Obj_BD_DAL.Obj_sql_cmd.Parameters.Add(Celda[0].ToString()
                            , volverDatoSQL(Celda[0].GetType())).Value = Celda[1];
                    }
                }
                // Se especifica el tipo de comando de SP
                Obj_BD_DAL.Obj_sql_cmd.CommandType = CommandType.StoredProcedure;
                // Se ejecuta la consulta
                Obj_BD_DAL.Obj_sql_cmd.ExecuteNonQuery();
                // Se establece en vacío el mensaje de error
                Obj_BD_DAL.sMsj_error = string.Empty;
                // Se retorna valor exitoso
                return true;
            }
            catch (SqlException e)
            {
                Obj_BD_DAL.sMsj_error = e.ToString().Trim();
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
        public string ExecuteScalar(ref Cls_BD_DAL Obj_BD_DAL)
        {
            string valorScalar = string.Empty;
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
                // Se inicializa el SQL Command con el SP y la conexión abierta
                Obj_BD_DAL.Obj_sql_cmd = new SqlCommand(Obj_BD_DAL.sNombre_SP, Obj_BD_DAL.Obj_sql_cnx);
                if (Obj_BD_DAL.Obj_dtparam.Rows.Count >= 1)
                {
                    
                    foreach (DataRow Celda in Obj_BD_DAL.Obj_dtparam.Rows)
                    {
                        Obj_BD_DAL.Obj_sql_cmd.Parameters.Add(Celda[0].ToString()
                            , volverDatoSQL(Celda[0].GetType())).Value = Celda[1].ToString();
                    }
                }
                // Se especifica el tipo de comando de SP
                Obj_BD_DAL.Obj_sql_cmd.CommandType = CommandType.StoredProcedure;
                // Se ejecuta la consulta y se carga el valor retornado al scalar
                valorScalar = Obj_BD_DAL.Obj_sql_cmd.ExecuteScalar().ToString();
                // Se establece en vacío el mensaje de error
                Obj_BD_DAL.sMsj_error = string.Empty;
                // Se retorna valor escalar
                return valorScalar;
            }
            catch (SqlException e)
            {
                Obj_BD_DAL.sMsj_error = e.ToString().Trim();
                // Se retorna valor escalar, posiblemente vacío
                return valorScalar;
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
