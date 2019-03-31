using System.Data;
using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

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
        public DataTable filtrarBeneficiarios(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL = new Cls_Beneficiarios_DAL();
            // Se asignan datos a buscar
            Obj_Beneficiarios_DAL.SIdBeneficiario = sIdBeneficiario;
            Obj_Beneficiarios_DAL.SIdCliente = sIdCliente;
            Obj_Beneficiarios_DAL.SIdPersona = sIdPersona;
            Obj_Beneficiarios_DAL.CIdEstado = cIdEstado;
            Obj_Beneficiarios_BLL.Filtrar(ref Obj_Beneficiarios_DAL);
            return Obj_Beneficiarios_DAL.DS.Tables[0];
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
        public DataTable filtrarClientes(short sIdCliente, byte bIdTipoCliente, string sIdPersona)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            Cls_Clientes_DAL Obj_Clientes_DAL = new Cls_Clientes_DAL();
            // Se asignan datos a buscar
            Obj_Clientes_DAL.SIdCliente = sIdCliente;
            Obj_Clientes_DAL.BIdTipoCliente = bIdTipoCliente;
            Obj_Clientes_DAL.SIdPersona = sIdPersona;
            Obj_Clientes_BLL.Filtrar(ref Obj_Clientes_DAL);
            return Obj_Clientes_DAL.DS.Tables[0];
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
        public DataTable filtrarCorreos(short sIdCorreo, string sIdPersona, string sCorreo)
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            Cls_Correos_DAL Obj_Correos_DAL = new Cls_Correos_DAL();
            // Se asignan datos a buscar
            Obj_Correos_DAL.SIdCorreo = sIdCorreo;
            Obj_Correos_DAL.SIdPersona = sIdPersona;
            Obj_Correos_DAL.SCorreo = sCorreo;
            Obj_Correos_BLL.Filtrar(ref Obj_Correos_DAL);
            return Obj_Correos_DAL.DS.Tables[0];
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
        public DataTable filtrarEstado(char cIdEstado, string sEstado)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Cls_Estado_DAL Obj_Estado_DAL = new Cls_Estado_DAL();
            // Se asignan datos a buscar
            Obj_Estado_DAL.CIdEstado = cIdEstado;
            Obj_Estado_DAL.SEstado = sEstado;
            Obj_Estado_BLL.Filtrar(ref Obj_Estado_DAL);
            return Obj_Estado_DAL.DS.Tables[0];
        }
        public char insertarEstado(char cIdEstado, string sEstado)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Cls_Estado_DAL Obj_Estado_DAL = new Cls_Estado_DAL();
            // Se asignan datos a insertar
            Obj_Estado_DAL.CIdEstado = cIdEstado;
            Obj_Estado_DAL.SEstado = sEstado;
            Obj_Estado_BLL.Insertar(ref Obj_Estado_DAL);
            return Obj_Estado_DAL.CIdEstado;
        }
        public bool actualizarEstado(char cIdEstado, string sEstado)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Cls_Estado_DAL Obj_Estado_DAL = new Cls_Estado_DAL();
            // Se asignan datos a actualizar
            Obj_Estado_DAL.CIdEstado = cIdEstado;
            Obj_Estado_DAL.SEstado = sEstado;
            Obj_Estado_BLL.Actualizar(ref Obj_Estado_DAL);
            return Obj_Estado_DAL.SMsjError == string.Empty ? true : false;
        }
        public bool eliminarEstado(char cIdEstado)
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Cls_Estado_DAL Obj_Estado_DAL = new Cls_Estado_DAL();
            // Se asignan datos a actualizar
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
        public DataTable filtrarFacturacion(short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal)
        {
            Cls_Facturacion_BLL Obj_Facturacion_BLL = new Cls_Facturacion_BLL();
            Cls_Facturacion_DAL Obj_Facturacion_DAL = new Cls_Facturacion_DAL();
            // Se asignan datos a buscar
            Obj_Facturacion_DAL.SIdCliente = sIdCliente;
            Obj_Facturacion_DAL.SDescripcion = sDescripcion;
            Obj_Facturacion_DAL.DFecha = DFecha;
            Obj_Facturacion_DAL.FMontototal = fMontototal;
            Obj_Facturacion_BLL.Filtrar(ref Obj_Facturacion_DAL);
            return Obj_Facturacion_DAL.DS.Tables[0];
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
        public DataTable filtrarFacturaDetalle(int iIdFacturaDetalle, int iIdFactura, string sDetalle, 
            float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal)
        {
            Cls_FacturaDetalle_BLL Obj_FacturaDetalle_BLL = new Cls_FacturaDetalle_BLL();
            Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL = new Cls_FacturaDetalle_DAL();
            // Se asignan datos a buscar
            Obj_FacturaDetalle_DAL.IIdFacturaDetalle = iIdFacturaDetalle;
            Obj_FacturaDetalle_DAL.IIdFactura = iIdFactura;
            Obj_FacturaDetalle_DAL.SDetalle = sDetalle;
            Obj_FacturaDetalle_DAL.Fcosto = fcosto;
            Obj_FacturaDetalle_DAL.BIdTipoServicio = bIdTipoServicio;
            Obj_FacturaDetalle_DAL.IIdMembresia = iIdMembresia;
            Obj_FacturaDetalle_DAL.Icantidad = icantidad;
            Obj_FacturaDetalle_DAL.Ftotal = ftotal;
            Obj_FacturaDetalle_BLL.Filtrar(ref Obj_FacturaDetalle_DAL);
            return Obj_FacturaDetalle_DAL.DS.Tables[0];
        }
        #endregion
    }
}
