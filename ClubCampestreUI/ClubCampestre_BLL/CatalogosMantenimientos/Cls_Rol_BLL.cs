using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Rol_BLL
    {
        public void Listar(ref Cls_Rol_DAL Obj_Rol_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Rol_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                //Obj_Rol_DAL.DS.Tables.Add(Obj_Estado_Client.listarRoles(ref SMsjError));
                Obj_Rol_DAL.DS.Tables.Add(Obj_Rol_Client.listarRol(ref sMsjError));
                Obj_Rol_Client.Close();
                Obj_Rol_DAL.sMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Rol_DAL.sMsjError = ex.Message.ToString();
            }

        }

        public void Filtrar(ref Cls_Rol_DAL Obj_Rol_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Rol_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Rol_DAL.DS.Tables.Add(Obj_Rol_Client.filtrarRol(Obj_Rol_DAL.bIdRol,Obj_Rol_DAL.sDescripcion, ref sMsjError));
                Obj_Rol_Client.Close();
                Obj_Rol_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Rol_DAL.sMsjError = ex.Message.ToString();
            }

        }

        public void Insertar(ref Cls_Rol_DAL Obj_Rol_DAL)
        {

            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Rol_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                
                Obj_Rol_Client.insertarRol(Obj_Rol_DAL.sDescripcion, ref sMsjError); // Aqui se devuelve un valor scalar, sino se va a usar, hay que mejor mandarlo a usar nonquery
                Obj_Rol_Client.Close();
                Obj_Rol_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Rol_DAL.sMsjError = ex.Message.ToString();
            }

        }

        public void Actualizar(ref Cls_Rol_DAL Obj_Rol_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Rol_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                //Obj_Rol_Client.actualizarRol(Obj_Rol_DAL.CIdEstado, Obj_Estado_DAL.SEstado, ref SMsjError);
                Obj_Rol_Client.actualizarRol(Obj_Rol_DAL.bIdRol, Obj_Rol_DAL.sDescripcion, ref sMsjError);
                Obj_Rol_Client.Close();
                Obj_Rol_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Rol_DAL.sMsjError = ex.Message.ToString();
            }

        }
        public void Eliminar(ref Cls_Rol_DAL Obj_Rol_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Rol_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                //Obj_Estado_Client.eliminarEstado(Obj_Estado_DAL.CIdEstado, ref SMsjError);
                Obj_Rol_Client.eliminarRol(Obj_Rol_DAL.bIdRol, ref sMsjError);
                Obj_Rol_Client.Close();
                Obj_Rol_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Rol_DAL.sMsjError = ex.Message.ToString();
            }

        }
    }
}
