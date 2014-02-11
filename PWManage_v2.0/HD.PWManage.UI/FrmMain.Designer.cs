namespace HD.PWManage.UI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabControlEx1 = new HD.MyControls.TabControlEx();
            this.tpMMGL = new System.Windows.Forms.TabPage();
            this.tpSetUp = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dgvInfos = new System.Windows.Forms.DataGridView();
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlEx1.SuspendLayout();
            this.tpMMGL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEx1
            // 
            this.tabControlEx1.Controls.Add(this.tpMMGL);
            this.tabControlEx1.Controls.Add(this.tpSetUp);
            this.tabControlEx1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControlEx1.Image = ((System.Drawing.Image)(resources.GetObject("tabControlEx1.Image")));
            this.tabControlEx1.ImageList = this.imageList;
            this.tabControlEx1.ItemSize = new System.Drawing.Size(110, 60);
            this.tabControlEx1.Location = new System.Drawing.Point(12, 31);
            this.tabControlEx1.Name = "tabControlEx1";
            this.tabControlEx1.SelectedIndex = 0;
            this.tabControlEx1.Size = new System.Drawing.Size(736, 477);
            this.tabControlEx1.TabIndex = 0;
            // 
            // tpMMGL
            // 
            this.tpMMGL.Controls.Add(this.dgvInfos);
            this.tpMMGL.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpMMGL.ImageIndex = 0;
            this.tpMMGL.Location = new System.Drawing.Point(4, 64);
            this.tpMMGL.Name = "tpMMGL";
            this.tpMMGL.Padding = new System.Windows.Forms.Padding(3);
            this.tpMMGL.Size = new System.Drawing.Size(728, 409);
            this.tpMMGL.TabIndex = 0;
            this.tpMMGL.Tag = 0;
            this.tpMMGL.Text = "密码管理";
            this.tpMMGL.UseVisualStyleBackColor = true;
            // 
            // tpSetUp
            // 
            this.tpSetUp.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpSetUp.ImageIndex = 1;
            this.tpSetUp.Location = new System.Drawing.Point(4, 64);
            this.tpSetUp.Name = "tpSetUp";
            this.tpSetUp.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetUp.Size = new System.Drawing.Size(728, 409);
            this.tpSetUp.TabIndex = 1;
            this.tpSetUp.Tag = 0;
            this.tpSetUp.Text = "系统设置";
            this.tpSetUp.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "application-sidebar.png");
            this.imageList.Images.SetKeyName(1, "color-swatch.png");
            this.imageList.Images.SetKeyName(2, "blue-document-text.png");
            this.imageList.Images.SetKeyName(3, "calendar-blue.png");
            this.imageList.Images.SetKeyName(4, "clock.png");
            this.imageList.Images.SetKeyName(5, "color.png");
            this.imageList.Images.SetKeyName(6, "keyboard.png");
            // 
            // dgvInfos
            // 
            this.dgvInfos.AllowUserToAddRows = false;
            this.dgvInfos.AllowUserToDeleteRows = false;
            this.dgvInfos.AllowUserToResizeRows = false;
            this.dgvInfos.BackgroundColor = System.Drawing.Color.White;
            this.dgvInfos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInfos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb,
            this.id,
            this.key,
            this.name,
            this.pw,
            this.type});
            this.dgvInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfos.Location = new System.Drawing.Point(3, 3);
            this.dgvInfos.MultiSelect = false;
            this.dgvInfos.Name = "dgvInfos";
            this.dgvInfos.RowHeadersVisible = false;
            this.dgvInfos.RowTemplate.Height = 23;
            this.dgvInfos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfos.Size = new System.Drawing.Size(722, 403);
            this.dgvInfos.TabIndex = 1;
            // 
            // cb
            // 
            this.cb.FalseValue = "0";
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
            this.cb.TrueValue = "1";
            this.cb.Width = 30;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // key
            // 
            this.key.DataPropertyName = "key";
            this.key.HeaderText = "关键字";
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.Width = 230;
            // 
            // name
            // 
            this.name.DataPropertyName = "UName";
            this.name.HeaderText = "登录名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 230;
            // 
            // pw
            // 
            this.pw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pw.DataPropertyName = "pw";
            this.pw.HeaderText = "密码";
            this.pw.Name = "pw";
            this.pw.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "加密方法";
            this.type.Name = "type";
            this.type.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(128)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Controls.Add(this.tabControlEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmMain";
            this.Text = "密码管理器";
            this.tabControlEx1.ResumeLayout(false);
            this.tpMMGL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.TabControlEx tabControlEx1;
        private System.Windows.Forms.TabPage tpMMGL;
        private System.Windows.Forms.TabPage tpSetUp;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.DataGridView dgvInfos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pw;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}