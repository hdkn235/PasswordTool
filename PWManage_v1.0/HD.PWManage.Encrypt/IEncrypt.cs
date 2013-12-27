using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.PWManage.Encrypt
{
    public interface IEncrypt
    {
        //加密方法的名字
        string Name { get; }

        //使用加密方法得到加密后的字符串
        string GetEncryptStr(string encryptStr);

        //使用解密算法得到解密后的字符串
        string GetDecryptStr(string decryptStr);
    }
}
