using System.Data;
using System.ServiceModel;

namespace WCF.Interfaces
{
    [ServiceContract]
    public interface IMantenimientosGenericos
    {
        [OperationContract]
        DataTable ListarDatos(string sNombreSP, ref string sMsjError);

        [OperationContract]
        DataTable FiltrarDatos(string sNombreSP, string sNombreParametro, SqlDbType DbType, string sValorParametro, ref string sMsjError);

        [OperationContract]
        bool Insertar_DatosSinIdentity(string sNombreSP, DataTable dtParametros, ref string sMsjError);

        [OperationContract]
        string Insertar_DatosConIdentity(string sNombreSP, DataTable dtParametros, ref string sValorScalar, ref string sMsjError);

        [OperationContract]
        bool Modifica_Datos(string sNombreSP, DataTable dtParametros, ref string sMsjError);

        [OperationContract]
        bool Elimina_Datos(string sNombreSP, DataTable dtParametros, ref string sMsjError);
    }
}
