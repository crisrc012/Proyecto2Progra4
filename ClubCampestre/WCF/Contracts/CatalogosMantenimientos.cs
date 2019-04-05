using ClubCampestre_BLL.CatalogosMantenimientos;
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
        public bool eliminarBeneficiarios(short sIdBeneficiario, ref string sMsjError)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            return Obj_Beneficiarios_BLL.Eliminar(sIdBeneficiario, ref sMsjError);
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
        public short insertarClientes(short sIdCliente, byte bIdTipoCliente, string sIdPersona, ref string sMsjError)
        {
            Cls_Clientes_BLL Obj_Clientes_BLL = new Cls_Clientes_BLL();
            return Obj_Clientes_BLL.Insertar(sIdCliente, bIdTipoCliente, sIdPersona, ref sMsjError);
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
        public short insertarCorreos(short sIdCorreo, string sIdPersona, string sCorreo, ref string sMsjError)
        {
            Cls_Correos_BLL Obj_Correos_BLL = new Cls_Correos_BLL();
            return Obj_Correos_BLL.Insertar(sIdCorreo, sIdPersona, sCorreo, ref sMsjError);
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
        public char insertarEstado(char cIdEstado, string sEstado, ref string sMsj_error)
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
        public void listarFacturacion()
        {

        }
        public void filtrarFacturacion()
        {

        }
        public void insertarFacturacion()
        {

        }
        public void actualizarFacturacion()
        {

        }
        public void eliminarFacturacion()
        {

        }
        #endregion
        #region FacturaDetalle
        public void listarFacturaDetalle()
        {

        }
        public void filtrarFacturaDetalle()
        {

        }
        public void insertarFacturaDetalle()
        {

        }
        public void actualizarFacturaDetalle()
        {

        }
        public void eliminarFacturaDetalle()
        {

        }
        #endregion
        #region TipoServicio
        public void listarTipoServicio()
        {

        }
        #endregion
        #region TipoMembresia
        public void listarTipoMembresia()
        {

        }
        #endregion
        #region TipoCliente
        public void listarTipoCliente()
        {

        }
        #endregion
        #region Usuario
        public void listarUsuarios()
        {

        }
        #endregion
        #region Telefonos
        public void listarTelefonos()
        {

        }
        #endregion
        
    }
}
