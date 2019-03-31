﻿using ClubCampestre_BLL.BD;
using ClubCampestre_DAL.BD;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCampestre_BLL
{
    public class Cls_Telefonos_BLL
    {
        #region Variables Globales
        private Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        private Cls_BD_DAL Obj_BD_DAL;
        #endregion

        public void Listar(ref Cls_Estado_DAL Obj_Estado_DAL)
        {
            Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sNombre_SP = "[dbo].[sp_select_TB_Telefonos]";
            Obj_Estado_DAL.DS.Tables.Add(Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL).Copy());
            if (Obj_BD_DAL.sMsj_error == string.Empty)
            {
                Obj_Estado_DAL.SMsjError = string.Empty;
            }
            else
            {
                Obj_Estado_DAL.SMsjError = Obj_BD_DAL.sMsj_error;
                Obj_Estado_DAL.DS = null;
            }
        }

        

        public void Insertar(ref Cls_Estado_DAL Obj_Estado_DAL)
        {

        }

        public void Actualizar(ref Cls_Estado_DAL Obj_Estado_DAL)
        {

        }

        public void Eliminar(ref Cls_Estado_DAL Obj_Estado_DAL)
        {

        }
    }
}