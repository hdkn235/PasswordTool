using System;
using System.Collections.Generic;
using System.Text;

namespace DataEncrypt
{
    public abstract class EncryptSuper
    {
        //定义加密用户密码所用的伪随机数
        protected string randStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";

        //使用加密方法得到加密后的字符串
        public abstract string GetEncryptStr(string encryptStr);

        //使用解密算法得到解密后的字符串
        public abstract string GetDecryptStr(string decryptStr);
    }
}
