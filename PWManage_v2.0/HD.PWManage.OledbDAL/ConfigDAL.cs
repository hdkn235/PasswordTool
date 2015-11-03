#region Version Info
/* ======================================================================== 
* 【本类功能概述】 
* 
* 作者：雨隹 
* 创建日期：2014/4/7 星期一 22:09:47 
* 文件名：ConfigDAL 
* 版本：V1.0.0
* 博客地址：http://www.cnblogs.com/hdkn235/
* 
* 修改者： 		
* 修改日期： 
* 修改说明： 
* ======================================================================== 
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.PWManage.IDAL;
using System.Data.OleDb;
using HD.PWManage.DBHelper;
using System.Data;

namespace HD.PWManage.OledbDAL
{
    /// <summary>
    /// 数据访问类:ConfigDAL
    /// </summary>
    public partial class ConfigDAL : IConfigDAL
    {
        public ConfigDAL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Config");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            return DbHelperOleDb.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(HD.PWManage.Model.Config model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Config(");
            strSql.Append("CName,CInfo)");
            strSql.Append(" values (");
            strSql.Append("@CName,@CInfo)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@CName", OleDbType.VarChar,255),
					new OleDbParameter("@CInfo", OleDbType.VarChar,255)};
            parameters[0].Value = model.CName;
            parameters[1].Value = model.CInfo;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(HD.PWManage.Model.Config model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Config set ");
            strSql.Append("CName=@CName,");
            strSql.Append("CInfo=@CInfo");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@CName", OleDbType.VarChar,255),
					new OleDbParameter("@CInfo", OleDbType.VarChar,255),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.CName;
            parameters[1].Value = model.CInfo;
            parameters[2].Value = model.ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Config ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Config ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HD.PWManage.Model.Config GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,CName,CInfo from Config ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            HD.PWManage.Model.Config model = new HD.PWManage.Model.Config();
            DataSet ds = DbHelperOleDb.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HD.PWManage.Model.Config DataRowToModel(DataRow row)
        {
            HD.PWManage.Model.Config model = new HD.PWManage.Model.Config();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["CName"] != null)
                {
                    model.CName = row["CName"].ToString();
                }
                if (row["CInfo"] != null)
                {
                    model.CInfo = row["CInfo"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,CName,CInfo ");
            strSql.Append(" FROM Config ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
