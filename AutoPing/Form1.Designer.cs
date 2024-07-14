namespace AutoPing
{
    partial class Form1
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
            this.btnOpenLogs = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxInterval = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenLogs
            // 
            this.btnOpenLogs.Location = new System.Drawing.Point(12, 12);
            this.btnOpenLogs.Name = "btnOpenLogs";
            this.btnOpenLogs.Size = new System.Drawing.Size(87, 31);
            this.btnOpenLogs.TabIndex = 0;
            this.btnOpenLogs.Text = "打开日志";
            this.btnOpenLogs.UseVisualStyleBackColor = true;
            this.btnOpenLogs.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 140);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 584);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // tbxHost
            // 
            this.tbxHost.Location = new System.Drawing.Point(84, 54);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(100, 21);
            this.tbxHost.TabIndex = 2;
            this.tbxHost.TextChanged += new System.EventHandler(this.tbxHost_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "目标设备IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "时间间隔（秒）";
            // 
            // tbxInterval
            // 
            this.tbxInterval.Location = new System.Drawing.Point(108, 81);
            this.tbxInterval.Name = "tbxInterval";
            this.tbxInterval.Size = new System.Drawing.Size(100, 21);
            this.tbxInterval.TabIndex = 4;
            this.tbxInterval.TextChanged += new System.EventHandler(this.tbxInterval_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 31);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始Ping";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(108, 103);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 31);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "停止Ping";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 736);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxHost);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnOpenLogs);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "AutoPing工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenLogs;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxInterval;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}

