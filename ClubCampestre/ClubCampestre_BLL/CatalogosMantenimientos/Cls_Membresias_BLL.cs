﻿using System;
using ClubCampestre_BLL.BD;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Membresias_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion

        private DataTable inicializarDT(int iIdMembresia, short sIdCliente, byte bIdTipoMembresia, char cIdEstado, DateTime dFechaInicio, DateTime dFechaVence, bool bFiltrar = false)
        {
            System.Globalization.CultureInfo customCulture = new System.Globalization.CultureInfo("en-US", true);
            customCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = customCulture;

            DataTable dt = new DataTable("Membresias");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (iIdMembresia != int.MinValue || bFiltrar)
            {
                dt.Rows.Add("@IdMembresia", iIdMembresia);
            }
            if (sIdCliente != short.MinValue || bFiltrar)
            {
                dt.Rows.Add("@IdCliente", sIdCliente);
            }
            if (bIdTipoMembresia != byte.MinValue || bFiltrar)
            {
                dt.Rows.Add("@IdTipoMembresia", bIdTipoMembresia);
            }
            if (cIdEstado != char.MinValue)
            {
                dt.Rows.Add("@IdEstado", cIdEstado);
            }
            if (dFechaInicio != DateTime.MinValue)
            {
                dt.Rows.Add("@FechaInicio", Convert.ToDateTime(dFechaInicio, customCulture));
            }
            if (dFechaVence != DateTime.MinValue)
            {
                dt.Rows.Add("@FechaVencimiento", Convert.ToDateTime(dFechaVence, customCulture));
            }
            return dt;

        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_V_Membresia]", ref sMsj_error);
        }

        public DataTable Filtrar(int iIdMembresia, short sIdCliente, byte bIdTipoMembresia, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(iIdMembresia, short.MinValue, bIdTipoMembresia, char.MinValue, DateTime.MinValue, DateTime.MinValue, true), "[dbo].[sp_search_TB_Membresias]", ref sMsj_error);
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
