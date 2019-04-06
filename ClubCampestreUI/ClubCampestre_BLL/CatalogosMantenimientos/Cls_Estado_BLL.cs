using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Estado_BLL
    {
        public void Listar(ref Cls_Estado_DAL Obj_Estado_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Estado_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Estado_DAL.DS.Tables.Add(Obj_Estado_Client.listarEstado(ref sMsjError));
                Obj_Estado_Client.Close();
                Obj_Estado_DAL.sMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Estado_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar(ref Cls_Estado_DAL Obj_Estado_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Estado_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Estado_DAL.DS.Tables.Add(Obj_Estado_Client.filtrarEstado(Obj_Estado_DAL.CIdEstado, Obj_Estado_DAL.SEstado, ref sMsjError));
                Obj_Estado_Client.Close();
                Obj_Estado_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Estado_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Insertar(ref Cls_Estado_DAL Obj_Estado_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Estado_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_Estado_Client.insertarEstado(Obj_Estado_DAL.CIdEstado, Obj_Estado_DAL.SEstado, ref sMsjError);
                Obj_Estado_Client.Close();
                Obj_Estado_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Estado_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Actualizar(ref Cls_Estado_DAL Obj_Estado_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Estado_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                Obj_Estado_Client.actualizarEstado(Obj_Estado_DAL.CIdEstado, Obj_Estado_DAL.SEstado, ref sMsjError);
                Obj_Estado_Client.Close();
                Obj_Estado_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Estado_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Eliminar(ref Cls_Estado_DAL Obj_Estado_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Estado_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                Obj_Estado_Client.eliminarEstado(Obj_Estado_DAL.CIdEstado, ref sMsjError);
                Obj_Estado_Client.Close();
                Obj_Estado_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Estado_DAL.sMsjError = ex.Message.ToString();
            }
        }
    }
}
