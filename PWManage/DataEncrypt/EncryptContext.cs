using System;
using System.Collections.Generic;
using System.Text;

namespace DataEncrypt
{
    public class EncryptContext
    {
        private EncryptSuper es;

        public void SetBehavior(EncryptSuper es)
        {
            this.es = es;
        }

        public string GetEnResult(string str)
        {
            return es.GetEncryptStr(str);
        }

        public string GetDeResult(string str)
        {
            return es.GetDecryptStr(str);
        }
    }
}
