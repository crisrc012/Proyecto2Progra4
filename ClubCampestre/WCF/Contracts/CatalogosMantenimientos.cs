using ClubCampestre_BLL.CatalogosMantenimientos;
using System.Data;

namespace WCF.Contracts
{
    public class CatalogosMantenimientos : Interfaces.ICatalogosMantenimientos
    {
        #region Beneficiarios
        public DataTable listarBeneficiarios(ref string sMsj_error)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            return Obj_Beneficiarios_BLL.Listar(ref sMsj_error);
        }
        public DataTable filtrarBeneficiarios(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsj_error)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            return Obj_Beneficiarios_BLL.Filtrar(sIdBeneficiario, sIdCliente, sIdPersona, cIdEstado, ref sMsj_error);
        }
        public short insertarBeneficiarios(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsj_error)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            return Obj_Beneficiarios_BLL.Insertar(sIdBeneficiario, sIdCliente, sIdPersona, cIdEstado, ref sMsj_error);
        }
        public bool actualizarBeneficiarios(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsj_error)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            return Obj_Beneficiarios_BLL.Actualizar(sIdBeneficiario, sIdCliente, sIdPersona, cIdEstado, ref sMsj_error);
        }
        public bool eliminarBeneficiarios(short sIdBeneficiario, ref string sMsj_error)
        {
            Cls_Beneficiarios_BLL Obj_Beneficiarios_BLL = new Cls_Beneficiarios_BLL();
            return Obj_Beneficiarios_BLL.Eliminar(sIdBeneficiario, ref sMsj_error);
        }
        #endregion
        #region Clientes
        public void listarClientes()
        {

        }
        public void filtrarClientes()
        {

        }
        public void insertarClientes()
        {

        }
        public void actualizarClientes()
        {

        }
        public void eliminarClientes(short SIdCliente)
        {

        }
        #endregion
        #region Correos
        public void listarCorreos()
        {

        }
        public void filtrarCorreos()
        {

        }
        public void insertarCorreos()
        {

        }
        public void actualizarCorreos()
        {

        }
        public void eliminarCorreos(string sCorreo)
        {

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
