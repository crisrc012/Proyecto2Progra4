using ClubCampestre_BLL.BD;
using System;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Facturacion_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion

        private DataTable inicializarDT(int iIdFactura, short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal)
        {
            DataTable dt = new DataTable("Facturacion");
            dt.Columns.Add("IdFactura");
            dt.Columns.Add("IdCliente");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Montototal");
            dt.Rows.Add("@IdFactura", iIdFactura);
            if (sIdCliente != short.MinValue)
            {
                dt.Rows.Add("@IdCliente", sIdCliente);
            }
            if (sDescripcion != string.Empty)
            {
                dt.Rows.Add("@Descripcion", sDescripcion);
            }
            if (DFecha != DateTime.MinValue)
            {
                dt.Rows.Add("@Fecha", DFecha);
            }
            if (!float.IsNaN(fMontototal))
            {
                dt.Rows.Add("@Montototal", fMontototal);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_Facturacion]", ref sMsjError);
        }

        public DataTable Filtrar(int iIdFactura, short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(iIdFactura, sIdCliente, sDescripcion, DFecha, fMontototal), "[dbo].[sp_search_TB_Facturacion]", ref sMsjError);
        }

        public short Insertar(int iIdFactura, short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal, ref string sMsjError)
        {
            return Convert.ToInt16(Obj_BD_BLL.ExecuteScalar(inicializarDT(iIdFactura, sIdCliente, sDescripcion, DFecha, fMontototal), "[dbo].[sp_insert_TB_Facturacion]", ref sMsjError));
        }

        public bool Actualizar(int iIdFactura, short sIdCliente, string sDescripcion, DateTime DFecha, float fMontototal, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(iIdFactura, sIdCliente, sDescripcion, DFecha, fMontototal), "[dbo].[sp_update_TB_Facturacion]", ref sMsjError);
        }

        public bool Eliminar(int iIdFactura, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(iIdFactura, short.MinValue, string.Empty, DateTime.MinValue, float.NaN), "[dbo].[sp_delete_TB_Facturacion]", ref sMsjError);
        }
    }
}