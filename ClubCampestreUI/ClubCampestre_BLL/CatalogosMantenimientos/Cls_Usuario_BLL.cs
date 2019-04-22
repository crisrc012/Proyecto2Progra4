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
        public byte[] Clave = Encoding.ASCII.GetBytes("Tu Clave");
        public byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

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
        public void Listar(ref Cls_Usuario_DAL Obj_Usuario_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Usuario_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable y se carga al Obj_Estado_DAL
                String sMsjError = string.Empty;
                Obj_Usuario_DAL.DS.Tables.Add(Obj_Usuario_Client.listarUsuario(ref sMsjError));
                Obj_Usuario_Client.Close();

                Obj_Usuario_DAL.sMsjError = sMsjError;


            }
            catch (Exception ex)
            {
                Obj_Usuario_DAL.sMsjError = ex.Message.ToString();
            }
        }


        public void Filtrar(ref Cls_Usuario_DAL Obj_Usuario_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Usuario_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable
                string sMsjError = string.Empty;
                Obj_Usuario_DAL.DS.Tables.Add(Obj_Usuario_Client.filtrarUsuario(Obj_Usuario_DAL.SIdUsuario, Obj_Usuario_DAL.SIdPersona, Obj_Usuario_DAL.SContrasena, ref sMsjError));
                Obj_Usuario_Client.Close();
                Obj_Usuario_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Usuario_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Insertar(ref Cls_Usuario_DAL Obj_Usuario_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Usuario_Client = new CatalogosMantenimientosClient();
                // Se mandan a insertar los datos
                string sMsjError = string.Empty;
                Obj_Usuario_Client.insertarUsuario(Obj_Usuario_DAL.SIdUsuario, Obj_Usuario_DAL.SIdPersona, Obj_Usuario_DAL.SContrasena, ref sMsjError);
                Obj_Usuario_Client.Close();
                Obj_Usuario_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Usuario_DAL.sMsjError = ex.Message.ToString();
            }
        }


        public void Actualizar(ref Cls_Usuario_DAL Obj_Usuario_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Usuario_Client = new CatalogosMantenimientosClient();
                // Se mandan a actualizar los datos
                string sMsjError = string.Empty;

                Obj_Usuario_Client.actualizarUsuario(Obj_Usuario_DAL.SIdUsuario, Obj_Usuario_DAL.SIdPersona, Obj_Usuario_DAL.SContrasena, ref sMsjError);
                Obj_Usuario_Client.Close();
                Obj_Usuario_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Usuario_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Eliminar(ref Cls_Usuario_DAL Obj_Usuario_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Usuario_Client = new CatalogosMantenimientosClient();
                // Se manda a eliminar el dato
                string sMsjError = string.Empty;

                Obj_Usuario_Client.eliminarUsuario(Obj_Usuario_DAL.SIdUsuario, ref sMsjError);
                Obj_Usuario_Client.Close();
                Obj_Usuario_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Usuario_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void Login(ref Cls_Usuario_DAL Obj_Usuario_DAL)
        {
            try
            {
                // Se instancia el Objeto de CatalogosMantenimientosClient (WCF)
                CatalogosMantenimientosClient Obj_Usuario_Client = new CatalogosMantenimientosClient();
                // Se cargan trae el DataTable
                string sMsjError = string.Empty;
                Obj_Usuario_DAL.DS.Tables.Add(Obj_Usuario_Client.Login(Obj_Usuario_DAL.SIdPersona, Obj_Usuario_DAL.SContrasena, ref sMsjError));
                Obj_Usuario_Client.Close();
                Obj_Usuario_DAL.sMsjError = sMsjError;
            }
            catch (Exception ex)
            {
                Obj_Usuario_DAL.sMsjError = ex.Message.ToString();
            }
        }


    }
}
