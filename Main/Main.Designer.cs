namespace Main
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.token_label_text = new CCWin.SkinControl.SkinLabel();
            this.Site_text = new CCWin.SkinControl.SkinWaterTextBox();
            this.Token_text = new CCWin.SkinControl.SkinWaterTextBox();
            this.rtfRichTextBox1 = new CCWin.SkinControl.RtfRichTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.LinkSubmit = new CCWin.SkinControl.SkinButton();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.Verification_Button = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(32, 64);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "域名：";
            // 
            // token_label_text
            // 
            this.token_label_text.AutoSize = true;
            this.token_label_text.BackColor = System.Drawing.Color.Transparent;
            this.token_label_text.BorderColor = System.Drawing.Color.White;
            this.token_label_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.token_label_text.Location = new System.Drawing.Point(32, 100);
            this.token_label_text.Name = "token_label_text";
            this.token_label_text.Size = new System.Drawing.Size(44, 17);
            this.token_label_text.TabIndex = 1;
            this.token_label_text.Text = "密钥：";
            // 
            // Site_text
            // 
            this.Site_text.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Site_text.Location = new System.Drawing.Point(76, 62);
            this.Site_text.Name = "Site_text";
            this.Site_text.Size = new System.Drawing.Size(208, 21);
            this.Site_text.TabIndex = 2;
            this.Site_text.Text = "请输入百度搜索资源平台验证的站点";
            this.Site_text.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Site_text.WaterText = "";
            this.Site_text.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Site_text_MouseClick);
            // 
            // Token_text
            // 
            this.Token_text.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Token_text.Location = new System.Drawing.Point(76, 96);
            this.Token_text.Name = "Token_text";
            this.Token_text.Size = new System.Drawing.Size(208, 21);
            this.Token_text.TabIndex = 3;
            this.Token_text.Text = "请输入准入密钥";
            this.Token_text.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.Token_text.WaterText = "";
            this.Token_text.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Token_text_MouseClick);
            // 
            // rtfRichTextBox1
            // 
            this.rtfRichTextBox1.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBox1.Location = new System.Drawing.Point(76, 138);
            this.rtfRichTextBox1.Name = "rtfRichTextBox1";
            this.rtfRichTextBox1.Size = new System.Drawing.Size(208, 244);
            this.rtfRichTextBox1.TabIndex = 4;
            this.rtfRichTextBox1.Text = "";
            this.rtfRichTextBox1.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(32, 148);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(44, 34);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "链接\r\n地址：";
            // 
            // LinkSubmit
            // 
            this.LinkSubmit.BackColor = System.Drawing.Color.Transparent;
            this.LinkSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.LinkSubmit.DownBack = null;
            this.LinkSubmit.Location = new System.Drawing.Point(209, 405);
            this.LinkSubmit.MouseBack = null;
            this.LinkSubmit.Name = "LinkSubmit";
            this.LinkSubmit.NormlBack = null;
            this.LinkSubmit.Size = new System.Drawing.Size(75, 23);
            this.LinkSubmit.TabIndex = 6;
            this.LinkSubmit.Text = "提交";
            this.LinkSubmit.UseVisualStyleBackColor = false;
            this.LinkSubmit.Click += new System.EventHandler(this.LinkSubmit_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(7, 457);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(44, 17);
            this.skinLabel4.TabIndex = 7;
            this.skinLabel4.Text = "状态：";
            // 
            // Verification_Button
            // 
            this.Verification_Button.BackColor = System.Drawing.Color.Transparent;
            this.Verification_Button.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Verification_Button.DownBack = null;
            this.Verification_Button.Location = new System.Drawing.Point(76, 405);
            this.Verification_Button.MouseBack = null;
            this.Verification_Button.Name = "Verification_Button";
            this.Verification_Button.NormlBack = null;
            this.Verification_Button.Size = new System.Drawing.Size(75, 23);
            this.Verification_Button.TabIndex = 8;
            this.Verification_Button.Text = "验证";
            this.Verification_Button.UseVisualStyleBackColor = false;
            this.Verification_Button.Click += new System.EventHandler(this.Verification_Button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 478);
            this.Controls.Add(this.Verification_Button);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.LinkSubmit);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.rtfRichTextBox1);
            this.Controls.Add(this.Token_text);
            this.Controls.Add(this.Site_text);
            this.Controls.Add(this.token_label_text);
            this.Controls.Add(this.skinLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "百度主动推送链接工具";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel token_label_text;
        private CCWin.SkinControl.SkinWaterTextBox Site_text;
        private CCWin.SkinControl.SkinWaterTextBox Token_text;
        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton LinkSubmit;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinButton Verification_Button;
    }
}

