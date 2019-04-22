using ClubCampestre_BLL.BD;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Usuarios_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(string IdUsuario, string IdPersona, string Contrasena)
        {
            DataTable dt = new DataTable("Usuario");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (IdUsuario != string.Empty)
            {
                dt.Rows.Add("@IdUsuario", IdUsuario);
            }
            if (IdPersona != string.Empty)
            {
                dt.Rows.Add("@IdPersona", IdPersona);
            }

            if (Contrasena != string.Empty)
            {
                dt.Rows.Add("@Contrasena", Contrasena);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_V_Usuarios]", ref sMsj_error);
        }

        public DataTable Filtrar(string IdUsuario, string IdPersona, string Contrasena, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(IdUsuario, IdPersona, Contrasena), "[dbo].[sp_search_TB_Usuarios]", ref sMsj_error).Copy();
        }
        public DataTable FiltrarV(string IdUsuario, string IdPersona, string Contrasena, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(IdUsuario, IdPersona, Contrasena), "[dbo].[sp_search_V_Usuarios]", ref sMsj_error).Copy();
        }

        public bool Insertar(string IdUsuario, string IdPersona, string Contrasena, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdUsuario, IdPersona, Contrasena), "[dbo].[sp_insert_TB_Usuarios]", ref sMsj_error);
        }

        public bool Actualizar(string IdUsuario, string IdPersona, string Contrasena, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdUsuario, IdPersona, Contrasena), "[dbo].[sp_update_TB_Usuarios]", ref sMsj_error);
        }

        public bool Eliminar(string IdUsuario, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(IdUsuario, string.Empty, string.Empty), "[dbo].[sp_delete_TB_Usuarios]", ref sMsj_error);
        }

        public DataTable Login(string IdPersona, string Contrasena, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(string.Empty,IdPersona, Contrasena), "[dbo].[sp_login]", ref sMsj_error);
        }
    }
}
