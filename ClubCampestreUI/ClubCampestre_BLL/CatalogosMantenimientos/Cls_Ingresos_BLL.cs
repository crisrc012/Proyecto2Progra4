using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Ingresos_BLL
    {

        public void Cargar(ref Cls_Ingreso_DAL Obj_Ingreso_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Ingresos_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Ingreso_DAL.DS.Tables.Add(Obj_Ingresos_Client.Cargar(Obj_Ingreso_DAL.sIdPersona,  ref sMsjError));
                Obj_Ingresos_Client.Close();
                Obj_Ingreso_DAL.sMsj_error = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Ingreso_DAL.sMsj_error = ex.Message.ToString();
            }
        }

        public void Insertar_Ingreso_Factura(ref Cls_Ingreso_DAL Obj_Ingreso_Dal)
        {
            CatalogosMantenimientosClient Obj_Ingresos_Client = new CatalogosMantenimientosClient();
            string sMsjError = string.Empty;
            Obj_Ingresos_Client.Insertar_Ingreso_factura(Obj_Ingreso_Dal.sIdPersona, Obj_Ingreso_Dal.fCosto, ref sMsjError);
        }

        public void Insertar_Detalle_Factura(ref Cls_Ingreso_DAL Obj_Ingreso_Dal)
        {
            CatalogosMantenimientosClient Obj_Ingresos_Client = new CatalogosMantenimientosClient();
            string sMsjError = string.Empty;
            Obj_Ingresos_Client.Insertar_Detalle_Factura(Obj_Ingreso_Dal.sIdPersona, Obj_Ingreso_Dal.fCosto, Obj_Ingreso_Dal.bIdTipoServicio, Obj_Ingreso_Dal.fTotal, ref sMsjError);
        }

        public void Invitado_Beneficiario(ref Cls_Ingreso_DAL Obj_Ingreso_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Ingresos_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Ingreso_DAL.DI.Tables.Add(Obj_Ingresos_Client.Invitado_Beneficiario(Obj_Ingreso_DAL.sIdPersona, ref sMsjError));
                Obj_Ingresos_Client.Close();
                Obj_Ingreso_DAL.sMsj_error = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Ingreso_DAL.sMsj_error = ex.Message.ToString();
            }
        }
    }
}
