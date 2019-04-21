using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Cliente_BLL
    {
        public void crudCliente(ref Cls_Clientes_DAL Obj_Clientes_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_Clientes_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_Clientes_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_Clientes_Client.actualizarClientes(Obj_Clientes_DAL.SIdCliente, Obj_Clientes_DAL.BIdTipoCliente, Obj_Clientes_DAL.SIdPersona, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_Clientes_Client.eliminarClientes(Obj_Clientes_DAL.SIdCliente, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_Clientes_DAL.DS.Tables.Add(Obj_Clientes_Client.filtrarClientes(Obj_Clientes_DAL.SIdCliente, Obj_Clientes_DAL.BIdTipoCliente, Obj_Clientes_DAL.SIdPersona, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_Clientes_Client.insertarClientes(Obj_Clientes_DAL.BIdTipoCliente, Obj_Clientes_DAL.SIdPersona, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_Clientes_DAL.DS.Tables.Add(Obj_Clientes_Client.listarClientes(ref sMsjError));
                        break;
                    case BD.FiltrarVista:
                        Obj_Clientes_DAL.DS.Tables.Add(Obj_Clientes_Client.filtrarClientesV(Obj_Clientes_DAL.SIdCliente, string.Empty, Obj_Clientes_DAL.SIdPersona, string.Empty, string.Empty, string.Empty, ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_Clientes_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Clientes_DAL.SMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_Clientes_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_Clientes_Client.Close();
                }
            }
        }
    }
}