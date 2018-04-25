using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Keystroke.API;
using Keystroke.API.CallbackObjects;

namespace KeyCounterApp
{
	public partial class MainForm : Form
	{
		private readonly KeyCounterService _service;

		public MainForm()
		{
			InitializeComponent();
#if DEBUG
			_service = new KeyCounterService(enableTimeSimulation: true);

#else
			_service = new KeyCounterService(enableTimeSimulation: false);
			AddHour.Visible = false;
			SubtractHour.Visible = false;
#endif
			KeyCountChart.Series.Add("Hours");
			KeyCountChart.Series["Hours"].IsValueShownAsLabel = true;
			KeyCountChart.Series["Hours"].XValueType = ChartValueType.String;
			KeyCountChart.Series["Hours"].ChartType = SeriesChartType.Column;
			_service.Updated += UpdateChartOnKeystroke;
			_service.Exported += UpdateLabelOnExport;
		}

		private void UpdateLabelOnExport(DateTime time)
		{
			ExportedLabel.Text = $"Last exported: {time.ToString()}";
		}

		private void UpdateChartOnKeystroke()
		{
			KeyCountChart.Series["Hours"].Points.DataBindXY(_service.HourLabels, _service.Keystrokes);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void StartStopButton_Click(object sender, EventArgs e)
		{
			if (!_service.IsRunning)
			{
				_service.Start();
				StartStopButton.Text = "Stop";
				StartStopButton.BackColor = Color.Red;
			}
			else
			{
				_service.Stop();
				StartStopButton.Text = "Start";
				StartStopButton.BackColor = Color.Green;
			}
		}

		private void ExportButton_Click(object sender, EventArgs e)
		{
			var dialog = new SaveFileDialog
			{
				AddExtension = true,
				DefaultExt = "csv",
				Filter = "CSV File |*.csv"
			};
			dialog.FileOk += Dialog_FileOk;
			dialog.ShowDialog();
		}

		private void Dialog_FileOk(object sender, CancelEventArgs e)
		{
			if (e.Cancel) return;

			if (sender is SaveFileDialog dialog)
			{
				_service.Export(dialog.FileName);
			}
		}

		private void SubtractHour_Click(object sender, EventArgs e)
		{
			_service.IncrementHour(-1);
		}

		private void AddHour_Click(object sender, EventArgs e)
		{
			_service.IncrementHour(+1);
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
