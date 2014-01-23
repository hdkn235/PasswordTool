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
        public FrmManage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmManage_Load(object sender, EventArgs e)
        {
            Search();
        }

        /// <summary>
        /// 查询
        /// </summary>
        private void Search()
        {
            dgvInfos.AutoGenerateColumns = false;
            UsersBLL bll = new UsersBLL();
            List<Users> list = bll.GetList();
            if (list != null)
            {
                dgvInfos.DataSource = list;
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
                UsersBLL ubll = new UsersBLL();
                Users userInfo = new Users();
                EncryptBLL ebll = new EncryptBLL();
                try
                {
                    userInfo.Key = txtKey.Text;
                    userInfo.UName = txtName.Text;
                    userInfo.Pw = ebll.GetEncryptStr(txtPw.Text);
                    userInfo.Type = ebll.GetName();
                    if (txtID.Text == "")
                    {
                        ubll.Add(userInfo);
                    }
                    else
                    {
                        userInfo.ID = Convert.ToInt32(txtID.Text);
                        ubll.Update(userInfo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ClearInput();
                Search();
            }
        }

        /// <summary>
        ///清空输入框
        /// </summary>
        private void ClearInput()
        {
            txtPw.Text = "";
            txtName.Text = "";
            txtKey.Text = "";
            txtID.Text = "";
        }

        /// <summary>
        /// 新建按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        /// <summary>
        /// 列表双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvInfos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            UsersBLL ubll = new UsersBLL();
            if (e.RowIndex < 0) return;
            txtKey.Text = dgvInfos.Rows[e.RowIndex].Cells["key"].Value.ToString();
            txtName.Text = dgvInfos.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtPw.Text = dgvInfos.Rows[e.RowIndex].Cells["pw"].Value.ToString();
            txtID.Text = dgvInfos.Rows[e.RowIndex].Cells["id"].Value.ToString();
        }

        /// <summary>
        /// 检查输入项
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            if (txtKey.Text == "")
            {
                MessageBox.Show("请输入关键字！");
                return false;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("请输入登录名！");
                return false;
            }
            if (txtPw.Text == "")
            {
                MessageBox.Show("请输入密码！");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "您确定要删除选择的密码信息吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;
            UsersBLL bll = new UsersBLL();
            Users userInfo = new Users();
            try
            {
                for (int i = 0; i < dgvInfos.Rows.Count; i++)
                {
                    if (dgvInfos.Rows[i].Cells["cb"].Value != null && dgvInfos.Rows[i].Cells["cb"].Value.ToString() == "1")
                    {
                        bll.Delete(Convert.ToInt32(dgvInfos.Rows[i].Cells["id"].Value));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ClearInput();
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
                if (!dgvInfos.Rows[i].Cells["key"].Value.ToString().Contains(txtSearch.Text))
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

        /// <summary>
        /// 修改密码确认按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();

            if (CheckPwInfo())
            {
                CommonHelper.SetPw(txtNewPw.Text);
                ClearPwInfo();
                MessageBox.Show("修改密码成功！");
            }

        }

        private void ClearPwInfo()
        {
            txtNewPw.Text = "";
            txtOldPw.Text = "";
            txtConfirmPw.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearPwInfo();
        }

        private void FrmManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private bool CheckPwInfo()
        {
            if (txtOldPw.Text == "")
            {
                this.errorProvider1.SetError(this.txtOldPw, "旧密码不能为空！");
                txtOldPw.Focus();
                return false;
            }
            if (txtNewPw.Text == "")
            {
                this.errorProvider1.SetError(this.txtNewPw, "新密码不能为空！");
                txtNewPw.Focus();
                return false;
            }
            if (txtConfirmPw.Text == "")
            {
                this.errorProvider1.SetError(this.txtConfirmPw, "确认新密码不能为空！");
                txtConfirmPw.Focus();
                return false;
            }
            if (!CommonHelper.CheckPw(txtOldPw.Text))
            {
                this.errorProvider1.SetError(this.txtOldPw, "旧密码输入错误，请重新输入！");
                txtOldPw.Focus();
                return false;
            }

            if (txtNewPw.Text != txtConfirmPw.Text)
            {
                this.errorProvider1.SetError(this.txtNewPw, "新密码与确认新密码不一致，请重新输入！");
                txtNewPw.Focus();
                return false;
            }

            return true;
        }

    }
}
