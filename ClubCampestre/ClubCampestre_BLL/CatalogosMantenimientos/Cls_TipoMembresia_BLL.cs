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
        private DataTable inicializarDT(byte IdTipoMembresia, string Descripcion, float Costo)
        {
            DataTable dt = new DataTable("TipoMembresia");
            dt.Columns.Add("IdTipoMembresia");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Costo");
            dt.Rows.Add("@IdTipoMembresia", IdTipoMembresia);
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
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_TipoMembresia]", ref sMsj_error);
        }

        public DataTable Filtrar(byte IdTipoMembresia, string Descripcion, float Costo, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(IdTipoMembresia, Descripcion, Costo), "[dbo].[sp_search_TB_TipoMembresia]", ref sMsj_error).Copy();
        }

        public char Insertar(byte IdTipoMembresia, string Descripcion, float Costo, ref string sMsj_error)
        {
            return Convert.ToChar(Obj_BD_BLL.ExecuteScalar(inicializarDT(IdTipoMembresia, Descripcion, Costo), "[dbo].[sp_insert_TB_TipoMembresia]", ref sMsj_error));
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
