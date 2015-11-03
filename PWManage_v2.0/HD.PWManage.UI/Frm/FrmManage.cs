using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HD.PWManage.BLL;
using HD.PWManage.Model;
using HD.PWManage.Common;

namespace HD.PWManage.UI
{
    public partial class FrmManage : Form
    {
        private static FrmManage instance;
        private static readonly object syncRoot = new object();
        private AccountInfoBLL bll = new AccountInfoBLL();

        private FrmManage()
        {
            InitializeComponent();
        }

        public static FrmManage GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                lock (syncRoot)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new FrmManage();
                    }
                }
            }
            return instance;
        }

        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmManage_Load(object sender, EventArgs e)
        {
            //设置DataGridView不自动生成列
            dgvInfos.AutoGenerateColumns = false;

            Search();
        }

        /// <summary>
        /// 查询
        /// </summary>
        private void Search()
        {
            cbAll.Checked = false;
            List<AccountInfo> list = bll.GetListByPage(pagerControl1.PageIndex, pagerControl1.PageSize);
            if (list != null)
            {
                int count = bll.GetRecordCount("");
                dgvInfos.DataSource = list;
                pagerControl1.DrawControl(count);
            }
        }

        /// <summary>
        /// 新建按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmAccountInfo frmAccountInfo = new FrmAccountInfo("", AfterEditFunc);
            frmAccountInfo.ShowDialog();
        }

        private void AfterEditFunc(bool result)
        {
            if (result)
            {
                Search();
            }
        }

        public void SaveAccountInfo(string title, string pw)
        {
            FrmAccountInfo frmAccountInfo = new FrmAccountInfo(title, pw, AfterEditFunc);
            frmAccountInfo.ShowDialog();
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            List<string> delList = new List<string>();
            for (int i = 0; i < dgvInfos.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvInfos.Rows[i].Cells["cb"].Value))//刚发现
                {
                    delList.Add(dgvInfos.Rows[i].Cells["id"].Value.ToString());
                }
            }

            if (delList.Count > 0)
            {
                if (MessageBox.Show(this, "您确定要删除选择的账号信息吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;
                AccountInfoBLL bll = new AccountInfoBLL();
                AccountInfo accountInfo = new AccountInfo();
                bll.DeleteList(string.Join(",", delList.ToArray()));
            }
            else
            {
                MessageBox.Show("请您选择要删除的账号信息！","提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Search();
        }

        /// <summary>
        /// 查询框文本改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInfos.Rows.Count; i++)
            {
                if (!dgvInfos.Rows[i].Cells["title"].Value.ToString().Contains(txtSearch.Text))
                {
                    dgvInfos.BindingContext[dgvInfos.DataSource].SuspendBinding();//把邦定数据挂起，然后可以对空间中的数据进行操作
                    dgvInfos.Rows[i].Visible = false;
                    dgvInfos.BindingContext[dgvInfos.DataSource].ResumeBinding();//取消挂起，就可以按照自己设想的结果显示数据了
                }
                else
                {
                    dgvInfos.BindingContext[dgvInfos.DataSource].SuspendBinding();//把邦定数据挂起，然后可以对空间中的数据进行操作
                    dgvInfos.Rows[i].Visible = true;
                    dgvInfos.BindingContext[dgvInfos.DataSource].ResumeBinding();//取消挂起，就可以按照自己设想的结果显示数据了
                }
            }
        }

        private void FrmManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            object id = dgvInfos.SelectedRows[0].Cells["id"].Value;
            if (id != null)
            {
                FrmAccountInfo frmAccountInfo = new FrmAccountInfo(id.ToString(), AfterEditFunc);
                frmAccountInfo.ShowDialog();
            }
        }

        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            dgvInfos.EndEdit();//取消编辑状态 选中行的编辑没有结束之前是不会更新到DataGridView上的
            for (int i = 0; i < dgvInfos.Rows.Count; i++)
            {
                dgvInfos.Rows[i].Cells["cb"].Value = (sender as CheckBox).Checked;
            }
        }

        private void pagerControl_OnPageChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void dgvInfos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dgvInfos.Rows.Count != 0)
            {
                for (int i = 0; i < this.dgvInfos.Rows.Count; )
                {
                    this.dgvInfos.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                    i += 2;
                }
            }
        }

        private void dgvInfos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            object id = dgvInfos.SelectedRows[0].Cells["id"].Value;
            if (id != null)
            {
                FrmAccountInfo frmAccountInfo = new FrmAccountInfo(id.ToString(), AfterEditFunc);
                frmAccountInfo.ShowDialog();
            }
        }


        #region 修改密码代码

        ///// <summary>
        ///// 修改密码确认按钮事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void btnConfirm_Click(object sender, EventArgs e)
        //{
        //    this.errorProvider1.Clear();

        //    if (CheckPwInfo())
        //    {
        //        CommonHelper.SetPw(txtNewPw.Text);
        //        ClearPwInfo();
        //        MessageBox.Show("修改密码成功！");
        //    }

        //}

        //private void ClearPwInfo()
        //{
        //    txtNewPw.Text = "";
        //    txtOldPw.Text = "";
        //    txtConfirmPw.Text = "";
        //}

        //private void btnCancel_Click(object sender, EventArgs e)
        //{
        //    ClearPwInfo();
        //}

        //private bool CheckPwInfo()
        //{
        //    if (txtOldPw.Text == "")
        //    {
        //        this.errorProvider1.SetError(this.txtOldPw, "旧密码不能为空！");
        //        txtOldPw.Focus();
        //        return false;
        //    }
        //    if (txtNewPw.Text == "")
        //    {
        //        this.errorProvider1.SetError(this.txtNewPw, "新密码不能为空！");
        //        txtNewPw.Focus();
        //        return false;
        //    }
        //    if (txtConfirmPw.Text == "")
        //    {
        //        this.errorProvider1.SetError(this.txtConfirmPw, "确认新密码不能为空！");
        //        txtConfirmPw.Focus();
        //        return false;
        //    }
        //    if (!CommonHelper.CheckPw(txtOldPw.Text))
        //    {
        //        this.errorProvider1.SetError(this.txtOldPw, "旧密码输入错误，请重新输入！");
        //        txtOldPw.Focus();
        //        return false;
        //    }

        //    if (txtNewPw.Text != txtConfirmPw.Text)
        //    {
        //        this.errorProvider1.SetError(this.txtNewPw, "新密码与确认新密码不一致，请重新输入！");
        //        txtNewPw.Focus();
        //        return false;
        //    }

        //    return true;
        //} 
        #endregion

    }
}
