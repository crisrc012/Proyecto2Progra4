using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
   public class Cls_TipoCliente_BLL
    {
        public void ListaClientes(ref Cls_TipoCliente_DAL Obj_TipoCliente_Dal)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoCliente_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_TipoCliente_Dal.DS.Tables.Add(Obj_TipoCliente_Client.listarTipoCliente(ref sMsjError));
                Obj_TipoCliente_Client.Close();
                Obj_TipoCliente_Dal.SMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_TipoCliente_Dal.SMsjError = ex.Message.ToString();
            }
        }

        public void Filtrar(ref Cls_TipoCliente_DAL Obj_TipoCliente_Dal)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_TipoCliente_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_TipoCliente_Dal.DS.Tables.Add(Obj_TipoCliente_Client.filtrarTipoCliente(Obj_TipoCliente_Dal.BIdTipoCliente, Obj_TipoCliente_Dal.SPKDescripcion, ref sMsjError));
                Obj_TipoCliente_Client.Close();
                Obj_TipoCliente_Dal.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_TipoCliente_Dal.SMsjError = ex.Message.ToString();
            }
        }
    }
}
