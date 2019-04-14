using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubCampestre_DAL.CatalogosMantenimientos;
using System.Security.Cryptography;
using System.IO;

namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public class Cls_Usuario_BLL
    {
        public byte[] Clave = Encoding.ASCII.GetBytes("Tu Clave");
        public byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

        public void Encripta(ref Cls_Usuarios_DAL Obj_Usuario_DAL)
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

        public void Desencripta(ref Cls_Usuarios_DAL Obj_Usuario_DAL)
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
    }
}
