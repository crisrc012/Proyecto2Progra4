using ClubCampestre_BLL.BD;
using System;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_FacturaDetalle_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion

        private DataTable inicializarDT(int iIdFacturaDetalle, int iIdFactura, string sDetalle, float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal)
        {
            DataTable dt = new DataTable("FacturaDetalle");
            dt.Columns.Add("iIdFacturaDetalle");
            dt.Columns.Add("iIdFactura");
            dt.Columns.Add("sDetalle");
            dt.Columns.Add("fcosto");
            dt.Columns.Add("bIdTipoServicio");
            dt.Columns.Add("iIdMembresia");
            dt.Columns.Add("icantidad");
            dt.Columns.Add("ftotal");
            dt.Rows.Add("@iIdFacturaDetalle", iIdFacturaDetalle);
            if (iIdFactura != int.MinValue)
            {
                dt.Rows.Add("@iIdFactura", iIdFactura);
            }
            if (sDetalle.Equals(null))
            {
                dt.Rows.Add("@sDetalle", sDetalle);
            }
            if (!float.IsNaN(fcosto))
            {
                dt.Rows.Add("@fcosto", fcosto);
            }
            if (bIdTipoServicio != byte.MinValue)
            {
                dt.Rows.Add("@bIdTipoServicio", bIdTipoServicio);
            }
            if (iIdMembresia != int.MinValue)
            {
                dt.Rows.Add("@iIdMembresia", iIdMembresia);
            }
            if (icantidad != int.MinValue)
            {
                dt.Rows.Add("@icantidad", icantidad);
            }
            if (float.IsNaN(ftotal))
            {
                dt.Rows.Add("@ftotal", ftotal);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_FacturaDetalle]", ref sMsjError);
        }

        public DataTable Filtrar(int iIdFacturaDetalle, int iIdFactura, string sDetalle, float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(iIdFacturaDetalle, iIdFactura, sDetalle, fcosto, bIdTipoServicio, iIdMembresia, icantidad, ftotal), "[dbo].[sp_search_TB_FacturaDetalle]", ref sMsjError);
        }

        public int Insertar(int iIdFacturaDetalle, int iIdFactura, string sDetalle, float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal, ref string sMsjError)
        {
            return Convert.ToInt32(Obj_BD_BLL.ExecuteScalar(inicializarDT(iIdFacturaDetalle, iIdFactura, sDetalle, fcosto, bIdTipoServicio, iIdMembresia, icantidad, ftotal), "[dbo].[sp_insert_TB_FacturaDetalle]", ref sMsjError));
        }

        public bool Actualizar(int iIdFacturaDetalle, int iIdFactura, string sDetalle, float fcosto, byte bIdTipoServicio, int iIdMembresia, int icantidad, float ftotal, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(iIdFacturaDetalle, iIdFactura, sDetalle, fcosto, bIdTipoServicio, iIdMembresia, icantidad, ftotal), "[dbo].[sp_update_TB_FacturaDetalle]", ref sMsjError);
        }

        public bool Eliminar(int iIdFacturaDetalle, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(iIdFacturaDetalle, int.MinValue, null, float.NaN, byte.MinValue, int.MinValue, int.MinValue, float.NaN), "[dbo].[sp_delete_TB_FacturaDetalle]", ref sMsjError);
        }
    }
}
