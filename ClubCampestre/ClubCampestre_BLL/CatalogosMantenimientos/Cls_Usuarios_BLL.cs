using ClubCampestre_BLL.BD;
using ClubCampestre_DAL.BD;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClubCampestre_BLL.CatalogosMantenimientos
{
   public class Cls_Usuarios_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        private Cls_BD_DAL Obj_BD_DAL;
        #endregion

        public void Listar(ref Cls_Usuarios_DAL Obj_Usuarios_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_select_TB_Usuarios]";
            //Obj_Usuarios_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
        }

        public void Insertar()
        {

        }

        public void Actualizar()
        {

        }

        public void Eliminar()
        {

        }
    }
}
