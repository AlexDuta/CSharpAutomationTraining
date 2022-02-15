using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutoTraining.Curs1
{
	class Browser
	{
		//variables
		public int Height = 768;
		public int Width = 1024;

		//methods
		public void ChangeWindowHeight(int newWindowHeight)
		{
			this.Height = newWindowHeight;
		}
		public void ChangeWindowWidht(int newWindowWidth)
		{
			this.Width = newWindowWidth;
		}
		public void DisplayBrowserResolution()
		{
			Console.WriteLine("Browser height is " + this.Height);
			Console.WriteLine("Browser width is " + this.Width);
			Console.ReadLine();
		}
	}
}
