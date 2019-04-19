using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Membresias_BLL
    {
        public void Listar(ref Cls_Membresias_DAL Obj_Membresia_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Membresia_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Membresia_DAL.DS.Tables.Add(Obj_Membresia_Client.listarMemebresias(ref sMsjError));
                Obj_Membresia_Client.Close();
                Obj_Membresia_DAL.sMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Membresia_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar(ref Cls_Membresias_DAL Obj_Membresia_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Membresia_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Membresia_DAL.DS.Tables.Add(Obj_Membresia_Client.filtrarMemebresias(Obj_Membresia_DAL.iIdMembresia, Obj_Membresia_DAL.SPKIdCliente, Obj_Membresia_DAL.BFKIdTipoMembresia, ref sMsjError));
                Obj_Membresia_Client.Close();
                Obj_Membresia_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Membresia_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Insertar(ref Cls_Membresias_DAL Obj_Membresia_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Membresia_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_Membresia_Client.insertarMemebresias(Obj_Membresia_DAL.SPKIdCliente, Obj_Membresia_DAL.BFKIdTipoMembresia, Obj_Membresia_DAL.CFKIdEstado, Obj_Membresia_DAL.dFechaInicio, Obj_Membresia_DAL.dFechaVence, ref sMsjError);
                Obj_Membresia_Client.Close();
                Obj_Membresia_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Membresia_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Actualizar(ref Cls_Membresias_DAL Obj_Membresia_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Membresia_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                Obj_Membresia_Client.actualizarMemebresias(Obj_Membresia_DAL.iIdMembresia, Obj_Membresia_DAL.SPKIdCliente, Obj_Membresia_DAL.BFKIdTipoMembresia, Obj_Membresia_DAL.CFKIdEstado, Obj_Membresia_DAL.dFechaInicio, Obj_Membresia_DAL.dFechaVence, ref sMsjError);
                Obj_Membresia_Client.Close();
                Obj_Membresia_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Membresia_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Eliminar(ref Cls_Membresias_DAL Obj_Membresia_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Membresia_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                Obj_Membresia_Client.eliminarMemebresias(Obj_Membresia_DAL.iIdMembresia, ref sMsjError);
                Obj_Membresia_Client.Close();
                Obj_Membresia_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Membresia_DAL.sMsjError = ex.Message.ToString();
            }
        }
    }
}
