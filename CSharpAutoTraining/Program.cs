using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Curs2_A;
using ConsoleApp1.Curs2_B;
using ConsoleApp1.Curs2_C;
using ConsoleApp1.Curs2_D;
using ConsoleApp1.Curs3_A;
using ConsoleApp1.Curs3_B;
using ConsoleApp1.Curs3_C;
using ConsoleApp1.Curs3_D;
using ConsoleApp1.Curs3_E;
namespace CSharpAutoTraining
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Problemele de la Curs 2");
			BrowserCurs2 browser = new BrowserCurs2();
			Chrome chrome = new Chrome();
			Firefox fireFox = new Firefox();
			InternetExplorer internetExplorer = new InternetExplorer();

			fireFox.DisplayConvert();
			chrome.DisplayWindowWidth();
			internetExplorer.DisplayWindowW();
			Console.ReadKey();

			Console.WriteLine("Problemele de la Curs 3 (MOSTENIRE)");
			var browserCurs3_1 = new BrowserCurs3_1();
			var firefoxCurs3_2 = new FirefoxCurs3_2();
			var chromeCurs3_3 = new ChromeCurs3_3();
			var internetExplorerCurs3_4 = new InternetExplorerCurs3_4();
			var edge = new Edge();

			browserCurs3_1.ChangeWindowWidth(1910);
			firefoxCurs3_2.SetProfile("Cristian Negrea");
			chromeCurs3_3.ChangeWindowWidth(1840);
			internetExplorerCurs3_4.ChangeWindowWidth(1960);
			edge.NewFeatureFunction();
			Console.ReadKey();
		}
	}
}