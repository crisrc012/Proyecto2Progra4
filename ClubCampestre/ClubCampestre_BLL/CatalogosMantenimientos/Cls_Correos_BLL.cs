using ClubCampestre_BLL.BD;
using System;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Correos_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(short sIdCorreo, string sIdPersona, string sCorreo)
        {
            DataTable dt = new DataTable("Correos");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (sIdCorreo != short.MinValue)
            {
                dt.Rows.Add("@IdCorreo", sIdCorreo);
            }
            if (sIdPersona != string.Empty)
            {
                dt.Rows.Add("@IdPersona", sIdPersona);
            }
            if (sCorreo != string.Empty)
            {
                dt.Rows.Add("@Correo", sCorreo);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_Correos]", ref sMsjError);
        }

        public DataTable Filtrar(short sIdCorreo, string sIdPersona, string sCorreo, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(sIdCorreo, sIdPersona, sCorreo), "[dbo].[sp_search_TB_Correos]", ref sMsjError);
        }

        public short Insertar(string sIdPersona, string sCorreo, ref string sMsjError)
        {
            return Convert.ToInt16(Obj_BD_BLL.ExecuteScalar(inicializarDT(short.MinValue, sIdPersona, sCorreo), "[dbo].[sp_insert_TB_Correos]", ref sMsjError));
        }

        public bool Actualizar(short sIdCorreo, string sIdPersona, string sCorreo, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(sIdCorreo, sIdPersona, sCorreo), "[dbo].[sp_update_TB_Correos]", ref sMsjError);
        }

        public bool Eliminar(short sIdCorreo, ref string sMsjError)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(sIdCorreo, string.Empty, string.Empty), "[dbo].[sp_delete_TB_Correos]", ref sMsjError);
        }
    }
}
