using ClubCampestre_BLL.BD;
using System.Data;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Servicios_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(short iIdServicio, short iIdCliente, char cIdEstado, Byte bIdTipoServicio)
        {
            DataTable dt = new DataTable("Servicios");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            dt.Rows.Add("@IdServicio", iIdServicio);
            if (iIdCliente != short.MinValue)
            {
                dt.Rows.Add("@IdCliente", iIdCliente);
            }
            if (char.IsWhiteSpace(cIdEstado))
            {
                dt.Rows.Add("@IdEstado", cIdEstado);
            }
            if (bIdTipoServicio != byte.MinValue)
            {
                dt.Rows.Add("@IdTipoServicio", bIdTipoServicio);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_Servicio]", ref sMsj_error);
        }

        public DataTable Filtrar(Byte iIdServicio, Byte iIdCliente, char cIdEstado, Byte bIdTipoServicio, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(iIdServicio, iIdCliente, cIdEstado, bIdTipoServicio), "[dbo].[sp_search_TB_Servicio]", ref sMsj_error).Copy();
        }


        public char Insertar(Byte iIdServicio, Byte iIdCliente, char cIdEstado, Byte bIdTipoServicio, ref string sMsj_error)
        {
            return Convert.ToChar(Obj_BD_BLL.ExecuteDataAdapter(inicializarDT( iIdServicio, iIdCliente, cIdEstado, bIdTipoServicio), "[dbo].[sp_insert_TB_Servicio]", ref sMsj_error));
        }


        public bool Actualizar(Byte iIdServicio, Byte iIdCliente, char cIdEstado, Byte bIdTipoServicio, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT( iIdServicio, iIdCliente, cIdEstado, bIdTipoServicio), "[dbo].[sp_update_TB_Servicio]", ref sMsj_error);
        }


        public bool Eliminar(Byte iIdServicio, Byte iIdCliente, char cIdEstado, Byte bIdTipoServicio, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(iIdServicio, iIdCliente, cIdEstado, bIdTipoServicio), "[dbo].[sp_delete_TB_Servicio]", ref sMsj_error);
        }

    }
}