using ClubCampestre_BLL.BD;
using System.Data;

namespace WCF.Contracts
{
    public class MantenimientosGenericos : Interfaces.IMantenimientosGenericos
    {
        public DataTable ListarDatos(string sNombreSP, ref string sMsjError)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            return Obj_BD_BLL.ExecuteDataAdapter(null, sNombreSP, ref sMsjError);
        }

        public DataTable FiltrarDatos(string sNombreSP, string sNombreParametro, SqlDbType DbType, string sValorParametro, ref string sMsjError)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            return Obj_BD_BLL.ExecuteDataAdapter(sNombreSP, sNombreParametro, DbType, sValorParametro, ref sMsjError);
        }

        public bool Insertar_DatosSinIdentity(string sNombreSP, DataTable dtParametros, ref string sMsjError)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            return Obj_BD_BLL.ExecuteNonQuery(dtParametros, sNombreSP, ref sMsjError);
        }

        public string Insertar_DatosConIdentity(string sNombreSP, DataTable dtParametros, ref string sValorScalar, ref string sMsjError)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            return Obj_BD_BLL.ExecuteScalar(dtParametros, sNombreSP, ref sMsjError);
        }

        public bool Modifica_Datos(string sNombreSP, DataTable dtParametros, ref string sMsjError)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            return Obj_BD_BLL.ExecuteNonQuery(dtParametros, sNombreSP, ref sMsjError);
        }


        public bool Elimina_Datos(string sNombreSP, DataTable dtParametros, ref string sMsjError)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            return Obj_BD_BLL.ExecuteNonQuery(dtParametros, sNombreSP, ref sMsjError);
        }
    }
}
