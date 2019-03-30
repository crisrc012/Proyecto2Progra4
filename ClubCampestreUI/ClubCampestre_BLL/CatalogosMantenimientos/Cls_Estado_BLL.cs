using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubCampestre_DAL.CatalogosMantenimientos;
using ClubCampestre_BLL.SVC_CatalogosMantenimientos;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Estado_BLL
    {
        public void listarEstado(ref Cls_Estado_DAL Obj_Estado_DAL)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_Estado_Client = new CatalogosMantenimientosClient();
            // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
            Obj_Estado_DAL.DS.Tables.Add(Obj_Estado_Client.listarEstado().Copy());
        }
    }
}
