namespace FMSBackground
{
    partial class FrmUpUserPwd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.texRealPwd = new System.Windows.Forms.TextBox();
            this.texOldPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texNewPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btNo = new System.Windows.Forms.Button();
            this.btYes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.texRealPwd);
            this.groupBox1.Controls.Add(this.texOldPwd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.texNewPwd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改密码";
            // 
            // texRealPwd
            // 
            this.texRealPwd.Location = new System.Drawing.Point(149, 123);
            this.texRealPwd.Name = "texRealPwd";
            this.texRealPwd.PasswordChar = '*';
            this.texRealPwd.Size = new System.Drawing.Size(217, 25);
            this.texRealPwd.TabIndex = 1;
            // 
            // texOldPwd
            // 
            this.texOldPwd.Location = new System.Drawing.Point(149, 41);
            this.texOldPwd.Name = "texOldPwd";
            this.texOldPwd.Size = new System.Drawing.Size(217, 25);
            this.texOldPwd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "请输入原密码：";
            // 
            // texNewPwd
            // 
            this.texNewPwd.Location = new System.Drawing.Point(149, 81);
            this.texNewPwd.Name = "texNewPwd";
            this.texNewPwd.PasswordChar = '*';
            this.texNewPwd.Size = new System.Drawing.Size(217, 25);
            this.texNewPwd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "请输入新密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "请确认新密码：";
            // 
            // btNo
            // 
            this.btNo.Location = new System.Drawing.Point(327, 192);
            this.btNo.Name = "btNo";
            this.btNo.Size = new System.Drawing.Size(82, 36);
            this.btNo.TabIndex = 1;
            this.btNo.Text = "取消";
            this.btNo.UseVisualStyleBackColor = true;
            this.btNo.Click += new System.EventHandler(this.btNo_Click);
            // 
            // btYes
            // 
            this.btYes.Location = new System.Drawing.Point(227, 192);
            this.btYes.Name = "btYes";
            this.btYes.Size = new System.Drawing.Size(82, 36);
            this.btYes.TabIndex = 1;
            this.btYes.Text = "确定";
            this.btYes.UseVisualStyleBackColor = true;
            this.btYes.Click += new System.EventHandler(this.btYes_Click);
            // 
            // FrmUpUserPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(423, 240);
            this.Controls.Add(this.btYes);
            this.Controls.Add(this.btNo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpUserPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "修改密码";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FrmUpUserPwd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texRealPwd;
        private System.Windows.Forms.TextBox texOldPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texNewPwd;
        private System.Windows.Forms.Button btNo;
        private System.Windows.Forms.Button btYes;
    }
}