﻿using ClubCampestre_BLL.BD;
using System;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Clientes_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion

        private DataTable inicializarDT(short sIdCliente, byte bIdTipoCliente, string sIdPersona, bool bFiltrar = false)
        {
            DataTable dt = new DataTable("Clientes");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (sIdCliente != short.MinValue || bFiltrar)
            {
                dt.Rows.Add("@IdCliente", sIdCliente);
            }
            if (bIdTipoCliente != byte.MinValue || bFiltrar)
            {
                dt.Rows.Add("@IdTipoCliente", bIdTipoCliente);
            }
            if (sIdPersona != string.Empty || bFiltrar)
            {
                dt.Rows.Add("@IdPersona", sIdPersona);
            }
            return dt;
        }
        private DataTable inicializarDT(short sIdCliente, string sTipoCliente, string sIdPersona, string sNombre, string sDireccion, string sRol, bool bFiltrar = false)
        {
            DataTable dt = new DataTable("Clientes");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (sIdCliente != short.MinValue || bFiltrar)
            {
                dt.Rows.Add("@IdCliente", sIdCliente);
            }
            if (sTipoCliente != string.Empty || bFiltrar)
            {
                dt.Rows.Add("@TipoCliente", sTipoCliente);
            }
            if (sIdPersona != string.Empty || bFiltrar)
            {
                dt.Rows.Add("@IdPersona", sIdPersona);
            }
            if (sNombre != string.Empty || bFiltrar)
            {
                dt.Rows.Add("@Nombre", sNombre);
            }
            if (sDireccion != string.Empty || bFiltrar)
            {
                dt.Rows.Add("@Direccion", sDireccion);
            }
            if (sRol != string.Empty || bFiltrar)
            {
                dt.Rows.Add("@Rol", sRol);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_V_Clientes]", ref sMsjError);
        }

        public DataTable Filtrar(short sIdCliente, byte bIdTipoCliente, string sIdPersona, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(sIdCliente, bIdTipoCliente, sIdPersona, true), "[dbo].[sp_search_TB_Clientes]", ref sMsjError);
        }
        public DataTable Filtrar(short sIdCliente, string sTipoCliente, string sIdPersona, string sNombre, string sDireccion, string sRol, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(sIdCliente, sTipoCliente, sIdPersona, sNombre, sDireccion, sRol, true), "[dbo].[sp_search_V_Clientes]", ref sMsjError);
        }

        public short Insertar(byte bIdTipoCliente, string sIdPersona, ref string sMsjError)
        {
            return Convert.ToInt16(Obj_BD_BLL.ExecuteScalar(inicializarDT(short.MinValue, bIdTipoCliente, sIdPersona), "[dbo].[sp_insert_TB_Clientes]", ref sMsjError));
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
