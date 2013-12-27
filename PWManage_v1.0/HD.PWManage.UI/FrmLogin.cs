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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CommonHelper.CheckPw(txtPw.Text))
            {
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
