using ClubCampestre_BLL.BD;
using System;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Estado_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(char cIdEstado, string sEstado, bool bFiltrar = false)
        {
            DataTable dt = new DataTable("Estado");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (cIdEstado != char.MinValue || bFiltrar)
            {
                dt.Rows.Add("@IdEstado", cIdEstado);
            }
            if (sEstado != string.Empty || bFiltrar)
            {
                dt.Rows.Add("@Estado", sEstado);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_Estado]", ref sMsj_error);
        }

        public DataTable Filtrar(char cIdEstado, string sEstado, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(char.MinValue, sEstado, true), "[dbo].[sp_search_TB_Estado]", ref sMsj_error);
        }

        public char Insertar(char cIdEstado, string sEstado, ref string sMsj_error)
        {
            return Convert.ToChar(Obj_BD_BLL.ExecuteScalar(inicializarDT(cIdEstado, sEstado), "[dbo].[sp_insert_TB_Estado]", ref sMsj_error));
        }

        public bool Actualizar(char cIdEstado, string sEstado, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(cIdEstado, sEstado), "[dbo].[sp_update_TB_Estado]", ref sMsj_error);
        }

        public bool Eliminar(char cIdEstado, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(cIdEstado, string.Empty), "[dbo].[sp_delete_TB_Estado]", ref sMsj_error);
        }
    }
}
