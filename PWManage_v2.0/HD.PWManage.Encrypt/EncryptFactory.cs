using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;

namespace HD.PWManage.Encrypt
{
    public class EncryptFactory
    {
        private static readonly string EncryptAssemblyName = ConfigurationManager.AppSettings["EncryptAssemblyName"];
        private static readonly string EncryptNameSpace = ConfigurationManager.AppSettings["EncryptNameSpace"];

        public static IEncrypt CreatePRanEncrypt()
        {
            string fullClassName = EncryptNameSpace + ".PRanEncrypt";
            return CreateInstance(fullClassName) as IEncrypt;
        }

        private static object CreateInstance(string className)
        {
            var assembly = Assembly.Load(EncryptAssemblyName);
            return assembly.CreateInstance(className);
        }
    }
}
