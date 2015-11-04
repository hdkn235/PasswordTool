using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HD.PWManage.BLL;

namespace HD.PWManage.UI.Frm
{
    public partial class FrmConfig : Form
    {
        private static FrmConfig instance;
        private static readonly object syncRoot = new object();

        private FrmConfig()
        {
            InitializeComponent();
            ConfigBLL bll = new ConfigBLL();
            cbStartVoiceLogin.Checked = bll.IsStartVoiceLogin;
        }

        public static FrmConfig GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                lock (syncRoot)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new FrmConfig();
                    }
                }
            }
            return instance;
        }

        private void cbStartVoiceLogin_CheckedChanged(object sender, EventArgs e)
        {
            ConfigBLL bll = new ConfigBLL();
            bll.IsStartVoiceLogin = cbStartVoiceLogin.Checked;
        }
    }
}
