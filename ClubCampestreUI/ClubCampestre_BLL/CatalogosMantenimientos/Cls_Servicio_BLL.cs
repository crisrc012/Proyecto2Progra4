using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Servicio_BLL
    {
        public void crudServicio(ref Cls_Servicio_DAL Obj_Servicio_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_Servicio_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_Servicio_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_Servicio_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_Servicio_Client.actualizarServicio(Obj_Servicio_DAL.SIdServicio, Obj_Servicio_DAL.SIdCliente, Obj_Servicio_DAL.CIdEstado, Obj_Servicio_DAL.BIdTipoServicio, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_Servicio_Client.eliminarServicio(Obj_Servicio_DAL.SIdServicio, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_Servicio_DAL.DS.Tables.Add(Obj_Servicio_Client.filtrarServicio(Obj_Servicio_DAL.SIdServicio, Obj_Servicio_DAL.SIdCliente, Obj_Servicio_DAL.CIdEstado, Obj_Servicio_DAL.BIdTipoServicio, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_Servicio_Client.insertarServicio(Obj_Servicio_DAL.SIdCliente, Obj_Servicio_DAL.CIdEstado, Obj_Servicio_DAL.BIdTipoServicio, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_Servicio_DAL.DS.Tables.Add(Obj_Servicio_Client.listarServicio(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_Servicio_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Servicio_DAL.SMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_Servicio_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_Servicio_Client.Close();
                }
            }
        }
    }
}
