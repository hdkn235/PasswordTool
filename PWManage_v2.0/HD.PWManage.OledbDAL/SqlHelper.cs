using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;
using System.Data;

namespace HD.PWManage.OledbDAL
{
    public static class SqlHelper
    {
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        static readonly string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        /// <summary>
        /// 执行增删改SQL语句
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="para">参数</param>
        public static void ExecuteNonQuery(string sql, params OleDbParameter[] para)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    if (para != null)
                    {
                        cmd.Parameters.AddRange(para);
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// 执行返回一个结果的sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="para"></param>
        /// <returns>返回object类型的数据</returns>
        public static object ExecuteScalar(string sql, params OleDbParameter[] para)
        {
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    if (para != null)
                    {
                        cmd.Parameters.AddRange(para);
                    }
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 与数据库建立连接 同步从数据库读取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static OleDbDataReader ExecuteReader(string sql, params OleDbParameter[] para)
        {
            OleDbConnection conn = new OleDbConnection(connStr);
            try
            {
                using (OleDbCommand cmd = new OleDbCommand(sql, conn))
                {
                    if (para != null)
                    {
                        cmd.Parameters.AddRange(para);
                    }
                    conn.Open();
                    return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
            }
            catch (Exception ex)
            {
                conn.Dispose();
                throw ex;
            }
        }

        /// <summary>
        /// 得到dataset结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, params OleDbParameter[] para)
        {
            DataSet ds = new DataSet();
            using (OleDbDataAdapter odda = new OleDbDataAdapter(sql, connStr))
            {
                if (para != null)
                {
                    odda.SelectCommand.Parameters.AddRange(para);
                }
                odda.Fill(ds);
            }
            return ds;
        }
    }
}
