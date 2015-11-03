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
        /// 获取加密MD5字符串
        /// </summary>
        /// <param name="encryptStr"></param>
        /// <returns></returns>
        public static string GetMD5Str(string encryptStr)
        {
            return MD5Encrypt.GetStrMD5(MD5Encrypt.GetStrMD5(encryptStr));
        }
    }
}
