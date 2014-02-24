﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HD.MyControls;

namespace HD.PWManage.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmManage fm = FrmManage.GetInstance();
            fm.MdiParent = this;
            fm.WindowState = FormWindowState.Maximized;
            fm.Show();
        }

        private void msMain_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text == "" || e.Item.Text == "还原(&R)" || e.Item.Text == "最小化(&N)" || e.Item.Text == "关闭(&C)")
            {
                msMain.Items.RemoveAt(e.Item.MergeIndex);
            }
        }
    }
}
