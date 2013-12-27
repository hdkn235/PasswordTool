namespace HD.PWManage.UI
{
    partial class FrmManage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvInfos = new System.Windows.Forms.DataGridView();
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfirmPw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtNewPw = new System.Windows.Forms.TextBox();
            this.txtOldPw = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.dgvInfos.Location = new System.Drawing.Point(0, 0);
            this.dgvInfos.MultiSelect = false;
            this.dgvInfos.Name = "dgvInfos";
            this.dgvInfos.RowHeadersVisible = false;
            this.dgvInfos.RowTemplate.Height = 23;
            this.dgvInfos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfos.Size = new System.Drawing.Size(740, 412);
            this.dgvInfos.TabIndex = 0;
            this.dgvInfos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfos_CellDoubleClick);
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
            this.key.Width = 230;
            // 
            // name
            // 
            this.name.DataPropertyName = "UName";
            this.name.HeaderText = "登录名";
            this.name.Name = "name";
            this.name.Width = 230;
            // 
            // pw
            // 
            this.pw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pw.DataPropertyName = "pw";
            this.pw.HeaderText = "密码";
            this.pw.Name = "pw";
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "加密方法";
            this.type.Name = "type";
            this.type.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvInfos);
            this.splitContainer1.Size = new System.Drawing.Size(740, 547);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 130);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 102);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "关键字";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(260, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 23);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.btnDel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.txtKey);
            this.tabPage1.Controls.Add(this.btnNew);
            this.tabPage1.Controls.Add(this.txtPw);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 104);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "登记";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(256, 63);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(38, 23);
            this.txtID.TabIndex = 26;
            this.txtID.Visible = false;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(613, 60);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(87, 27);
            this.btnDel.TabIndex = 25;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "登录名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 21;
            this.label1.Text = "关键字";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(322, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 23);
            this.txtName.TabIndex = 15;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(90, 15);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(160, 23);
            this.txtKey.TabIndex = 14;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(404, 60);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(87, 27);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "新建";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(546, 15);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(154, 23);
            this.txtPw.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(510, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCancel);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtConfirmPw);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.btnConfirm);
            this.tabPage3.Controls.Add(this.txtNewPw);
            this.tabPage3.Controls.Add(this.txtOldPw);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(732, 104);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "修改密码";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(566, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "确认新密码";
            // 
            // txtConfirmPw
            // 
            this.txtConfirmPw.Location = new System.Drawing.Point(575, 28);
            this.txtConfirmPw.Name = "txtConfirmPw";
            this.txtConfirmPw.PasswordChar = '*';
            this.txtConfirmPw.Size = new System.Drawing.Size(133, 23);
            this.txtConfirmPw.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "新密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "旧密码";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(452, 70);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtNewPw
            // 
            this.txtNewPw.Location = new System.Drawing.Point(336, 28);
            this.txtNewPw.Name = "txtNewPw";
            this.txtNewPw.PasswordChar = '*';
            this.txtNewPw.Size = new System.Drawing.Size(133, 23);
            this.txtNewPw.TabIndex = 1;
            // 
            // txtOldPw
            // 
            this.txtOldPw.Location = new System.Drawing.Point(101, 28);
            this.txtOldPw.Name = "txtOldPw";
            this.txtOldPw.PasswordChar = '*';
            this.txtOldPw.Size = new System.Drawing.Size(133, 23);
            this.txtOldPw.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 547);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码管理器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmManage_FormClosing);
            this.Load += new System.EventHandler(this.FrmManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConfirmPw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtNewPw;
        private System.Windows.Forms.TextBox txtOldPw;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pw;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}

