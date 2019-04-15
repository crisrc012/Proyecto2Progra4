using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_TipoServicio_BLL
    {
        public void Listar(ref Cls_TipoServicio_DAL Obj_TipoServicio_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoServicio_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                String sMsjError = string.Empty;
                Obj_TipoServicio_DAL.DS.Tables.Add(Obj_TipoServicio_Client.listarTipoServicio(ref sMsjError));
                Obj_TipoServicio_Client.Close();

            Obj_TipoServicio_DAL.sMsjError = sMsjError;


        }
            catch (Exception ex)
            {
                Obj_TipoServicio_DAL.sMsjError= ex.Message.ToString();
            }
        }
        public void Filtrar(ref Cls_TipoServicio_DAL  Obj_TipoServicio_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoServicio_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                //Obj_TipoServicio_DAL.DS.Tables.Add(Obj_TipoServicio_Client.filtrarEstado(Obj_TipoServicio_DAL.CIdEstado, Obj_TipoServicio_DAL.SEstado, ref sMsjError));
                Obj_TipoServicio_DAL.DS.Tables.Add(Obj_TipoServicio_Client.filtrarTipoServicio(Obj_TipoServicio_DAL.BIdTipoServicio, Obj_TipoServicio_DAL.SPKDescripcion, Obj_TipoServicio_DAL.Fcosto, ref sMsjError));
                Obj_TipoServicio_Client.Close();
                Obj_TipoServicio_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoServicio_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Insertar(ref Cls_TipoServicio_DAL Obj_TipoServicio_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoServicio_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_TipoServicio_Client.insertarTipoServicio(Obj_TipoServicio_DAL.SPKDescripcion, Obj_TipoServicio_DAL.Fcosto, ref sMsjError);
                Obj_TipoServicio_Client.Close();
                Obj_TipoServicio_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoServicio_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Actualizar(ref Cls_TipoServicio_DAL Obj_TipoServicio_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoServicio_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                
                Obj_TipoServicio_Client.actualizarTipoServicio(Obj_TipoServicio_DAL.BIdTipoServicio, Obj_TipoServicio_DAL.SPKDescripcion, Obj_TipoServicio_DAL.Fcosto, ref sMsjError);
                Obj_TipoServicio_Client.Close();
                Obj_TipoServicio_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoServicio_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Eliminar(ref Cls_TipoServicio_DAL Obj_TipoServicio_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoServicio_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                
                Obj_TipoServicio_Client.eliminarTipoServicio(Obj_TipoServicio_DAL.BIdTipoServicio, ref sMsjError);
                Obj_TipoServicio_Client.Close();
                Obj_TipoServicio_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoServicio_DAL.sMsjError = ex.Message.ToString();
            }
        }
    }
}
