using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_TipoMembresia_BLL
    {
        public void crudTipoMembresia(ref Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_TipoMembresia_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_TipoMembresia_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_TipoMembresia_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_TipoMembresia_Client.actualizarTipoMembresia(Obj_TipoMembresia_DAL.BIdTipoMembresia, Obj_TipoMembresia_DAL.SPKDescripcion, Obj_TipoMembresia_DAL.Fcosto, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_TipoMembresia_Client.eliminarTipoMembresia(Obj_TipoMembresia_DAL.BIdTipoMembresia, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_TipoMembresia_DAL.DS.Tables.Add(Obj_TipoMembresia_Client.filtrarTipoMembresia(Obj_TipoMembresia_DAL.BIdTipoMembresia, Obj_TipoMembresia_DAL.SPKDescripcion, Obj_TipoMembresia_DAL.Fcosto, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_TipoMembresia_Client.insertarTipoMembresia(Obj_TipoMembresia_DAL.SPKDescripcion, Obj_TipoMembresia_DAL.Fcosto, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_TipoMembresia_DAL.DS.Tables.Add(Obj_TipoMembresia_Client.listarTipoMembresia(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_TipoMembresia_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoMembresia_DAL.SMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_TipoMembresia_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_TipoMembresia_Client.Close();
                }
            }
        }
    }
}
