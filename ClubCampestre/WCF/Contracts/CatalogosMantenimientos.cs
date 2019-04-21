using ClubCampestre_BLL.CatalogosMantenimientos;
using System;
using System.Data;

namespace WCF.Contracts
{
    public class CatalogosMantenimientos : Interfaces.ICatalogosMantenimientos
    {
        #region Beneficiarios
        public DataTable listarBeneficiarios(ref string sMsjError)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            return Obj_Beneficiarios_BLL.Listar(ref sMsjError);
        }
        public DataTable filtrarBeneficiarios(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsjError)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            return Obj_Beneficiarios_BLL.Filtrar(sIdBeneficiario, sIdCliente, sIdPersona, cIdEstado, ref sMsjError);
        }
        public short insertarBeneficiarios(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsjError)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            return Obj_Beneficiarios_BLL.Insertar(sIdBeneficiario, sIdCliente, sIdPersona, cIdEstado, ref sMsjError);
        }
        public bool actualizarBeneficiarios(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsjError)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            return Obj_Beneficiarios_BLL.Actualizar(sIdBeneficiario, sIdCliente, sIdPersona, cIdEstado, ref sMsjError);
        }
        public bool eliminarBeneficiarios(short sIdCliente, ref string sMsjError)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            return Obj_Beneficiarios_BLL.Eliminar(sIdCliente, ref sMsjError);
        }
        #endregion
        #region Clientes
        public DataTable listarClientes(ref string sMsjError)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            return Obj_Clientes_BLL.Listar(ref sMsjError);
        }
        public DataTable filtrarClientes(short sIdCliente, byte bIdTipoCliente, string sIdPersona, ref string sMsjError)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            return Obj_Clientes_BLL.Filtrar(sIdCliente, bIdTipoCliente, sIdPersona, ref sMsjError);
        }
        public DataTable filtrarClientesV(short sIdCliente, string sTipoCliente, string sIdPersona, string sNombre, string sDireccion, string sRol, ref string sMsjError)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            return Obj_Clientes_BLL.Filtrar(sIdCliente, sTipoCliente, sIdPersona, sNombre, sDireccion, sRol, ref sMsjError);
        }
        public short insertarClientes(byte bIdTipoCliente, string sIdPersona, ref string sMsjError)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            return Obj_Clientes_BLL.Insertar(bIdTipoCliente, sIdPersona, ref sMsjError);
        }
        public bool actualizarClientes(short sIdCliente, byte bIdTipoCliente, string sIdPersona, ref string sMsjError)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            return Obj_Clientes_BLL.Actualizar(sIdCliente, bIdTipoCliente, sIdPersona, ref sMsjError);
        }
        public bool eliminarClientes(short sIdCliente, ref string sMsjError)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            return Obj_Clientes_BLL.Eliminar(sIdCliente, ref sMsjError);
        }
        #endregion
        #region Correos
        public DataTable listarCorreos(ref string sMsjError)
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            return Obj_Correos_BLL.Listar(ref sMsjError);
        }
        public DataTable filtrarCorreos(short sIdCorreo, string sIdPersona, string sCorreo, ref string sMsjError)
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            return Obj_Correos_BLL.Filtrar(sIdCorreo, sIdPersona, sCorreo, ref sMsjError);
        }
        public string insertarCorreos(string sIdPersona, string sCorreo, ref string sMsjError)
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            return Obj_Correos_BLL.Insertar(sIdPersona, sCorreo, ref sMsjError);
        }
        public bool actualizarCorreos(short sIdCorreo, string sIdPersona, string sCorreo, ref string sMsjError)
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            return Obj_Correos_BLL.Actualizar(sIdCorreo, sIdPersona, sCorreo, ref sMsjError);
        }
        public bool eliminarCorreos(short sIdCorreo, ref string sMsjError)
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            return Obj_Correos_BLL.Eliminar(sIdCorreo, ref sMsjError);
        }
        #endregion
        #region Estado
        public DataTable listarEstado(ref string sMsj_error)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            return Obj_Estado_BLL.Listar(ref sMsj_error);
        }
        public DataTable filtrarEstado(char cIdEstado, string sEstado, ref string sMsj_error)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            return Obj_Estado_BLL.Filtrar(cIdEstado, sEstado, ref sMsj_error);
        }
        public bool insertarEstado(char cIdEstado, string sEstado, ref string sMsj_error)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            return Obj_Estado_BLL.Insertar(cIdEstado, sEstado, ref sMsj_error);
        }
        public bool actualizarEstado(char cIdEstado, string sEstado, ref string sMsj_error)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            return Obj_Estado_BLL.Actualizar(cIdEstado, sEstado, ref sMsj_error);
        }
        public bool eliminarEstado(char cIdEstado, ref string sMsj_error)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            return Obj_Estado_BLL.Eliminar(cIdEstado, ref sMsj_error);
        }
        #endregion
        #region Facturacion
        public DataTable listarFacturacion(ref string sMsjError)
        {
            Cls_Facturacion_BLL Obj_Facturacion_BLL = new Cls_Facturacion_BLL();
            return Obj_Facturacion_BLL.Listar(ref sMsjError);
        }
        public DataTable filtrarFacturacion(int iIdFactura, short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal, ref string sMsjError)
        {
            Cls_Facturacion_BLL Obj_Facturacion_BLL = new Cls_Facturacion_BLL();
            return Obj_Facturacion_BLL.Filtrar(iIdFactura, sIdCliente, sDescripcion, DFecha, fMontototal, ref sMsjError);
        }
        public int insertarFacturacion(int iIdFactura, short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal, ref string sMsjError)
        {
            Cls_Facturacion_BLL Obj_Facturacion_BLL = new Cls_Facturacion_BLL();
            return Obj_Facturacion_BLL.Insertar(iIdFactura, sIdCliente, sDescripcion, DFecha, fMontototal, ref sMsjError);
        }
        public bool actualizarFacturacion(int iIdFactura, short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal, ref string sMsjError)
        {
            Cls_Facturacion_BLL Obj_Facturacion_BLL = new Cls_Facturacion_BLL();
            return Obj_Facturacion_BLL.Actualizar(iIdFactura, sIdCliente, sDescripcion, DFecha, fMontototal, ref sMsjError);
        }
        public bool eliminarFacturacion(int iIdFactura, ref string sMsjError)
        {
            Cls_Facturacion_BLL Obj_Facturacion_BLL = new Cls_Facturacion_BLL();
            return Obj_Facturacion_BLL.Eliminar(iIdFactura, ref sMsjError);
        }
        #endregion
        #region FacturaDetalle
        public DataTable listarFacturaDetalle(ref string sMsjError)
        {
            Cls_FacturaDetalle_BLL Obj_Factura_Detalle = new Cls_FacturaDetalle_BLL();
            return Obj_Factura_Detalle.Listar(ref sMsjError);
        }
        public DataTable filtrarFacturaDetalle(int iIdFacturaDetalle, int iIdFactura, string sDetalle, float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal, ref string sMsjError)
        {
            Cls_FacturaDetalle_BLL Obj_Factura_Detalle = new Cls_FacturaDetalle_BLL();
            return Obj_Factura_Detalle.Filtrar(iIdFacturaDetalle, iIdFactura, sDetalle, fcosto, bIdTipoServicio, iIdMembresia, icantidad, ftotal, ref sMsjError);
        }
        public int insertarFacturaDetalle(int iIdFacturaDetalle, int iIdFactura, string sDetalle, float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal, ref string sMsjError)
        {
            Cls_FacturaDetalle_BLL Obj_Factura_Detalle = new Cls_FacturaDetalle_BLL();
            return Obj_Factura_Detalle.Insertar(iIdFacturaDetalle, iIdFactura, sDetalle, fcosto, bIdTipoServicio, iIdMembresia, icantidad, ftotal, ref sMsjError);
        }
        public bool actualizarFacturaDetalle(int iIdFacturaDetalle, int iIdFactura, string sDetalle, float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal, ref string sMsjError)
        {
            Cls_FacturaDetalle_BLL Obj_Factura_Detalle = new Cls_FacturaDetalle_BLL();
            return Obj_Factura_Detalle.Actualizar(iIdFacturaDetalle, iIdFactura, sDetalle, fcosto, bIdTipoServicio, iIdMembresia, icantidad, ftotal, ref sMsjError);
        }
        public bool eliminarFacturaDetalle(int iIdFacturaDetalle, ref string sMsjError)
        {
            Cls_FacturaDetalle_BLL Obj_Factura_Detalle = new Cls_FacturaDetalle_BLL();
            return Obj_Factura_Detalle.Eliminar(iIdFacturaDetalle, ref sMsjError);
        }
        #endregion
        #region Persona
        public DataTable listarPersona(ref string sMsjError)
        {
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            return Obj_Persona_BLL.Listar(ref sMsjError);
        }
        public DataTable filtrarPersona(string sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError)
        {
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            return Obj_Persona_BLL.Filtrar(sIdPersona, sNombre, sDireccion, sIdRol, ref sMsjError);
        }
        public DataTable filtrarPersonaV(string sIdPersona, string sNombre, string sDireccion, string sRol, ref string sMsjError)
        {
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            return Obj_Persona_BLL.Filtrar(sIdPersona, sNombre, sDireccion, sRol, ref sMsjError);
        }
        public bool insertarPersona(string sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError)
        {
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            return Obj_Persona_BLL.Insertar(sIdPersona, sNombre, sDireccion, sIdRol, ref sMsjError);
        }
        public bool actualizarPersona(string sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError)
        {
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            return Obj_Persona_BLL.Actualizar(sIdPersona, sNombre, sDireccion, sIdRol, ref sMsjError);
        }
        public bool eliminarPersona(string sIdPersona, ref string sMsjError)
        {
            Cls_Persona_BLL Obj_Persona_BLL = new Cls_Persona_BLL();
            return Obj_Persona_BLL.Eliminar(sIdPersona, ref sMsjError);
        }

        #endregion
        #region TipoServicio

        public DataTable listarTipoServicio(ref string sMsj_error)
        {
            Cls_TipoServicio_BLL Obj_TipoServicio_BLL = new Cls_TipoServicio_BLL();
            return Obj_TipoServicio_BLL.Listar(ref sMsj_error);
        }
        public DataTable filtrarTipoServicio(byte IdTipoServicio, string Descripcion, float Costo, ref string sMsj_error)
        {
            Cls_TipoServicio_BLL Obj_TipoServicio_BLL = new Cls_TipoServicio_BLL();
            return Obj_TipoServicio_BLL.Filtrar(IdTipoServicio, Descripcion,Costo, ref sMsj_error);
        }
        public byte insertarTipoServicio(string Descripcion, float Costo, ref string sMsj_error)
        {
            Cls_TipoServicio_BLL Obj_TipoServicio_BLL = new Cls_TipoServicio_BLL();
            return Obj_TipoServicio_BLL.Insertar(Descripcion, Costo, ref sMsj_error);
        }
        public bool actualizarTipoServicio(byte IdTipoServicio, string Descripcion, float Costo, ref string sMsj_error)
        {
            Cls_TipoServicio_BLL Obj_TipoServicio_BLL = new Cls_TipoServicio_BLL();
            return Obj_TipoServicio_BLL.Actualizar(IdTipoServicio, Descripcion, Costo, ref sMsj_error);
        }
        public bool eliminarTipoServicio(byte IdTipoServicio, ref string sMsj_error)
        {
            Cls_TipoServicio_BLL Obj_TipoServicio_BLL = new Cls_TipoServicio_BLL();
            return Obj_TipoServicio_BLL.Eliminar(IdTipoServicio, ref sMsj_error);
        }
        #endregion
        #region TipoMembresia
        public DataTable listarTipoMembresia(ref string sMsj_error)
        {
            Cls_TipoMembresia_BLL Obj_TipoMebresia_BLL = new Cls_TipoMembresia_BLL();
            return Obj_TipoMebresia_BLL.Listar(ref sMsj_error);
        }
        public DataTable filtrarTipoMembresia(byte IdTipoMembresia, string Descripcion, float Costo, ref string sMsj_error)
        {
            Cls_TipoMembresia_BLL Obj_TipoMebresia_BLL = new Cls_TipoMembresia_BLL();
            return Obj_TipoMebresia_BLL.Filtrar(IdTipoMembresia, Descripcion, Costo, ref sMsj_error);
        }
        public byte insertarTipoMembresia(string Descripcion, float Costo, ref string sMsj_error)
        {
            Cls_TipoMembresia_BLL Obj_TipoMebresia_BLL = new Cls_TipoMembresia_BLL();
            return Obj_TipoMebresia_BLL.Insertar( Descripcion, Costo, ref sMsj_error);
        }
        public bool actualizarTipoMembresia(byte IdTipoMembresia, string Descripcion, float Costo, ref string sMsj_error)
        {
            Cls_TipoMembresia_BLL Obj_TipoMebresia_BLL = new Cls_TipoMembresia_BLL();
            return Obj_TipoMebresia_BLL.Actualizar(IdTipoMembresia, Descripcion, Costo, ref sMsj_error);
        }
        public bool eliminarTipoMembresia(byte IdTipoMembresia, ref string sMsj_error)
        {
            Cls_TipoMembresia_BLL Obj_TipoMebresia_BLL = new Cls_TipoMembresia_BLL();
            return Obj_TipoMebresia_BLL.Eliminar(IdTipoMembresia, ref sMsj_error);
        }
        #endregion
        #region TipoCliente

        public DataTable listarTipoCliente(ref string sMsj_error)
        {
            Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();
            return Obj_TipoCliente_BLL.Listar(ref sMsj_error);
        }
        public DataTable filtrarTipoCliente(byte IdTipoCliente, string Descripcion, ref string sMsj_error)
        {
            Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();
            return Obj_TipoCliente_BLL.Filtrar(IdTipoCliente, Descripcion, ref sMsj_error);
        }
        public string  insertarTipoCliente(byte IdTipoCliente, string Descripcion, ref string sMsj_error)
        {
            Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();
            return Obj_TipoCliente_BLL.Insertar(IdTipoCliente, Descripcion, ref sMsj_error);
        }
        public bool actualizarTipoCliente(byte IdTipoCliente, string Descripcion, ref string sMsj_error)
        {
            Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();
            return Obj_TipoCliente_BLL.Actualizar(IdTipoCliente, Descripcion, ref sMsj_error);
        }
        public bool eliminarTipoCliente(byte IdTipoCliente, ref string sMsj_error)
        {
            Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();
            return Obj_TipoCliente_BLL.Eliminar(IdTipoCliente, ref sMsj_error);
        }
        #endregion
        #region Usuario

        public DataTable listarUsuario(ref string sMsj_error)
        {
            Cls_Usuarios_BLL Obj_Usuario_BLL = new Cls_Usuarios_BLL();
            return Obj_Usuario_BLL.Listar(ref sMsj_error);
        }
        public DataTable filtrarUsuario(string IdUsuario, string IdPersona, string Contrasena, ref string sMsj_error)
        {
            Cls_Usuarios_BLL Obj_Usuario_BLL = new Cls_Usuarios_BLL();
            return Obj_Usuario_BLL.Filtrar(IdUsuario, IdPersona, Contrasena, ref sMsj_error);
        }
        public bool insertarUsuario(string IdUsuario, string IdPersona, string Contrasena, ref string sMsj_error)
        {
            Cls_Usuarios_BLL Obj_Usuario_BLL = new Cls_Usuarios_BLL();
            return Obj_Usuario_BLL.Insertar(IdUsuario, IdPersona, Contrasena, ref sMsj_error);
        }
        public bool actualizarUsuario(string IdUsuario, string IdPersona, string Contrasena, ref string sMsj_error)
        {
            Cls_Usuarios_BLL Obj_Usuario_BLL = new Cls_Usuarios_BLL();
            return Obj_Usuario_BLL.Actualizar(IdUsuario, IdPersona, Contrasena, ref sMsj_error);
        }
        public bool eliminarUsuario(string IdUsuario, ref string sMsj_error)
        {
            Cls_Usuarios_BLL Obj_Usuario_BLL = new Cls_Usuarios_BLL();
            return Obj_Usuario_BLL.Eliminar(IdUsuario, ref sMsj_error);
        }
        #endregion
        #region Telefonos
        public DataTable listarTelefonos(ref string sMsj_error)
        {
            Cls_Telefonos_BLL Obj_Telefonos_BLL = new Cls_Telefonos_BLL();
            return Obj_Telefonos_BLL.Listar(ref sMsj_error);
        }
        public DataTable filtrarTelefonos(string Telefono, string IdPersona, ref string sMsj_error)
        {
            Cls_Telefonos_BLL Obj_Telefonos_BLL = new Cls_Telefonos_BLL();
            return Obj_Telefonos_BLL.Filtrar(Telefono, IdPersona, ref sMsj_error);
        }
        public bool insertarTelefonos(string Telefono, string IdPersona, ref string sMsj_error)
        {
            Cls_Telefonos_BLL Obj_Telefonos_BLL = new Cls_Telefonos_BLL();
            return Obj_Telefonos_BLL.Insertar(Telefono, IdPersona, ref sMsj_error);
        }
        public bool actualizarTelefonos(string Telefono, string IdPersona, ref string sMsj_error)
        {
            Cls_Telefonos_BLL Obj_Telefonos_BLL = new Cls_Telefonos_BLL();
            return Obj_Telefonos_BLL.Actualizar(Telefono, IdPersona, ref sMsj_error);
        }
        public bool eliminarTelefonos(string Telefono, ref string sMsj_error)
        {
            Cls_Telefonos_BLL Obj_Telefonos_BLL = new Cls_Telefonos_BLL();
            return Obj_Telefonos_BLL.Eliminar(Telefono, ref sMsj_error);
        }
        #endregion
        #region Membresias
        public DataTable listarMemebresias(ref string sMsj_error)
        {
            Cls_Membresias_BLL Obj_Memebresias_BLL = new Cls_Membresias_BLL();
            return Obj_Memebresias_BLL.Listar(ref sMsj_error);
        }
        public DataTable filtrarMemebresias(int iIdMembresia, short sIdCliente, byte bIdTipoMembresia, ref string sMsj_error)
        {
            Cls_Membresias_BLL Obj_Memebresias_BLL = new Cls_Membresias_BLL();
            return Obj_Memebresias_BLL.Filtrar(iIdMembresia, sIdCliente, bIdTipoMembresia, ref sMsj_error);
        }
        public int insertarMemebresias(short sIdCliente, byte bIdTipoMembresia, char cIdEstado, DateTime dFechaInicio, DateTime dFechaVence, ref string sMsj_error)
        {
            Cls_Membresias_BLL Obj_Memebresias_BLL = new Cls_Membresias_BLL();
            return Obj_Memebresias_BLL.Insertar(sIdCliente, bIdTipoMembresia, cIdEstado, dFechaInicio, dFechaVence, ref sMsj_error);
        }
        public bool actualizarMemebresias(int iIdMembresia, short sIdCliente, byte bIdTipoMembresia, char cIdEstado, DateTime dFechaInicio, DateTime dFechaVence, ref string sMsj_error)
        {
            Cls_Membresias_BLL Obj_Memebresias_BLL = new Cls_Membresias_BLL();
            return Obj_Memebresias_BLL.Actualizar(iIdMembresia, sIdCliente, bIdTipoMembresia, cIdEstado, dFechaInicio, dFechaVence, ref sMsj_error);
        }
        public bool eliminarMemebresias(int iIdMembresia, ref string sMsj_error)
        {
            Cls_Membresias_BLL Obj_Memebresias_BLL = new Cls_Membresias_BLL();
            return Obj_Memebresias_BLL.Eliminar(iIdMembresia, ref sMsj_error);
        }
        #endregion
        #region Rol
        public DataTable listarRol(ref string sMsj_error)
        {
            Cls_Roles_BLL Obj_Rol_BLL = new Cls_Roles_BLL();
            return Obj_Rol_BLL.Listar(ref sMsj_error);
        }
        public DataTable filtrarRol(byte bIdRol, string sDescripcion, ref string sMsj_error)
        {
            Cls_Roles_BLL Obj_Rol_BLL = new Cls_Roles_BLL();
            return Obj_Rol_BLL.Filtrar(bIdRol, sDescripcion, ref sMsj_error);
        }
        public string insertarRol(string sDescripcion, ref string sMsj_error)
        {
            Cls_Roles_BLL Obj_Rol_BLL = new Cls_Roles_BLL();
            return Obj_Rol_BLL.Insertar(sDescripcion, ref sMsj_error);
        }
        public bool actualizarRol(byte bIdRol, string sDescripcion, ref string sMsj_error)
        {
            Cls_Roles_BLL Obj_Rol_BLL = new Cls_Roles_BLL();
            return Obj_Rol_BLL.Actualizar(bIdRol, sDescripcion, ref sMsj_error);
        }
        public bool eliminarRol(byte bIdRol, ref string sMsj_error)
        {
            Cls_Roles_BLL Obj_Rol_BLL = new Cls_Roles_BLL();
            return Obj_Rol_BLL.Eliminar(bIdRol, ref sMsj_error);
        }
        #endregion
        #region Servicio
        public DataTable listarServicio(ref string sMsj_error)
        {
            Cls_Servicios_BLL Obj_Servicios_BLL = new Cls_Servicios_BLL();
            return Obj_Servicios_BLL.Listar(ref sMsj_error);
        }

        public DataTable filtrarServicio(short iIdServicio, short iIdCliente, char cIdEstado, byte bIdTipoServicio, ref string sMsj_error)
        {
            Cls_Servicios_BLL Obj_Servicios_BLL = new Cls_Servicios_BLL();
            return Obj_Servicios_BLL.Filtrar(iIdServicio, iIdCliente, cIdEstado, bIdTipoServicio, ref sMsj_error);
        }


        public short insertarServicio(short iIdCliente, char cIdEstado, byte bIdTipoServicio, ref string sMsj_error)
        {
            Cls_Servicios_BLL Obj_Servicios_BLL = new Cls_Servicios_BLL();
            return Obj_Servicios_BLL.Insertar(iIdCliente, cIdEstado, bIdTipoServicio, ref sMsj_error);
        }

        public bool actualizarServicio(short iIdServicio, short iIdCliente, char cIdEstado, byte bIdTipoServicio, ref string sMsj_error)
        {
            Cls_Servicios_BLL Obj_Servicios_BLL = new Cls_Servicios_BLL();
            return Obj_Servicios_BLL.Actualizar(iIdServicio, iIdCliente, cIdEstado, bIdTipoServicio, ref sMsj_error);
        }


        public bool eliminarServicio(short iIdServicio, ref string sMsj_error)
        {
            Cls_Servicios_BLL Obj_Servicios_BLL = new Cls_Servicios_BLL();
            return Obj_Servicios_BLL.Eliminar(iIdServicio, ref sMsj_error);
        }
        #endregion
        #region Devuelve_Datos_Ingreso
        public DataTable Cargar(string IdPersona,  ref string sMsj_error)
        {
            Cls_Ingresos_BLL Obj_Ingresos_BLL = new Cls_Ingresos_BLL();
            return Obj_Ingresos_BLL.Cargar(IdPersona, ref sMsj_error);
        }
        #endregion

        #region Invitado_Beneficiario
        public DataTable Invitado_Beneficiario(string IdPersona, ref string sMsj_error)
        {
            Cls_Ingresos_BLL Obj_Ingresos_BLL = new Cls_Ingresos_BLL();
            return Obj_Ingresos_BLL.Invitado_Beneciario(IdPersona, ref sMsj_error);
        }
        #endregion
    }
}
