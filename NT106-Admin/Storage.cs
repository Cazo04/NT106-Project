using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NT106_Admin
{
    public static class Storage
    {
        private static string filePath = Path.Combine(Application.StartupPath, "settings.dat");
        private const string KEY = "sbIZoCJ5xizVfLagvYQnuZdgLUD4DtVe";
        public static string? TempToken { get; set; }

        public static void SaveEncryptedData(string data)
        {
            TempToken = data;
            var encryptedData = EncryptString(data);
            File.WriteAllText(filePath, encryptedData);
        }

        public static string? ReadEncryptedData()
        {
            if (!File.Exists(filePath))
                return null;
            string encryptedData = File.ReadAllText(filePath);
            
            return DecryptString(encryptedData);
        }
        public static void DeleteEncryptedData()
        {
            if (File.Exists(filePath))
                File.Delete(filePath);
            TempToken = null;
        }

        private static string EncryptString(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(KEY);
                aesAlg.IV = new byte[16];

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        private static string DecryptString(string cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(KEY);
                aesAlg.IV = new byte[16];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            string decrypted = srDecrypt.ReadToEnd();
                            TempToken = decrypted;
                            return decrypted;
                        }
                    }
                }
            }
        }
    }

}
