using ClubCampestre_BLL.BD;
using System;
using System.Data;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Beneficiarios_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        #endregion
        private DataTable inicializarDT(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado)
        {
            DataTable dt = new DataTable("Beneficiarios");
            dt.Columns.Add("Parametros");
            dt.Columns.Add("Valor");
            dt.Rows.Add("@IdBeneficiario", sIdBeneficiario);
            if (sIdCliente != short.MinValue)
            {
                dt.Rows.Add("@IdCliente", sIdCliente);
            }
            if (sIdPersona != string.Empty)
            {
                dt.Rows.Add("@IdPersona", sIdPersona);
            }
            if (char.IsWhiteSpace(cIdEstado))
            {
                dt.Rows.Add("@IdEstado", cIdEstado);
            }
            return dt;
        }
        public DataTable Listar(ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(null, "[dbo].[sp_select_TB_Beneficiarios]", ref sMsj_error);
        }

        public DataTable Filtrar(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteDataAdapter(inicializarDT(sIdBeneficiario, sIdCliente, sIdPersona, cIdEstado), "[dbo].[sp_search_TB_Beneficiarios]", ref sMsj_error);
        }

        public short Insertar(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsj_error)
        {
            return Convert.ToInt16(Obj_BD_BLL.ExecuteScalar(inicializarDT(sIdBeneficiario, sIdCliente, sIdPersona, cIdEstado), "[dbo].[sp_insert_TB_Beneficiarios]", ref sMsj_error));
        }

        public bool Actualizar(short sIdBeneficiario, short sIdCliente, string sIdPersona, char cIdEstado, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(sIdBeneficiario, sIdCliente, sIdPersona, cIdEstado), "[dbo].[sp_update_TB_Beneficiarios]", ref sMsj_error);
        }

        public bool Eliminar(short sIdBeneficiario, ref string sMsj_error)
        {
            return Obj_BD_BLL.ExecuteNonQuery(inicializarDT(sIdBeneficiario, short.MinValue, string.Empty, ' '), "[dbo].[sp_delete_TB_Beneficiarios]", ref sMsj_error);
        }
    }
}
