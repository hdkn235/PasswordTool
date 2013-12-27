using System;
using System.Collections.Generic;
using System.Text;
using DataEncrypt;
using DAL;

namespace BLL
{
    public class Center
    {
        /// <summary>
        /// 检查登录密码是否正确
        /// </summary>
        /// <param name="pw"></param>
        /// <returns></returns>
        public static bool CheckPw(string pw)
        {
            bool result = false;
            MD5Encrypt md = new MD5Encrypt();
            string encryptPwNow = md.GetEncryptStr(pw);
            string encryptPw = XMLOperation.ConfigueGet("ProgramSet.xml", "userInfo", "pw");
            if (encryptPw == encryptPwNow)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 设置登录密码
        /// </summary>
        /// <param name="pw"></param>
        public static void SetPw(string pw)
        {
            MD5Encrypt md = new MD5Encrypt();
            string encryptPw = md.GetEncryptStr(pw);
            XMLOperation.ConfigueSet("ProgramSet.xml", "userInfo", "pw", encryptPw);
        }
    }
}
