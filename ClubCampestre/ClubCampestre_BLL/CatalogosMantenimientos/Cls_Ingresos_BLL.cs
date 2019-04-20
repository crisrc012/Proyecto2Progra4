using ClubCampestre_BLL.BD;
using System;
using System.Data;


namespace ClubCampestre_BLL.CatalogosMantenimientos
{
   
    public class Cls_Ingresos_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable Datatable_Cargar(string IdPersona,string Nombre, string TipoCliente, string Membresia, float Costo)//datatable para devolver en ingresos
        {
            DataTable dt = new DataTable("Cliente_Membresia");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (IdPersona != string.Empty)
            {
                dt.Rows.Add("@IdPersona", IdPersona);
            }
            if (Nombre != string.Empty)
            {
                dt.Rows.Add("@Nombre", Nombre);
            }
            if (TipoCliente != string.Empty)
            {
                dt.Rows.Add("@TipoCliente", TipoCliente);
            }

            if (Membresia != string.Empty)
            {
                dt.Rows.Add("@Membresia", Membresia);
            }

            if (Costo != float.MinValue)
            {
                dt.Rows.Add("@Costo", Costo);
            }
            return dt;
        }

        public DataTable Cargar(string IdPersona, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(Datatable_Cargar(IdPersona, string.Empty, string.Empty, string.Empty, float.MinValue), "[dbo].[sp_search_cargar_membresia]", ref sMsj_error);

        }
    }
}
