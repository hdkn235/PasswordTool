using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace DataEncrypt
{
    /// <summary>
    /// MD5加密
    /// </summary>
    public class MD5Encrypt : EncryptSuper
    {
        // Hash an input string and return the hash as
        // a 32 character hexadecimal string.
        public override string GetEncryptStr(string encryptStr)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(encryptStr));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public override string GetDecryptStr(string decryptStr)
        {
            return "";
        }
    }
}
