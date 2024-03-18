using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace open_pid_tuner
{
	internal class OpenChart
	{
		private readonly Chart _chart = null;
		private readonly HScrollBar _hScrollBar = null;
		private readonly Dictionary<string, List<int>> dataDictionary = new Dictionary<string, List<int>>();
		public OpenChart(ref Chart chart1, ref HScrollBar hScrollBar1)
		{
			this._chart = chart1;
			this._hScrollBar = hScrollBar1;
			Initialize();
		}

		internal void AddY(string name, int value)
		{
			if (dataDictionary.ContainsKey(name))
			{
				dataDictionary[name].Add(value); // Update existing value
			}
			else
			{
				dataDictionary.Add(name, new List<int> { value }); // Add new key-value pair

				_chart.Series.Add(name);
				_chart.Series[name].ChartType = SeriesChartType.Line;
			}
		}

		internal void Initialize()
		{
			_chart.Series.Clear();
		}

		internal void Render()
		{
			foreach (var series in dataDictionary)
			{
				// Find the series in the chart by name
				Series chartSeries = _chart.Series.FindByName(series.Key);
				if (chartSeries != null)
				{
					chartSeries.Points.Clear(); // Clear existing points

					int maxIndex = series.Value.Count - 100;

					_hScrollBar.Maximum = maxIndex;

					// Add or update the data points in the series
					int startIndex = _hScrollBar.Value;
					int endIndex = startIndex + 100;

					for (int i = startIndex; i < endIndex; i++)
					{
						int value = series.Value[i];
						chartSeries.Points.AddXY(i, value);
					}
				}
			}
		}
	}
}
