using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.PWManage.Encrypt;

namespace HD.PWManage.BLL
{
    public class EncryptBLL
    {
        IEncrypt encrypt = EncryptFactory.CreatePRanEncrypt();

        public string GetEncryptStr(string encryptStr)
        {
            return encrypt.GetEncryptStr(encryptStr);
        }

        public string GetDecryptStr(string decryptStr)
        {
            return encrypt.GetDecryptStr(decryptStr);
        }

        public string GetName()
        {
            return encrypt.Name;
        }

    }
}
