using System;
using ClubCampestre_BLL.BD;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Membresias_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion

        private DataTable inicializarDT(int iIdMembresia, short sIdCliente, byte bIdTipoMembresia, char cIdEstado, DateTime dFechaInicio, DateTime dFechaVence)
        {
            DataTable dt = new DataTable("Membresias");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (iIdMembresia != int.MinValue)
            {
                dt.Rows.Add("@IdMembresia", iIdMembresia);
            }
            if (sIdCliente != short.MinValue)
            {
                dt.Rows.Add("@IdCliente", sIdCliente);
            }
            if (bIdTipoMembresia != byte.MinValue)
            {
                dt.Rows.Add("@IdTipoMembresia", bIdTipoMembresia);
            }
            if (cIdEstado != char.MinValue)
            {
                dt.Rows.Add("@IdEstado", cIdEstado);
            }
            if (dFechaInicio != DateTime.MinValue)
            {
                dt.Rows.Add("@FechaInicio", dFechaInicio);
            }
            if (dFechaVence != DateTime.MinValue)
            {
                dt.Rows.Add("@FechaVence", dFechaVence);
            }
            return dt;

        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_Membresias]", ref sMsj_error);
        }

        public DataTable Filtrar(int iIdMembresia, short sIdCliente, byte bIdTipoMembresia, char cIdEstado, DateTime dFechaInicio, DateTime dFechaVence, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(iIdMembresia, sIdCliente, bIdTipoMembresia, cIdEstado, dFechaInicio, dFechaVence), "[dbo].[sp_search_TB_Membresias]", ref sMsj_error).Copy();
        }

        public int Insertar(short sIdCliente, byte bIdTipoMembresia, char cIdEstado, DateTime dFechaInicio, DateTime dFechaVence, ref string sMsj_error)
        {
            return Convert.ToInt32(Obj_BD_BLL.ExecuteScalar(inicializarDT(int.MinValue, sIdCliente, bIdTipoMembresia, cIdEstado, dFechaInicio, dFechaVence), "[dbo].[sp_insert_TB_Membresias]", ref sMsj_error));
        }

        public bool Actualizar(int iIdMembresia, short sIdCliente, byte bIdTipoMembresia, char cIdEstado, DateTime dFechaInicio, DateTime dFechaVence, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(iIdMembresia, sIdCliente, bIdTipoMembresia, cIdEstado, dFechaInicio, dFechaVence), "[dbo].[sp_update_TB_Membresias]", ref sMsj_error);
        }

        public bool Eliminar(int iIdMembresia, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(iIdMembresia, short.MinValue, byte.MinValue, char.MinValue, DateTime.MinValue, DateTime.MinValue), "[dbo].[sp_delete_TB_Membresias]", ref sMsj_error);
        }
    }
}
