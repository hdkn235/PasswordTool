using System;
using System.Collections.Generic;
using System.Text;

namespace DataEncrypt
{
    /// <summary>
    /// 使用伪随机数加密技术加密用户及密码
    /// </summary>
    public class PRanDataEncrypt : EncryptSuper
    {
        //使用加密方法得到加密后的字符串
        public override string GetEncryptStr(string encryptStr)
        {
            byte[] btData = Encoding.Default.GetBytes(encryptStr);
            int j, k, m;
            int len = randStr.Length;
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < btData.Length; i++)
            {
                j = (byte)rand.Next(6);
                btData[i] = (byte)((int)btData[i] ^ j);
                k = (int)btData[i] % len;
                m = (int)btData[i] / len;
                m = m * 8 + j;
                sb.Append(randStr.Substring(k, 1) + randStr.Substring(m, 1));
            }
            return sb.ToString();
        }

        //使用解密算法得到解密后的字符串
        public override string GetDecryptStr(string decryptStr)
        {
            int j, k, m, n = 0;
            int len = randStr.Length;
            byte[] btData = new byte[decryptStr.Length / 2];
            for (int i = 0; i < decryptStr.Length; i += 2)
            {
                k = randStr.IndexOf(decryptStr[i]);
                m = randStr.IndexOf(decryptStr[i + 1]);
                j = m / 8;
                m = m - j * 8;
                btData[n] = (byte)(j * len + k);
                btData[n] = (byte)((int)btData[n] ^ m);
                n++;
            }
            return Encoding.Default.GetString(btData);
        }
    }
}
