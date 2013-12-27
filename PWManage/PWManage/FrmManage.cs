using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataEncrypt;
using BLL;

namespace PWManage
{
    public partial class FrmManage : Form
    {
        public FrmManage()
        {
            InitializeComponent();
            //this.skinEngine1.SkinFile = "Calmness.ssk";
        }

        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmManage_Load(object sender, EventArgs e)
        {
            UserInfoOperation userInfo = new UserInfoOperation();
            selType.DataSource = userInfo.GetTypeList();
            selType.SelectedIndex = 0;
            Search();
        }

        /// <summary>
        /// 查询
        /// </summary>
        private void Search()
        {
            while (dgvInfos.Rows.Count != 0)
            {
                dgvInfos.Rows.RemoveAt(0);
            }
            UserInfoOperation userInfo = new UserInfoOperation();
            dgvInfos.AutoGenerateColumns = false;
            if (userInfo.GetInfos().Tables.Count > 0) dgvInfos.DataSource = userInfo.GetInfos().Tables[0];
        }

        /// <summary>
        /// 保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            UserInfoOperation oprUserinfo = new UserInfoOperation();
            UserInfoEntity userInfo = new UserInfoEntity();
            try
            {
                userInfo.Key = txtKey.Text;
                userInfo.Name = txtName.Text;
                userInfo.Pw = oprUserinfo.GetStr(selType.SelectedItem.ToString(), txtPw.Text, UserInfoOperation.CryptMode.Encrypt);
                userInfo.Type = selType.SelectedItem.ToString();
                if (txtID.Text == "")
                {
                    userInfo.ID = GetMaxID();
                    oprUserinfo.Insert(userInfo);
                }
                else
                {
                    userInfo.ID = Convert.ToInt32(txtID.Text);
                    oprUserinfo.Update(userInfo);
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
        ///清空输入框
        /// </summary>
        private void ClearInput()
        {
            txtPw.Text = "";
            txtName.Text = "";
            txtKey.Text = "";
            selType.SelectedIndex = 0;
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
            UserInfoOperation userInfo = new UserInfoOperation();
            if (e.RowIndex < 0) return;
            txtKey.Text = dgvInfos.Rows[e.RowIndex].Cells["key"].Value.ToString();
            txtName.Text = dgvInfos.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtPw.Text = userInfo.GetStr(dgvInfos.Rows[e.RowIndex].Cells["type"].Value.ToString(), dgvInfos.Rows[e.RowIndex].Cells["pw"].Value.ToString(), UserInfoOperation.CryptMode.Decrypt);
            txtID.Text = dgvInfos.Rows[e.RowIndex].Cells["id"].Value.ToString();
            selType.SelectedItem = dgvInfos.Rows[e.RowIndex].Cells["type"].Value.ToString();

        }

        /// <summary>
        /// 获取ID
        /// </summary>
        /// <returns></returns>
        private int GetMaxID()
        {
            int maxId = 0;
            if (dgvInfos.Rows.Count > 0)
            {
                maxId = Convert.ToInt32(dgvInfos.Rows[0].Cells["id"].Value);
                for (int i = 0; i < dgvInfos.Rows.Count; i++)
                {
                    if (maxId < Convert.ToInt32(dgvInfos.Rows[i].Cells["id"].Value))
                    {
                        maxId = Convert.ToInt32(dgvInfos.Rows[i].Cells["id"].Value);
                    }
                }
            }
            return maxId + 1;
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
            if (selType.SelectedIndex == 0)
            {
                MessageBox.Show("请选择加密算法！");
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
            UserInfoEntity userInfo = new UserInfoEntity();
            UserInfoOperation oprUserinfo = new UserInfoOperation();
            try
            {
                for (int i = 0; i < dgvInfos.Rows.Count; i++)
                {
                    if (dgvInfos.Rows[i].Cells["cb"].Value != null && dgvInfos.Rows[i].Cells["cb"].Value.ToString() == "1")
                    {
                        userInfo.ID = Convert.ToInt32(dgvInfos.Rows[i].Cells["id"].Value);
                        oprUserinfo.Delete(userInfo);
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();

            if (CheckPwInfo())
            {
                Center.SetPw(txtNewPw.Text);
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
            if (!Center.CheckPw(txtOldPw.Text))
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
