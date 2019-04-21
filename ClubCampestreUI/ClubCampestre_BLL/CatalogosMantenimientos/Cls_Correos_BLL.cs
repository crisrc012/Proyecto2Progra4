using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Correos_BLL
    {
        public void crudCorreos(ref Cls_Correos_DAL Obj_Correos_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_Correos_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_Correos_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_Correos_Client.actualizarCorreos(Obj_Correos_DAL.SIdCorreo, Obj_Correos_DAL.SIdPersona, Obj_Correos_DAL.SCorreo, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_Correos_Client.eliminarCorreos(Obj_Correos_DAL.SIdCorreo, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_Correos_DAL.DS.Tables.Add(Obj_Correos_Client.filtrarCorreos(Obj_Correos_DAL.SIdCorreo, Obj_Correos_DAL.SIdPersona, Obj_Correos_DAL.SCorreo, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_Correos_Client.insertarCorreos(Obj_Correos_DAL.SIdPersona, Obj_Correos_DAL.SCorreo, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_Correos_DAL.DS.Tables.Add(Obj_Correos_Client.listarCorreos(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_Correos_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Correos_DAL.SMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_Correos_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_Correos_Client.Close();
                }

            }
        }
    }
}
