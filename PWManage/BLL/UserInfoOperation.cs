using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using DAL;
using System.Data;
using DataEncrypt;
using System.Reflection;

namespace BLL
{
    public class UserInfoOperation
    {
        public enum CryptMode
        {
            Encrypt, Decrypt
        }

        const string ASSEMBLY_NAME = "DataEncrypt";

        Operation o = OperationFactory.GetOperation();

        /// <summary>
        /// 插入密码数据
        /// </summary>
        /// <param name="userInfo"></param>
        public void Insert(UserInfoEntity userInfo)
        {
            o.userInfo = userInfo;
            o.Insert();
        }

        /// <summary>
        /// 更新密码数据
        /// </summary>
        /// <param name="userInfo"></param>
        public void Update(UserInfoEntity userInfo)
        {
            o.userInfo = userInfo;
            o.Update();
        }

        /// <summary>
        /// 查找密码数据
        /// </summary>
        /// <param name="userInfo"></param>
        public void Search(UserInfoEntity userInfo)
        {
            o.userInfo = userInfo;
            o.Search();
        }

        /// <summary>
        /// 删除密码数据
        /// </summary>
        /// <param name="userInfo"></param>
        public void Delete(UserInfoEntity userInfo)
        {
            o.userInfo = userInfo;
            o.Del();
        }

        /// <summary>
        /// 获取用户密码信息列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetInfos()
        {
            XMLOperation xmlOp = new XMLOperation();
            return xmlOp.GetAllInfo("DataFile.xml");
        }

        /// <summary>
        /// 获取加密算法列表
        /// </summary>
        /// <returns></returns>
        public string[] GetTypeList()
        {
            XMLOperation xmlOp = new XMLOperation();
            DataSet ds = xmlOp.GetAllInfo("TypeList.xml");
            int rowCount = ds.Tables[0].DefaultView.Count;
            string[] arrayResult = new string[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                arrayResult[i] = (string)ds.Tables[0].DefaultView[i]["name"];
            }
            return arrayResult;
        }

        /// <summary>
        /// 获取加密后的字符串
        /// </summary>
        /// <param name="selValue"></param>
        /// <param name="str"></param>
        /// <param name="cm"></param>
        /// <returns></returns>
        public string GetStr(string selValue, string str, CryptMode cm)
        {
            XMLOperation xmlOp = new XMLOperation();
            DataSet ds = xmlOp.GetAllInfo("TypeList.xml");

            EncryptContext ec = new EncryptContext();
            DataRow dr = ((DataRow[])ds.Tables[0].Select("name='" + selValue + "'"))[0];
            ec.SetBehavior((EncryptSuper)Assembly.Load(ASSEMBLY_NAME).CreateInstance(ASSEMBLY_NAME + "." + dr["class"].ToString(), false, BindingFlags.Default, null, null, null, null));
            if (cm == CryptMode.Encrypt) return ec.GetEnResult(str);
            else return ec.GetDeResult(str);
        }
    }
}
