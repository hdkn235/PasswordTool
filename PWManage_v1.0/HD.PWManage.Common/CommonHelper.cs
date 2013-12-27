using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace HD.PWManage.Common
{
    public class CommonHelper
    {
        /// <summary>
        /// 检查登录密码是否正确
        /// </summary>
        /// <param name="pw"></param>
        /// <returns></returns>
        public static bool CheckPw(string pw)
        {
            bool result = false;
            string encryptPwNow = GetMD5Str(GetMD5Str(pw));
            RegisterHelper rh = new RegisterHelper();

            //判断是否是第一次使用程序，若是则写入注册表初始密码123
            if (!rh.isExist(RegisterHelper.keyType.HKEY_CURRENT_USER,"user"))
            {
                rh.setValue(RegisterHelper.keyType.HKEY_CURRENT_USER, "user", "pw", GetMD5Str(GetMD5Str("123")));
            }

            string encryptPw = rh.getValue(RegisterHelper.keyType.HKEY_CURRENT_USER, "user", "pw");
            if (encryptPw == encryptPwNow)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 设置登录密码
        /// </summary>
        /// <param name="pw"></param>
        public static void SetPw(string pw)
        {
            string encryptPw = GetMD5Str(GetMD5Str(pw));
            RegisterHelper rh = new RegisterHelper();
            rh.setValue(RegisterHelper.keyType.HKEY_CURRENT_USER, "user", "pw", encryptPw);
        }

        // Hash an input string and return the hash as
        // a 32 character hexadecimal string.
        public static string GetMD5Str(string encryptStr)
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
    }
}
