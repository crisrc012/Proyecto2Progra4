using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class CLS_TipoMembresia_BLL
    {
        public void ListaTipoMembresia(ref Cls_TipoMembresia_DAL Obj_TipoMembresia_Dal)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoMembresia_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_TipoMembresia_Dal.DS.Tables.Add(Obj_TipoMembresia_Client.listarTipoMembresia(ref sMsjError));
                Obj_TipoMembresia_Client.Close();
                Obj_TipoMembresia_Dal.SMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_TipoMembresia_Dal.SMsjError = ex.Message.ToString();
            }
        }

        public void Filtrar(ref Cls_TipoMembresia_DAL Obj_TipoMembresia_Dal)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoMembresia_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_TipoMembresia_Dal.DS.Tables.Add(Obj_TipoMembresia_Client.filtrarTipoMembresia(Obj_TipoMembresia_Dal.BIdTipoMembresia, Obj_TipoMembresia_Dal.SPKDescripcion, Obj_TipoMembresia_Dal.Fcosto, ref sMsjError));
                Obj_TipoMembresia_Client.Close();
                Obj_TipoMembresia_Dal.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoMembresia_Dal.SMsjError = ex.Message.ToString();
            }
        }

        public void Actualizar(ref Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoMembresia_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                Obj_TipoMembresia_Client.actualizarTipoMembresia(Obj_TipoMembresia_DAL.BIdTipoMembresia, Obj_TipoMembresia_DAL.SPKDescripcion, Obj_TipoMembresia_DAL.Fcosto, ref sMsjError);
                Obj_TipoMembresia_Client.Close();
                Obj_TipoMembresia_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoMembresia_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Insertar(ref Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoMembresia_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_TipoMembresia_Client.insertarTipoMembresia( Obj_TipoMembresia_DAL.SPKDescripcion, Obj_TipoMembresia_DAL.Fcosto, ref sMsjError);
                Obj_TipoMembresia_Client.Close();
                Obj_TipoMembresia_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoMembresia_DAL.SMsjError = ex.Message.ToString();
            }
        }


        public void Eliminar(ref Cls_TipoMembresia_DAL Obj_TipoMembresia_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoMembresia_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                Obj_TipoMembresia_Client.eliminarTipoMembresia(Obj_TipoMembresia_DAL.BIdTipoMembresia, ref sMsjError);
                Obj_TipoMembresia_Client.Close();
                Obj_TipoMembresia_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoMembresia_DAL.SMsjError = ex.Message.ToString();
            }
        }

    }
}
