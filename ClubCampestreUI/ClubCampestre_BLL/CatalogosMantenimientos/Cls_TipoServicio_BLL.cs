using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_TipoServicio_BLL
    {
        public void crudTipoServicio(ref Cls_TipoServicio_DAL Obj_TipoServicio_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_TipoServicio_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_TipoServicio_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_TipoServicio_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_TipoServicio_Client.actualizarTipoServicio(Obj_TipoServicio_DAL.BIdTipoServicio, Obj_TipoServicio_DAL.SPKDescripcion, Obj_TipoServicio_DAL.Fcosto, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_TipoServicio_Client.eliminarTipoServicio(Obj_TipoServicio_DAL.BIdTipoServicio, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_TipoServicio_DAL.DS.Tables.Add(Obj_TipoServicio_Client.filtrarTipoServicio(Obj_TipoServicio_DAL.BIdTipoServicio, Obj_TipoServicio_DAL.SPKDescripcion, Obj_TipoServicio_DAL.Fcosto, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_TipoServicio_Client.insertarTipoServicio(Obj_TipoServicio_DAL.SPKDescripcion, Obj_TipoServicio_DAL.Fcosto, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_TipoServicio_DAL.DS.Tables.Add(Obj_TipoServicio_Client.listarTipoServicio(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_TipoServicio_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoServicio_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_TipoServicio_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_TipoServicio_Client.Close();
                }
            }
        }
    }
}
