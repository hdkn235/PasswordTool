using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HD.PWManage.BLL;
using HD.PWManage.Common;
using HD.PWManage.Model;

namespace HD.PWManage.UI
{
    public partial class FrmLogin : Form
    {
        //语音对象
        private SoundHelper sh;
        //皮肤的索引
        public static int var_bar = 1;

        public FrmLogin()
        {
            InitializeComponent();

            ConfigBLL bll = new ConfigBLL();
            if (bll.IsStartVoiceLogin)
            {
                OpenVoice();
            }
        }

        /// <summary>
        /// 语音识别功能
        /// </summary>
        private void OpenVoice()
        {
            sh = SoundHelper.instance();
            sh.BeginRec();
            sh.SetMessage = SetPW;
        }

        private void SetPW(string pw)
        {
            txtPw.Text = pw;
            btnLogin_Click(null, null);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckPw(txtPw.Text))
            {
                ConfigBLL bll = new ConfigBLL();
                if (sh!= null)
                {
                    sh.CloseRec();
                }                    
                this.Hide();
                FrmMain fm = new FrmMain();
                fm.Show();
            }
            else
            {
                this.errorProvider1.SetError(this.txtPw, "登录密码输入错误，请重新输入！");
                txtPw.Focus();
            }
        }

        /// <summary>
        /// 检查登录密码是否正确
        /// </summary>
        /// <returns></returns>
        private bool CheckPw(string pw)
        {
            string loginPw = CommonHelper.GetMD5Str(pw);
            ConfigBLL bll = new ConfigBLL();
            string realPw = bll.LoginPW;
            if (realPw.Equals(loginPw))
            {
                return true;
            }
            return false;
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            FrmClickMeans(this, Convert.ToInt16(((PictureBox)sender).Tag.ToString()));
        }

        #region  设置窗体的最大化、最小化和关闭按钮的单击事件
        /// <summary>
        /// 设置窗体的最大化、最小化和关闭按钮的单击事件
        /// </summary>
        /// <param Frm_Tem="Form">窗体</param>
        /// <param n="int">标识</param>
        public void FrmClickMeans(Form Frm_Tem, int n)
        {
            switch (n)
            {
                case 0:
                    Frm_Tem.WindowState = FormWindowState.Minimized;
                    break;
                case 1:
                    {
                        if (Frm_Tem.WindowState == FormWindowState.Maximized)
                            Frm_Tem.WindowState = FormWindowState.Normal;
                        else
                            Frm_Tem.WindowState = FormWindowState.Maximized;
                        break;
                    }
                case 2:
                    Frm_Tem.Close();
                    break;
            }
        }
        #endregion

        private void barter(int n)
        {
            switch (n)
            {
                case 1:
                    {
                        this.Width = Properties.Resources.sy1_01.Width;
                        this.Height = Properties.Resources.sy1_01.Height + Properties.Resources.sy1_02.Height - 5;
                        panel_Title.BackgroundImage = Properties.Resources.sy1_01;
                        panel_ALL.BackgroundImage = Properties.Resources.sy1_02;
                        pictureBox_Min.Image = null;
                        pictureBox_Min.Image = Properties.Resources.sy1_04;
                        pictureBox_Close.Image = null;
                        pictureBox_Close.Image = Properties.Resources.sy1_03;
                        var_bar = 1;
                        break;
                    }
                case 2:
                    {
                        this.Width = Properties.Resources.sy2_01.Width;
                        this.Height = Properties.Resources.sy2_01.Height + Properties.Resources.sy2_02.Height - 5;
                        panel_Title.BackgroundImage = Properties.Resources.sy2_01;
                        panel_ALL.BackgroundImage = Properties.Resources.sy2_02;
                        pictureBox_Min.Image = null;
                        pictureBox_Min.Image = Properties.Resources.sy2_04;
                        pictureBox_Close.Image = null;
                        pictureBox_Close.Image = Properties.Resources.sy2_03;
                        var_bar = 2;
                        break;
                    }
                case 3:
                    {
                        this.Width = Properties.Resources.sy3_01.Width;
                        this.Height = Properties.Resources.sy3_01.Height + Properties.Resources.sy3_02.Height - 5;
                        panel_Title.BackgroundImage = Properties.Resources.sy3_01;
                        panel_ALL.BackgroundImage = Properties.Resources.sy3_02;
                        pictureBox_Min.Image = null;
                        pictureBox_Min.Image = Properties.Resources.sy3_04;
                        pictureBox_Close.Image = null;
                        pictureBox_Close.Image = Properties.Resources.sy3_03;
                        var_bar = 3;
                        break;
                    }
            }
            //barterShow(n);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            barter(1);
        }

