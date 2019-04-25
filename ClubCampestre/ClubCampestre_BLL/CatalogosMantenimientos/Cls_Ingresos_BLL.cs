using ClubCampestre_BLL.BD;
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

        private DataTable Datatable_Invitado_Beneficiario(string IdPersona)//datatable para devolver en ingresos
        {
            DataTable dt = new DataTable("Invitado_Beneficiario");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (IdPersona != string.Empty)
            {
                dt.Rows.Add("@IdPersona", IdPersona);
            }
           
            return dt;
        }

        private DataTable Datatable_Ingreso_factura(string IdPersona, float Costo )//datatable para datos de ingreso y encabezado de factura
        {
            DataTable dt = new DataTable("Ingreso_Factura");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (IdPersona != string.Empty)
            {
                dt.Rows.Add("@IdPersona", IdPersona);
            }

            if (Costo != float.MinValue)
            {
                dt.Rows.Add("@Costo", Costo);
            }

            return dt;
        }

        private DataTable Datatable_Detalle_Factura(string IdPersona, float Costo, byte IdTipoServicio, float Total )//datatable para datos de ingreso y encabezado de factura
        {
            DataTable dt = new DataTable("Ingreso_Factura");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (IdPersona != string.Empty)
            {
                dt.Rows.Add("@IdPersona", IdPersona);
            }

            if (Costo != float.MinValue)
            {
                dt.Rows.Add("@Costo", Costo);
            }

            if (IdTipoServicio!= byte.MinValue)
            {
                dt.Rows.Add("@IdTipoServicio", IdTipoServicio);
            }

            if (Total != float.MinValue)
            {
                dt.Rows.Add("@Total", Total);
            }
            return dt;
        }

        public DataTable Cargar(string IdPersona, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(Datatable_Cargar(IdPersona, string.Empty, string.Empty, string.Empty, float.MinValue), "[dbo].[sp_search_cargar_membresia]", ref sMsj_error);

        }

        public DataTable Invitado_Beneciario(string IdPersona, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(Datatable_Invitado_Beneficiario(IdPersona), "[dbo].[sp_search_Beneficiarios_Personas]", ref sMsj_error);

        }

        public void Insertar_Ingreso_factura(string IdPersona, float Costo, ref string sMsj_error)
        {
            Obj_BD_BLL.ExecuteNonQuery(Datatable_Ingreso_factura(IdPersona, Costo), "[dbo].[sp_insert_Ingreso_factura]", ref sMsj_error);
        }

        public void Insertar_Detalle_Factura(string IdPersona, float Costo, byte IdTipoServicio, float Total, ref string sMsj_error)
        {
            Obj_BD_BLL.ExecuteNonQuery(Datatable_Detalle_Factura(IdPersona, Costo, IdTipoServicio, Total), "[dbo].[sp_insert_detalle_factura]", ref sMsj_error);
        }
    }
}
