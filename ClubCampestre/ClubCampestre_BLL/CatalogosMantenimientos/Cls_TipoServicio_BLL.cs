using ClubCampestre_BLL.BD;
using System;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_TipoServicio_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(byte IdTipoServicio, string Descripcion, float Costo)
        {
            DataTable dt = new DataTable("TipoServicio");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            dt.Rows.Add("@IdTipoServicio", IdTipoServicio);
            if (Descripcion != string.Empty)
            {
                dt.Rows.Add("@Descripcion", Descripcion);
            }

            if (Costo != float.MinValue)
            {
                dt.Rows.Add("@Costo", Costo);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_TipoServicio]", ref sMsj_error);
        }

        public DataTable Filtrar(byte IdTipoServicio, string Descripcion, float Costo, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(IdTipoServicio, Descripcion, Costo), "[dbo].[sp_search_TB_TipoServicio]", ref sMsj_error).Copy();
        }

        public char Insertar(byte IdTipoServicio, string Descripcion, float Costo, ref string sMsj_error)
        {
            return Convert.ToChar(Obj_BD_BLL.ExecuteScalar(inicializarDT(IdTipoServicio, Descripcion, Costo), "[dbo].[sp_insert_TB_TipoServicio]", ref sMsj_error));
        }

        public bool Actualizar(byte IdTipoServicio, string Descripcion, float Costo, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdTipoServicio, Descripcion, Costo), "[dbo].[sp_update_TB_TipoServicio]", ref sMsj_error);
        }

        public bool Eliminar(byte IdTipoServicio, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdTipoServicio, string.Empty, float.MinValue), "[dbo].[sp_delete_TB_TipoServicio]", ref sMsj_error);
        }
    }
}
