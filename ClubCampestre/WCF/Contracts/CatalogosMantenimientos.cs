using System.Data;
using ClubCampestre_BLL.CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;

namespace WCF.Contracts
{
    public class CatalogosMantenimientos : Interfaces.ICatalogosMantenimientos
    {
        #region Estado
        public DataTable listarEstado()
        {
            Cls_Estado_BLL Obj_Estado_BLL = new Cls_Estado_BLL();
            Cls_Estado_DAL Obj_Estado_DAL = new Cls_Estado_DAL();
            Obj_Estado_BLL.Listar(ref Obj_Estado_DAL);
            return Obj_Estado_DAL.DS.Tables[0];
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
