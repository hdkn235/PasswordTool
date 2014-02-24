using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.PWManage.IDAL;
using HD.PWManage.Model;
using System.Data;
using System.Data.OleDb;
using HD.PWManage.DBHelper;

namespace HD.PWManage.OledbDAL
{
    public class AccountInfoDAL : IAccountInfoDAL
    {
        #region IBaseDAL<Users> 成员

        public AccountInfoDAL()
        { }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from AccountInfo");
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
        public bool Add(AccountInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AccountInfo(");
            strSql.Append("Title,UserName,UserPassWord,WebUrl,Email,Remark,EncryptType,RegistTime,ClassID)");
            strSql.Append(" values (");
            strSql.Append("@Title,@UserName,@UserPassWord,@WebUrl,@Email,@Remark,@EncryptType,@RegistTime,@ClassID)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Title", OleDbType.VarChar,255),
					new OleDbParameter("@UserName", OleDbType.VarChar,255),
					new OleDbParameter("@UserPassWord", OleDbType.VarChar,255),
					new OleDbParameter("@WebUrl", OleDbType.VarChar,255),
					new OleDbParameter("@Email", OleDbType.VarChar,255),
					new OleDbParameter("@Remark", OleDbType.VarChar,255),
					new OleDbParameter("@EncryptType", OleDbType.VarChar,255),
					new OleDbParameter("@RegistTime", OleDbType.Date),
					new OleDbParameter("@ClassID", OleDbType.Integer,4)};
            parameters[0].Value = model.Title;
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.UserPassWord;
            parameters[3].Value = model.WebUrl;
            parameters[4].Value = model.Email;
            parameters[5].Value = model.Remark;
            parameters[6].Value = model.EncryptType;
            parameters[7].Value = model.RegistTime;
            parameters[8].Value = model.ClassID;

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
        public bool Update(AccountInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AccountInfo set ");
            strSql.Append("Title=@Title,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("UserPassWord=@UserPassWord,");
            strSql.Append("WebUrl=@WebUrl,");
            strSql.Append("Email=@Email,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("EncryptType=@EncryptType,");
            strSql.Append("RegistTime=@RegistTime,");
            strSql.Append("ClassID=@ClassID");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Title", OleDbType.VarChar,255),
					new OleDbParameter("@UserName", OleDbType.VarChar,255),
					new OleDbParameter("@UserPassWord", OleDbType.VarChar,255),
					new OleDbParameter("@WebUrl", OleDbType.VarChar,255),
					new OleDbParameter("@Email", OleDbType.VarChar,255),
					new OleDbParameter("@Remark", OleDbType.VarChar,255),
					new OleDbParameter("@EncryptType", OleDbType.VarChar,255),
					new OleDbParameter("@RegistTime", OleDbType.Date),
					new OleDbParameter("@ClassID", OleDbType.Integer,4),
					new OleDbParameter("@ID", OleDbType.Integer,4)};
            parameters[0].Value = model.Title;
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.UserPassWord;
            parameters[3].Value = model.WebUrl;
            parameters[4].Value = model.Email;
            parameters[5].Value = model.Remark;
            parameters[6].Value = model.EncryptType;
            parameters[7].Value = model.RegistTime;
            parameters[8].Value = model.ClassID;
            parameters[9].Value = model.ID;

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
            strSql.Append("delete from AccountInfo ");
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
            strSql.Append("delete from AccountInfo ");
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
        public AccountInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Title,UserName,UserPassWord,WebUrl,Email,Remark,EncryptType,RegistTime,ClassID from AccountInfo ");
            strSql.Append(" where ID=@ID");
            OleDbParameter[] parameters = {
					new OleDbParameter("@ID", OleDbType.Integer,4)
			};
            parameters[0].Value = ID;

            AccountInfo model = new AccountInfo();
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
        public AccountInfo DataRowToModel(DataRow row)
        {
            AccountInfo model = new AccountInfo();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Title"] != null)
                {
                    model.Title = row["Title"].ToString();
                }
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["UserPassWord"] != null)
                {
                    model.UserPassWord = row["UserPassWord"].ToString();
                }
                if (row["WebUrl"] != null)
                {
                    model.WebUrl = row["WebUrl"].ToString();
                }
                if (row["Email"] != null)
                {
                    model.Email = row["Email"].ToString();
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["EncryptType"] != null)
                {
                    model.EncryptType = row["EncryptType"].ToString();
                }
                if (row["RegistTime"] != null && row["RegistTime"].ToString() != "")
                {
                    model.RegistTime = DateTime.Parse(row["RegistTime"].ToString());
                }
                if (row["ClassID"] != null && row["ClassID"].ToString() != "")
                {
                    model.ClassID = int.Parse(row["ClassID"].ToString());
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
            strSql.Append("select ID,Title,UserName,UserPassWord,WebUrl,Email,Remark,EncryptType,RegistTime,ClassID ");
            strSql.Append(" FROM AccountInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM AccountInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperOleDb.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from AccountInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOleDb.Query(strSql.ToString());
        }

        #endregion
    }
}
