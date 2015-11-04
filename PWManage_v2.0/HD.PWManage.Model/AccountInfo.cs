using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HD.PWManage.Common;

namespace HD.PWManage.Model
{
    public class AccountInfo
    {
        public AccountInfo()
        { }

        #region Model
        private int _id;
        private string _title;
        private string _username;
        private string _userpassword;
        private string _weburl;
        private string _email;
        private string _remark;
        private string _encrypttype;
        private DateTime? _registtime;
        private int? _classid = 0;

        /// <summary>
        /// 显示未加密的密码
        /// </summary>
        public string DisplayPW
        {
            get
            {
                return DESEncrypt.Decrypt(_userpassword);
            }
            set
            {
                _userpassword = DESEncrypt.Encrypt(value);
            }
        }

        /// <summary>
        /// 主键
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string UserPassWord
        {
            set { _userpassword = value; }
            get { return _userpassword; }
        }
        /// <summary>
        /// 网络地址
        /// </summary>
        public string WebUrl
        {
            set { _weburl = value; }
            get { return _weburl; }
        }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 加密类型
        /// </summary>
        public string EncryptType
        {
            set { _encrypttype = value; }
            get { return _encrypttype; }
        }
        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime? RegistTime
        {
            set { _registtime = value; }
            get { return _registtime; }
        }
        /// <summary>
        /// 分类号
        /// </summary>
        public int? ClassID
        {
            set { _classid = value; }
            get { return _classid; }
        }
        #endregion Model
    }
}
