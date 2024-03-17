using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace open_pid_tuner
{
	internal class OpenChart
	{
		private readonly Chart _chart = null;
		private readonly HScrollBar _hScrollBar = null;

		public OpenChart(ref Chart chart1, ref HScrollBar hScrollBar1)
		{
			this._chart = chart1;
			this._hScrollBar = hScrollBar1;
			Initialize();
		}

		internal void Initialize()
		{
			var objChart = _chart.ChartAreas[0];
			objChart.AxisX.IntervalType = DateTimeIntervalType.Number;
			_chart.Series.Clear();
			_chart.Series.Add("Temperature");
			_chart.Series.Add("Setpoint");
			_chart.Series.Add("PWM");
			_chart.Series[0].Points.AddY(100);
			_chart.Series[0].Points.AddY(150);
		}
	}
}
