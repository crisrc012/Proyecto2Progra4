using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Persona_BLL
    {
        public void Listar(ref Cls_Persona_DAL Obj_Persona_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Persona_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Persona_DAL.DS.Tables.Add(Obj_Persona_Client.listarPersona(ref sMsjError));
                Obj_Persona_Client.Close();
                Obj_Persona_DAL.SMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Persona_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar(ref Cls_Persona_DAL Obj_Persona_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Persona_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Persona_DAL.BIdRol = byte.MinValue;
                Obj_Persona_DAL.SDireccion = string.Empty;
                Obj_Persona_DAL.SNombre = string.Empty;
                Obj_Persona_DAL.DS.Tables.Add(Obj_Persona_Client.filtrarPersona(Obj_Persona_DAL.SIdPersona, Obj_Persona_DAL.SNombre, Obj_Persona_DAL.SDireccion, Obj_Persona_DAL.BIdRol, ref sMsjError));
                Obj_Persona_Client.Close();
                Obj_Persona_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Persona_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Insertar(ref Cls_Persona_DAL Obj_Persona_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Persona_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_Persona_Client.insertarPersona(Obj_Persona_DAL.SIdPersona, Obj_Persona_DAL.SNombre, Obj_Persona_DAL.SDireccion, Obj_Persona_DAL.BIdRol, ref sMsjError);
                Obj_Persona_Client.Close();
                Obj_Persona_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Persona_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Actualizar(ref Cls_Persona_DAL Obj_Persona_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Persona_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                Obj_Persona_Client.actualizarPersona(Obj_Persona_DAL.SIdPersona, Obj_Persona_DAL.SNombre, Obj_Persona_DAL.SDireccion, Obj_Persona_DAL.BIdRol, ref sMsjError);
                Obj_Persona_Client.Close();
                Obj_Persona_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Persona_DAL.SMsjError = ex.Message.ToString();
            }
        }

        public void Eliminar(ref Cls_Persona_DAL Obj_Persona_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Persona_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                Obj_Persona_Client.eliminarPersona(Obj_Persona_DAL.SIdPersona, ref sMsjError);
                Obj_Persona_Client.Close();
                Obj_Persona_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Persona_DAL.SMsjError = ex.Message.ToString();
            }
        }
    }
}
