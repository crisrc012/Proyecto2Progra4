using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCampestre_DAL.BD
{
    public class Cls_BD_DAL
    {
        #region Variables
        private string _smsj_error, _scadena_conexion;

        public string sMsj_error
        {
            get
            {
                return _smsj_error;
            }

            set
            {
                _smsj_error = value;
            }
        }

        public string sCadena_conexion
        {
            get
            {
                return _scadena_conexion;
            }

            set
            {
                _scadena_conexion = value;
            }
        }
        #endregion
        #region Objetos de base de datos
        public SqlCommand Obj_sql_cmd;
        public SqlDataAdapter Obj_sql_adap;
        public SqlConnection Obj_sql_cnx;
        #endregion
    }
}
