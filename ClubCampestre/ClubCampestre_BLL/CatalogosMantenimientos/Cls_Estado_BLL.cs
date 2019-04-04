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
        private DataTable inicializarDT(DataTable dt, char cIdEstado, string sEstado)
        {
            dt.Columns.Add("IdEstado");
            dt.Columns.Add("Estado");
            dt.Rows.Add("@IdEstado", cIdEstado);
            if (sEstado != string.Empty)
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
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(new DataTable(), cIdEstado, sEstado), "[dbo].[sp_search_TB_Estado]", ref sMsj_error).Copy();
        }

        public char Insertar(char cIdEstado, string sEstado, ref string sMsj_error)
        {
            return Convert.ToChar(Obj_BD_BLL.ExecuteScalar(inicializarDT(new DataTable(), cIdEstado, sEstado), "[dbo].[sp_insert_TB_Estado]", ref sMsj_error));
        }

        public bool Actualizar(char cIdEstado, string sEstado, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(new DataTable(), cIdEstado, sEstado), "[dbo].[sp_update_TB_Estado]", ref sMsj_error);
        }

        public bool Eliminar(char cIdEstado, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(new DataTable(), cIdEstado, string.Empty), "[dbo].[sp_update_TB_Estado]", ref sMsj_error);
        }
    }
}
