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
                CatalogosMantenimientosClient Obj_Estado_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                //Obj_Rol_DAL.DS.Tables.Add(Obj_Estado_Client.listarRoles(ref sMsjError));
                Obj_Estado_Client.Close();
                Obj_Rol_DAL.sMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Rol_DAL.sMsjError = ex.Message.ToString();
            }

        }

        public void Filtrar(ref Cls_Rol_DAL Obj_Rol_DAL)
        {

        }

        public void Insertar(ref Cls_Rol_DAL Obj_Rol_DAL)
        {

        }

        public void Actualizar(ref Cls_Rol_DAL Obj_Rol_DAL)
        {

        }
        public void Eliminar(ref Cls_Rol_DAL Obj_Rol_DAL)
        {

        }
    }
}
