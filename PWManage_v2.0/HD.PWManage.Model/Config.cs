#region Version Info
/* ======================================================================== 
* 【本类功能概述】 
* 
* 作者：雨隹 
* 创建日期：2014/4/7 星期一 18:24:41 
* 文件名：Config 
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
namespace HD.PWManage.Model
{
    /// <summary>
    /// Config:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Config
    {
        public Config()
        { }
        #region Model
        private int _id;
        private string _cname;
        private string _cinfo;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CName
        {
            set { _cname = value; }
            get { return _cname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CInfo
        {
            set { _cinfo = value; }
            get { return _cinfo; }
        }
        #endregion Model

    }
}

