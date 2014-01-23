using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.PWManage.IDAL;
using HD.PWManage.Model;
using System.Data;
using System.Data.OleDb;

namespace HD.PWManage.OledbDAL
{
    public class UsersDAL : IUsersDAL
    {
        #region IBaseDAL<Users> 成员

        /// <summary>
        /// 获得列表
        /// </summary>
        /// <returns></returns>
        public List<Model.Users> GetList()
        {
            string sql = "select * from users order by uname";
            List<Users> list = null;
            DataTable dt = SqlHelper.GetDataSet(sql).Tables[0];
            if (dt.Rows.Count > 0)
            {
                list = new List<Users>();
                Users user = null;
                foreach (DataRow row in dt.Rows)
                {
                    user = new Users();
                    LoadEntity(user, row);
                    list.Add(user);
                }
            }
            return list;
        }

        private void LoadEntity(Users user, DataRow row)
        {
            if (row["ID"] != null)
            {
                user.ID = Convert.ToInt32(row["ID"]);
            }
            if (row["Key"] != null)
            {
                user.Key = row["Key"].ToString();
            }
            if (row["UName"] != null)
            {
                user.UName = row["UName"].ToString();
            }
            if (row["Pw"] != null)
            {
                user.Pw = row["Pw"].ToString();
            }
            if (row["Type"] != null)
            {
                user.Type = row["Type"].ToString();
            }
            if (row["RegTime"] != null)
            {
                user.RegTime = Convert.ToDateTime(row["RegTime"]);
            }
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void Add(Model.Users model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into Users(");
            sql.Append("[Key],UName,Pw,[Type],RegTime)");
            sql.Append(" values(");
            sql.Append("@Key,@UName,@Pw,@Type,@RegTime)");
            OleDbParameter[] param = { 
                                        new OleDbParameter("@Key", model.Key),
                                        new OleDbParameter("@UName", model.UName),
                                        new OleDbParameter("@Pw", model.Pw),
                                        new OleDbParameter("@Type", model.Type),
                                        new OleDbParameter("@RegTime", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"))
                                     };
            SqlHelper.ExecuteNonQuery(sql.ToString(), param);
        }

        public void Delete(int id)
        {
            string sql = "delete from Users where ID=@ID";
            SqlHelper.ExecuteNonQuery(sql, new OleDbParameter("@ID", id));
        }

        public void Update(Model.Users model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("update Users set ");
            sql.Append("Key=@Key,");
            sql.Append("UName=@UName,");
            sql.Append("Pw=@Pw,");
            sql.Append("Type=@Type ");
            sql.Append("where ID=@ID");
            OleDbParameter[] param = { 
                                        new OleDbParameter("@Key", model.Key),
                                        new OleDbParameter("@UName", model.UName),
                                        new OleDbParameter("@Pw", model.Pw),
                                        new OleDbParameter("@Type", model.Type),
                                        new OleDbParameter("@ID", model.ID)
                                     };
            SqlHelper.ExecuteNonQuery(sql.ToString(), param);
        }

        #endregion
    }
}
