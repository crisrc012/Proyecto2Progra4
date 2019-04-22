using ClubCampestre_BLL.BD;
using System.Data;
namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_TipoCliente_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(byte IdTipoCliente, string Descripcion, bool bFiltrar)
        {
            DataTable dt = new DataTable("TipoCliente");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (IdTipoCliente != byte.MinValue || bFiltrar)
            {
                dt.Rows.Add("@IdTipoCliente", IdTipoCliente);
            }
            if (Descripcion != string.Empty || bFiltrar)
            {
                dt.Rows.Add("@Descripcion", Descripcion);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_TipoCliente]", ref sMsj_error);
        }

        public DataTable Filtrar(byte IdTipoCliente, string Descripcion, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(IdTipoCliente, Descripcion, true), "[dbo].[sp_search_TB_TipoCliente]", ref sMsj_error).Copy();
        }

        public string Insertar(byte IdTipoCliente, string Descripcion, ref string sMsj_error)
        {
            return (Obj_BD_BLL.ExecuteScalar(inicializarDT(IdTipoCliente, Descripcion, false), "[dbo].[sp_insert_TB_TipoCliente]", ref sMsj_error));
        }

        public bool Actualizar(byte IdTipoCliente, string Descripcion, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdTipoCliente, Descripcion, false), "[dbo].[sp_update_TB_TipoCliente]", ref sMsj_error);
        }

        public bool Eliminar(byte IdTipoCliente, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdTipoCliente, string.Empty, false), "[dbo].[sp_delete_TB_TipoCliente]", ref sMsj_error);
        }
    }
}
