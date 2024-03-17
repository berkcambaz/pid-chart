namespace open_pid_tuner
{
	partial class Form1
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.cbBaud = new System.Windows.Forms.ComboBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.cbPort = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtSetpoint = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtKD = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtKI = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtKP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.rtbTerminal = new System.Windows.Forms.RichTextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDisconnect);
			this.groupBox1.Controls.Add(this.cbBaud);
			this.groupBox1.Controls.Add(this.btnConnect);
			this.groupBox1.Controls.Add(this.cbPort);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(90, 127);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Serial port";
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Location = new System.Drawing.Point(6, 70);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
			this.btnDisconnect.TabIndex = 3;
			this.btnDisconnect.Text = "Disonnect";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			// 
			// cbBaud
			// 
			this.cbBaud.FormattingEnabled = true;
			this.cbBaud.Items.AddRange(new object[] {
            "9600"});
			this.cbBaud.Location = new System.Drawing.Point(7, 46);
			this.cbBaud.Name = "cbBaud";
			this.cbBaud.Size = new System.Drawing.Size(74, 21);
			this.cbBaud.TabIndex = 2;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(6, 96);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			// 
			// cbPort
			// 
			this.cbPort.FormattingEnabled = true;
			this.cbPort.Location = new System.Drawing.Point(7, 20);
			this.cbPort.Name = "cbPort";
			this.cbPort.Size = new System.Drawing.Size(74, 21);
			this.cbPort.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtSetpoint);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtKD);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtKI);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtKP);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(110, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(142, 127);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "PID parameters";
			// 
			// txtSetpoint
			// 
			this.txtSetpoint.Location = new System.Drawing.Point(32, 98);
			this.txtSetpoint.Name = "txtSetpoint";
			this.txtSetpoint.Size = new System.Drawing.Size(100, 20);
			this.txtSetpoint.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "set";
			// 
			// txtKD
			// 
			this.txtKD.Location = new System.Drawing.Point(32, 72);
			this.txtKD.Name = "txtKD";
			this.txtKD.Size = new System.Drawing.Size(100, 20);
			this.txtKD.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "kD";
			// 
			// txtKI
			// 
			this.txtKI.Location = new System.Drawing.Point(32, 46);
			this.txtKI.Name = "txtKI";
			this.txtKI.Size = new System.Drawing.Size(100, 20);
			this.txtKI.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "kI";
			// 
			// txtKP
			// 
			this.txtKP.Location = new System.Drawing.Point(32, 20);
			this.txtKP.Name = "txtKP";
			this.txtKP.Size = new System.Drawing.Size(100, 20);
			this.txtKP.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "kP";
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(12, 146);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Temperature";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "Setpoint";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "PWM";
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(559, 187);
			this.chart1.TabIndex = 2;
			this.chart1.Text = "chart1";
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(9, 337);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.Size = new System.Drawing.Size(565, 17);
			this.hScrollBar1.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Command";
			// 
			// txtCommand
			// 
			this.txtCommand.Location = new System.Drawing.Point(68, 101);
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.Size = new System.Drawing.Size(155, 20);
			this.txtCommand.TabIndex = 6;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(227, 99);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 3;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			// 
			// rtbTerminal
			// 
			this.rtbTerminal.Location = new System.Drawing.Point(6, 19);
			this.rtbTerminal.Name = "rtbTerminal";
			this.rtbTerminal.Size = new System.Drawing.Size(296, 76);
			this.rtbTerminal.TabIndex = 7;
			this.rtbTerminal.Text = "";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.rtbTerminal);
			this.groupBox3.Controls.Add(this.btnSend);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.txtCommand);
			this.groupBox3.Location = new System.Drawing.Point(258, 13);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(312, 127);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Terminal";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 362);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.hScrollBar1);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Open PID Tuner";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.ComboBox cbPort;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtKP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbBaud;
		private System.Windows.Forms.TextBox txtKD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtKI;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCommand;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.RichTextBox rtbTerminal;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtSetpoint;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnDisconnect;
		public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
	}
}

