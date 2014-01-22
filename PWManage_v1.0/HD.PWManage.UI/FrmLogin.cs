using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HD.PWManage.BLL;
using HD.PWManage.Common;

namespace HD.PWManage.UI
{
    public partial class FrmLogin : Form
    {
        //语音对象
        private SoundHelper sh;

        public FrmLogin()
        {
            InitializeComponent();
            //语音识别功能
            //sh = SoundHelper.instance();
            //sh.BeginRec();
            //sh.SetMessage = SetPW;
        }

        private void SetPW(string pw)
        {
            txtPw.Text = pw;
            btnLogin_Click(null, null);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CommonHelper.CheckPw(txtPw.Text))
            {
                //sh.CloseRec();
                this.Hide();
                FrmManage fm = new FrmManage();
                fm.Show();
            }
            else
            {
                this.errorProvider1.SetError(this.txtPw, "登录密码输入错误，请重新输入！");
                txtPw.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
