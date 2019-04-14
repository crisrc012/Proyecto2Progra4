using ClubCampestre_BLL.BD;
using System.Data;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Ingresos_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(int iIdIngreso, short sIdCliente, int iIdMembresia, DateTime dFecha)
        {
            DataTable dt = new DataTable("Ingreso");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            dt.Rows.Add("@IdIngreso", iIdIngreso);

            if (sIdCliente != short.MinValue)
            {
                dt.Rows.Add("@IdCliente", sIdCliente);
            }
            if (iIdMembresia != short.MinValue)
            {
                dt.Rows.Add("@IdMembresia", iIdMembresia);
            }
            if (dFecha != DateTime.MinValue)
            {
                dt.Rows.Add("@FechaIngreso", dFecha);
            }

            return dt;
        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_Ingresos]", ref sMsj_error);
        }

        public DataTable Filtrar(int iIdIngreso, short sIdCliente, int iIdMembresia, DateTime dFecha, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(iIdIngreso, sIdCliente, iIdMembresia, dFecha), "[dbo].[sp_search_TB_Ingresos]", ref sMsj_error).Copy();
        }

        public char Insertar(int iIdIngreso,short sIdCliente, int iIdMembresia, DateTime dFecha, ref string sMsj_error)
        {
            return Convert.ToChar(Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(iIdIngreso, sIdCliente, iIdMembresia, dFecha), "[dbo].[sp_insert_TB_Ingresos]", ref sMsj_error));
        }

        public bool Actualizar(int iIdIngreso,short sIdCliente, int iIdMembresia, DateTime dFecha, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(iIdIngreso, sIdCliente, iIdMembresia, dFecha), "[dbo].[sp_update_TB_Ingresos]", ref sMsj_error);
        }

        public bool Eliminar(int iIdIngreso, short sIdCliente, int iIdMembresia, DateTime dFecha, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(iIdIngreso, sIdCliente, iIdMembresia, dFecha), "[dbo].[sp_delete_TB_Ingresos]", ref sMsj_error);
        }
    }
}
