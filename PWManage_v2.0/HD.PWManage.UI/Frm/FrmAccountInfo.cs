using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HD.PWManage.BLL;
using HD.PWManage.Model;

namespace HD.PWManage.UI
{
    public partial class FrmAccountInfo : Form
    {
        private string id = "";
        private Action<bool> callBackFunc;
        private AccountInfoBLL ubll = new AccountInfoBLL();
        private EncryptBLL ebll = new EncryptBLL();

        public FrmAccountInfo()
        {
            InitializeComponent();
        }

        public FrmAccountInfo(string id, Action<bool> callBackFunc)
        {
            this.id = id;
            this.callBackFunc = callBackFunc;
            InitializeComponent();
        }

        public FrmAccountInfo(string title,string pw, Action<bool> callBackFunc)
        {
            InitializeComponent();
            this.callBackFunc = callBackFunc;
            txtTitle.Text = title;
            txtUserPassWord.Text = pw;
        }

        private void FrmAccountInfo_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id))
            {
                AccountInfo model = ubll.GetModel(int.Parse(id));
                if (model != null)
                {
                    txtTitle.Text = model.Title;
                    txtUserName.Text = model.UserName;
                    txtUserPassWord.Text = model.UserPassWord;
                    txtWebUrl.Text = model.WebUrl;
                    txtEmail.Text = model.Email;
                    txtRemark.Text = model.Remark;
                }
            }
        }

        /// <summary>
        /// 保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                AccountInfo accountInfo = new AccountInfo();
                try
                {
                    accountInfo.UserName = txtUserName.Text;
                    accountInfo.Title = txtTitle.Text;
                    accountInfo.UserPassWord = txtUserPassWord.Text;
                    accountInfo.WebUrl = txtWebUrl.Text;
                    accountInfo.Email = txtEmail.Text;
                    accountInfo.Remark = txtRemark.Text;
                    accountInfo.EncryptType = ebll.GetName();
                    accountInfo.RegistTime = DateTime.Now;

                    bool result = false;
                    if (string.IsNullOrEmpty(id))
                    {
                        result = ubll.Add(accountInfo);
                    }
                    else
                    {
                        accountInfo.ID = int.Parse(id);
                        result = ubll.Update(accountInfo);
                    }
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    callBackFunc(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        ///清空输入框
        /// </summary>
        private void ClearInput()
        {
            foreach (var item in plAccountInfo.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Text = "";
                }
            }
        }

        /// <summary>
        /// 检查输入项
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            if (txtUserPassWord.Text == "")
            {
                MessageBox.Show("请输入密码！");
                return false;
            }
            if (txtTitle.Text == "")
            {
                MessageBox.Show("请输入标题！");
                return false;
            }
            if (txtUserName.Text == "")
            {
                MessageBox.Show("请输入用户名！");
                return false;
            }
            return true;
        }

    }
}
