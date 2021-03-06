﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HD.PWManage.Common;
using HD.PWManage.BLL;

namespace HD.PWManage.UI
{
    public partial class FrmCreatePw : Form
    {
        public FrmCreatePw()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            int pwLength = (int)nupPWlength.Value;

            title = PinYinHelper.GetPinYinStr(title);

            string encryptStr = DESEncrypt.Encrypt(title);
            txtPw.Text = encryptStr.Substring(0, pwLength);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPw.Text))
            {
                MessageBox.Show("还未生成密码！");
                return;
            }
            FrmManage frmManage = FrmManage.GetInstance();
            frmManage.SaveAccountInfo(txtTitle.Text, txtPw.Text);
            this.Dispose();
        }

    }
}
