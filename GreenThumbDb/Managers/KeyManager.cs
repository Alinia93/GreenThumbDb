namespace GreenThumbDb.Managers
{
    public static class KeyManager
    {
        //public static string GetEncryptionKey()
        //{
        //    if (File.Exists("key.txt"))
        //    {
        //        return File.ReadAllText("key.txt");
        //    }
        //    else
        //    {
        //        //string encryptionKey = GenerateEncryptionKey();
        //        //File.WriteAllText("key.txt", encryptionKey);
        //        return null;
        //    }
        //}



        //public static string GenerateEncryptionKey()
        //{
        //    var rng = new RNGCryptoServiceProvider();
        //    var byteArray = new byte[16];
        //    rng.GetBytes(byteArray);
        //    return Convert.ToBase64String(byteArray);
        //}


        //public static string DecryptKey(string encryptedPassword)
        //{
        //    string encryptionKey = GetEncryptionKey();
        //    IEncryptionProvider encryptionProvider = new GenerateEncryptionProvider(encryptionKey);
        //    return encryptionProvider.Decrypt(encryptedPassword);

        //}
    }
}

