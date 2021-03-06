﻿using ClubCampestre_BLL.BD;
using System;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_TipoServicio_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(byte IdTipoServicio, string Descripcion, float Costo, bool bFiltrar)
        {
            DataTable dt = new DataTable("TipoServicio");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (IdTipoServicio != byte.MinValue || bFiltrar)
            {
                dt.Rows.Add("@IdTipoServicio", IdTipoServicio);
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
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_TipoServicio]", ref sMsj_error);
        }

        public DataTable Filtrar(byte IdTipoServicio, string Descripcion, float Costo, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(IdTipoServicio, Descripcion, Costo, true), "[dbo].[sp_search_TB_TipoServicio]", ref sMsj_error);
        }

        public byte Insertar(string Descripcion, float Costo, ref string sMsj_error)
        {
            return Convert.ToByte(Obj_BD_BLL.ExecuteScalar(inicializarDT(byte.MinValue, Descripcion, Costo, false), "[dbo].[sp_insert_TB_TipoServicio]", ref sMsj_error));
        }

        public bool Actualizar(byte IdTipoServicio, string Descripcion, float Costo, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdTipoServicio, Descripcion, Costo, false), "[dbo].[sp_update_TB_TipoServicio]", ref sMsj_error);
        }

        public bool Eliminar(byte IdTipoServicio, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdTipoServicio, string.Empty, float.MinValue, false), "[dbo].[sp_delete_TB_TipoServicio]", ref sMsj_error);
        }
    }
}
