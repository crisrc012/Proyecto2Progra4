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
   public class Cls_TipoCliente_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        private Cls_BD_DAL Obj_BD_DAL;
        #endregion

        public void Listar(ref Cls_TipoCliente_DAL Obj_TipoCliente_DAL)
        {
            Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sNombre_SP = "[dbo].[sp_select_TB_TipoCliente]";
            Obj_TipoCliente_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
            if (Obj_BD_DAL.sMsj_error == string.Empty)
            {
                Obj_TipoCliente_DAL.SMsjError = string.Empty;
            }
            else
            {
                Obj_TipoCliente_DAL.SMsjError = Obj_BD_DAL.sMsj_error;
                Obj_TipoCliente_DAL.DS = null;
            }
        }

       

        public void Insertar(ref Cls_TipoCliente_DAL Obj_TipoCliente_DAL)
        {

        }

        public void Actualizar(ref Cls_TipoCliente_DAL Obj_TipoCliente_DAL)
        {

        }

        public void Eliminar(ref Cls_TipoCliente_DAL Obj_TipoCliente_DAL)
        {

        }
    }
}