        private void pictureBox_Close_MouseEnter(object sender, EventArgs e)
        {
            ImageSwitch(sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), 0);
        }

        private void pictureBox_Close_MouseLeave(object sender, EventArgs e)
        {
            ImageSwitch(sender, Convert.ToInt16(((PictureBox)sender).Tag.ToString()), 1);
        }

        #region  控制图片的切换状态
        /// <summary>
        /// 控制图片的切换状态
        /// </summary>
        /// <param Frm_Tem="Form">要改变图片的对象</param>
        /// <param n="int">标识</param>
        /// <param ns="int">移出移入标识</param>
        public static PictureBox Tem_PictB = new PictureBox();
        public void ImageSwitch(object sender, int n, int ns)
        {
            Tem_PictB = (PictureBox)sender;

            switch (n)
            {
                case 0:
                    {
                        Tem_PictB.Image = null;
                        if (ns == 0)
                        {
                            switch (var_bar)
                            {
                                case 1: Tem_PictB.Image = Properties.Resources.sy1_04_1; break;
                                case 2: Tem_PictB.Image = Properties.Resources.sy2_04_1; break;
                                case 3: Tem_PictB.Image = Properties.Resources.sy3_04_1; break;
                            }
                        }
                        if (ns == 1)
                        {
                            switch (var_bar)
                            {
                                case 1: Tem_PictB.Image = Properties.Resources.sy1_04; break;
                                case 2: Tem_PictB.Image = Properties.Resources.sy2_04; break;
                                case 3: Tem_PictB.Image = Properties.Resources.sy3_04; break;
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        Tem_PictB.Image = null;
                        if (ns == 0)
                        {
                            switch (var_bar)
                            {
                                case 1: Tem_PictB.Image = Properties.Resources.sy1_05_1; break;
                                case 2: Tem_PictB.Image = Properties.Resources.sy2_05_1; break;
                                case 3: Tem_PictB.Image = Properties.Resources.sy3_05_1; break;
                            }
                        }
                        if (ns == 1)
                        {
                            switch (var_bar)
                            {
                                case 1: Tem_PictB.Image = Properties.Resources.sy1_05; break;
                                case 2: Tem_PictB.Image = Properties.Resources.sy2_05; break;
                                case 3: Tem_PictB.Image = Properties.Resources.sy3_05; break;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Tem_PictB.Image = null;
                        if (ns == 0)
                        {
                            switch (var_bar)
                            {
                                case 1: Tem_PictB.Image = Properties.Resources.sy1_03_1; break;
                                case 2: Tem_PictB.Image = Properties.Resources.sy2_03_1; break;
                                case 3: Tem_PictB.Image = Properties.Resources.sy3_03_1; break;
                            }
                        }
                        if (ns == 1)
                        {
                            switch (var_bar)
                            {
                                case 1: Tem_PictB.Image = Properties.Resources.sy1_03; break;
                                case 2: Tem_PictB.Image = Properties.Resources.sy2_03; break;
                                case 3: Tem_PictB.Image = Properties.Resources.sy3_03; break;
                            }
                        }
                        break;
                    }
            }
        }
        #endregion

        private void txtPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
