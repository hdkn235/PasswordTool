using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace HD.PWManage.UI
{
    public partial class PagerControl : UserControl
    {
        #region 构造函数

        public PagerControl()
        {
            InitializeComponent();
        }

        #endregion

        #region 分页字段和属性

        private int pageIndex = 1;
        /// <summary>
        /// 当前页面
        /// </summary>
        [Category("Page")]
        [Description("当前页码")]
        public virtual int PageIndex
        {
            get { return pageIndex; }
            set
            {
                pageIndex = value;
                lblSept.Text = value + " / " + PageCount.ToString();
            }
        }

        private int pageSize = 100;
        /// <summary>
        /// 每页记录数
        /// </summary>
        [Category("Page")]
        [Description("每页记录数")]
        public virtual int PageSize
        {
            get { return pageSize; }
            set
            {
                pageSize = value;
                lblPageSize.Text = "每页 " + value + " 条";
            }
        }

        private int recordCount = 0;
        /// <summary>
        /// 总记录数
        /// </summary>
        [Category("Page")]
        [Description("总记录数")]
        public virtual int RecordCount
        {
            get { return recordCount; }
            set
            {
                recordCount = value;
                lblTotalCount.Text = "共 " + value.ToString() + " 条记录";
            }
        }

        private int pageCount = 0;
        /// <summary>
        /// 总页数
        /// </summary>
        [Category("Page")]
        [Description("总页数")]
        public int PageCount
        {
            get
            {
                if (pageSize != 0)
                {
                    pageCount = GetPageCount();
                }
                return pageCount;
            }
        }

        private string jumpText;
        /// <summary>
        /// 跳转按钮文本
        /// </summary>
        [Category("Page")]
        [Description("跳转按钮文本")]
        public string JumpText
        {
            get
            {
                if (string.IsNullOrEmpty(jumpText))
                {
                    jumpText = "Go";
                }
                return jumpText;
            }
            set
            {
                jumpText = value;
                btnGo.Text = value;
            }
        }


        #endregion

        #region 页码变化触发事件

        public event EventHandler OnPageChanged;

        #endregion

        #region 分页及相关事件功能实现

        private void SetFormCtrEnabled()
        {
            lnkFirst.Enabled = true;
            lnkPrev.Enabled = true;
            lnkNext.Enabled = true;
            lnkLast.Enabled = true;
            btnGo.Enabled = true;
        }

        /// <summary>
        /// 计算总页数
        /// </summary>
        /// <returns></returns>
        private int GetPageCount()
        {
            if (PageSize == 0)
            {
                return 0;
            }
            int pageCount = RecordCount / PageSize;
            if (RecordCount % PageSize == 0)
            {
                pageCount = RecordCount / PageSize;
            }
            else
            {
                pageCount = RecordCount / PageSize + 1;
            }
            return pageCount;
        }
        /// <summary>
        /// 外部调用
        /// </summary>
        public void DrawControl(int count)
        {
            recordCount = count;
            DrawControl(false);
        }
        /// <summary>
        /// 页面控件呈现
        /// </summary>
        private void DrawControl(bool callEvent)
        {
            lblSept.Text = PageIndex.ToString() + " / " + PageCount.ToString();
            lblTotalCount.Text = "共 " + RecordCount.ToString() + " 条记录";

            if (callEvent && OnPageChanged != null)
            {
                OnPageChanged(this, null);//当前分页数字改变时，触发委托事件
            }
            SetFormCtrEnabled();
            if (PageCount == 1)//有且仅有一页
            {
                lnkFirst.Enabled = false;
                lnkPrev.Enabled = false;
                lnkNext.Enabled = false;
                lnkLast.Enabled = false;
                btnGo.Enabled = false;
            }
            else if (PageIndex == 1)//第一页
            {
                lnkFirst.Enabled = false;
                lnkPrev.Enabled = false;
            }
            else if (PageIndex == PageCount)//最后一页
            {
                lnkNext.Enabled = false;
                lnkLast.Enabled = false;
            }
        }

        #endregion

        #region 相关控件事件

        private void lnkFirst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageIndex = 1;
            DrawControl(true);
        }

        private void lnkPrev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageIndex = Math.Max(1, PageIndex - 1);
            DrawControl(true);
        }

        private void lnkNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageIndex = Math.Min(PageCount, PageIndex + 1);
            DrawControl(true);
        }

        private void lnkLast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageIndex = PageCount;
            DrawControl(true);
        }

        /// <summary>
        /// enter键功能
        /// </summary>
        private void txtPageNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGo_Click(null, null);
            }
            else
            {
                if (!(e.KeyChar > '0' && e.KeyChar <= '9'
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar == (char)Keys.Delete))
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// 跳转页数限制
        /// </summary>
        private void txtPageNum_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(txtPageNum.Text.Trim(), out num) && num > 0)
            {
                if (num > PageCount)
                {
                    txtPageNum.Text = PageCount.ToString();
                }
            }
        }

        /// <summary>
        /// 跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGo_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (int.TryParse(txtPageNum.Text.Trim(), out num) && num > 0)
            {
                PageIndex = num;
                DrawControl(true);
            }
        }

        #endregion

    }
}