using ClubCampestre_BLL.BD;
using ClubCampestre_DAL.BD;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_FacturaDetalle_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        private Cls_BD_DAL Obj_BD_DAL;
        #endregion

        public void Listar(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_select_TB_FacturaDetalle]";
            //Obj_FacturaDetalle_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
        }

        public void Filtrar(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_search_TB_FacturaDetalle]";
            //// Se cargan valores a buscar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdFacturaDetalle", Obj_FacturaDetalle_DAL.IIdFacturaDetalle);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdFactura", Obj_FacturaDetalle_DAL.IIdFactura);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Detalle", Obj_FacturaDetalle_DAL.SDetalle);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@costo", Obj_FacturaDetalle_DAL.Fcosto);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdTipoServicio", Obj_FacturaDetalle_DAL.BIdTipoServicio);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdMembresia", Obj_FacturaDetalle_DAL.IIdMembresia);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@cantidad", Obj_FacturaDetalle_DAL.Icantidad);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@total", Obj_FacturaDetalle_DAL.Ftotal);
            //Obj_FacturaDetalle_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
        }

        public void Insertar(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_insert_TB_FacturaDetalle]";
            //// Se cargan valores a insertar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdFacturaDetalle", Obj_FacturaDetalle_DAL.IIdFacturaDetalle);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdFactura", Obj_FacturaDetalle_DAL.IIdFactura);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Detalle", Obj_FacturaDetalle_DAL.SDetalle);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@costo", Obj_FacturaDetalle_DAL.Fcosto);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdTipoServicio", Obj_FacturaDetalle_DAL.BIdTipoServicio);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdMembresia", Obj_FacturaDetalle_DAL.IIdMembresia);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@cantidad", Obj_FacturaDetalle_DAL.Icantidad);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@total", Obj_FacturaDetalle_DAL.Ftotal);
            //Obj_FacturaDetalle_DAL.IIdFactura = Convert.ToInt32(Obj_BD_BLL.ExecuteScalar(ref Obj_BD_DAL));
        }

        public void Actualizar(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_update_TB_FacturaDetalle]";
            //// Se cargan valores a actualizar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdFacturaDetalle", Obj_FacturaDetalle_DAL.IIdFacturaDetalle);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdFactura", Obj_FacturaDetalle_DAL.IIdFactura);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Detalle", Obj_FacturaDetalle_DAL.SDetalle);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@costo", Obj_FacturaDetalle_DAL.Fcosto);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdTipoServicio", Obj_FacturaDetalle_DAL.BIdTipoServicio);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdMembresia", Obj_FacturaDetalle_DAL.IIdMembresia);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@cantidad", Obj_FacturaDetalle_DAL.Icantidad);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@total", Obj_FacturaDetalle_DAL.Ftotal);
            //Obj_BD_BLL.ExecuteNonQuery(ref Obj_BD_DAL);
        }

        public void Eliminar(ref Cls_FacturaDetalle_DAL Obj_FacturaDetalle_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_delete_TB_FacturaDetalle]";
            //// Se cargan valores a eliminar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdFacturaDetalle", Obj_FacturaDetalle_DAL.IIdFacturaDetalle);
            //Obj_BD_BLL.ExecuteNonQuery(ref Obj_BD_DAL);
        }
    }
}
