using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HD.MyControls;
using HD.PWManage.UI.Frm;

namespace HD.PWManage.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            ShowPwBox();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShowPwBox();
        }

        private void ShowPwBox()
        {
            FrmManage fm = FrmManage.GetInstance();
            fm.MdiParent = this;
            fm.Dock = DockStyle.Fill;
            fm.Show();
        }

        private void msMain_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text == "" || e.Item.Text == "还原(&R)" || e.Item.Text == "最小化(&N)" || e.Item.Text == "关闭(&C)")
            {
                msMain.Items.RemoveAt(e.Item.MergeIndex);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmCreatePw frmCreatePw = new FrmCreatePw();
            frmCreatePw.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmModifyPW frmSettings = new FrmModifyPW();
            frmSettings.ShowDialog();
        }
    }
}
