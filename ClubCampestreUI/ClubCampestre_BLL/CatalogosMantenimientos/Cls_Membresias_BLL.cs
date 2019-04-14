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
                CatalogosMantenimientosClient Obj_Estado_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                //Obj_Membresia_DAL.DS.Tables.Add(Obj_Estado_Client.listarMembresias(ref sMsjError));
                //Obj_Membresia_DAL.Close();
                Obj_Membresia_DAL.sMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Membresia_DAL.sMsjError = ex.Message.ToString();
            }
        }
    }
}
