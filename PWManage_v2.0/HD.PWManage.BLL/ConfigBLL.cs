#region Version Info
/* ======================================================================== 
* 【本类功能概述】 
* 
* 作者：雨隹 
* 创建日期：2014/4/7 星期一 22:22:37 
* 文件名：IConfigBLL 
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
using System.Data;
using HD.PWManage.IDAL;
using HD.PWManage.DALFactory;
using HD.PWManage.Model;
using HD.PWManage.Common;

namespace HD.PWManage.BLL
{
    public class ConfigBLL
    {
        private readonly IConfigDAL dal = AbstractFactory.CreateConfigDAL();
        public ConfigBLL()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(HD.PWManage.Model.Config model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(HD.PWManage.Model.Config model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            return dal.Delete(ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HD.PWManage.Model.Config GetModel(int ID)
        {
            return dal.GetModel(ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<HD.PWManage.Model.Config> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<HD.PWManage.Model.Config> DataTableToList(DataTable dt)
        {
            List<HD.PWManage.Model.Config> modelList = new List<HD.PWManage.Model.Config>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                HD.PWManage.Model.Config model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        /// <summary>
        /// 获取登录密码Model
        /// </summary>
        /// <returns></returns>
        public Config GetLoginPWModel()
        {
            Config model = null;
            List<Config> list = GetModelList("CName='LoginPW'");
            if (list.Count > 0)
            {
                model = list[0];
            }
            else
            {
                model = new Config();
                model.CName = "LoginPW";
                model.CInfo = CommonHelper.GetMD5Str("123");
                Add(model);
            }
            return model;
        }


        #endregion  ExtensionMethod
    }
}
