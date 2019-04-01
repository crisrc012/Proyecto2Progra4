﻿using ClubCampestre_BLL.BD;
using ClubCampestre_DAL.BD;
using ClubCampestre_DAL.CatalogosMantenimientos;

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
            Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sNombre_SP = "[dbo].[sp_select_TB_Facturacion]";
            Obj_Facturacion_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
            if (Obj_BD_DAL.sMsj_error == string.Empty)
            {
                Obj_Facturacion_DAL.SMsjError = string.Empty;
            }
            else
            {
                Obj_Facturacion_DAL.SMsjError = Obj_BD_DAL.sMsj_error;
                Obj_Facturacion_DAL.DS = null;
            }
        }

        public void Filtrar(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {
            Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sNombre_SP = "[dbo].[sp_search_TB_Facturacion]";
            Obj_Facturacion_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
            if (Obj_BD_DAL.sMsj_error == string.Empty)
            {
                Obj_Facturacion_DAL.SMsjError = string.Empty;
            }
            else
            {
                Obj_Facturacion_DAL.SMsjError = Obj_BD_DAL.sMsj_error;
                Obj_Facturacion_DAL.DS = null;
            }
        }

        public void Insertar(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {

        }

        public void Actualizar(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {

        }

        public void Eliminar(ref Cls_Facturacion_DAL Obj_Facturacion_DAL)
        {

        }
    }
}