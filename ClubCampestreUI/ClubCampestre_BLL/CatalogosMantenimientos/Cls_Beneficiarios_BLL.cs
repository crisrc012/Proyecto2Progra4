using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Beneficiarios_BLL
    {
        public void Listar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Beneficiario_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Beneficiarios_DAL.DS.Tables.Add(Obj_Beneficiario_Client.listarBeneficiarios(ref sMsjError));
                Obj_Beneficiario_Client.Close();
                Obj_Beneficiarios_DAL.SMsjError = sMsjError;

            }
            catch (Exception ex)
            {
                Obj_Beneficiarios_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Filtrar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Beneficiario_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                Obj_Beneficiarios_DAL.DS.Tables.Add(Obj_Beneficiario_Client.filtrarBeneficiarios(Obj_Beneficiarios_DAL.SIdBeneficiario, Obj_Beneficiarios_DAL.SIdCliente, Obj_Beneficiarios_DAL.SIdPersona, Obj_Beneficiarios_DAL.CIdEstado, ref sMsjError));
                Obj_Beneficiario_Client.Close();
                Obj_Beneficiarios_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Beneficiarios_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Insertar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Beneficiario_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_Beneficiario_Client.insertarBeneficiarios(Obj_Beneficiarios_DAL.SIdBeneficiario, Obj_Beneficiarios_DAL.SIdCliente, Obj_Beneficiarios_DAL.SIdPersona, Obj_Beneficiarios_DAL.CIdEstado, ref sMsjError);
                Obj_Beneficiario_Client.Close();
                Obj_Beneficiarios_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Beneficiarios_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Actualizar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Beneficiario_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;
                Obj_Beneficiario_Client.actualizarBeneficiarios(Obj_Beneficiarios_DAL.SIdBeneficiario, Obj_Beneficiarios_DAL.SIdCliente, Obj_Beneficiarios_DAL.SIdPersona, Obj_Beneficiarios_DAL.CIdEstado, ref sMsjError);
                Obj_Beneficiario_Client.Close();
                Obj_Beneficiarios_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Beneficiarios_DAL.SMsjError = ex.Message.ToString();
            }
        }
        public void Eliminar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Beneficiario_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;
                Obj_Beneficiario_Client.eliminarBeneficiarios(Obj_Beneficiarios_DAL.SIdCliente, ref sMsjError);
                Obj_Beneficiario_Client.Close();
                Obj_Beneficiarios_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Beneficiarios_DAL.SMsjError = ex.Message.ToString();
            }
        }
    }
}
