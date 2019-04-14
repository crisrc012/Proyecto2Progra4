using ClubCampestre_BLL.BD;
using System.Data;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Roles_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(byte bIdRol, string sDescripcion)
        {
            DataTable dt = new DataTable("Persona");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (bIdRol != byte.MinValue)
            {
                dt.Rows.Add("@IdRol", bIdRol);
            }
            if (sDescripcion != string.Empty)
            {
                dt.Rows.Add("@Descripcion", sDescripcion);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_Rol]", ref sMsj_error);
        }

        public DataTable Filtrar(byte bIdRol, string sDescripcion, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(bIdRol, sDescripcion), "[dbo].[sp_search_TB_Rol]", ref sMsj_error).Copy();
        }


        public byte Insertar(byte bIdRol, string sDescripcion, ref string sMsj_error)
        {
            return Convert.ToByte(Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(byte.MinValue, sDescripcion), "[dbo].[sp_insert_TB_Rol]", ref sMsj_error));
        }


        public bool Actualizar(byte bIdRol, string sDescripcion, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(bIdRol, sDescripcion), "[dbo].[sp_update_TB_Rol]", ref sMsj_error);
        }


        public bool Eliminar(byte bIdRol, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(bIdRol, string.Empty), "[dbo].[sp_delete_TB_Rol]", ref sMsj_error);
        }

    }
}
