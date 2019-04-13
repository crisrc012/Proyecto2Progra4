using ClubCampestre_BLL.BD;
using System;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Clientes_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion

        private DataTable inicializarDT(short sIdCliente, byte bIdTipoCliente, string sIdPersona)
        {
            DataTable dt = new DataTable("Clientes");
            dt.Columns.Add("IdCliente");
            dt.Columns.Add("IdTipoCliente");
            dt.Columns.Add("IdPersona");
            dt.Rows.Add("@IdCliente", sIdCliente);
            if (bIdTipoCliente != byte.MinValue)
            {
                dt.Rows.Add("@IdTipoCliente", bIdTipoCliente);
            }
            if (sIdPersona != string.Empty)
            {
                dt.Rows.Add("@IdPersona", sIdPersona);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_Clientes]", ref sMsjError);
        }

        public DataTable Filtrar(short sIdCliente, byte bIdTipoCliente, string sIdPersona, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(sIdCliente, bIdTipoCliente, sIdPersona), "[dbo].[sp_search_TB_Clientes]", ref sMsjError);
        }

        public short Insertar(short sIdCliente, byte bIdTipoCliente, string sIdPersona, ref string sMsjError)
        {
            return Convert.ToInt16(Obj_BD_BLL.ExecuteScalar(inicializarDT(sIdCliente, bIdTipoCliente, sIdPersona), "[dbo].[sp_insert_TB_Clientes]", ref sMsjError));
        }

        public bool Actualizar(short sIdCliente, byte bIdTipoCliente, string sIdPersona, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(sIdCliente, bIdTipoCliente, sIdPersona), "[dbo].[sp_update_TB_Clientes]", ref sMsjError);
        }

        public bool Eliminar(short sIdCliente, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(sIdCliente, byte.MinValue, string.Empty), "[dbo].[sp_delete_TB_Clientes]", ref sMsjError);
        }
    }
}
