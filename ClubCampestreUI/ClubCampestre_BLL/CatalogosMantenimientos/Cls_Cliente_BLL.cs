using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Cliente_BLL
    {
        public void Listar(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Clientes_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Clientes_DAL.DS.Tables.Add(Obj_Clientes_Client.listarClientes(ref sMsjError));
                Obj_Clientes_Client.Close();
                Obj_Clientes_DAL.SMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Clientes_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Clientes_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Clientes_DAL.DS.Tables.Add(Obj_Clientes_Client.filtrarClientesV(Obj_Clientes_DAL.SIdCliente, string.Empty, Obj_Clientes_DAL.SIdPersona, string.Empty, string.Empty, string.Empty, ref sMsjError));
                Obj_Clientes_Client.Close();
                Obj_Clientes_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Clientes_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Insertar(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Clientes_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_Clientes_Client.insertarClientes(Obj_Clientes_DAL.SIdCliente,Obj_Clientes_DAL.BIdTipoCliente, Obj_Clientes_DAL.SIdPersona, ref sMsjError);
                Obj_Clientes_Client.Close();
                Obj_Clientes_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Clientes_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Actualizar(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Clientes_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                Obj_Clientes_Client.actualizarClientes(Obj_Clientes_DAL.SIdCliente, Obj_Clientes_DAL.BIdTipoCliente, Obj_Clientes_DAL.SIdPersona, ref sMsjError);
                Obj_Clientes_Client.Close();
                Obj_Clientes_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Clientes_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Eliminar(ref Cls_Clientes_DAL Obj_Clientes_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Clientes_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                Obj_Clientes_Client.eliminarPersona(Convert.ToString(Obj_Clientes_DAL.SIdCliente), ref sMsjError);
                Obj_Clientes_Client.Close();
                Obj_Clientes_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Clientes_DAL.SMsjError = ex.Message.ToString();
            }
        }
    }
}