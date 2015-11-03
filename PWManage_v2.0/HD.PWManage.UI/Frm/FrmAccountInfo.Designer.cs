namespace HD.PWManage.UI
{
    partial class FrmAccountInfo
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
            this.plAccountInfo = new System.Windows.Forms.Panel();
            this.btnCancel = new HD.MyControls.QQButton();
            this.txtRemark = new HD.MyControls.QQTextBox();
            this.txtEmail = new HD.MyControls.QQTextBox();
            this.txtWebUrl = new HD.MyControls.QQTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new HD.MyControls.QQButton();
            this.txtUserPassWord = new HD.MyControls.QQTextBox();
            this.txtUserName = new HD.MyControls.QQTextBox();
            this.txtTitle = new HD.MyControls.QQTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.plAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // plAccountInfo
            // 
            this.plAccountInfo.Controls.Add(this.label9);
            this.plAccountInfo.Controls.Add(this.label8);
            this.plAccountInfo.Controls.Add(this.label7);
            this.plAccountInfo.Controls.Add(this.btnCancel);
            this.plAccountInfo.Controls.Add(this.txtRemark);
            this.plAccountInfo.Controls.Add(this.txtEmail);
            this.plAccountInfo.Controls.Add(this.txtWebUrl);
            this.plAccountInfo.Controls.Add(this.label4);
            this.plAccountInfo.Controls.Add(this.label5);
            this.plAccountInfo.Controls.Add(this.label6);
            this.plAccountInfo.Controls.Add(this.btnSave);
            this.plAccountInfo.Controls.Add(this.txtUserPassWord);
            this.plAccountInfo.Controls.Add(this.txtUserName);
            this.plAccountInfo.Controls.Add(this.txtTitle);
            this.plAccountInfo.Controls.Add(this.label3);
            this.plAccountInfo.Controls.Add(this.label2);
            this.plAccountInfo.Controls.Add(this.label1);
            this.plAccountInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plAccountInfo.Location = new System.Drawing.Point(0, 0);
            this.plAccountInfo.Name = "plAccountInfo";
            this.plAccountInfo.Size = new System.Drawing.Size(373, 417);
            this.plAccountInfo.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(211, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 30);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.EmptyTextTip = null;
            this.txtRemark.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtRemark.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtRemark.Location = new System.Drawing.Point(79, 236);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(250, 124);
            this.txtRemark.TabIndex = 36;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.EmptyTextTip = null;
            this.txtEmail.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtEmail.Location = new System.Drawing.Point(79, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 23);
            this.txtEmail.TabIndex = 35;
            // 
            // txtWebUrl
            // 
            this.txtWebUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWebUrl.EmptyTextTip = null;
            this.txtWebUrl.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtWebUrl.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtWebUrl.Location = new System.Drawing.Point(79, 152);
            this.txtWebUrl.Name = "txtWebUrl";
            this.txtWebUrl.Size = new System.Drawing.Size(250, 23);
            this.txtWebUrl.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 33;
            this.label4.Text = "邮箱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 32;
            this.label5.Text = "网址";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "备注";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(91, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 30);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUserPassWord
            // 
            this.txtUserPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserPassWord.EmptyTextTip = null;
            this.txtUserPassWord.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtUserPassWord.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtUserPassWord.Location = new System.Drawing.Point(79, 110);
            this.txtUserPassWord.Name = "txtUserPassWord";
            this.txtUserPassWord.Size = new System.Drawing.Size(250, 23);
            this.txtUserPassWord.TabIndex = 29;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.EmptyTextTip = null;
            this.txtUserName.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtUserName.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtUserName.Location = new System.Drawing.Point(79, 68);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 23);
            this.txtUserName.TabIndex = 28;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.EmptyTextTip = null;
            this.txtTitle.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtTitle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtTitle.Location = new System.Drawing.Point(79, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(250, 23);
            this.txtTitle.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "关键词";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(333, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 38;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(333, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 39;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(333, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "*";
            // 
            // FrmAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 417);
            this.Controls.Add(this.plAccountInfo);
            this.Name = "FrmAccountInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账号信息";
            this.Load += new System.EventHandler(this.FrmAccountInfo_Load);
            this.plAccountInfo.ResumeLayout(false);
            this.plAccountInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plAccountInfo;
        private MyControls.QQButton btnCancel;
        private MyControls.QQTextBox txtRemark;
        private MyControls.QQTextBox txtEmail;
        private MyControls.QQTextBox txtWebUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MyControls.QQButton btnSave;
        private MyControls.QQTextBox txtUserPassWord;
        private MyControls.QQTextBox txtUserName;
        private MyControls.QQTextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}