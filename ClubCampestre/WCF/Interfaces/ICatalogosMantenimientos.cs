using System.Data;
using System.ServiceModel;

namespace WCF.Interfaces
{
    [ServiceContract]
    public interface ICatalogosMantenimientos
    {
        #region Beneficiarios
        [OperationContract]
        DataTable listarBeneficiarios(ref string sMsj_error);
        [OperationContract]
        DataTable filtrarBeneficiarios(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsj_error);
        [OperationContract]
        short insertarBeneficiarios(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsj_error);
        [OperationContract]
        bool actualizarBeneficiarios(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsj_error);
        [OperationContract]
        bool eliminarBeneficiarios(short SIdBeneficiario, ref string sMsj_error);
        #endregion
        #region Clientes
        [OperationContract]
        DataTable listarClientes(ref string sMsjError);
        [OperationContract]
        DataTable filtrarClientes(short sIdCliente, byte bIdTipoCliente, string sIdPersona, ref string sMsjError);
        [OperationContract]
        short insertarClientes(short sIdCliente, byte bIdTipoCliente, string sIdPersona, ref string sMsjError);
        [OperationContract]
        bool actualizarClientes(short sIdCliente, byte bIdTipoCliente, string sIdPersona, ref string sMsjError);
        [OperationContract]
        bool eliminarClientes(short sIdCliente, ref string sMsjError);
        #endregion
        #region Correos
        [OperationContract]
        DataTable listarCorreos(ref string sMsjError);
        [OperationContract]
        DataTable filtrarCorreos(short sIdCorreo, string sIdPersona, string sCorreo, ref string sMsjError);
        [OperationContract]
        short insertarCorreos(short sIdCorreo, string sIdPersona, string sCorreo, ref string sMsjError);
        [OperationContract]
        bool actualizarCorreos(short sIdCorreo, string sIdPersona, string sCorreo, ref string sMsjError);
        [OperationContract]
        bool eliminarCorreos(short sIdCorreo, ref string sMsjError);
        #endregion
        #region Estado
        [OperationContract]
        DataTable listarEstado(ref string sMsj_error);
        [OperationContract]
        DataTable filtrarEstado(char cIdEstado, string sEstado, ref string sMsj_error);
        [OperationContract]
        char insertarEstado(char cIdEstado, string sEstado, ref string sMsj_error);
        [OperationContract]
        bool actualizarEstado(char cIdEstado, string sEstado, ref string sMsj_error);
        [OperationContract]
        bool eliminarEstado(char cIdEstado, ref string sMsj_error);
        #endregion
        #region Facturacion
        //DataTable listarFacturacion();
        //[OperationContract]
        //DataTable filtrarFacturacion(ref Cls_Facturacion_DAL Obj_Facturacion_DAL);
        //[OperationContract]
        //int insertarFacturacion(ref Cls_Facturacion_DAL Obj_Facturacion_DAL);
        //[OperationContract]
        //bool actualizarFacturacion(ref Cls_Facturacion_DAL Obj_Facturacion_DAL);
        //[OperationContract]
        //bool eliminarFacturacion(int iIdFactura);
        #endregion
        #region FacturaDetalle
        //[OperationContract]
        //DataTable listarFacturaDetalle();
        //[OperationContract]
        //DataTable filtrarFacturaDetalle(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL);
        //[OperationContract]
        //int insertarFacturaDetalle(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL);
        //[OperationContract]
        //bool actualizarFacturaDetalle(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL);
        //[OperationContract]
        //bool eliminarFacturaDetalle(int iIdFacturaDetalle);
        #endregion
    }
}
