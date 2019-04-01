using System;
using System.Data;
using System.ServiceModel;
using ClubCampestre_DAL.CatalogosMantenimientos;

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
        DataTable filtrarClientes(ref Cls_Clientes_DAL Obj_Clientes_DAL);
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
        DataTable filtrarEstado(ref Cls_Estado_DAL Obj_Estado_DAL);
        [OperationContract]
        char insertarEstado(ref Cls_Estado_DAL Obj_Estado_DAL);
        [OperationContract]
        bool actualizarEstado(ref Cls_Estado_DAL Obj_Estado_DAL);
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
