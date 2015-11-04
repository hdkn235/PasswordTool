namespace HD.PWManage.UI.Frm
{
    partial class FrmConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStartVoiceLogin = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbStartVoiceLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 425);
            this.panel1.TabIndex = 0;
            // 
            // cbStartVoiceLogin
            // 
            this.cbStartVoiceLogin.AutoSize = true;
            this.cbStartVoiceLogin.Location = new System.Drawing.Point(23, 27);
            this.cbStartVoiceLogin.Name = "cbStartVoiceLogin";
            this.cbStartVoiceLogin.Size = new System.Drawing.Size(96, 16);
            this.cbStartVoiceLogin.TabIndex = 0;
            this.cbStartVoiceLogin.Text = "开启语音登录";
            this.cbStartVoiceLogin.UseVisualStyleBackColor = true;
            this.cbStartVoiceLogin.CheckedChanged += new System.EventHandler(this.cbStartVoiceLogin_CheckedChanged);
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 425);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfig";
            this.Text = "FrmConfig";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbStartVoiceLogin;
    }
}