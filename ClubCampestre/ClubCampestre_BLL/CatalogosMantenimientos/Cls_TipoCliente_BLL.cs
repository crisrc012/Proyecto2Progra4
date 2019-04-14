using ClubCampestre_BLL.BD;
using System;
using System.Data;
namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_TipoCliente_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(byte IdTipoCliente, string Descripcion)
        {
            DataTable dt = new DataTable("TipoCliente");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            dt.Rows.Add("@IdTipoCliente", IdTipoCliente);
            if (Descripcion != string.Empty)
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
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(IdTipoCliente, Descripcion), "[dbo].[sp_search_TB_TipoCliente]", ref sMsj_error).Copy();
        }

        public char Insertar(byte IdTipoCliente, string Descripcion, ref string sMsj_error)
        {
            return Convert.ToChar(Obj_BD_BLL.ExecuteScalar(inicializarDT(IdTipoCliente, Descripcion), "[dbo].[sp_insert_TB_TipoCliente]", ref sMsj_error));
        }

        public bool Actualizar(byte IdTipoCliente, string Descripcion, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdTipoCliente, Descripcion), "[dbo].[sp_update_TB_TipoCliente]", ref sMsj_error);
        }

        public bool Eliminar(byte IdTipoCliente, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdTipoCliente, string.Empty), "[dbo].[sp_delete_TB_TipoCliente]", ref sMsj_error);
        }
    }
}
