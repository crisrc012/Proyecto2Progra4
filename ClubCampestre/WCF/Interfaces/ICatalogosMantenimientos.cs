using ClubCampestre_DAL.CatalogosMantenimientos;
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
        DataTable filtrarBeneficiarios(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL);
        [OperationContract]
        short insertarBeneficiarios(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL);
        [OperationContract]
        bool actualizarBeneficiarios(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL);
        [OperationContract]
        bool eliminarBeneficiarios(short SIdBeneficiario);
        #endregion
        #region Clientes
        [OperationContract]
        DataTable listarClientes();
        [OperationContract]
        DataTable filtrarClientes(ref Cls_Clientes_DAL Obj_Clientes_DAL);
        [OperationContract]
        short insertarClientes(ref Cls_Clientes_DAL Obj_Clientes_DAL);
        [OperationContract]
        bool actualizarClientes(ref Cls_Clientes_DAL Obj_Clientes_DAL);
        [OperationContract]
        bool eliminarClientes(short SIdCliente);
        #endregion
        #region Correos
        [OperationContract]
        DataTable listarCorreos();
        [OperationContract]
        DataTable filtrarCorreos(ref Cls_Correos_DAL Obj_Correos_DAL);
        [OperationContract]
        string insertarCorreos(ref Cls_Correos_DAL Obj_Correos_DAL);
        [OperationContract]
        bool actualizarCorreos(ref Cls_Correos_DAL Obj_Correos_DAL);
        [OperationContract]
        bool eliminarCorreos(string sCorreo);
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
        DataTable filtrarFacturacion(ref Cls_Facturacion_DAL Obj_Facturacion_DAL);
        [OperationContract]
        int insertarFacturacion(ref Cls_Facturacion_DAL Obj_Facturacion_DAL);
        [OperationContract]
        bool actualizarFacturacion(ref Cls_Facturacion_DAL Obj_Facturacion_DAL);
        [OperationContract]
        bool eliminarFacturacion(int iIdFactura);
        #endregion
        #region FacturaDetalle
        [OperationContract]
        DataTable listarFacturaDetalle();
        [OperationContract]
        DataTable filtrarFacturaDetalle(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL);
        [OperationContract]
        int insertarFacturaDetalle(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL);
        [OperationContract]
        bool actualizarFacturaDetalle(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL);
        [OperationContract]
        bool eliminarFacturaDetalle(int iIdFacturaDetalle);
        #endregion
    }
}
