using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AutoRefresh {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void btnGo_Click(object sender, EventArgs e) {
			wbrowser.Navigate(txtUrl.Text);
			
		}

		private void btnStart_Click(object sender, EventArgs e) {
			btnGo.Enabled = false;
			btnStart.Enabled = false;
			btnStop.Enabled = true;
			timer1.Interval = Convert.ToInt32(txtInterval.Text) * 1000;
			timer1.Enabled = true;
		}

		private void btnStop_Click(object sender, EventArgs e) {
			btnGo.Enabled = true;
			btnStart.Enabled = true;
			btnStop.Enabled = false;
			timer1.Enabled = false;
			lblNo.Text = "0";
			no = 0;
		}

		int no = 1;

		private void timer1_Tick(object sender, EventArgs e) {
			wbrowser.Refresh();
			lblNo.Text = no++.ToString();
		}

		private void button1_Click(object sender, EventArgs e) {
			textBox1.Text = wbrowser.DocumentText;
		}
	}
}
