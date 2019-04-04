using ClubCampestre_BLL.BD;
using ClubCampestre_DAL.BD;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Facturacion_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        private Cls_BD_DAL Obj_BD_DAL;
        #endregion

        public void Listar(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_select_TB_Facturacion]";
            //Obj_Facturacion_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
        }

        public void Filtrar(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_search_TB_Facturacion]";
            //// Se cargan valores a buscar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdFactura", Obj_Facturacion_DAL.IIdFactura);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdCliente", Obj_Facturacion_DAL.SIdCliente);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Descripcion", Obj_Facturacion_DAL.SDescripcion);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Fecha", Obj_Facturacion_DAL.DFecha);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Montototal", Obj_Facturacion_DAL.FMontototal);
            //Obj_Facturacion_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
        }

        public void Insertar(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_insert_TB_Facturacion]";
            //// Se cargan valores a insertar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdFactura", Obj_Facturacion_DAL.IIdFactura);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdCliente", Obj_Facturacion_DAL.SIdCliente);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Descripcion", Obj_Facturacion_DAL.SDescripcion);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Fecha", Obj_Facturacion_DAL.DFecha);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Montototal", Obj_Facturacion_DAL.FMontototal);
            //Obj_Facturacion_DAL.IIdFactura = Convert.ToInt32(Obj_BD_BLL.ExecuteScalar(ref Obj_BD_DAL));
        }

        public void Actualizar(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_update_TB_Facturacion]";
            //// Se cargan valores a actualizar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdFactura", Obj_Facturacion_DAL.IIdFactura);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdCliente", Obj_Facturacion_DAL.SIdCliente);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Descripcion", Obj_Facturacion_DAL.SDescripcion);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Fecha", Obj_Facturacion_DAL.DFecha);
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@Montototal", Obj_Facturacion_DAL.FMontototal);
            //Obj_BD_BLL.ExecuteNonQuery(ref Obj_BD_DAL);
        }

        public void Eliminar(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            //Obj_BD_DAL = new Cls_BD_DAL();
            //Obj_BD_DAL.sNombre_SP = "[dbo].[sp_delete_TB_Facturacion]";
            //// Se cargan valores a eliminar
            //Obj_BD_DAL.Obj_dtparam.Rows.Add("@IdFactura", Obj_Facturacion_DAL.IIdFactura);
            //Obj_BD_BLL.ExecuteNonQuery(ref Obj_BD_DAL);
        }
    }
}