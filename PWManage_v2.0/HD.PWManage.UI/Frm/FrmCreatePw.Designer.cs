namespace HD.PWManage.UI
{
    partial class FrmCreatePw
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
            this.txtTitle = new HD.MyControls.QQTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMainPw = new HD.MyControls.QQTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPw = new HD.MyControls.QQTextBox();
            this.btnSave = new HD.MyControls.QQButton();
            this.btnCancel = new HD.MyControls.QQButton();
            this.btnCreate = new HD.MyControls.QQGlassButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.EmptyTextTip = null;
            this.txtTitle.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtTitle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtTitle.Location = new System.Drawing.Point(80, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(186, 23);
            this.txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "标题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "主密码";
            // 
            // txtMainPw
            // 
            this.txtMainPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMainPw.EmptyTextTip = null;
            this.txtMainPw.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtMainPw.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtMainPw.Location = new System.Drawing.Point(80, 76);
            this.txtMainPw.Name = "txtMainPw";
            this.txtMainPw.Size = new System.Drawing.Size(186, 23);
            this.txtMainPw.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码";
            // 
            // txtPw
            // 
            this.txtPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPw.EmptyTextTip = null;
            this.txtPw.EmptyTextTipColor = System.Drawing.Color.DarkGray;
            this.txtPw.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtPw.Location = new System.Drawing.Point(80, 123);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(271, 23);
            this.txtPw.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(94, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(228, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(69, 30);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(128)))), ((int)(((byte)(226)))));
            this.btnCreate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCreate.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreate.Image = global::HD.PWManage.UI.Properties.Resources._6400;
            this.btnCreate.Location = new System.Drawing.Point(281, 27);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(70, 70);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.TabStop = false;
            this.btnCreate.ToolTipText = null;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FrmCreatePw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(377, 222);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMainPw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreatePw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "密码生成";
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.QQTextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MyControls.QQTextBox txtMainPw;
        private System.Windows.Forms.Label label3;
        private MyControls.QQTextBox txtPw;
        private MyControls.QQButton btnSave;
        private MyControls.QQButton btnCancel;
        private MyControls.QQGlassButton btnCreate;
    }
}