using ClubCampestre_BLL.BD;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Telefonos_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(string Telefono, string IdPersona, bool bFiltrar = false)
        {
            DataTable dt = new DataTable("Telefonos");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            if (Telefono != string.Empty || bFiltrar)
            {
                dt.Rows.Add("@Telefono", Telefono);
            }
            if (IdPersona != string.Empty || bFiltrar)
            {
                dt.Rows.Add("@IdPErsona", IdPersona);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_Telefonos]", ref sMsj_error);
        }

        public DataTable Filtrar(string Telefono, string IdPersona, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(Telefono, IdPersona, true), "[dbo].[sp_search_TB_Telefonos]", ref sMsj_error);
        }

        public bool  Insertar(string Telefono, string IdPersona, ref string sMsj_error)
        {
            return (Obj_BD_BLL.ExecuteNonQuery(inicializarDT(Telefono, IdPersona), "[dbo].[sp_insert_TB_Telefonos]", ref sMsj_error));
        }

        public bool Actualizar(string Telefono, string IdPersona, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(Telefono, IdPersona), "[dbo].[sp_update_TB_Telefonos]", ref sMsj_error);
        }

        public bool Eliminar(string Telefono, string IdPersona, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(Telefono, IdPersona, true), "[dbo].[sp_delete_TB_Telefonos]", ref sMsj_error);
        }
    }
}
