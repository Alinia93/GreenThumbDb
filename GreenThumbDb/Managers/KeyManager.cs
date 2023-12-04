using System;
using System.IO;
using System.Security.Cryptography;

namespace GreenThumbDb.Managers
{
    public static class KeyManager
    {
        public static string GetEncryptionKey()
        {
            if (File.Exists("key.txt"))
            {
                return File.ReadAllText("C:\\Users\\alini\\OneDrive\\Skrivbord\\Ny mapp(2)\\key.txt");
            }
            else
            {
                string encryptionKey = GenerateEncryptionKey();
                File.WriteAllText("key.txt", encryptionKey);
                return null;
            }
        }



        public static string GenerateEncryptionKey()
        {
            var rng = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            rng.GetBytes(byteArray);
            return Convert.ToBase64String(byteArray);
        }
    }
}

