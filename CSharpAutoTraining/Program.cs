using System;
using CSharpAutoTraining.Curs1;

namespace Curs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Browser browser = new Browser();
            browser.ChangeWindowHeight(1080);
            browser.ChangeWindowWidht(1920);
            browser.DisplayBrowserResolution();
        }
    }
}