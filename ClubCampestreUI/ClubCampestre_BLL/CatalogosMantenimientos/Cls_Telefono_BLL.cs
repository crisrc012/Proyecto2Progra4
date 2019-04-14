using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;


namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Telefono_BLL
    {
        public void Listar(ref Cls_Telefonos_DAL Obj_Telefonos_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Telefono_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Telefonos_DAL.DS.Tables.Add(Obj_Telefono_Client.listarTelefonos(ref sMsjError));
                Obj_Telefono_Client.Close();
                Obj_Telefonos_DAL.SMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Telefonos_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar(ref Cls_Telefonos_DAL Obj_Telefonos_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Telefono_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Telefonos_DAL.DS.Tables.Add(Obj_Telefono_Client.filtrarTelefonos(Obj_Telefonos_DAL.STelefono ,Obj_Telefonos_DAL.SIdPersona, ref sMsjError));
                Obj_Telefono_Client.Close();
                Obj_Telefonos_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Telefonos_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Insertar(ref Cls_Telefonos_DAL Obj_Telefonos_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Telefonos_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_Telefonos_Client.insertarTelefonos(Obj_Telefonos_DAL.STelefono,Obj_Telefonos_DAL.SIdPersona, ref sMsjError);
                Obj_Telefonos_Client.Close();
                Obj_Telefonos_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Telefonos_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Actualizar(ref Cls_Telefonos_DAL Obj_Telefonos_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Telefonos_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                Obj_Telefonos_Client.actualizarTelefonos(Obj_Telefonos_DAL.STelefono, Obj_Telefonos_DAL.SIdPersona, ref sMsjError);
                Obj_Telefonos_Client.Close();
                Obj_Telefonos_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Telefonos_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Eliminar(ref Cls_Telefonos_DAL Obj_Telefonos_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Telefonos_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                Obj_Telefonos_Client.eliminarTelefonos(Obj_Telefonos_DAL.SIdPersona, ref sMsjError);
                Obj_Telefonos_Client.Close();
                Obj_Telefonos_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Telefonos_DAL.SMsjError = ex.Message.ToString();
            }
        }
    }
}
