using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using HD.PWManage.IDAL;
using System.Reflection;

namespace HD.PWManage.DALFactory
{
    public class AbstractFactory
    {
        private static readonly string DalAssemblyName = ConfigurationManager.AppSettings["DalAssemblyName"];
        private static readonly string NameSpace = ConfigurationManager.AppSettings["NameSpace"];

        static AbstractFactory() { }

        /// <summary>
        /// 创建IUsersDAL数据操作类的实例对象
        /// </summary>
        /// <returns></returns>
        public static IAccountInfoDAL CreateAccountInfoDAL()
        {
            string fullClassName = NameSpace + ".AccountInfoDAL";
            return CreateInstance(fullClassName) as IAccountInfoDAL;
        }

        /// <summary>
        /// 从程序集中创建出具体的数据操作类的实例
        /// </summary>
        /// <param name="fullClassName">类的完整名称</param>
        /// <returns></returns>
        private static object CreateInstance(string fullClassName)
        {
            //要对哪个程序集进行操作。
            var assembly = Assembly.Load(DalAssemblyName);
            //从程序集中创建出传递过来的类型的实例.就是一个new操作.
            return assembly.CreateInstance(fullClassName);
        }
    }
}
