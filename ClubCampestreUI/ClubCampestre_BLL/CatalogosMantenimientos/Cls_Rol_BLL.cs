using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Rol_BLL
    {
        public void crudRol(ref Cls_Rol_DAL Obj_Rol_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_Rol_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_Rol_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_Rol_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_Rol_Client.actualizarRol(Obj_Rol_DAL.bIdRol, Obj_Rol_DAL.sDescripcion, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_Rol_Client.eliminarRol(Obj_Rol_DAL.bIdRol, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_Rol_DAL.DS.Tables.Add(Obj_Rol_Client.filtrarRol(Obj_Rol_DAL.bIdRol, Obj_Rol_DAL.sDescripcion, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_Rol_Client.insertarRol(Obj_Rol_DAL.sDescripcion, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_Rol_DAL.DS.Tables.Add(Obj_Rol_Client.listarRol(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_Rol_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Rol_DAL.SMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_Rol_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_Rol_Client.Close();
                }
            }
        }
    }
}
