using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;


namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Telefono_BLL
    {
        public void crudTelefono(ref Cls_Telefonos_DAL Obj_Telefonos_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_Telefonos_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_Telefonos_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_Telefono_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_Telefonos_Client.actualizarTelefonos(Obj_Telefonos_DAL.sTelefono, Obj_Telefonos_DAL.sIdPersona, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_Telefonos_Client.eliminarTelefonos(Obj_Telefonos_DAL.sIdPersona, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_Telefonos_DAL.DS.Tables.Add(Obj_Telefonos_Client.filtrarTelefonos(Obj_Telefonos_DAL.sTelefono, Obj_Telefonos_DAL.sIdPersona, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_Telefonos_Client.insertarTelefonos(Obj_Telefonos_DAL.sTelefono, Obj_Telefonos_DAL.sIdPersona, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_Telefonos_DAL.DS.Tables.Add(Obj_Telefonos_Client.listarTelefonos(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_Telefonos_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Telefonos_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_Telefonos_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_Telefonos_Client.Close();
                }
            }
        }
    }
}
