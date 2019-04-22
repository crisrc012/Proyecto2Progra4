using System.Data;
using ClubCampestre_BLL.BD;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Persona_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(string sIdPersona, string sNombre, string sDireccion, short sIdRol, bool bFiltrar = false)
        {
            DataTable dt = new DataTable("Persona");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
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
            if (sIdRol != byte.MinValue || bFiltrar)
            {
                dt.Rows.Add("@IdRol", sIdRol);
            }
            return dt;
        }
        private DataTable inicializarDT(string sIdPersona, string sNombre, string sDireccion, string sRol, bool bFiltrar = false)
        {
            DataTable dt = new DataTable("Persona");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
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
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_V_Persona]", ref sMsjError);
        }

        public DataTable Filtrar(string sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(sIdPersona, sNombre, sDireccion, sIdRol, true), "[dbo].[sp_search_TB_Persona]", ref sMsjError);
        }
        public DataTable Filtrar(string sIdPersona, string sNombre, string sDireccion, string sRol, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(sIdPersona, sNombre, sDireccion, sRol, true), "[dbo].[sp_search_V_Persona]", ref sMsjError);
        }
        public bool Insertar(string sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError)
        {

            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(sIdPersona, sNombre, sDireccion, sIdRol), "[dbo].[sp_insert_TB_Persona]", ref sMsjError);
        }

        public bool Actualizar(string sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(sIdPersona, sNombre, sDireccion, sIdRol), "[dbo].[sp_update_TB_Persona]", ref sMsjError);
        }

        public bool Eliminar(string sIdPersona, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(sIdPersona, string.Empty, string.Empty, byte.MinValue), "[dbo].[sp_delete_TB_Persona]", ref sMsjError);
        }
    }
}
