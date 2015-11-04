using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HD.PWManage.Model;
using HD.PWManage.BLL;
using HD.PWManage.Common;

namespace HD.PWManage.UI.Frm
{
    public partial class FrmModifyPW : Form
    {
        public FrmModifyPW()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                string oldPw = MD5Encrypt.GetStrMD5(MD5Encrypt.GetStrMD5(txtOldPw.Text));
                ConfigBLL bll = new ConfigBLL();
                string loginPw = bll.LoginPW;
                if (loginPw.Equals(oldPw))
                {
                    loginPw = MD5Encrypt.GetStrMD5(MD5Encrypt.GetStrMD5(txtNewPw.Text));
                    bll.LoginPW = loginPw;
                    MessageBox.Show("修改密码成功！");
                    this.Close();
                }
                else
                {
                    ShowErrorMsg(txtOldPw, "原密码输入错误，请重新输入！");
                }
            }
        }

        /// <summary>
        /// 检查输入
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            return IsNotEmpty(txtOldPw, "原密码不能为空！")
                    && IsNotEmpty(txtNewPw, "新密码不能为空！")
                    && IsNotEmpty(txtConPw, "确认新密码不能为空！")
                    && IsEqual(txtNewPw, txtConPw, "新密码与确认新密码不一致，请重新输入！");
        }

        /// <summary>
        /// 判断输入是否为空 并弹出错误信息
        /// </summary>
        /// <param name="str">验证内容</param>
        /// <param name="erroStr">错误提示内容</param>
        /// <returns>bool</returns>
        private bool IsNotEmpty(TextBox tb, string erroStr)
        {
            bool result = true;
            if (string.IsNullOrEmpty(tb.Text))
            {
                ShowErrorMsg(tb, erroStr);
                result = false;
            }
            return result;
        }

        /// <summary>
        /// 判断两个字符串是否相等
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="errorStr"></param>
        /// <returns></returns>
        private bool IsEqual(TextBox tb1, TextBox tb2, string errorStr)
        {
            bool result = true;
            if (!tb1.Text.Equals(tb2.Text))
            {
                ShowErrorMsg(tb2, errorStr);
                result = false;
            }
            return result;
        }

        /// <summary>
        /// 显示错误信息
        /// </summary>
        /// <param name="control"></param>
        /// <param name="msg"></param>
        private void ShowErrorMsg(Control control, string msg)
        {
            this.errorProvider1.Clear();
            this.errorProvider1.SetError(control, msg);
            control.Focus();
        }

    }
}
