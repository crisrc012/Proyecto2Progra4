using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System.Data;

namespace WCF.Contracts
{
    public class CatalogosMantenimientos : Interfaces.ICatalogosMantenimientos
    {
        #region Beneficiarios
        public DataTable listarBeneficiarios()
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL = new Cls_Beneficiarios_DAL();
            Obj_Beneficiarios_BLL.Listar(ref Obj_Beneficiarios_DAL);
            return Obj_Beneficiarios_DAL.DS.Tables[0];
        }
        public DataTable filtrarBeneficiarios(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            Obj_Beneficiarios_BLL.Filtrar(ref Obj_Beneficiarios_DAL);
            return Obj_Beneficiarios_DAL.DS.Tables[0];
        }
        public short insertarBeneficiarios(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            Obj_Beneficiarios_BLL.Insertar(ref Obj_Beneficiarios_DAL);
            return Obj_Beneficiarios_DAL.SIdBeneficiario;
        }
        public bool actualizarBeneficiarios(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            Obj_Beneficiarios_BLL.Actualizar(ref Obj_Beneficiarios_DAL);
            return Obj_Beneficiarios_DAL.SMsjError == string.Empty ? true : false;
        }
        public bool eliminarBeneficiarios(short SIdBeneficiario)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL = new Cls_Beneficiarios_DAL();
            // Se asignan datos a eliminar
            Obj_Beneficiarios_DAL.SIdBeneficiario = SIdBeneficiario;
            Obj_Beneficiarios_BLL.Eliminar(ref Obj_Beneficiarios_DAL);
            return Obj_Beneficiarios_DAL.SMsjError == string.Empty ? true : false;
        }
        #endregion
        #region Clientes
        public DataTable listarClientes()
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            Cls_Clientes_DAL Obj_Clientes_DAL = new Cls_Clientes_DAL();
            Obj_Clientes_BLL.Listar(ref Obj_Clientes_DAL);
            return Obj_Clientes_DAL.DS.Tables[0];
        }
        public DataTable filtrarClientes(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            Obj_Clientes_BLL.Filtrar(ref Obj_Clientes_DAL);
            return Obj_Clientes_DAL.DS.Tables[0];
        }
        public short insertarClientes(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            Obj_Clientes_BLL.Insertar(ref Obj_Clientes_DAL);
            return Obj_Clientes_DAL.SIdCliente;
        }
        public bool actualizarClientes(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            Obj_Clientes_BLL.Actualizar(ref Obj_Clientes_DAL);
            return Obj_Clientes_DAL.SMsjError == string.Empty ? true : false;
        }
        public bool eliminarClientes(short SIdCliente)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            Cls_Clientes_DAL Obj_Clientes_DAL = new Cls_Clientes_DAL();
            // Se asignan datos a eliminar
            Obj_Clientes_DAL.SIdCliente = SIdCliente;
            Obj_Clientes_BLL.Filtrar(ref Obj_Clientes_DAL);
            return Obj_Clientes_DAL.SMsjError == string.Empty ? true : false;
        }
        #endregion
        #region Correos
        public DataTable listarCorreos()
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            Cls_Correos_DAL Obj_Correos_DAL = new Cls_Correos_DAL();
            Obj_Correos_BLL.Listar(ref Obj_Correos_DAL);
            return Obj_Correos_DAL.DS.Tables[0];
        }
        public DataTable filtrarCorreos(ref Cls_Correos_DAL Obj_Correos_DAL)
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            Obj_Correos_BLL.Filtrar(ref Obj_Correos_DAL);
            return Obj_Correos_DAL.DS.Tables[0];
        }
        public string insertarCorreos(ref Cls_Correos_DAL Obj_Correos_DAL)
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            Obj_Correos_BLL.Insertar(ref Obj_Correos_DAL);
            return Obj_Correos_DAL.SCorreo;
        }
        public bool actualizarCorreos(ref Cls_Correos_DAL Obj_Correos_DAL)
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            Obj_Correos_BLL.Actualizar(ref Obj_Correos_DAL);
            return Obj_Correos_DAL.SMsjError == string.Empty ? true : false;
        }
        public bool eliminarCorreos(string sCorreo)
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            Cls_Correos_DAL Obj_Correos_DAL = new Cls_Correos_DAL();
            // Se asignan datos a eliminar
            Obj_Correos_DAL.SCorreo = sCorreo;
            Obj_Correos_BLL.Eliminar(ref Obj_Correos_DAL);
            return Obj_Correos_DAL.SMsjError == string.Empty ? true : false;
        }
        #endregion
        #region Estado
        public DataTable listarEstado()
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Cls_Estado_DAL Obj_Estado_DAL = new Cls_Estado_DAL();
            Obj_Estado_BLL.Listar(ref Obj_Estado_DAL);
            return Obj_Estado_DAL.DS.Tables[0];
        }
        public DataTable filtrarEstado(ref Cls_Estado_DAL Obj_Estado_DAL)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Obj_Estado_BLL.Filtrar(ref Obj_Estado_DAL);
            return Obj_Estado_DAL.DS.Tables[0];
        }
        public char insertarEstado(ref Cls_Estado_DAL Obj_Estado_DAL)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Obj_Estado_BLL.Insertar(ref Obj_Estado_DAL);
            return Obj_Estado_DAL.CIdEstado;
        }
        public bool actualizarEstado(ref Cls_Estado_DAL Obj_Estado_DAL)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Obj_Estado_BLL.Actualizar(ref Obj_Estado_DAL);
            return Obj_Estado_DAL.SMsjError == string.Empty ? true : false;
        }
        public bool eliminarEstado(char cIdEstado)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Cls_Estado_DAL Obj_Estado_DAL = new Cls_Estado_DAL();
            // Se asignan datos a eliminar
            Obj_Estado_DAL.CIdEstado = cIdEstado;
            Obj_Estado_BLL.Eliminar(ref Obj_Estado_DAL);
            return Obj_Estado_DAL.SMsjError == string.Empty ? true : false;
        }
        #endregion
        #region Facturacion
        public DataTable listarFacturacion()
        {
            Cls_Facturacion_BLL Obj_Facturacion_BLL = new Cls_Facturacion_BLL();
            Cls_Facturacion_DAL Obj_Facturacion_DAL = new Cls_Facturacion_DAL();
            Obj_Facturacion_BLL.Listar(ref Obj_Facturacion_DAL);
            return Obj_Facturacion_DAL.DS.Tables[0];
        }
        public DataTable filtrarFacturacion(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            Cls_Facturacion_BLL Obj_Facturacion_BLL = new Cls_Facturacion_BLL();
            Obj_Facturacion_BLL.Filtrar(ref Obj_Facturacion_DAL);
            return Obj_Facturacion_DAL.DS.Tables[0];
        }
        public int insertarFacturacion(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            Cls_Facturacion_BLL Obj_Facturacion_BLL = new Cls_Facturacion_BLL();
            Obj_Facturacion_BLL.Insertar(ref Obj_Facturacion_DAL);
            return Obj_Facturacion_DAL.IIdFactura;
        }
        public bool actualizarFacturacion(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            Cls_Facturacion_BLL Obj_Facturacion_BLL = new Cls_Facturacion_BLL();
            Obj_Facturacion_BLL.Actualizar(ref Obj_Facturacion_DAL);
            return Obj_Facturacion_DAL.SMsjError == string.Empty ? true : false;
        }
        public bool eliminarFacturacion(int iIdFactura)
        {
            Cls_Facturacion_BLL Obj_Facturacion_BLL = new Cls_Facturacion_BLL();
            Cls_Facturacion_DAL Obj_Facturacion_DAL = new Cls_Facturacion_DAL();
            // Se asignan datos a buscar
            Obj_Facturacion_DAL.IIdFactura = iIdFactura;
            Obj_Facturacion_BLL.Eliminar(ref Obj_Facturacion_DAL);
            return Obj_Facturacion_DAL.SMsjError == string.Empty ? true : false;
        }
        #endregion
        #region FacturaDetalle
        public DataTable listarFacturaDetalle()
        {
            Cls_FacturaDetalle_BLL Obj_FacturaDetalle_BLL = new Cls_FacturaDetalle_BLL();
            Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL = new Cls_FacturaDetalle_DAL();
            Obj_FacturaDetalle_BLL.Listar(ref Obj_FacturaDetalle_DAL);
            return Obj_FacturaDetalle_DAL.DS.Tables[0];
        }
        public DataTable filtrarFacturaDetalle(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL)
        {
            Cls_FacturaDetalle_BLL Obj_FacturaDetalle_BLL = new Cls_FacturaDetalle_BLL();
            Obj_FacturaDetalle_BLL.Filtrar(ref Obj_FacturaDetalle_DAL);
            return Obj_FacturaDetalle_DAL.DS.Tables[0];
        }
        public int insertarFacturaDetalle(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL)
        {
            Cls_FacturaDetalle_BLL Obj_FacturaDetalle_BLL = new Cls_FacturaDetalle_BLL();
            Obj_FacturaDetalle_BLL.Insertar(ref Obj_FacturaDetalle_DAL);
            return Obj_FacturaDetalle_DAL.IIdFacturaDetalle;
        }
        public bool actualizarFacturaDetalle(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL)
        {
            Cls_FacturaDetalle_BLL Obj_FacturaDetalle_BLL = new Cls_FacturaDetalle_BLL();
            Obj_FacturaDetalle_BLL.Actualizar(ref Obj_FacturaDetalle_DAL);
            return Obj_FacturaDetalle_DAL.SMsjError == string.Empty ? true : false;
        }
        public bool eliminarFacturaDetalle(int iIdFacturaDetalle)
        {
            Cls_FacturaDetalle_BLL Obj_FacturaDetalle_BLL = new Cls_FacturaDetalle_BLL();
            Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL = new Cls_FacturaDetalle_DAL();
            // Se asignan datos a buscar
            Obj_FacturaDetalle_DAL.IIdFacturaDetalle = iIdFacturaDetalle;
            Obj_FacturaDetalle_BLL.Eliminar(ref Obj_FacturaDetalle_DAL);
            return Obj_FacturaDetalle_DAL.SMsjError == string.Empty ? true : false;
        }
        #endregion
        #region TipoServicio
        public DataTable listarTipoServicio()
        {
            Cls_TipoServicio_BLL Obj_TipoServicio_BLL = new Cls_TipoServicio_BLL();
            Cls_TipoServicio_DAL Obj_TipoServicio_DAL = new Cls_TipoServicio_DAL();
            Obj_TipoServicio_BLL.Listar(ref Obj_TipoServicio_DAL);
            return Obj_TipoServicio_DAL.DS.Tables[0];
        }
        #endregion
        #region TipoMembresia
        public DataTable listarTipoMembresia()
        {
            Cls_TipoMembresia_BLL Obj_TipoMembresia_BLL = new Cls_TipoMembresia_BLL();
            Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL = new Cls_TipoMembresia_DAL();
            Obj_TipoMembresia_BLL.Listar(ref Obj_TipoMembresia_DAL);
            return Obj_TipoMembresia_DAL.DS.Tables[0];
        }
        #endregion
        #region TipoCliente
        public DataTable listarTipoCliente()
        {
            Cls_TipoCliente_BLL Obj_TipoCliente_BLL = new Cls_TipoCliente_BLL();
            Cls_TipoCliente_DAL Obj_TipoCliente_DAL = new Cls_TipoCliente_DAL();
            Obj_TipoCliente_BLL.Listar(ref Obj_TipoCliente_DAL);
            return Obj_TipoCliente_DAL.DS.Tables[0];
        }
        #endregion
        #region Usuario
        public DataTable listarUsuarios()
        {
            Cls_Usuarios_BLL Obj_Usuarios_BLL = new Cls_Usuarios_BLL();
            Cls_Usuarios_DAL Obj_Usuarios_DAL = new Cls_Usuarios_DAL();
            Obj_Usuarios_BLL.Listar(ref Obj_Usuarios_DAL);
            return Obj_Usuarios_DAL.DS.Tables[0];
        }
        #endregion
        #region Telefonos
        public DataTable listarTelefonos()
        {
            Cls_Telefonos_BLL Obj_Telefonos_BLL = new Cls_Telefonos_BLL();
            Cls_Telefonos_DAL Obj_Telefonos_DAL = new Cls_Telefonos_DAL();
            Obj_Telefonos_BLL.Listar(ref Obj_Telefonos_DAL);
            return Obj_Telefonos_DAL.DS.Tables[0];
        }
        #endregion
        
    }
}
