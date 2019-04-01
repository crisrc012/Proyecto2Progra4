using ClubCampestre_BLL.BD;
using ClubCampestre_DAL.BD;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Clientes_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        private Cls_BD_DAL Obj_BD_DAL;
        #endregion

        public void Listar(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sNombre_SP = "[dbo].[sp_select_TB_Clientes]";
            Obj_Clientes_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
            if (Obj_BD_DAL.sMsj_error == string.Empty)
            {
                Obj_Clientes_DAL.SMsjError = string.Empty;
            }
            else
            {
                Obj_Clientes_DAL.SMsjError = Obj_BD_DAL.sMsj_error;
                Obj_Clientes_DAL.DS = null;
            }
        }

        public void Filtrar(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sNombre_SP = "[dbo].[sp_search_TB_Clientes]";
            // Se cargan valores a buscar
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdCliente", Obj_Clientes_DAL.SIdCliente);
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdTipoCliente", Obj_Clientes_DAL.BIdTipoCliente);
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdPersona", Obj_Clientes_DAL.SIdPersona);
            Obj_Clientes_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
            if (Obj_BD_DAL.sMsj_error == string.Empty)
            {
                Obj_Clientes_DAL.SMsjError = string.Empty;
            }
            else
            {
                Obj_Clientes_DAL.SMsjError = Obj_BD_DAL.sMsj_error;
                Obj_Clientes_DAL.DS = null;
            }
        }

        public void Insertar(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sNombre_SP = "[dbo].[sp_insert_TB_Clientes]";
            // Se cargan valores a insertar
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdTipoCliente", Obj_Clientes_DAL.BIdTipoCliente);
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdPersona", Obj_Clientes_DAL.SIdPersona);
            Obj_Clientes_DAL.SIdCliente = Convert.ToInt16(Obj_BD_BLL.ExecuteScalar(ref Obj_BD_DAL));
            if (Obj_BD_DAL.sMsj_error == string.Empty)
            {
                Obj_Clientes_DAL.SMsjError = string.Empty;
            }
            else
            {
                Obj_Clientes_DAL.SMsjError = Obj_BD_DAL.sMsj_error;
                Obj_Clientes_DAL.DS = null;
            }
        }

        public void Actualizar(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sNombre_SP = "[dbo].[sp_update_TB_Clientes]";
            // Se cargan valores a actualizar
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdCliente", Obj_Clientes_DAL.SIdCliente);
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdTipoCliente", Obj_Clientes_DAL.BIdTipoCliente);
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdPersona", Obj_Clientes_DAL.SIdPersona);
            Obj_BD_BLL.ExecuteNonQuery(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsj_error == string.Empty)
            {
                Obj_Clientes_DAL.SMsjError = string.Empty;
            }
            else
            {
                Obj_Clientes_DAL.SMsjError = Obj_BD_DAL.sMsj_error;
                Obj_Clientes_DAL.DS = null;
            }
        }

        public void Eliminar(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sNombre_SP = "[dbo].[sp_delete_TB_Clientes]";
            // Se cargan valores a eliminar
            Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdCliente", Obj_Clientes_DAL.SIdCliente);
            Obj_BD_BLL.ExecuteNonQuery(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsj_error == string.Empty)
            {
                Obj_Clientes_DAL.SMsjError = string.Empty;
            }
            else
            {
                Obj_Clientes_DAL.SMsjError = Obj_BD_DAL.sMsj_error;
                Obj_Clientes_DAL.DS = null;
            }
        }
    }
}
