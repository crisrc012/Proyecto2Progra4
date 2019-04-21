using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Membresias_BLL
    {
        public void crudMembresias(ref Cls_Membresias_DAL Obj_Membresias_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_Membresias_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_Membresias_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_Membresias_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_Membresias_Client.actualizarMemebresias(Obj_Membresias_DAL.iIdMembresia, Obj_Membresias_DAL.SPKIdCliente, Obj_Membresias_DAL.BFKIdTipoMembresia, Obj_Membresias_DAL.CFKIdEstado, Obj_Membresias_DAL.dFechaInicio, Obj_Membresias_DAL.dFechaVence, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_Membresias_Client.eliminarMemebresias(Obj_Membresias_DAL.iIdMembresia, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_Membresias_DAL.DS.Tables.Add(Obj_Membresias_Client.filtrarMemebresias(Obj_Membresias_DAL.iIdMembresia, Obj_Membresias_DAL.SPKIdCliente, Obj_Membresias_DAL.BFKIdTipoMembresia, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_Membresias_Client.insertarMemebresias(Obj_Membresias_DAL.SPKIdCliente, Obj_Membresias_DAL.BFKIdTipoMembresia, Obj_Membresias_DAL.CFKIdEstado, Obj_Membresias_DAL.dFechaInicio, Obj_Membresias_DAL.dFechaVence, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_Membresias_DAL.DS.Tables.Add(Obj_Membresias_Client.listarMemebresias(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_Membresias_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Membresias_DAL.SMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_Membresias_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_Membresias_Client.Close();
                }
            }
        }
    }
}