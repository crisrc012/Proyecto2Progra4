using System;
using ClubCampestre_BLL.BD;
using ClubCampestre_DAL.BD;
using ClubCampestre_DAL.CatalogosMantenimientos;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Beneficiarios_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        private Cls_BD_DAL Obj_BD_DAL;
        #endregion

        public void Listar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_select_TB_Beneficiarios]";
            //Obj_Beneficiarios_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
        }

        public void Filtrar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_search_TB_Beneficiarios]";
            //// Se cargan valores a buscar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdBeneficiario", Obj_Beneficiarios_DAL.SIdBeneficiario);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdCliente", Obj_Beneficiarios_DAL.SIdCliente);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdPersona", Obj_Beneficiarios_DAL.SIdPersona);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdEstado", Obj_Beneficiarios_DAL.CIdEstado);
            //Obj_Beneficiarios_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
        }

        public void Insertar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_insert_TB_Beneficiarios]";
            //// Se cargan valores a insertar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdBeneficiario", Obj_Beneficiarios_DAL.SIdBeneficiario);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdCliente", Obj_Beneficiarios_DAL.SIdCliente);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdPersona", Obj_Beneficiarios_DAL.SIdPersona);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdEstado", Obj_Beneficiarios_DAL.CIdEstado);
            //Obj_Beneficiarios_DAL.SIdBeneficiario = Convert.ToInt16(Obj_BD_BLL.ExecuteScalar(ref Obj_BD_DAL));
        }

        public void Actualizar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_update_TB_Beneficiarios]";
            //// Se cargan valores a actualizar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdBeneficiario", Obj_Beneficiarios_DAL.SIdBeneficiario);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdCliente", Obj_Beneficiarios_DAL.SIdCliente);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdPersona", Obj_Beneficiarios_DAL.SIdPersona);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdEstado", Obj_Beneficiarios_DAL.CIdEstado);
            //Obj_BD_BLL.ExecuteNonQuery(ref Obj_BD_DAL);
        }

        public void Eliminar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_delete_TB_Beneficiarios]";
            //// Se cargan valores a eliminar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdBeneficiario", Obj_Beneficiarios_DAL.SIdBeneficiario);
            //Obj_BD_BLL.ExecuteNonQuery(ref Obj_BD_DAL);
        }
    }
}
