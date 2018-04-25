using System;
using System.Threading.Tasks;

namespace KeyCounter
{
	public class Program
	{
		static void Main(string[] args)
		{
			var api = new Keystroke.API.KeystrokeAPI();
			api.CreateKeyboardHook((c) => Console.WriteLine(c));
		}
	}
}
