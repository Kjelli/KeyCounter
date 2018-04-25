using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyCounterApp
{
	public class Exporter
	{
		public void WriteResultsToFile(IList<string> hourLabels, IList<int> keystrokes, string filepath)
		{
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath))
			{
				file.WriteLine($"Hour,Keystrokes");
				for (var i = 0; i < keystrokes.Count(); i++)
				{
					file.WriteLine($"{hourLabels[i]},{keystrokes[i]}");
				}
			}
		}
	}
}
