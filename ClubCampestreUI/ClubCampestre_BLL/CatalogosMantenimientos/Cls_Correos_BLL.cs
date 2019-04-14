using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Correos_BLL
    {
        public void Listar(ref Cls_Correos_DAL Obj_Correos_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Correos_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Correos_DAL.DS.Tables.Add(Obj_Correos_Client.listarCorreos(ref sMsjError));
                Obj_Correos_Client.Close();
                Obj_Correos_DAL.SMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Correos_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar(ref Cls_Correos_DAL Obj_Correos_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Correos_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Correos_DAL.DS.Tables.Add(Obj_Correos_Client.filtrarCorreos(Obj_Correos_DAL.SIdCorreo, Obj_Correos_DAL.SIdPersona, Obj_Correos_DAL.SCorreo, ref sMsjError));
                Obj_Correos_Client.Close();
                Obj_Correos_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Correos_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Insertar(ref Cls_Correos_DAL Obj_Correos_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Correos_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_Correos_Client.insertarCorreos(Obj_Correos_DAL.SIdPersona, Obj_Correos_DAL.SCorreo, ref sMsjError);
                Obj_Correos_Client.Close();
                Obj_Correos_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Correos_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Actualizar(ref Cls_Correos_DAL Obj_Correos_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Correos_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                Obj_Correos_Client.actualizarCorreos(Obj_Correos_DAL.SIdCorreo, Obj_Correos_DAL.SIdPersona, Obj_Correos_DAL.SCorreo, ref sMsjError);
                Obj_Correos_Client.Close();
                Obj_Correos_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Correos_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Eliminar(ref Cls_Correos_DAL Obj_Correos_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Correos_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                Obj_Correos_Client.eliminarCorreos(Obj_Correos_DAL.SIdCorreo, ref sMsjError);
                Obj_Correos_Client.Close();
                Obj_Correos_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Correos_DAL.SMsjError = ex.Message.ToString();
            }
        }
    }
}
