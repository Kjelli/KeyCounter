using Keystroke.API;
using Keystroke.API.CallbackObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCounterApp
{
	public class KeyCounterService
	{
		private readonly KeystrokeAPI _api;
		private readonly Exporter _exporter;
		private DateTime _lastExported;
		private DateTime? _simulatedDateTime;
		private bool _isTimeSimulationEnabled;

		public bool IsRunning = false;
		public List<string> HourLabels;
		public List<int> Keystrokes;

		public Action Updated { get; set; }
		public Action<DateTime> Exported { get; set; }

		public KeyCounterService(bool enableTimeSimulation = false)
		{
			_api = new KeystrokeAPI();
			_exporter = new Exporter();

			_api.CreateKeyboardHook(OnKeystroke);

			Keystrokes = new List<int>();
			HourLabels = new List<string>();

			_isTimeSimulationEnabled = enableTimeSimulation;

			var refDate = DateTime.ParseExact("00:00", "HH:mm", null);
			for(var i = 0; i < 24; i++)
			{
				var hourLabel = FormatHourLabel(refDate.AddHours(i));
				HourLabels.Add(hourLabel);
				Keystrokes.Add(0);
			}
		}

		public DateTime GetCurrentTime()
		{
			if (_isTimeSimulationEnabled)
			{
				return _simulatedDateTime ?? (_simulatedDateTime = DateTime.Now).Value ;
			}
			else
			{
				return DateTime.Now;
			}
		}

		private void OnKeystroke(KeyPressed obj)
		{
			if (!IsRunning) return;
			IncrementKeysCounted();
		}

		private void IncrementKeysCounted()
		{
			var currentTime = GetCurrentTime();
			var index = currentTime.Hour;

			Keystrokes[index] += 1;
			Updated?.Invoke();
		}

		public void Start()
		{
			IsRunning = true;
		}

		public void Stop()
		{
			IsRunning = false;
		}

		public void IncrementHour(int diff)
		{
			_simulatedDateTime = _simulatedDateTime?.AddHours(diff);
		}

		private string FormatHourLabel(DateTime dateTime)
		{
			dateTime = dateTime.AddMinutes(-dateTime.Minute);
			return $"{dateTime.ToString("HH:mm")}";
		}

		public void Export(string filename)
		{
			_lastExported = GetCurrentTime();
			_exporter.WriteResultsToFile(HourLabels, Keystrokes, filename);
			Exported?.Invoke(_lastExported);
		}

		public void Dispose()
		{
			
		}
	}

}
