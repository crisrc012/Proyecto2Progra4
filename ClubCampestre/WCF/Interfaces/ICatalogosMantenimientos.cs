using System.Data;
using System.ServiceModel;

namespace WCF.Interfaces
{
    [ServiceContract]
    public interface ICatalogosMantenimientos
    {
        #region Estado
        [OperationContract]
        DataTable listarEstado();
        #endregion
    }
}
