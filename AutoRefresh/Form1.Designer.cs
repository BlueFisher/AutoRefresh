namespace AutoRefresh {
	partial class Form1 {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnGo = new System.Windows.Forms.Button();
			this.txtInterval = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStop = new System.Windows.Forms.Button();
			this.lblNo = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.wbrowser = new System.Windows.Forms.WebBrowser();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnGo);
			this.groupBox1.Controls.Add(this.txtInterval);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtUrl);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(935, 57);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Setting";
			// 
			// btnGo
			// 
			this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGo.Location = new System.Drawing.Point(663, 18);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 25);
			this.btnGo.TabIndex = 4;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// txtInterval
			// 
			this.txtInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtInterval.Location = new System.Drawing.Point(853, 18);
			this.txtInterval.Name = "txtInterval";
			this.txtInterval.Size = new System.Drawing.Size(76, 25);
			this.txtInterval.TabIndex = 3;
			this.txtInterval.Text = "5";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(744, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Interval(s):";
			// 
			// txtUrl
			// 
			this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUrl.Location = new System.Drawing.Point(51, 18);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(606, 25);
			this.txtUrl.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btnStop);
			this.groupBox2.Controls.Add(this.lblNo);
			this.groupBox2.Controls.Add(this.btnStart);
			this.groupBox2.Location = new System.Drawing.Point(12, 75);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(220, 454);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Info";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 15);
			this.label3.TabIndex = 3;
			this.label3.Text = "Has Refreshed:";
			// 
			// btnStop
			// 
			this.btnStop.Enabled = false;
			this.btnStop.Location = new System.Drawing.Point(6, 76);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(208, 46);
			this.btnStop.TabIndex = 2;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// lblNo
			// 
			this.lblNo.AutoSize = true;
			this.lblNo.Font = new System.Drawing.Font("宋体", 9F);
			this.lblNo.Location = new System.Drawing.Point(6, 177);
			this.lblNo.Name = "lblNo";
			this.lblNo.Size = new System.Drawing.Size(15, 15);
			this.lblNo.TabIndex = 1;
			this.lblNo.Text = "0";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(6, 24);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(208, 46);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.wbrowser);
			this.groupBox3.Location = new System.Drawing.Point(238, 75);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(403, 454);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Browser";
			// 
			// wbrowser
			// 
			this.wbrowser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbrowser.Location = new System.Drawing.Point(3, 21);
			this.wbrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbrowser.Name = "wbrowser";
			this.wbrowser.Size = new System.Drawing.Size(397, 430);
			this.wbrowser.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(647, 75);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(300, 454);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(30, 234);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 541);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "AutoRefresh - Fisher";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtInterval;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lblNo;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.WebBrowser wbrowser;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
	}
}

