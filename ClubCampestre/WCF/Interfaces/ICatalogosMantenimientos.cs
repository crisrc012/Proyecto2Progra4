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
        string insertarCorreos(string sIdPersona, string sCorreo, ref string sMsjError);
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
        DataTable listarFacturacion(ref string sMsjError);
        [OperationContract]
        DataTable filtrarFacturacion(int iIdFactura, short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal, ref string sMsjError);
        [OperationContract]
        int insertarFacturacion(int iIdFactura, short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal, ref string sMsjError);
        [OperationContract]
        bool actualizarFacturacion(int iIdFactura, short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal, ref string sMsjError);
        [OperationContract]
        bool eliminarFacturacion(int iIdFactura, ref string sMsjError);
        #endregion
        #region FacturaDetalle
        [OperationContract]
        DataTable listarFacturaDetalle(ref string sMsjError);
        [OperationContract]
        DataTable filtrarFacturaDetalle(int iIdFacturaDetalle, int iIdFactura, string sDetalle, float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal, ref string sMsjError);
        [OperationContract]
        int insertarFacturaDetalle(int iIdFacturaDetalle, int iIdFactura, string sDetalle, float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal, ref string sMsjError);
        [OperationContract]
        bool actualizarFacturaDetalle(int iIdFacturaDetalle, int iIdFactura, string sDetalle, float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal, ref string sMsjError);
        [OperationContract]
        bool eliminarFacturaDetalle(int iIdFacturaDetalle, ref string sMsjError);
        #endregion
        #region Persona
        [OperationContract]
        DataTable listarPersona(ref string sMsjError);
        [OperationContract]
        DataTable filtrarPersona(string sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError);
        [OperationContract]
        DataTable filtrarPersonaV(string sIdPersona, string sNombre, string sDireccion, string sRol, ref string sMsjError);
        [OperationContract]
        bool insertarPersona(string sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError);
        [OperationContract]
        bool actualizarPersona(string sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError);
        [OperationContract]
        bool eliminarPersona(string sIdPersona, ref string sMsjError);
        #endregion
        #region TipoServicio
        [OperationContract]
        DataTable listarTipoServicio(ref string sMsj_error);
        [OperationContract]
        DataTable filtrarTipoServicio(byte IdTipoServicio, string Descripcion, float Costo, ref string sMsj_error);
        [OperationContract]
        byte insertarTipoServicio(string Descripcion, float Costo, ref string sMsj_error);
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
        byte insertarTipoMembresia( string Descripcion, float Costo, ref string sMsj_error);
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
        String  insertarTipoCliente(byte IdTipoCliente, string Descripcion, ref string sMsj_error);
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
        bool insertarUsuario(string IdUsuario, string IdPersona, string Contrasena, ref string sMsj_error);
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
        bool insertarTelefonos(string Telefono, string IdPersona, ref string sMsj_error);
        [OperationContract]
        bool actualizarTelefonos(string Telefono, string IdPersona, ref string sMsj_error);
        [OperationContract]
        bool eliminarTelefonos(string Telefono, ref string sMsj_error);
        #endregion
        #region Roles
        [OperationContract]
        DataTable listarRol(ref string sMsj_error);
        [OperationContract]
        DataTable filtrarRol(byte bIdRol, string sDescripcion, ref string sMsj_error);
        [OperationContract]
        string  insertarRol(string sDescripcion, ref string sMsj_error);
        [OperationContract]
        bool actualizarRol(byte bIdRol, string sDescripcion, ref string sMsj_error);
        [OperationContract]
        bool eliminarRol(byte bIdRol, ref string sMsj_error);
        #endregion
        #region Membresias
        [OperationContract]
        DataTable listarMemebresias(ref string sMsj_error);
        [OperationContract]
        DataTable filtrarMemebresias(int iIdMembresia, short sIdCliente, byte bIdTipoMembresia, ref string sMsj_error);
        [OperationContract]
        int insertarMemebresias(short sIdCliente, byte bIdTipoMembresia, char cIdEstado, DateTime dFechaInicio, DateTime dFechaVence, ref string sMsj_error);
        [OperationContract]
        bool actualizarMemebresias(int iIdMembresia, short sIdCliente, byte bIdTipoMembresia, char cIdEstado, DateTime dFechaInicio, DateTime dFechaVence, ref string sMsj_error);
        [OperationContract]
        bool eliminarMemebresias(int iIdMembresia, ref string sMsj_error);
        #endregion
        #region Servicio
        [OperationContract]
        DataTable listarServicio(ref string sMsj_error);
        [OperationContract]
        DataTable filtrarServicio(short iIdServicio, short iIdCliente, char cIdEstado, byte bIdTipoServicio, ref string sMsj_error);
        [OperationContract]
        short insertarServicio(short iIdCliente, char cIdEstado, byte bIdTipoServicio, ref string sMsj_error);
        [OperationContract]
        bool actualizarServicio(short iIdServicio, short iIdCliente, char cIdEstado, byte bIdTipoServicio, ref string sMsj_error);
        [OperationContract]
        bool eliminarServicio(short iIdServicio, ref string sMsj_error);
        #endregion
    }
}
