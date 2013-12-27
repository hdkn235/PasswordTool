using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.PWManage.Encrypt
{
    /// <summary>
    /// 伪随机数加密
    /// </summary>
    public class PRanEncrypt : IEncrypt
    {
        //定义加密用户密码所用的伪随机数
        private static readonly string randStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";

        #region IEncrypt 成员

        public string GetEncryptStr(string encryptStr)
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

        public string GetDecryptStr(string decryptStr)
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

        public string Name
        {
            get { return "1"; }
        }

        #endregion
    }
}
