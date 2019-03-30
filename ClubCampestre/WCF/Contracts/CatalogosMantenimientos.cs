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
            Obj_Estado_BLL.listarEstado(ref Obj_Estado_DAL);
            return Obj_Estado_DAL.DS.Tables[0];
        }
        #endregion
    }
}
