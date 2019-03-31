using System;
using System.Data;
using System.ServiceModel;

namespace WCF.Interfaces
{
    [ServiceContract]
    public interface ICatalogosMantenimientos
    {
        #region Beneficiarios
        [OperationContract]
        DataTable listarBeneficiarios();
        [OperationContract]
        DataTable filtrarBeneficiarios(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado);
        #endregion
        #region Clientes
        [OperationContract]
        DataTable listarClientes();
        [OperationContract]
        DataTable filtrarClientes(short sIdCliente, byte bIdTipoCliente, string sIdPersona);
        #endregion
        #region Correos
        [OperationContract]
        DataTable listarCorreos();
        [OperationContract]
        DataTable filtrarCorreos(short sIdCorreo, string sIdPersona, string sCorreo);
        #endregion
        #region Estado
        [OperationContract]
        DataTable listarEstado();
        [OperationContract]
        DataTable filtrarEstado(char cIdEstado, string sEstado);
        [OperationContract]
        char insertarEstado(char cIdEstado, string sEstado);
        [OperationContract]
        bool actualizarEstado(char cIdEstado, string sEstado);
        [OperationContract]
        bool eliminarEstado(char cIdEstado);
        #endregion
        #region Facturacion
        DataTable listarFacturacion();
        [OperationContract]
        DataTable filtrarFacturacion(short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal);
        #endregion
        #region FacturaDetalle
        [OperationContract]
        DataTable listarFacturaDetalle();
        [OperationContract]
        DataTable filtrarFacturaDetalle(int iIdFacturaDetalle, int iIdFactura, string sDetalle, float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal);
        #endregion
    }
}
