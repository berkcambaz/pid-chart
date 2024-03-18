using System;
using System.Windows.Forms;

namespace open_pid_tuner
{
	public partial class Form1 : Form
	{
		private readonly OpenChart openChart = null;
		public Form1()
		{
			InitializeComponent();
			openChart = new OpenChart(ref chart1, ref hScrollBar1);
			//openChart.Test();
		}

		private void btnSend_Click(object sender, System.EventArgs e)
		{
			Random random = new Random();
			for (int i = 0; i < 200; i++)
			{
				openChart.AddY("Temperature", random.Next(200, 255));
				openChart.AddY("Setpoint", random.Next(100, 155));
				openChart.AddY("PWM", random.Next(50, 100));
			}
			openChart.Render();
		}

		private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			openChart.Render();
		}
	}
}
