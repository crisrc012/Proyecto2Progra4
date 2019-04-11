﻿using System.Data;
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
        #region Persona
        [OperationContract]
        DataTable listarPersona(ref string sMsjError);
        [OperationContract]
        DataTable filtrarPersona(short sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError);
        [OperationContract]
        short insertarPersona(short sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError);
        [OperationContract]
        bool actualizarPersona(short sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError);
        [OperationContract]
        bool eliminarPersona(short sIdPersona, ref string sMsjError);
        #endregion
        #region TipoServicio
        [OperationContract]
        DataTable listarTipoServicio(ref string sMsj_error);
        [OperationContract]
        DataTable filtrarTipoServicio(byte IdTipoServicio, string Descripcion, float Costo, ref string sMsj_error);
        [OperationContract]
        char insertarTipoServicio(byte IdTipoServicio, string Descripcion, float Costo, ref string sMsj_error);
        [OperationContract]
        bool actualizarTipoServicio(byte IdTipoServicio, string Descripcion, float Costo, ref string sMsj_error);
        [OperationContract]
        bool eliminarTipoServicio(byte IdTipoServicio, ref string sMsj_error);
        #endregion
        #region TipoMembresia
        [OperationContract]
        DataTable listarTipoMembresia(ref string sMsj_error);
        [OperationContract]
        DataTable filtrarTipoMembresia(byte IdTipoMembresia, string Descripcion, float Costo, ref string sMsj_error);
        [OperationContract]
        char insertarTipoMembresia(byte IdTipoMembresia, string Descripcion, float Costo, ref string sMsj_error);
        [OperationContract]
        bool actualizarTipoMembresia(byte IdTipoMembresia, string Descripcion, float Costo, ref string sMsj_error);
        [OperationContract]
        bool eliminarTipoMembresia(byte IdTipoMembresia, ref string sMsj_error);
        #endregion
        #region TipoCliente
        [OperationContract]
        DataTable listarTipoCliente(ref string sMsj_error);
        [OperationContract]
        DataTable filtrarTipoCliente(byte IdTipoCliente, string Descripcion, ref string sMsj_error);
        [OperationContract]
        char insertarTipoCliente(byte IdTipoCliente, string Descripcion, ref string sMsj_error);
        [OperationContract]
        bool actualizarTipoCliente(byte IdTipoCliente, string Descripcion, ref string sMsj_error);
        [OperationContract]
        bool eliminarTipoCliente(byte IdTipoCliente, ref string sMsj_error);
        #endregion
        #region Usuario
        [OperationContract]
        DataTable listarUsuario(ref string sMsj_error);
        [OperationContract]
        DataTable filtrarUsuario(string IdUsuario, string IdPersona, string Contrasena, ref string sMsj_error);
        [OperationContract]
        char insertarUsuario(string IdUsuario, string IdPersona, string Contrasena, ref string sMsj_error);
        [OperationContract]
        bool actualizarUsuario(string IdUsuario, string IdPersona, string Contrasena, ref string sMsj_error);
        [OperationContract]
        bool eliminarUsuario(string IdUsuario, ref string sMsj_error);
        #endregion
        #region Telefonos
        [OperationContract]
        DataTable listarTelefonos(ref string sMsj_error);
        [OperationContract]
        DataTable filtrarTelefonos(string Telefono, string IdPersona, ref string sMsj_error);
        [OperationContract]
        char insertarTelefonos(string Telefono, string IdPersona, ref string sMsj_error);
        [OperationContract]
        bool actualizarTelefonos(string Telefono, string IdPersona, ref string sMsj_error);
        [OperationContract]
        bool eliminarTelefonos(string Telefono, ref string sMsj_error);
        #endregion
    }
}
