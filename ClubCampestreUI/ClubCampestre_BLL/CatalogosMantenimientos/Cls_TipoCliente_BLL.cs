using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_TipoCliente_BLL
    {
        public void crudTipoCliente(ref Cls_TipoCliente_DAL Obj_TipoCliente_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_TipoCliente_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_TipoCliente_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_TipoCliente_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_TipoCliente_Client.actualizarTipoCliente(Obj_TipoCliente_DAL.BIdTipoCliente, Obj_TipoCliente_DAL.sDescripcion, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_TipoCliente_Client.eliminarTipoCliente(Obj_TipoCliente_DAL.BIdTipoCliente, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_TipoCliente_DAL.DS.Tables.Add(Obj_TipoCliente_Client.filtrarTipoCliente(Obj_TipoCliente_DAL.BIdTipoCliente, Obj_TipoCliente_DAL.sDescripcion, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_TipoCliente_Client.insertarTipoCliente(Obj_TipoCliente_DAL.BIdTipoCliente, Obj_TipoCliente_DAL.sDescripcion, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_TipoCliente_DAL.DS.Tables.Add(Obj_TipoCliente_Client.listarTipoCliente(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_TipoCliente_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoCliente_DAL.SMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_TipoCliente_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_TipoCliente_Client.Close();
                }
            }
        }
    }
}
