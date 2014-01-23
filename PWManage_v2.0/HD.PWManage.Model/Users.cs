using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HD.PWManage.Model
{
    public class Users
    {
        #region  属性

        /// <summary>
        /// 主键id
        /// </summary>
        private int id = 0;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// 关键词
        /// </summary>
        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        /// <summary>
        /// 账户名称
        /// </summary>
        private string uName;

        public string UName
        {
            get { return uName; }
            set { uName = value; }
        }

        /// <summary>
        /// 账户密码
        /// </summary>
        private string pw;

        public string Pw
        {
            get { return pw; }
            set { pw = value; }
        }

        /// <summary>
        /// 加密规则
        /// </summary>
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>
        /// 登记时间
        /// </summary>
        private DateTime regTime;

        public DateTime RegTime
        {
            get { return regTime; }
            set { regTime = value; }
        }

        #endregion
    }
}
