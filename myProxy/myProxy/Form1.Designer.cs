namespace myProxy
{
    partial class MyProxy
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
            this.BtnStart = new System.Windows.Forms.Button();
            this.comboBoxIp = new System.Windows.Forms.ComboBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStart.Location = new System.Drawing.Point(285, 203);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // comboBoxIp
            // 
            this.comboBoxIp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxIp.FormattingEnabled = true;
            this.comboBoxIp.Location = new System.Drawing.Point(105, 26);
            this.comboBoxIp.Name = "comboBoxIp";
            this.comboBoxIp.Size = new System.Drawing.Size(121, 20);
            this.comboBoxIp.TabIndex = 1;
            // 
            // textPort
            // 
            this.textPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textPort.Location = new System.Drawing.Point(369, 26);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 21);
            this.textPort.TabIndex = 2;
            // 
            // labelIP
            // 
            this.labelIP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(57, 35);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(23, 12);
            this.labelIP.TabIndex = 3;
            this.labelIP.Text = "IP:";
            // 
            // labelPort
            // 
            this.labelPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(322, 29);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 12);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Port";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(394, 203);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(32, 81);
            this.richTextBox1.MinimumSize = new System.Drawing.Size(200, 100);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(502, 100);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // MyProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 250);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.comboBoxIp);
            this.Controls.Add(this.BtnStart);
            this.Name = "MyProxy";
            this.Text = "myProxy";
            this.Load += new System.EventHandler(this.myProxy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ComboBox comboBoxIp;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

