using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Estado_BLL
    {
        public void crudEstado(ref Cls_Estado_DAL Obj_Estado_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_Estado_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_Estado_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_Estado_Client.actualizarEstado(Obj_Estado_DAL.CIdEstado, Obj_Estado_DAL.SEstado, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_Estado_Client.eliminarEstado(Obj_Estado_DAL.CIdEstado, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_Estado_DAL.DS.Tables.Add(Obj_Estado_Client.filtrarEstado(Obj_Estado_DAL.CIdEstado, Obj_Estado_DAL.SEstado, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_Estado_Client.insertarEstado(Obj_Estado_DAL.CIdEstado, Obj_Estado_DAL.SEstado, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_Estado_DAL.DS.Tables.Add(Obj_Estado_Client.listarEstado(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_Estado_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Estado_DAL.SMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_Estado_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_Estado_Client.Close();
                }
            }
        }
    }
}
