using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Beneficiarios_BLL
    {
        public void crudBeneficiarios(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_Beneficiarios_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_Beneficiarios_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_Beneficiarios_Client.actualizarBeneficiarios(Obj_Beneficiarios_DAL.sIdBeneficiario, Obj_Beneficiarios_DAL.sIdCliente, Obj_Beneficiarios_DAL.sIdPersona, Obj_Beneficiarios_DAL.cIdEstado, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_Beneficiarios_Client.eliminarBeneficiarios(Obj_Beneficiarios_DAL.sIdCliente, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_Beneficiarios_DAL.DS.Tables.Add(Obj_Beneficiarios_Client.filtrarBeneficiarios(Obj_Beneficiarios_DAL.sIdBeneficiario, Obj_Beneficiarios_DAL.sIdCliente, Obj_Beneficiarios_DAL.sIdPersona, Obj_Beneficiarios_DAL.cIdEstado, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_Beneficiarios_Client.insertarBeneficiarios(Obj_Beneficiarios_DAL.sIdBeneficiario, Obj_Beneficiarios_DAL.sIdCliente, Obj_Beneficiarios_DAL.sIdPersona, Obj_Beneficiarios_DAL.cIdEstado, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_Beneficiarios_DAL.DS.Tables.Add(Obj_Beneficiarios_Client.listarBeneficiarios(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_Beneficiarios_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Beneficiarios_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_Beneficiarios_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_Beneficiarios_Client.Close();
                }

            }
        }
    }
}
