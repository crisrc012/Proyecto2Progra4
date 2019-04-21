using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Ingresos_BLL
    {

        public void Cargar(ref Cls_Ingreso_Dal Obj_Ingreso_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Ingresos_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Ingreso_DAL.DS.Tables.Add(Obj_Ingresos_Client.Cargar(Obj_Ingreso_DAL.IdPersona,  ref sMsjError));
                Obj_Ingresos_Client.Close();
                Obj_Ingreso_DAL.SMsj_error = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Ingreso_DAL.SMsj_error = ex.Message.ToString();
            }
        }

        public void Invitado_Beneficiario(ref Cls_Ingreso_Dal Obj_Ingreso_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Ingresos_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Ingreso_DAL.DI.Tables.Add(Obj_Ingresos_Client.Invitado_Beneficiario(Obj_Ingreso_DAL.IdPersona, ref sMsjError));
                Obj_Ingresos_Client.Close();
                Obj_Ingreso_DAL.SMsj_error = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Ingreso_DAL.SMsj_error = ex.Message.ToString();
            }
        }
    }
}
