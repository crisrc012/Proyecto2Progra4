using ClubCampestre_BLL.BD;
using System;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_TipoMembresia_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(byte IdTipoMembresia, string Descripcion, float Costo, bool bFiltrar = false)
        {
            DataTable dt = new DataTable("TipoMembresia");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (IdTipoMembresia != byte.MinValue || bFiltrar)
            {
                dt.Rows.Add("@IdTipoMembresia", IdTipoMembresia);
            }
            if (Descripcion != string.Empty || bFiltrar)
            {
                dt.Rows.Add("@Descripcion", Descripcion);
            }
            if (Costo != float.MinValue || bFiltrar)
            {
                dt.Rows.Add("@Costo", Costo);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_TipoMembresia]", ref sMsj_error);
        }

        public DataTable Filtrar(byte IdTipoMembresia, string Descripcion, float Costo, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(IdTipoMembresia, Descripcion, Costo, true), "[dbo].[sp_search_TB_TipoMembresia]", ref sMsj_error);
        }

        public byte Insertar(string Descripcion, float Costo, ref string sMsj_error)
        {
            return Convert.ToByte(Obj_BD_BLL.ExecuteScalar(inicializarDT(byte.MinValue, Descripcion, Costo), "[dbo].[sp_insert_TB_TipoMembresia]", ref sMsj_error));
        }

        public bool Actualizar(byte IdTipoMembresia, string Descripcion, float Costo, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdTipoMembresia, Descripcion, Costo), "[dbo].[sp_update_TB_TipoMembresia]", ref sMsj_error);
        }

        public bool Eliminar(byte IdTipoMembresia, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdTipoMembresia, string.Empty, float.MinValue), "[dbo].[sp_delete_TB_TipoMembresia]", ref sMsj_error);
        }
    }
}
