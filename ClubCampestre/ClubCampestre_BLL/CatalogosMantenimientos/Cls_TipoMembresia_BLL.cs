using ClubCampestre_BLL.BD;
using ClubCampestre_DAL.CatalogosMantenimientos;


namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_TipoMembresia_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion

        public void Listar(ref Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_select_TB_TipoMembresia]";
            //Obj_TipoMembresia_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
        }

      

        public void Insertar(ref Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL)
        {

        }

        public void Actualizar(ref Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL)
        {

        }

        public void Eliminar(ref Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL)
        {

        }
    }
}
