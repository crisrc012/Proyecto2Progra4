using ClubCampestre_BLL.SVC_CatalogosMantenimientos;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Usuario_BLL
    {
        private byte[] Clave = Encoding.ASCII.GetBytes("Tu Clave");
        private byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

        public void Encripta(ref Cls_Usuario_DAL Obj_Usuario_DAL)
        {
            try
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(Obj_Usuario_DAL.SContrasena);
                byte[] encripted;
                RijndaelManaged cripto = new RijndaelManaged();
                using (MemoryStream ms = new MemoryStream(inputBytes.Length))
                {
                    using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateEncryptor(Clave, IV), CryptoStreamMode.Write))
                    {
                        objCryptoStream.Write(inputBytes, 0, inputBytes.Length);
                        objCryptoStream.FlushFinalBlock();
                        objCryptoStream.Close();
                    }
                    encripted = ms.ToArray();
                }
                Obj_Usuario_DAL.SContrasena = Convert.ToBase64String(encripted);
                Obj_Usuario_DAL.sMsjError = string.Empty;
            }
            catch (Exception ex)
            {
                Obj_Usuario_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Desencripta(ref Cls_Usuario_DAL Obj_Usuario_DAL)
        {
            try
            {
                byte[] inputBytes = Convert.FromBase64String(Obj_Usuario_DAL.SContrasena);
                byte[] resultBytes = new byte[inputBytes.Length];
                RijndaelManaged cripto = new RijndaelManaged();
                using (MemoryStream ms = new MemoryStream(inputBytes))
                {
                    using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(Clave, IV), CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(objCryptoStream, true))
                        {
                            Obj_Usuario_DAL.SContrasena = sr.ReadToEnd();
                        }
                    }
                }
                Obj_Usuario_DAL.sMsjError = string.Empty;
            }
            catch (Exception ex)
            {
                Obj_Usuario_DAL.sMsjError = ex.Message.ToString();
            }
        }
        public void crudUsuario(ref Cls_Usuario_DAL Obj_Usuario_DAL, BD Accion)
        {
            // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
            CatalogosMantenimientosClient Obj_Usuario_Client = new CatalogosMantenimientosClient();
            try
            {
                // Se abre la conexion al servicio
                Obj_Usuario_Client.Open();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                string sMsjError = string.Empty;
                switch (Accion)
                {
                    case BD.Actualizar:
                        Obj_Usuario_Client.actualizarUsuario(Obj_Usuario_DAL.SIdUsuario, Obj_Usuario_DAL.SIdPersona, Obj_Usuario_DAL.SContrasena, ref sMsjError);
                        break;
                    case BD.Eliminar:
                        Obj_Usuario_Client.eliminarUsuario(Obj_Usuario_DAL.SIdUsuario, ref sMsjError);
                        break;
                    case BD.Filtrar:
                        Obj_Usuario_DAL.DS.Tables.Add(Obj_Usuario_Client.filtrarUsuario(Obj_Usuario_DAL.SIdUsuario, Obj_Usuario_DAL.SIdPersona, Obj_Usuario_DAL.SContrasena, ref sMsjError));
                        break;
                    case BD.Insertar:
                        Obj_Usuario_Client.insertarUsuario(Obj_Usuario_DAL.SIdUsuario, Obj_Usuario_DAL.SIdPersona, Obj_Usuario_DAL.SContrasena, ref sMsjError);
                        break;
                    case BD.Listar:
                        Obj_Usuario_DAL.DS.Tables.Add(Obj_Usuario_Client.listarUsuario(ref sMsjError));
                        break;
                    default:
                        break;
                }
                Obj_Usuario_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Usuario_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                if (Obj_Usuario_Client.State == System.ServiceModel.CommunicationState.Opened)
                {
                    Obj_Usuario_Client.Close();
                }
            }
        }
    }
}
