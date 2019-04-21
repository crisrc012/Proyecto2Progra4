using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Beneficiarios_BLL
    {
        private void crudBeneficiarios(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL, BD Accion)
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
                        Obj_Beneficiarios_Client.actualizarBeneficiarios(Obj_Beneficiarios_DAL.SIdBeneficiario, Obj_Beneficiarios_DAL.SIdCliente, Obj_Beneficiarios_DAL.SIdPersona, Obj_Beneficiarios_DAL.CIdEstado, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_Beneficiarios_Client.eliminarBeneficiarios(Obj_Beneficiarios_DAL.SIdCliente, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_Beneficiarios_DAL.DS.Tables.Add(Obj_Beneficiarios_Client.filtrarBeneficiarios(Obj_Beneficiarios_DAL.SIdBeneficiario, Obj_Beneficiarios_DAL.SIdCliente, Obj_Beneficiarios_DAL.SIdPersona, Obj_Beneficiarios_DAL.CIdEstado, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_Beneficiarios_Client.insertarBeneficiarios(Obj_Beneficiarios_DAL.SIdBeneficiario, Obj_Beneficiarios_DAL.SIdCliente, Obj_Beneficiarios_DAL.SIdPersona, Obj_Beneficiarios_DAL.CIdEstado, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_Beneficiarios_DAL.DS.Tables.Add(Obj_Beneficiarios_Client.listarBeneficiarios(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_Beneficiarios_DAL.SMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Beneficiarios_DAL.SMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_Beneficiarios_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_Beneficiarios_Client.Close();
                }

            }
        }
        public void Listar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            crudBeneficiarios(ref Obj_Beneficiarios_DAL, BD.Listar);
        }
        public void Filtrar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            crudBeneficiarios(ref Obj_Beneficiarios_DAL, BD.Filtrar);
        }
        public void Insertar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            crudBeneficiarios(ref Obj_Beneficiarios_DAL, BD.Insertar);
        }
        public void Actualizar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            crudBeneficiarios(ref Obj_Beneficiarios_DAL, BD.Actualizar);
        }
        public void Eliminar(ref Cls_Beneficiarios_DAL Obj_Beneficiarios_DAL)
        {
            crudBeneficiarios(ref Obj_Beneficiarios_DAL, BD.Eliminar);
        }
    }
}
