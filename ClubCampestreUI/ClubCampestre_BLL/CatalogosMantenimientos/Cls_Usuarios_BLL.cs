using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.Data;

namespace ClubCampestre_BLL
{
    class Cls_Usuarios_BLL
    {
        public void Listar(ref Cls_Usuarios_DAL Obj_Usuarios_DAL)
        {
            try
            {
                //Se instancia el Objeto de CatalogoManteniemientosClient(WCF)
                CatalogosMantenimientosClient Obj_Usuarios_Client = new CatalogosMantenimientosClient();
                //Se carga trae el DT y carga el objeto al Obj_Usuarios_DAL
                string sMsjError = string.Empty;
                Obj_Usuarios_DAL.DS.Tables.Add(Obj_Usuarios_Client.listarUsuario(ref sMsjError));
                Obj_Usuarios_Client.Close();
                Obj_Usuarios_DAL.sMsjError = sMsjError;
            }
            catch(Exception ex)
            {
                Obj_Usuarios_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Filtrar(ref Cls_Usuarios_DAL Obj_Usuarios_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Usuarios_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Usuarios_DAL.DS.Tables.Add(Obj_Usuarios_Client.filtrarUsuario(Obj_Usuarios_DAL.SIdUsuario, Obj_Usuarios_DAL.SIdPersona, Obj_Usuarios_DAL.SContrasena, ref sMsjError));
                Obj_Usuarios_Client.Close();
                Obj_Usuarios_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Usuarios_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Insertar(ref Cls_Usuarios_DAL Obj_Usuarios_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Usuarios_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_Usuarios_Client.insertarUsuario(Obj_Usuarios_DAL.SIdUsuario, Obj_Usuarios_DAL.SIdPersona, Obj_Usuarios_DAL.SContrasena, ref sMsjError);
                Obj_Usuarios_Client.Close();
                Obj_Usuarios_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Usuarios_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Actualizar(ref Cls_Usuarios_DAL Obj_Usuarios_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Usuarios_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                Obj_Usuarios_Client.actualizarUsuario(Obj_Usuarios_DAL.SIdUsuario, Obj_Usuarios_DAL.SIdPersona, Obj_Usuarios_DAL.SContrasena, ref sMsjError);
                Obj_Usuarios_Client.Close();
                Obj_Usuarios_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Usuarios_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Eliminar(ref Cls_Usuarios_DAL Obj_Usuarios_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Usuarios_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                Obj_Usuarios_Client.eliminarEstado(Convert.ToChar(Obj_Usuarios_DAL.SIdUsuario), ref sMsjError);
                Obj_Usuarios_Client.Close();
                Obj_Usuarios_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Usuarios_DAL.sMsjError = ex.Message.ToString();
            }
        }

    }
}
