﻿using System;
using System.Configuration;
using HD.PWManage.Common;

namespace HD.PWManage.DBHelper
{
    
    public class PubConstant
    {        
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string ConnectionString
        {           
            get 
            {
                return GetConnectionString("ConnectionString"); 
            }
        }

        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }


    }
}
