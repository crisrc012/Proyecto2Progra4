using System.Data.SqlClient;

namespace ClubCampestre_DAL.BD
{
    public class Cls_BD_DAL
    {
        #region Constructores
        public Cls_BD_DAL()
        {
            Obj_dtparam.Columns.Add("Nombre");
            Obj_dtparam.Columns.Add("Valor");
        }
        #endregion
        #region Variables
        private string _smsj_error, _scadena_conexion, _sNombre_SP;

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

        public string sNombre_SP
        {
            get
            {
                return _sNombre_SP;
            }

            set
            {
                _sNombre_SP = value;
            }
        }
        #endregion
        #region Objetos de base de datos
        public SqlCommand Obj_sql_cmd;
        public SqlDataAdapter Obj_sql_adap;
        public SqlConnection Obj_sql_cnx;
        public System.Data.DataTable Obj_dtparam = new System.Data.DataTable("Parametros");
        #endregion
    }
}
