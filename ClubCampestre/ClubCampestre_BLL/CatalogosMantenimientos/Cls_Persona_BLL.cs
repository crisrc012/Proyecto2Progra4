using System;
using System.Data;
using ClubCampestre_BLL.BD;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Persona_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(string sIdPersona, string sNombre, string sDireccion, short sIdRol)
        {
            DataTable dt = new DataTable("Persona");
            dt.Columns.Add("IdPersona");
            dt.Columns.Add("Persona");
            dt.Rows.Add("@IdPersona", sIdPersona);
            if (sNombre != string.Empty)
            {
                dt.Columns.Add("Nombre");
                dt.Rows.Add("@Nombre", sNombre);
            }
            if (sDireccion != string.Empty)
            {
                dt.Columns.Add("Direccion");
                dt.Rows.Add("@Direccion", sDireccion);
            }
            if (sIdRol != byte.MinValue)
            {
                dt.Columns.Add("IdRol");
                dt.Rows.Add("@IdRol", sIdRol);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_Persona]", ref sMsjError).Copy();
        }

        public DataTable Filtrar(string sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(sIdPersona, sNombre, sDireccion, sIdRol), "[dbo].[sp_search_TB_Persona]", ref sMsjError).Copy();
        }

        public short Insertar(string sIdPersona, string sNombre, string sDireccion, short sIdRol, ref string sMsjError)
        {
            return Convert.ToInt16(Obj_BD_BLL.ExecuteScalar(inicializarDT(sIdPersona, sNombre, sDireccion, sIdRol), "[dbo].[sp_insert_TB_Persona]", ref sMsjError));
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
