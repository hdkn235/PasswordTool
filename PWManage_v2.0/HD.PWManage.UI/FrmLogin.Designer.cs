namespace HD.PWManage.UI
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_Title = new System.Windows.Forms.Panel();
            this.panel_ALL = new System.Windows.Forms.Panel();
            this.btnCancel = new HD.MyControls.VistaButton();
            this.btnLogin = new HD.MyControls.VistaButton();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox_Min = new System.Windows.Forms.PictureBox();
            this.pictureBox_Max = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel_Title.SuspendLayout();
            this.panel_ALL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Max)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录密码";
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(101, 42);
            this.txtPw.Name = "txtPw";
            this.txtPw.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(172, 21);
            this.txtPw.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel_Title
            // 
            this.panel_Title.Controls.Add(this.pictureBox_Close);
            this.panel_Title.Controls.Add(this.pictureBox_Min);
            this.panel_Title.Controls.Add(this.pictureBox_Max);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(298, 37);
            this.panel_Title.TabIndex = 4;
            // 
            // panel_ALL
            // 
            this.panel_ALL.Controls.Add(this.btnCancel);
            this.panel_ALL.Controls.Add(this.btnLogin);
            this.panel_ALL.Controls.Add(this.txtPw);
            this.panel_ALL.Controls.Add(this.label1);
            this.panel_ALL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ALL.Location = new System.Drawing.Point(0, 37);
            this.panel_ALL.Name = "panel_ALL";
            this.panel_ALL.Size = new System.Drawing.Size(298, 157);
            this.panel_ALL.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Transparent;
            this.btnCancel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(252)))));
            this.btnCancel.ButtonText = "退出";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(128)))), ((int)(((byte)(226)))));
            this.btnCancel.Location = new System.Drawing.Point(175, 97);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BaseColor = System.Drawing.Color.Transparent;
            this.btnLogin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(252)))));
            this.btnLogin.ButtonText = "登录";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(128)))), ((int)(((byte)(226)))));
            this.btnLogin.Location = new System.Drawing.Point(40, 97);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 32);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Close.Location = new System.Drawing.Point(266, 9);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Close.TabIndex = 6;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Tag = "2";
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Close.MouseEnter += new System.EventHandler(this.pictureBox_Close_MouseEnter);
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Close_MouseLeave);
            // 
            // pictureBox_Min
            // 
            this.pictureBox_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Min.Location = new System.Drawing.Point(214, 9);
            this.pictureBox_Min.Name = "pictureBox_Min";
            this.pictureBox_Min.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Min.TabIndex = 5;
            this.pictureBox_Min.TabStop = false;
            this.pictureBox_Min.Tag = "0";
            this.pictureBox_Min.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Min.MouseEnter += new System.EventHandler(this.pictureBox_Close_MouseEnter);
            this.pictureBox_Min.MouseLeave += new System.EventHandler(this.pictureBox_Close_MouseLeave);
            // 
            // pictureBox_Max
            // 
            this.pictureBox_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Max.Location = new System.Drawing.Point(240, 9);
            this.pictureBox_Max.Name = "pictureBox_Max";
            this.pictureBox_Max.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Max.TabIndex = 4;
            this.pictureBox_Max.TabStop = false;
            this.pictureBox_Max.Tag = "1";
            this.pictureBox_Max.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Max.MouseEnter += new System.EventHandler(this.pictureBox_Close_MouseEnter);
            this.pictureBox_Max.MouseLeave += new System.EventHandler(this.pictureBox_Close_MouseLeave);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 194);
            this.Controls.Add(this.panel_ALL);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码管理器";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel_Title.ResumeLayout(false);
            this.panel_ALL.ResumeLayout(false);
            this.panel_ALL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Max)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel_ALL;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.PictureBox pictureBox_Min;
        private System.Windows.Forms.PictureBox pictureBox_Max;
        private MyControls.VistaButton btnCancel;
        private MyControls.VistaButton btnLogin;
    }
}