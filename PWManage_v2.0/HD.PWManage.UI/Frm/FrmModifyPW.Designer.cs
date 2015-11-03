namespace HD.PWManage.UI.Frm
{
    partial class FrmModifyPW
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOldPw = new HD.MyControls.QQTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConPw = new HD.MyControls.QQTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPw = new HD.MyControls.QQTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new HD.MyControls.QQButton();
            this.btnSave = new HD.MyControls.QQButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOldPw);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtConPw);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNewPw);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "登录密码：";
            // 
            // txtOldPw
            // 
            this.txtOldPw.AcceptsReturn = true;
            this.txtOldPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldPw.EmptyTextTip = null;
            this.txtOldPw.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtOldPw.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtOldPw.Location = new System.Drawing.Point(137, 20);
            this.txtOldPw.Name = "txtOldPw";
            this.txtOldPw.PasswordChar = '*';
            this.txtOldPw.Size = new System.Drawing.Size(165, 23);
            this.txtOldPw.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "原密码：";
            // 
            // txtConPw
            // 
            this.txtConPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConPw.EmptyTextTip = null;
            this.txtConPw.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtConPw.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtConPw.Location = new System.Drawing.Point(137, 106);
            this.txtConPw.Name = "txtConPw";
            this.txtConPw.PasswordChar = '*';
            this.txtConPw.Size = new System.Drawing.Size(165, 23);
            this.txtConPw.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "确认新密码：";
            // 
            // txtNewPw
            // 
            this.txtNewPw.AcceptsReturn = true;
            this.txtNewPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPw.EmptyTextTip = null;
            this.txtNewPw.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtNewPw.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtNewPw.Location = new System.Drawing.Point(137, 63);
            this.txtNewPw.Name = "txtNewPw";
            this.txtNewPw.PasswordChar = '*';
            this.txtNewPw.Size = new System.Drawing.Size(165, 23);
            this.txtNewPw.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "新密码：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 54);
            this.panel1.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnCancel.Location = new System.Drawing.Point(201, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSave.Location = new System.Drawing.Point(109, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmModifyPW
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(378, 205);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmModifyPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MyControls.QQTextBox txtConPw;
        private System.Windows.Forms.Label label4;
        private MyControls.QQTextBox txtNewPw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private MyControls.QQButton btnCancel;
        private MyControls.QQButton btnSave;
        private MyControls.QQTextBox txtOldPw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}