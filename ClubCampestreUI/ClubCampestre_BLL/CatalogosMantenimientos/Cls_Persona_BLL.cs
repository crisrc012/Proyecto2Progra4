using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Persona_BLL
    {
        public void crudPersona(ref Cls_Persona_DAL Obj_Persona_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_Persona_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_Persona_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_Persona_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_Persona_Client.actualizarPersona(Obj_Persona_DAL.sIdPersona, Obj_Persona_DAL.sNombre, Obj_Persona_DAL.sDireccion, Obj_Persona_DAL.bIdRol, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_Persona_Client.eliminarPersona(Obj_Persona_DAL.sIdPersona, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_Persona_DAL.DS.Tables.Add(Obj_Persona_Client.filtrarPersonaV(Obj_Persona_DAL.sIdPersona, Obj_Persona_DAL.sNombre, Obj_Persona_DAL.sDireccion, Obj_Persona_DAL.sRol, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_Persona_Client.insertarPersona(Obj_Persona_DAL.sIdPersona, Obj_Persona_DAL.sNombre, Obj_Persona_DAL.sDireccion, Obj_Persona_DAL.bIdRol, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_Persona_DAL.DS.Tables.Add(Obj_Persona_Client.listarPersona(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_Persona_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Persona_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_Persona_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_Persona_Client.Close();
                }
            }
        }
    }
}
