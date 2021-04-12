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
using CSharpAutoTraining.Curs4;
using CSharpAutoTraining.Curs5;
using CSharpAutoTraining.Curs6;

namespace CSharpAutoTraining
{
	class Program
	{
		public static void Main(string[] args)
		{
            //Console.WriteLine("-------------Problemele de la Curs 2----------");
            //BrowserCurs2 browser = new BrowserCurs2();
            //Chrome chrome = new Chrome();
            //Firefox fireFox = new Firefox();
            //InternetExplorer internetExplorer = new InternetExplorer();

            //fireFox.DisplayConvert();
            //chrome.DisplayWindowWidth();
            //internetExplorer.DisplayWindowW();
            //Console.ReadKey();

            //Console.WriteLine("------------Problemele de la Curs 3 (MOSTENIRE)------------");
            //var browserCurs3_1 = new BrowserCurs3_1();
            //var firefoxCurs3_2 = new FirefoxCurs3_2();
            //var chromeCurs3_3 = new ChromeCurs3_3();
            //var internetExplorerCurs3_4 = new InternetExplorerCurs3_4();
            //var edge = new Edge();

            //browserCurs3_1.ChangeWindowWidth(1910);
            //firefoxCurs3_2.SetProfile("Cristian Negrea");
            //chromeCurs3_3.ChangeWindowWidth(1840);
            //internetExplorerCurs3_4.ChangeWindowWidth(1960);
            //edge.NewFeatureFunction();
            //Console.ReadKey();

            //Console.WriteLine("----------Problemele de la Curs 4(INTERFETE)---------");
            //FirefoxCurs4 firefox = new FirefoxCurs4();
            //Skype skype = new Skype();
            //firefox.About();
            //firefox.StartBrowser();
            //firefox.Ping();
            //firefox.WindowWidth = 1840;
            //skype.About();
            //skype.Ping();
            //Console.ReadKey();

            //Console.WriteLine("----------Problemele de la Curs 5(EXCEPTII)---------");
            ////public access
            //BrowserCurs5 browserCurs5 = new BrowserCurs5();
            //browserCurs5.SendTextToElement();

            ////internal access
            //BrowserCurs5_1 browserCurs5_1 = new BrowserCurs5_1();
            //browserCurs5_1.SendTextToElement();

            ////private access: can not be accessed because of private modificator 
            //BrowserCurs5_2 browserCurs5_2 = new BrowserCurs5_2();
            //// browserCurs5_2.SendTextToElement();
            //Console.ReadKey();

            Console.WriteLine("----------Problemele de la Curs 6()---------");
			var firefoxCurs6 = new FirefoxCurs6();
			var firefoxCurs6_2 = new FirefoxCurs6(10);
			var firefoxCurs6_3 = new FirefoxCurs6(10.3);
			firefoxCurs6.WindowWidth = 15;
			Console.WriteLine("Returned value is: " + firefoxCurs6.GetWindowWidth());
            Console.ReadKey();
        }
	}
	}