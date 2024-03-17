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
	}
}
