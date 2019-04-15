using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Servicio_BLL
    {
        public void Listar(ref Cls_Servicio_DAL Obj_Servicio_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Servicio_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Servicio_DAL.DS.Tables.Add(Obj_Servicio_Client.listarServicio(ref sMsjError));
                Obj_Servicio_Client.Close();
                Obj_Servicio_DAL.SMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Servicio_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar(ref Cls_Servicio_DAL Obj_Servicio_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Servicio_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Servicio_DAL.DS.Tables.Add(Obj_Servicio_Client.filtrarServicio(Obj_Servicio_DAL.SIdServicio, Obj_Servicio_DAL.SIdCliente, Obj_Servicio_DAL.CIdEstado, Obj_Servicio_DAL.BIdTipoServicio, ref sMsjError));
                Obj_Servicio_Client.Close();
                Obj_Servicio_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Servicio_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Insertar(ref Cls_Servicio_DAL Obj_Servicio_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Servicio_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_Servicio_Client.insertarServicio(Obj_Servicio_DAL.SIdCliente, Obj_Servicio_DAL.CIdEstado, Obj_Servicio_DAL.BIdTipoServicio, ref sMsjError);
                Obj_Servicio_Client.Close();
                Obj_Servicio_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Servicio_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Actualizar(ref Cls_Servicio_DAL Obj_Servicio_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Servicio_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                Obj_Servicio_Client.actualizarServicio(Obj_Servicio_DAL.SIdServicio, Obj_Servicio_DAL.SIdCliente, Obj_Servicio_DAL.CIdEstado, Obj_Servicio_DAL.BIdTipoServicio, ref sMsjError);
                Obj_Servicio_Client.Close();
                Obj_Servicio_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Servicio_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Eliminar(ref Cls_Servicio_DAL Obj_Servicio_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Servicio_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                Obj_Servicio_Client.eliminarServicio(Obj_Servicio_DAL.SIdServicio, ref sMsjError);
                Obj_Servicio_Client.Close();
                Obj_Servicio_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Servicio_DAL.SMsjError = ex.Message.ToString();
            }
        }
    }
}
